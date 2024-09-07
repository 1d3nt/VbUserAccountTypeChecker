Namespace CoreServices.ProcessManagement

    ''' <summary>
    ''' Provides functionality to check if the process is running under the System account.
    ''' </summary>
    Friend Class SystemAccountChecker
        Implements ISystemAccountChecker

        ''' <summary>
        ''' Manages the security tokens for the current process.
        ''' </summary>
        Private ReadOnly _processTokenManager As IProcessTokenManager

        ''' <summary>
        ''' Provides methods for retrieving token information.
        ''' </summary>
        Private ReadOnly _tokenInformationHelper As ITokenInformationHelper

        ''' <summary>
        ''' Initializes a new instance of the <see cref="SystemAccountChecker"/> class.
        ''' </summary>
        ''' <param name="processTokenManager">The process token manager.</param>
        ''' <param name="tokenInformationHelper">An instance of <see cref="ITokenInformationHelper"/>. This instance is provided via dependency injection and used to retrieve token information.</param>
        Friend Sub New(processTokenManager As IProcessTokenManager, tokenInformationHelper As ITokenInformationHelper)
            _processTokenManager = processTokenManager
            _tokenInformationHelper = tokenInformationHelper
        End Sub

        ''' <summary>
        ''' Determines whether the specified token handle belongs to the System account.
        ''' </summary>
        ''' <param name="tokenHandle">The token handle.</param>
        ''' <returns><c>true</c> if the token handle belongs to the System account; otherwise, <c>false</c>.</returns>
        Friend Function IsSystemAccount(tokenHandle As IntPtr) As Boolean Implements ISystemAccountChecker.IsSystemAccount
            Dim systemSid As New SecurityIdentifier(WellKnownSidType.LocalSystemSid, Nothing)
            Dim tokenUser As IntPtr = NativeMethods.NullHandleValue
            Dim dwSize As UInteger = 0
            Try
                If Not _tokenInformationHelper.TryGetTokenInformation(_processTokenManager, tokenHandle, TokenInformationClass.TokenUser, dwSize, tokenUser) Then
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