''' <author>
''' Sam (ident)
''' Twitter: <see href="https://twitter.com/1d3nt">https://twitter.com/1d3nt</see>
''' GitHub: <see href="https://github.com/1d3nt">https://github.com/1d3nt</see>
''' Email: <see href="mailto:ident@simplecoders.com">ident@simplecoders.com</see>
''' VBForums: <see href="https://www.vbforums.com/member.php?113656-ident">https://www.vbforums.com/member.php?113656-ident</see>
''' ORCID: <see href="https://orcid.org/0009-0007-1363-3308">https://orcid.org/0009-0007-1363-3308</see>
''' </author>
''' <date>31/08/2024</date>
''' <summary>
''' The entry point for the application.
''' </summary>
''' <remarks>
''' This module contains the <see cref="Main"/> method, which sets up and starts the application host.
''' 
''' This project includes P/Invoke declarations and methods for interacting with Windows API functions.
''' Contributions and enhancements are welcomed to further extend the functionality and improve the integration.
''' 
''' Just a hobby programmer that enjoys P/Invoke.
''' 
''' The <see cref="SupportedOSPlatformAttribute"/> specifies the platform on which the code is expected to run. 
''' In this case, it indicates that the code is intended to run on Windows platforms.
''' 
''' The code is specifically designed for Windows 10 and later versions. This ensures compatibility with modern Windows 
''' features and API levels. For more details on the attribute, visit the 
''' <see href="https://learn.microsoft.com/en-us/dotnet/api/system.runtime.versioning.supportedosplatformattribute?view=net-8.0">official documentation</see>.
''' </remarks>
<SupportedOSPlatform("Windows10.0")>
Module Program

    ''' <summary>
    ''' Entry point for the console application.
    ''' Determines the user type (Admin, System, or User) based on the current Windows identity.
    ''' </summary>
    ''' <param name="args">Command-line arguments (not used).</param>
    ''' <remarks>
    ''' The <paramref name="args"/> parameter is included to adhere to the standard signature for a console application's 
    ''' <c>Main</c> method. Although ReSharper sometimes flags this parameter as unused and suggests its removal, 
    ''' it is considered best practice to include it for consistency and future-proofing. 
    ''' The <see cref="SuppressMessageAttribute"/> is used to prevent style warnings from suggesting 
    ''' its removal, even though the parameter is not utilized in this implementation.
    ''' </remarks>
    <SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification:="Standard Main method parameter signature.")>
    Sub Main(args As String())
        Dim services As New ServiceCollection()
        services.AddTransient(Of IProcessTokenManager, ProcessTokenManager)()
        services.AddTransient(Of IUserPrivilegesDeterminer, UserPrivilegesDeterminer)()
        services.AddTransient(Of IUserAccountService, UserAccountService)()
        services.AddTransient(Of ITokenInformationHelper, TokenInformationHelper)()
        services.AddTransient(Of IWin32ErrorHelper, Win32ErrorHelper)
        services.AddTransient(Of IUserAccountTypeExtensions, UserAccountTypeExtensions)
        Dim serviceProvider As IServiceProvider = services.BuildServiceProvider()
        Dim userAccountService = serviceProvider.GetService(Of IUserAccountService)()
        Dim friendlyAccountType = userAccountService.GetFriendlyUserAccountType()
        Console.WriteLine($"You are running as: {friendlyAccountType}")
        Console.ReadLine()
    End Sub
End Module