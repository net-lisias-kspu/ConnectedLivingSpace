using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ConnectedLivingSpace /L Unofficial")]
[assembly: AssemblyDescription("KSP Plugin to detect internally connected living spaces")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(KSPe.LegalMamboJambo.Company)]
[assembly: AssemblyProduct(KSPe.LegalMamboJambo.Product)]
[assembly: AssemblyCopyright(KSPe.LegalMamboJambo.Copyright)]
[assembly: AssemblyTrademark(KSPe.LegalMamboJambo.Trademark)]
[assembly: AssemblyCulture("")]

// The following attributes are used to specify the signing key for the assembly,
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("39ece0ec-3186-45d4-9cfd-bac6548c3f72")]

//[assembly: AssemblyFileVersion("2.0.0.3")]
// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.
[assembly: AssemblyVersion(ConnectedLivingSpace.Version.Number)]
[assembly: AssemblyFileVersion(ConnectedLivingSpace.Version.Number)]
[assembly: KSPAssembly("ConnectedLivingSpace", KSPe.Version.major, KSPe.Version.minor)]
[assembly: KSPAssemblyDependency("KSPe", 2, 2)]
[assembly: KSPAssemblyDependency("KSPe.UI", 2, 2)]
