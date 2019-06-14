﻿using System;
using System.Collections.Generic;
using System.CommandLine;
using Microsoft.DotNet.Tools.Uninstall.Shared.Configs;
using Microsoft.DotNet.Tools.Uninstall.Shared.Exceptions;
using Microsoft.DotNet.Tools.Uninstall.Shared.BundleInfo;
using Microsoft.DotNet.Tools.Uninstall.Shared.Utils;
using Microsoft.DotNet.Tools.Uninstall.Windows;

namespace Microsoft.DotNet.Tools.Uninstall.Shared.Commands
{
    internal static class UninstallCommandExec
    {
        private static readonly ParseResult CommandLineParseResult
            = CommandLineConfigs.UninstallRootCommand.Parse(Environment.GetCommandLineArgs());

        public static void Execute()
        {
            if (RuntimeInfo.RunningOnWindows)
            {
                Execute(RegistryQuery.GetInstalledBundles());
            }
            else if (RuntimeInfo.RunningOnOSX)
            {
                throw new NotImplementedException();
            }
            else if (RuntimeInfo.RunningOnLinux)
            {
                throw new LinuxNotSupportedException();
            }
        }

        private static void Execute(IEnumerable<Bundle> bundles)
        {
            var option = CommandLineParseResult.RootCommandResult.GetUninstallMainOptions();

            if (option == CommandLineConfigs.UninstallVerbosityOption)
            {
                throw new NotImplementedException();
            }

            var typeSelection = (BundleType)0;

            if (CommandLineParseResult.RootCommandResult.OptionResult(CommandLineConfigs.SdkOption.Name) != null)
            {
                typeSelection |= BundleType.Sdk;
            }
            if (CommandLineParseResult.RootCommandResult.OptionResult(CommandLineConfigs.RuntimeOption.Name) != null)
            {
                typeSelection |= BundleType.Runtime;
            }

            if (typeSelection == 0)
            {
                typeSelection = (BundleType)3;
            }

            var filteredBundles = option == null ?
                OptionFilterers.UninstallNoOptionFilterer.Filter(CommandLineParseResult.RootCommandResult.Arguments, bundles, typeSelection) :
                OptionFilterers.OptionFiltererDictionary[option].Filter(CommandLineParseResult, option, bundles, typeSelection);

            ExecuteUninstall(filteredBundles);
        }

        private static void ExecuteUninstall(IEnumerable<Bundle> bundles)
        {
            foreach (var bundle in bundles)
            {
                // TODO: replace this
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(string.Format("Uninstalling: {0}", bundle.UninstallCommand));
                Console.ResetColor();
            }
        }
    }
}
