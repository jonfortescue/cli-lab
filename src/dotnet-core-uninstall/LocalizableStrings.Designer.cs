﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.DotNet.Tools.Uninstall {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LocalizableStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizableStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.DotNet.Tools.Uninstall.LocalizableStrings", typeof(LocalizableStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove ASP.NET Core Runtimes only..
        /// </summary>
        internal static string AspNetRuntimeOptionDescription {
            get {
                return ResourceManager.GetString("AspNetRuntimeOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must specify either --sdk or --runtime..
        /// </summary>
        internal static string BundleTypeMissingExceptionMessage {
            get {
                return ResourceManager.GetString("BundleTypeMissingExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Canceling: waiting for the current uninstall to complete..
        /// </summary>
        internal static string CancelingMessage {
            get {
                return ResourceManager.GetString("CancelingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actually uninstall specified .NET Core SDKs or Runtimes..
        /// </summary>
        internal static string DoItOptionDescription {
            get {
                return ResourceManager.GetString("DoItOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would uninstall: {0}..
        /// </summary>
        internal static string DryRunBundleFormat {
            get {
                return ResourceManager.GetString("DryRunBundleFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to *** END DRY RUN.
        /// </summary>
        internal static string DryRunEndMessage {
            get {
                return ResourceManager.GetString("DryRunEndMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To actually uninstall, add --do-it: {0} --do-it..
        /// </summary>
        internal static string DryRunHowToDoItMessageFormat {
            get {
                return ResourceManager.GetString("DryRunHowToDoItMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to *** DRY RUN.
        /// </summary>
        internal static string DryRunStartMessage {
            get {
                return ResourceManager.GetString("DryRunStartMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified version is not valid: &quot;{0}&quot;..
        /// </summary>
        internal static string InvalidInputVersionExceptionMessageFormat {
            get {
                return ResourceManager.GetString("InvalidInputVersionExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ASP.NET Core Runtimes:.
        /// </summary>
        internal static string ListCommandAspNetRuntimeHeader {
            get {
                return ResourceManager.GetString("ListCommandAspNetRuntimeHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List .NET Core SDKs or Runtimes that can be removed with this tool..
        /// </summary>
        internal static string ListCommandDescription {
            get {
                return ResourceManager.GetString("ListCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .NET Core Runtimes:.
        /// </summary>
        internal static string ListCommandRuntimeHeader {
            get {
                return ResourceManager.GetString("ListCommandRuntimeHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .NET Core SDKs:.
        /// </summary>
        internal static string ListCommandSdkHeader {
            get {
                return ResourceManager.GetString("ListCommandSdkHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft .NET Core {0} {1} (x64).
        /// </summary>
        internal static string MacOsBundleDisplayNameFormat {
            get {
                return ResourceManager.GetString("MacOsBundleDisplayNameFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must specify exactly one version for option: {0}..
        /// </summary>
        internal static string MoreThanOneVersionSpecifiedExceptionMessageFormat {
            get {
                return ResourceManager.GetString("MoreThanOneVersionSpecifiedExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot specify a version for option: {0}..
        /// </summary>
        internal static string MoreThanZeroVersionSpecifiedExceptionMessageFormat {
            get {
                return ResourceManager.GetString("MoreThanZeroVersionSpecifiedExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current user does not have adequate privileges. See https://aka.ms/dotnet-core-uninstall..
        /// </summary>
        internal static string NotAdminExceptionMessage {
            get {
                return ResourceManager.GetString("NotAdminExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This command is not supported on this operating system..
        /// </summary>
        internal static string OperatingSystemNotSupportedExceptionMessage {
            get {
                return ResourceManager.GetString("OperatingSystemNotSupportedExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must specify only one of the options: {0}..
        /// </summary>
        internal static string OptionsConflictExceptionMessageFormat {
            get {
                return ResourceManager.GetString("OptionsConflictExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required argument missing for the uninstall command..
        /// </summary>
        internal static string RequiredArgMissingForUninstallCommandExceptionMessage {
            get {
                return ResourceManager.GetString("RequiredArgMissingForUninstallCommandExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove .NET Core Runtimes only..
        /// </summary>
        internal static string RuntimeOptionDescription {
            get {
                return ResourceManager.GetString("RuntimeOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove .NET Core SDKs only..
        /// </summary>
        internal static string SdkOptionDescription {
            get {
                return ResourceManager.GetString("SdkOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified version is not found: {0}..
        /// </summary>
        internal static string SpecifiedVersionNotFoundExceptionMessageFormat {
            get {
                return ResourceManager.GetString("SpecifiedVersionNotFoundExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to VERSION.
        /// </summary>
        internal static string UninstallAllBelowOptionArgumentName {
            get {
                return ResourceManager.GetString("UninstallAllBelowOptionArgumentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove .NET Core SDKs or Runtimes below the specified version. The specified version will remain..
        /// </summary>
        internal static string UninstallAllBelowOptionDescription {
            get {
                return ResourceManager.GetString("UninstallAllBelowOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove .NET Core SDKs or Runtimes, except the one highest version..
        /// </summary>
        internal static string UninstallAllButLatestOptionDescription {
            get {
                return ResourceManager.GetString("UninstallAllButLatestOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to VERSIONS.
        /// </summary>
        internal static string UninstallAllButOptionArgumentName {
            get {
                return ResourceManager.GetString("UninstallAllButOptionArgumentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove .NET Core SDKs or Runtimes, except those specified..
        /// </summary>
        internal static string UninstallAllButOptionDescription {
            get {
                return ResourceManager.GetString("UninstallAllButOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove .NET Core SDKs or Runtimes that have been superceded by higher patches..
        /// </summary>
        internal static string UninstallAllLowerPatchesOptionDescription {
            get {
                return ResourceManager.GetString("UninstallAllLowerPatchesOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove all .NET Core SDKs or Runtimes..
        /// </summary>
        internal static string UninstallAllOptionDescription {
            get {
                return ResourceManager.GetString("UninstallAllOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove .NET Core SDKs or Runtimes that are marked as previews, except the one highest preview..
        /// </summary>
        internal static string UninstallAllPreviewsButLatestOptionDescription {
            get {
                return ResourceManager.GetString("UninstallAllPreviewsButLatestOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove .NET Core SDKs or Runtimes that are marked as previews..
        /// </summary>
        internal static string UninstallAllPreviewsOptionDescription {
            get {
                return ResourceManager.GetString("UninstallAllPreviewsOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timeout during uninstall: {0}..
        /// </summary>
        internal static string UninstallationFailedExceptionMessageFormat {
            get {
                return ResourceManager.GetString("UninstallationFailedExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The uninstallation operation failed. Exit code was {1} for {0}..
        /// </summary>
        internal static string UninstallationFailedExceptionWithExitCodeMessageFormat {
            get {
                return ResourceManager.GetString("UninstallationFailedExceptionWithExitCodeMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MAJOR_MINOR.
        /// </summary>
        internal static string UninstallMajorMinorOptionArgumentName {
            get {
                return ResourceManager.GetString("UninstallMajorMinorOptionArgumentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove .NET Core SDKs or Runtimes that match the specified `major.minor` version..
        /// </summary>
        internal static string UninstallMajorMinorOptionDescription {
            get {
                return ResourceManager.GetString("UninstallMajorMinorOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified versions to uninstall..
        /// </summary>
        internal static string UninstallNoOptionArgumentDescription {
            get {
                return ResourceManager.GetString("UninstallNoOptionArgumentDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to VERSIONS.
        /// </summary>
        internal static string UninstallNoOptionArgumentName {
            get {
                return ResourceManager.GetString("UninstallNoOptionArgumentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove specified .NET Core SDKs or Runtimes. This tool can only uninstall items that were installed using .NET Core SDK or Runtime installers..
        /// </summary>
        internal static string UninstallNoOptionDescription {
            get {
                return ResourceManager.GetString("UninstallNoOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstalling: {0}..
        /// </summary>
        internal static string UninstallNormalVerbosityFormat {
            get {
                return ResourceManager.GetString("UninstallNormalVerbosityFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LEVEL.
        /// </summary>
        internal static string UninstallVerbosityOptionArgumentName {
            get {
                return ResourceManager.GetString("UninstallVerbosityOptionArgumentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the verbosity level. Allowed values are q[uiet], m[inimal], n[ormal], d[etailed], and diag[nostic]..
        /// </summary>
        internal static string UninstallVerbosityOptionDescription {
            get {
                return ResourceManager.GetString("UninstallVerbosityOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Allowed verbosity levels are q[uiet], m[inimal], n[ormal], d[etailed], and diag[nostic]..
        /// </summary>
        internal static string VerbosityLevelInvalidExceptionMessage {
            get {
                return ResourceManager.GetString("VerbosityLevelInvalidExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not use a version before an option: {0}..
        /// </summary>
        internal static string VersionBeforeOptionExceptionMessageFormat {
            get {
                return ResourceManager.GetString("VersionBeforeOptionExceptionMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can be used with --sdk, --runtime and --aspnet-runtime to remove x64..
        /// </summary>
        internal static string X64OptionDescription {
            get {
                return ResourceManager.GetString("X64OptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can be used with --sdk, --runtime and --aspnet-runtime to remove x86..
        /// </summary>
        internal static string X86OptionDescription {
            get {
                return ResourceManager.GetString("X86OptionDescription", resourceCulture);
            }
        }
    }
}
