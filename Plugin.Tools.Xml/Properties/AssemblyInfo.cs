using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(false)]
[assembly: Guid("8f901e4a-0567-42b0-b3d1-044f1183ac1e")]
[assembly: System.CLSCompliant(true)]

#if NETCOREAPP
[assembly: AssemblyMetadata("ProjectUrl", "https://dkorablin.ru/project/Default.aspx?File=98")]
#else

[assembly: AssemblyTitle("Plugin.Tools.Xml")]
[assembly: AssemblyDescription("XML/XSL/XPath Tools")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("Danila Korablin")]
[assembly: AssemblyProduct("Plugin.Tools.Xml")]
[assembly: AssemblyCopyright("Copyright © Danila Korablin 2016-2019")]
#endif