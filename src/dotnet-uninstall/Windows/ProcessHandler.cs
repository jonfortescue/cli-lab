﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.DotNet.Tools.Uninstall.Shared.BundleInfo;
using Microsoft.DotNet.Tools.Uninstall.Shared.Exceptions;

namespace Microsoft.DotNet.Tools.Uninstall.Windows
{
    public static class ProcessHandler
    {
        private const int UNINSTALL_TIMEOUT = 5 * 60 * 1000;

        [DllImport("shell32.dll", SetLastError = true)]
        static extern IntPtr CommandLineToArgvW(
            [MarshalAs(UnmanagedType.LPWStr)] string lpCmdLine, out int pNumArgs);

        internal static void ExecuteUninstallCommand(IEnumerable<Bundle> bundles)
        {
            if (!IsAdmin())
            {
                RunAsAdmin();
                return;
            }

            foreach (var bundle in bundles.ToList().AsReadOnly())
            {
                var args = ParseCommand(bundle.UninstallCommand, out var argc);

                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = args.First(),
                        Arguments = string.Join(" ", args.Skip(1)),
                        UseShellExecute = true,
                        Verb = "runas"
                    }
                };

                if (!process.Start() || !process.WaitForExit(UNINSTALL_TIMEOUT))
                {
                    throw new UninstallationFailedException(bundle.UninstallCommand);
                }

                if (process.ExitCode != 0)
                {
                    throw new UninstallationFailedException(bundle.UninstallCommand, process.ExitCode);
                }
            }
        }

        private static bool IsAdmin()
        {
            try
            {
                var identity = WindowsIdentity.GetCurrent();
                var principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch
            {
                return false;
            }
        }

        private static void RunAsAdmin()
        {
            var location = Assembly.GetEntryAssembly().Location;

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c dotnet {location} {string.Join(" ", Environment.GetCommandLineArgs().Skip(1))}",
                    UseShellExecute = true,
                    Verb = "runas"
                }
            };

            if (!process.Start())
            {
                throw new ElevationFailedException();
            }

            Environment.Exit(0);
        }

        private static IEnumerable<string> ParseCommand(string command, out int argc)
        {
            var argv = CommandLineToArgvW(command, out argc);

            if (argv == IntPtr.Zero)
            {
                throw new Win32Exception();
            }

            string[] args;
            try
            {
                args = new string[argc];

                for (var i = 0; i < argc; i++)
                {
                    var p = Marshal.ReadIntPtr(argv, i * IntPtr.Size);
                    args[i] = Marshal.PtrToStringUni(p);
                }
            }
            finally
            {
                Marshal.FreeHGlobal(argv);
            }

            return args;
        }
    }
}
