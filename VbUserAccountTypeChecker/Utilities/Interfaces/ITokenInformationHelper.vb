Namespace Utilities.Interfaces

    ''' <summary>
    ''' Provides an interface for retrieving token information.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="ITokenInformationHelper"/> interface defines a method for safely retrieving token information from a process.
    ''' Implementations of this interface should handle memory allocation and cleanup to ensure that resources are managed properly during the retrieval process.
    ''' 
    ''' The <see cref="UsedImplicitlyAttribute"/> indicates that the method is used implicitly, either through reflection or external 
    ''' libraries, even if it appears unused in the current codebase. This helps prevent code analysis tools from incorrectly 
    ''' flagging the method as unused and suggesting its removal.
    ''' 
    ''' In this context, <c>IsAdminAccount</c> may be invoked by external services or libraries that manage tokens, and 
    ''' therefore, it is necessary to annotate the method to ensure its inclusion and avoid premature optimization issues.
    ''' </remarks>
    Public Interface ITokenInformationHelper

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
        <UsedImplicitly>
        Function TryGetTokenInformation(tokenManager As IProcessTokenManager, tokenHandle As IntPtr, tokenInfoClass As TokenInformationClass, ByRef dwSize As UInteger, ByRef tokenInfo As IntPtr) As Boolean
    End Interface
End Namespace
