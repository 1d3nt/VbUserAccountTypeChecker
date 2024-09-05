Namespace CoreServices.ProcessManagement

    ''' <summary>
    ''' Provides methods for handling process token operations.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="ProcessTokenManager"/> class includes methods to manage process tokens, 
    ''' including opening a process token and retrieving information about the token. 
    ''' These operations are useful for scenarios involving security contexts and access control.
    ''' </remarks>
    Friend Class ProcessTokenManager

        ''' <summary>
        ''' Opens the process token.
        ''' </summary>
        ''' <param name="processHandle">
        ''' The handle to the process for which the token is to be opened.
        ''' </param>
        ''' <param name="desiredAccess">
        ''' The access rights requested for the token. This should be a value from the <see cref="AccessMask"/> enumeration.
        ''' </param>
        ''' <param name="tokenHandle">
        ''' A reference to an <see cref="IntPtr"/> that will receive the handle to the opened token.
        ''' </param>
        ''' <returns>
        ''' <c>True</c> if the token was opened successfully; otherwise, <c>false</c>. 
        ''' The handle to the token is returned in the <paramref name="tokenHandle"/> parameter.
        ''' </returns>
        ''' <remarks>
        ''' This method uses the <see cref="NativeMethods.OpenProcessToken"/> function to obtain a handle to the process's token.
        ''' The token handle can be used for further operations such as querying or modifying token attributes.
        ''' </remarks>
        ''' <remarks>
        ''' This method is marked with a suppression attribute because ReSharper may incorrectly suggest 
        ''' that the method should be marked as <c>Shared</c> (static). However, the method is not <c>Shared</c> 
        ''' because it relies on instance-level operations and creating new instances of the class. Making it <c>Shared</c> 
        ''' would prevent instance creation and break the intended functionality.
        ''' </remarks>
        <SuppressMessage("StaticMembers", "CA1822:Mark members as static", Justification:="ReSharper incorrectly suggests marking this method as Shared. The method relies on instance-level operations.")>
        Friend Function OpenProcessToken(processHandle As IntPtr, desiredAccess As AccessMask, ByRef tokenHandle As IntPtr) As Boolean
            Return NativeMethods.OpenProcessToken(processHandle, desiredAccess, tokenHandle)
        End Function

        ''' <summary>
        ''' Gets the token information.
        ''' </summary>
        ''' <param name="tokenHandle">
        ''' The handle to the token for which information is being retrieved.
        ''' </param>
        ''' <param name="tokenInformationClass">
        ''' The class of information to retrieve, represented by a value from the <see cref="TokenInformationClass"/> enumeration.
        ''' </param>
        ''' <param name="tokenInformation">
        ''' A pointer to a buffer that receives the token information.
        ''' </param>
        ''' <param name="tokenInformationLength">
        ''' The length of the <paramref name="tokenInformation"/> buffer.
        ''' </param>
        ''' <param name="returnLength">
        ''' A reference to a variable that receives the size of the data returned in the <paramref name="tokenInformation"/> buffer.
        ''' </param>
        ''' <returns>
        ''' <c>True</c> if the token information was retrieved successfully; otherwise, <c>false</c>.
        ''' </returns>
        ''' <remarks>
        ''' This method uses the <see cref="NativeMethods.GetTokenInformation"/> function to retrieve specific information about a token.
        ''' The information class determines what kind of data is retrieved, such as token groups or privileges.
        ''' </remarks>
        ''' <remarks>
        ''' This method is marked with a suppression attribute because ReSharper may incorrectly suggest 
        ''' that the method should be marked as <c>Shared</c> (static). However, the method is not <c>Shared</c> 
        ''' because it relies on instance-level operations and creating new instances of the class. Making it <c>Shared</c> 
        ''' would prevent instance creation and break the intended functionality.
        ''' </remarks>
        <SuppressMessage("StaticMembers", "CA1822:Mark members as static", Justification:="ReSharper incorrectly suggests marking this method as Shared. The method relies on instance-level operations.")>
        Friend Function GetTokenInformation(tokenHandle As IntPtr, tokenInformationClass As TokenInformationClass, tokenInformation As IntPtr, tokenInformationLength As UInteger, ByRef returnLength As UInteger) As Boolean
            Return NativeMethods.GetTokenInformation(tokenHandle, tokenInformationClass, tokenInformation, tokenInformationLength, returnLength)
        End Function
    End Class
End Namespace
