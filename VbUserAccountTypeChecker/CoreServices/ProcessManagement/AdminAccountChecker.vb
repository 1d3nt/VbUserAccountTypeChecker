Namespace CoreServices.ProcessManagement

    ''' <summary>
    ''' Provides functionality to check if the process is running with elevated (admin) privileges.
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
                elevationType = CType(Marshal.ReadInt32(pElevationType), TokenElevationType)
                Return elevationType = TokenElevationType.TokenElevationTypeFull
            Finally
                MemoryManager.FreeMemoryIfNotNull(pElevationType)
            End Try
        End Function
    End Class
End Namespace
