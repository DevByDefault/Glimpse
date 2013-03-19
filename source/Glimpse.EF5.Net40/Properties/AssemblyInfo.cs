﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Glimpse.Core.Extensibility;

[assembly: ComVisible(false)]
[assembly: Guid("8BAAD0C1-E44B-4E1B-9206-A1D8B9CD4870")]

[assembly: AssemblyTitle("Glimpse for EF 5.0 Assembly")]
[assembly: AssemblyDescription("Main extensibility implementations for running Glimpse with EF 5.0.")]
[assembly: AssemblyProduct("Glimpse.EF5")]
[assembly: AssemblyCopyright("© 2012 Nik Molnar & Anthony van der Hoorn")]
[assembly: AssemblyTrademark("Glimpse™")]

// Version is in major.minor.build format to support http://semver.org/
// Keep these three attributes in sync
[assembly: AssemblyVersion("1.0.0")]
[assembly: AssemblyFileVersion("1.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0")] // Used to specify the NuGet version number at build time

[assembly: InternalsVisibleTo("Glimpse.Test.EF")]
[assembly: NuGetPackage]