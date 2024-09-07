''' <summary>
''' Specifies that the entire assembly is intended to run on Windows 10 and later versions.
''' </summary>
''' <remarks>
''' This attribute ensures that all classes and methods within this assembly are marked as supported 
''' on Windows 10 and later versions. It helps in maintaining compatibility with modern Windows features 
''' and API levels. It is particularly useful for indicating that certain APIs or features used in this assembly
''' are only available on Windows 10 or newer operating systems.
''' </remarks>
''' <seealso href="https://learn.microsoft.com/en-us/dotnet/api/system.runtime.versioning.supportedosplatformattribute?view=net-8.0">
''' For more information, see the documentation for <see cref="SupportedOSPlatformAttribute"/>.
''' </seealso>
<Assembly: SupportedOSPlatform("Windows10.0")>
