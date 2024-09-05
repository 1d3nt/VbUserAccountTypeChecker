Namespace CoreServices.ProcessManagement

    ''' <summary>
    ''' Determines the type of user account under which the process is running.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="SupportedOSPlatformAttribute"/> specifies the platform on which the code is expected to run. 
    ''' In this case, it indicates that the code is intended to run on Windows platforms.
    ''' 
    ''' The code is specifically designed for Windows 10 and later versions. This ensures compatibility with modern Windows 
    ''' features and API levels. For more details on the attribute, visit the 
    ''' <see href="https://learn.microsoft.com/en-us/dotnet/api/system.runtime.versioning.supportedosplatformattribute?view=net-8.0">official documentation</see>.
    ''' </remarks>
    <SupportedOSPlatform("windows10.0")>
    Friend Class UserPrivilegesDeterminer

        ''' <summary>
        ''' Manages the security tokens for the current process.
        ''' </summary>
        ''' <remarks>
        ''' This field holds an instance of the <see cref="ProcessTokenManager"/> class, which is responsible for handling 
        ''' the security tokens associated with the process. The token manager is used to query and manipulate process tokens 
        ''' to determine the privileges and account type under which the process is running.
        ''' </remarks>
        Private ReadOnly _processTokenManager As ProcessTokenManager

        ''' <summary>
        ''' Initializes a new instance of the <see cref="UserPrivilegesDeterminer"/> class.
        ''' </summary>
        ''' <param name="tokenManager">The process token manager.</param>
        ''' <remarks>
        ''' The constructor initializes the <see cref="_processTokenManager"/> field with the provided <paramref name="tokenManager"/>. 
        ''' This manager is used to interact with process tokens and determine user privileges.
        ''' </remarks>
        Friend Sub New(tokenManager As ProcessTokenManager)
            _processTokenManager = tokenManager
        End Sub

        ''' <summary>
        ''' Determines the type of user account under which the process is running.
        ''' </summary>
        ''' <returns>
        ''' A <see cref="UserAccountType"/> enumeration value indicating the type of user account.
        ''' Possible values are:
        ''' <list type="bullet">
        ''' <item>
        ''' <description><see cref="UserAccountType.System"/>: The process is running under a system account.</description>
        ''' </item>
        ''' <item>
        ''' <description><see cref="UserAccountType.Admin"/>: The process is running under an administrative account.</description>
        ''' </item>
        ''' <item>
        ''' <description><see cref="UserAccountType.User"/>: The process is running under a user or other non-administrative account.</description>
        ''' </item>
        ''' </list>
        ''' </returns>
        ''' <remarks>
        ''' This method checks the type of user account under which the process is running by querying the process's security token.
        ''' It first attempts to open the process token using the <see cref="OpenProcessToken"/> method.
        ''' If the token is successfully obtained, it checks if the account is a system account or an administrative account.
        ''' If neither, it defaults to <see cref="UserAccountType.User"/>. The method returns a <see cref="UserAccountType"/> value representing the account type.
        ''' </remarks>
        ''' <exception cref="InvalidOperationException">Thrown when the process token cannot be opened.</exception>
        Friend Function GetUserAccountType() As UserAccountType
            Dim tokenHandle As IntPtr = NativeMethods.NullHandleValue
            Try
                If Not OpenProcessToken(tokenHandle) Then
                    Throw New InvalidOperationException("Failed to open process token.")
                End If
                If IsSystemAccount(tokenHandle) Then
                    Return UserAccountType.System
                End If
                If IsAdminAccount(tokenHandle) Then
                    Return UserAccountType.Admin
                End If
            Finally
                HandleManager.CloseTokenHandleIfNotNull(tokenHandle)
            End Try
            Return UserAccountType.User
        End Function

        ''' <summary>
        ''' Opens the process token for the current process.
        ''' </summary>
        ''' <param name="tokenHandle">When this method returns, contains the handle to the process token.</param>
        ''' <returns>
        ''' <c>true</c> if the process token was successfully opened; otherwise, <c>false</c>.
        ''' </returns>
        ''' <remarks>
        ''' This method attempts to open the process token for the current process using the <see cref="NativeMethods.OpenProcessToken"/> function.
        ''' </remarks>
        Private Function OpenProcessToken(ByRef tokenHandle As IntPtr) As Boolean
            Return _processTokenManager.OpenProcessToken(NativeMethods.GetCurrentProcess(), AccessMask.TokenQuery, tokenHandle)
        End Function

        ''' <summary>
        ''' Determines whether the specified token handle belongs to a system account.
        ''' </summary>
        ''' <param name="tokenHandle">The handle to the process token.</param>
        ''' <returns>
        ''' <c>true</c> if the token handle belongs to a system account; otherwise, <c>false</c>.
        ''' </returns>
        ''' <remarks>
        ''' This method checks if the specified token handle belongs to a system account by using the <see cref="SystemAccountChecker"/> class.
        ''' </remarks>
        Private Function IsSystemAccount(tokenHandle As IntPtr) As Boolean
            Dim systemChecker As New SystemAccountChecker(_processTokenManager)
            Return systemChecker.IsSystemAccount(tokenHandle)
        End Function

        ''' <summary>
        ''' Determines whether the specified token handle belongs to an administrative account.
        ''' </summary>
        ''' <param name="tokenHandle">The handle to the process token.</param>
        ''' <returns>
        ''' <c>true</c> if the token handle belongs to an administrative account; otherwise, <c>false</c>.
        ''' </returns>
        ''' <remarks>
        ''' This method checks if the specified token handle belongs to an administrative account by using the <see cref="AdminAccountChecker"/> class.
        ''' </remarks>
        Private Function IsAdminAccount(tokenHandle As IntPtr) As Boolean
            Dim adminChecker As New AdminAccountChecker(_processTokenManager)
            Return adminChecker.IsAdminAccount(tokenHandle)
        End Function
    End Class
End Namespace
