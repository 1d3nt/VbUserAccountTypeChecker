Namespace Application

    ''' <summary>
    ''' Configures the services for dependency injection.
    ''' </summary>
    ''' <returns>
    ''' An <see cref="IServiceProvider"/> that provides the configured services.
    ''' </returns>
    ''' <remarks>
    ''' The <c>ConfigureServices</c> method creates a new instance of the <see cref="ServiceCollection"/>
    ''' and registers various services and their corresponding implementations. The method then builds
    ''' and returns an <see cref="IServiceProvider"/> which can be used to resolve services at runtime.
    ''' 
    ''' The following services are configured:
    ''' <list type="bullet">
    '''   <item>
    '''     <description>
    '''       <see cref="IProcessTokenManager"/> is implemented by <see cref="ProcessTokenManager"/>. 
    '''       This service manages process tokens, including opening tokens and retrieving token information.
    '''     </description>
    '''   </item>
    '''   <item>
    '''     <description>
    '''       <see cref="IUserPrivilegesDeterminer"/> is implemented by <see cref="UserPrivilegesDeterminer"/>. 
    '''       This service determines user privileges and account types based on process tokens.
    '''     </description>
    '''   </item>
    '''   <item>
    '''     <description>
    '''       <see cref="IUserAccountService"/> is implemented by <see cref="UserAccountService"/>. 
    '''       This service provides user account type information as a friendly string.
    '''     </description>
    '''   </item>
    '''   <item>
    '''     <description>
    '''       <see cref="ITokenInformationHelper"/> is implemented by <see cref="TokenInformationHelper"/>. 
    '''       This service assists in safely retrieving token information.
    '''     </description>
    '''   </item>
    '''   <item>
    '''     <description>
    '''       <see cref="IWin32ErrorHelper"/> is implemented by <see cref="Win32ErrorHelper"/>. 
    '''       This service provides functionality to retrieve the last Win32 error code.
    '''     </description>
    '''   </item>
    '''   <item>
    '''     <description>
    '''       <see cref="IUserAccountTypeExtensions"/> is implemented by <see cref="UserAccountTypeExtensions"/>. 
    '''       This service extends the <see cref="UserAccountType"/> enumeration with custom string representations.
    '''     </description>
    '''   </item>
    ''' </list>
    ''' </remarks>
    Friend Class ServiceConfigurator

        ''' <summary>
        ''' Configures the services for dependency injection.
        ''' </summary>
        ''' <returns>
        ''' An <see cref="IServiceProvider"/> that provides the configured services.
        ''' </returns>
        ''' <remarks>
        ''' The <see cref="ConfigureServices"/> method creates a new instance of the <see cref="ServiceCollection"/>
        ''' and registers various services and their corresponding implementations. The method then builds
        ''' and returns an <see cref="IServiceProvider"/> which can be used to resolve services at runtime.
        ''' 
        ''' The following services are configured:
        ''' <list type="bullet">
        '''   <item>
        '''     <description>
        '''       <see cref="IProcessTokenManager"/> is implemented by <see cref="ProcessTokenManager"/>. 
        '''       This service manages process tokens, including opening tokens and retrieving token information.
        '''     </description>
        '''   </item>
        '''   <item>
        '''     <description>
        '''       <see cref="IUserPrivilegesDeterminer"/> is implemented by <see cref="UserPrivilegesDeterminer"/>. 
        '''       This service determines user privileges and account types based on process tokens.
        '''     </description>
        '''   </item>
        '''   <item>
        '''     <description>
        '''       <see cref="IUserAccountService"/> is implemented by <see cref="UserAccountService"/>. 
        '''       This service provides user account type information as a friendly string.
        '''     </description>
        '''   </item>
        '''   <item>
        '''     <description>
        '''       <see cref="ITokenInformationHelper"/> is implemented by <see cref="TokenInformationHelper"/>. 
        '''       This service assists in safely retrieving token information.
        '''     </description>
        '''   </item>
        '''   <item>
        '''     <description>
        '''       <see cref="IWin32ErrorHelper"/> is implemented by <see cref="Win32ErrorHelper"/>. 
        '''       This service provides functionality to retrieve the last Win32 error code.
        '''     </description>
        '''   </item>
        '''   <item>
        '''     <description>
        '''       <see cref="IUserAccountTypeExtensions"/> is implemented by <see cref="UserAccountTypeExtensions"/>. 
        '''       This service extends the <see cref="UserAccountType"/> enumeration with custom string representations.
        '''     </description>
        '''   </item>
        ''' </list>
        ''' </remarks>
        Friend Shared Function ConfigureServices() As IServiceProvider
            Dim services As New ServiceCollection()
            services.AddTransient(Of IProcessTokenManager, ProcessTokenManager)()
            services.AddTransient(Of IUserPrivilegesDeterminer, UserPrivilegesDeterminer)()
            services.AddTransient(Of IUserAccountService, UserAccountService)()
            services.AddTransient(Of ITokenInformationHelper, TokenInformationHelper)()
            services.AddTransient(Of IWin32ErrorHelper, Win32ErrorHelper)()
            services.AddTransient(Of IUserAccountTypeExtensions, UserAccountTypeExtensions)()
            Return services.BuildServiceProvider()
        End Function
    End Class
End Namespace
