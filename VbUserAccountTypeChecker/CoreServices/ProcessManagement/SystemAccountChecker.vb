Namespace CoreServices.ProcessManagement

    ''' <summary>
    ''' Provides functionality to check if the process is running under the System account.
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
    Friend Class SystemAccountChecker

        ''' <summary>
        ''' Manages the security tokens for the current process.
        ''' </summary>
        Private ReadOnly _processTokenManager As ProcessTokenManager

        ''' <summary>
        ''' Initializes a new instance of the <see cref="SystemAccountChecker"/> class.
        ''' </summary>
        ''' <param name="processTokenManager">The process token manager.</param>
        Friend Sub New(processTokenManager As ProcessTokenManager)
            _processTokenManager = processTokenManager
        End Sub

        ''' <summary>
        ''' Determines whether the specified token handle belongs to the System account.
        ''' </summary>
        ''' <param name="tokenHandle">The token handle.</param>
        ''' <returns><c>true</c> if the token handle belongs to the System account; otherwise, <c>false</c>.</returns>
        Friend Function IsSystemAccount(tokenHandle As IntPtr) As Boolean
            Dim systemSid As New SecurityIdentifier(WellKnownSidType.LocalSystemSid, Nothing)
            Dim tokenUser As IntPtr = NativeMethods.NullHandleValue
            Dim dwSize As UInteger = 0
            Try
                If Not TokenInformationHelper.TryGetTokenInformation(_processTokenManager, tokenHandle, TokenInformationClass.TokenUser, dwSize, tokenUser) Then
                    Return False
                End If
                Dim tokenUserInfo = Marshal.PtrToStructure(Of TokenUser)(tokenUser)
                Dim userSid As New SecurityIdentifier(tokenUserInfo.User.Sid)
                Return userSid.Equals(systemSid)
            Finally
                MemoryManager.FreeMemoryIfNotNull(tokenUser)
            End Try
        End Function
    End Class
End Namespace