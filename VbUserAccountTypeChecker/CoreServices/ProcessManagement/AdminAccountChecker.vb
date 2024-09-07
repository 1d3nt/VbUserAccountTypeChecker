Namespace CoreServices.ProcessManagement

    ''' <summary>
    ''' Provides functionality to check if the process is running with elevated (admin) privileges.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="AdminAccountChecker"/> class is responsible for determining whether a process token indicates an administrative account.
    ''' It uses provided services to retrieve and analyze token information to make this determination.
    ''' </remarks>
    Friend Class AdminAccountChecker
        Implements IAdminAccountChecker

        ''' <summary>
        ''' Manages the security tokens for the current process.
        ''' </summary>
        Private ReadOnly _processTokenManager As IProcessTokenManager

        ''' <summary>
        ''' Provides methods for retrieving token information.
        ''' </summary>
        Private ReadOnly _tokenInformationHelper As ITokenInformationHelper

        ''' <summary>
        ''' Initializes a new instance of the <see cref="AdminAccountChecker"/> class.
        ''' </summary>
        ''' <param name="processTokenManager">The process token manager.</param>
        ''' <param name="tokenInformationHelper">An instance of <see cref="ITokenInformationHelper"/>. This instance is provided via dependency injection and used to retrieve token information.</param>
        Friend Sub New(processTokenManager As IProcessTokenManager, tokenInformationHelper As ITokenInformationHelper)
            _processTokenManager = processTokenManager
            _tokenInformationHelper = tokenInformationHelper
        End Sub

        ''' <summary>
        ''' Determines whether the specified token handle belongs to an admin account.
        ''' </summary>
        ''' <param name="tokenHandle">The token handle.</param>
        ''' <returns><c>true</c> if the token handle belongs to an admin account; otherwise, <c>false</c>.</returns>
        Friend Function IsAdminAccount(tokenHandle As IntPtr) As Boolean Implements  IAdminAccountChecker.IsAdminAccount
            Dim pElevationType As IntPtr = NativeMethods.NullHandleValue
            Dim dwSize As UInteger = 0
            Dim elevationType As TokenElevationType
            Try
                If Not _tokenInformationHelper.TryGetTokenInformation(_processTokenManager, tokenHandle, TokenInformationClass.TokenElevationType, dwSize, pElevationType) Then
                    Return False
                End If
                elevationType = DirectCast(Marshal.ReadInt32(pElevationType), TokenElevationType)
                Return elevationType = TokenElevationType.TokenElevationTypeFull
            Finally
                MemoryManager.FreeMemoryIfNotNull(pElevationType)
            End Try
        End Function
    End Class
End Namespace
