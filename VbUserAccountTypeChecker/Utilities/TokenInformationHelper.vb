Namespace Utilities

    ''' <summary>
    ''' Provides helper methods for retrieving token information.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="TokenInformationHelper"/> class contains methods for safely retrieving token information from a process. 
    ''' It handles memory allocation and cleanup to ensure that resources are managed properly during the retrieval process.
    ''' </remarks>
    Friend Class TokenInformationHelper
        Implements ITokenInformationHelper

        ''' <summary>
        ''' Provides methods for handling Win32 errors.
        ''' </summary>
        ''' <remarks>
        ''' The <see cref="IWin32ErrorHelper"/> instance is used to retrieve the last Win32 error code in a managed way.
        ''' This ensures that the error code retrieved is reliable and not overwritten by other system calls.
        ''' </remarks>
        Private ReadOnly _win32ErrorHelper As IWin32ErrorHelper

        ''' <summary>
        ''' Initializes a new instance of the <see cref="TokenInformationHelper"/> class.
        ''' </summary>
        ''' <param name="win32ErrorHelper">
        ''' The Win32 error helper used to retrieve the last Win32 error code.
        ''' </param>
        ''' <remarks>
        ''' The constructor initializes the <see cref="_win32ErrorHelper"/> field with the provided <paramref name="win32ErrorHelper"/>. 
        ''' This helper is used to obtain error codes during the token information retrieval process.
        ''' </remarks>
        Public Sub New(win32ErrorHelper As IWin32ErrorHelper)
            _win32ErrorHelper = win32ErrorHelper
        End Sub

        ''' <summary>
        ''' Tries to get the token information.
        ''' </summary>
        ''' <param name="tokenManager">
        ''' The process token manager used to retrieve token information.
        ''' </param>
        ''' <param name="tokenHandle">
        ''' The handle to the token from which information is retrieved. This handle should be opened with the appropriate access rights.
        ''' </param>
        ''' <param name="tokenInfoClass">
        ''' The class of token information to retrieve, represented by a value from the <see cref="TokenInformationClass"/> enumeration.
        ''' </param>
        ''' <param name="dwSize">
        ''' On input, the size of the buffer pointed to by the <paramref name="tokenInfo"/> parameter. 
        ''' On output, the size of the token information data.
        ''' </param>
        ''' <param name="tokenInfo">
        ''' A pointer to the buffer that receives the token information. This buffer is allocated by the method if necessary.
        ''' </param>
        ''' <returns>
        ''' <c>True</c> if the token information was successfully retrieved; otherwise, <c>false</c>. 
        ''' The method will also return <c>true</c> if the token information is successfully retrieved after reallocating memory.
        ''' </returns>
        ''' <exception cref="InvalidOperationException">
        ''' Thrown when the token information retrieval fails despite reallocation of memory.
        ''' </exception>
        ''' <remarks>
        ''' This method first attempts to retrieve token information using a buffer size of zero to determine if the buffer is insufficient. 
        ''' If the buffer is insufficient (indicated by the <see cref="Win32Error.ErrorInsufficientBuffer"/> error), 
        ''' it reallocates memory based on the required size and retries the retrieval.
        ''' </remarks>
        Friend Function TryGetTokenInformation(tokenManager As IProcessTokenManager, tokenHandle As IntPtr, tokenInfoClass As TokenInformationClass, ByRef dwSize As UInteger, ByRef tokenInfo As IntPtr) As Boolean Implements ITokenInformationHelper.TryGetTokenInformation
            If NeedsBufferResize(tokenManager, tokenHandle, tokenInfoClass, dwSize) Then
                tokenInfo = Marshal.AllocHGlobal(CInt(dwSize))
                Try
                    If tokenManager.GetTokenInformation(tokenHandle, tokenInfoClass, tokenInfo, dwSize, dwSize) Then
                        Return True
                    Else
                        Throw New InvalidOperationException("Failed to get token information.")
                    End If
                Catch
                    MemoryManager.FreeMemoryIfNotNull(tokenInfo)
                    Throw
                End Try
            End If
            Return False
        End Function

        ''' <summary>
        ''' Determines if the buffer needs to be resized based on the token information retrieval result.
        ''' </summary>
        ''' <param name="tokenManager">The token manager responsible for handling token operations.</param>
        ''' <param name="tokenHandle">The handle to the token.</param>
        ''' <param name="tokenInfoClass">The class of the token information being queried.</param>
        ''' <param name="dwSize">The size of the buffer required to hold the token information.</param>
        ''' <returns>
        ''' <c>True</c> if the buffer needs to be resized; otherwise, <c>False</c>.
        ''' </returns>
        ''' <remarks>
        ''' This function checks if the initial call to <see cref="IProcessTokenManager.GetTokenInformation"/> 
        ''' fails due to an insufficient buffer size. If the error code returned by the last Win32 error 
        ''' is <see cref="Win32Error.ErrorInsufficientBuffer"/>, it indicates that the buffer needs to be resized.
        ''' </remarks>
        Private Function NeedsBufferResize(tokenManager As IProcessTokenManager, tokenHandle As IntPtr, tokenInfoClass As TokenInformationClass, ByRef dwSize As UInteger) As Boolean
            Return Not tokenManager.GetTokenInformation(tokenHandle, tokenInfoClass, NativeMethods.NullHandleValue, 0, dwSize) AndAlso
                   _win32ErrorHelper.GetLastWin32Error() = Win32Error.ErrorInsufficientBuffer
        End Function
    End Class
End Namespace
