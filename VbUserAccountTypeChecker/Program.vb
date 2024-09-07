Imports VbUserAccountTypeChecker.Application

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
''' </remarks>
Module Program

    ''' <summary>
    ''' Entry point for the console application.
    ''' Determines the user type (Admin, System, or User) based on the current Windows identity.
    ''' </summary>
    ''' <param name="args">Command-line arguments (not used).</param>
    ''' <remarks>
    ''' The <paramref name="args"/> parameter is included to adhere to the standard signature for a console application's 
    ''' <see cref="Main"/> method. Although ReSharper sometimes flags this parameter as unused and suggests its removal, 
    ''' it is considered best practice to include it for consistency and future-proofing. 
    ''' The <see cref="SuppressMessageAttribute"/> is used to prevent style warnings from suggesting 
    ''' its removal, even though the parameter is not utilized in this implementation.
    ''' </remarks>
    <SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification:="Standard Main method parameter signature.")>
    Sub Main(args As String())
        Dim serviceProvider As IServiceProvider = ServiceConfigurator.ConfigureServices()
        Dim appRunner As New AppRunner(serviceProvider)
        appRunner.Run()
    End Sub
End Module