Namespace Utilities

    ''' <summary>
    ''' Provides helper methods for retrieving token information.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="TokenInformationHelper"/> class contains methods for safely retrieving token information from a process. 
    ''' It handles memory allocation and cleanup to ensure that resources are managed properly during the retrieval process.
    ''' </remarks>
    Friend Class TokenInformationHelper

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
        ''' If the buffer is insufficient (indicated by the <see cref="NativeMethods.ErrorInsufficientBuffer"/> error), 
        ''' it reallocates memory based on the required size and retries the retrieval.
        ''' </remarks>
        Friend Shared Function TryGetTokenInformation(tokenManager As ProcessTokenManager, tokenHandle As IntPtr, tokenInfoClass As TokenInformationClass, ByRef dwSize As UInteger, ByRef tokenInfo As IntPtr) As Boolean
            If Not tokenManager.GetTokenInformation(tokenHandle, tokenInfoClass, NativeMethods.NullHandleValue, 0, dwSize) AndAlso Win32ErrorHelper.GetLastWin32Error() = Win32Error.ErrorInsufficientBuffer Then
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
    End Class
End Namespace
