Namespace CoreServices.WindowsApiInterop.Structs

    ''' <summary>
    ''' Represents a user in a token, including the user's security identifier (SID) and associated attributes.
    ''' The <see cref="TokenUser"/> structure is used in Windows API functions to retrieve information about the user associated with a token.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="TokenUser"/> structure mirrors the C++ definition of the <c>TOKEN_USER</c> structure:
    ''' <code>
    ''' typedef struct _TOKEN_USER {
    '''   SID_AND_ATTRIBUTES User;
    ''' } TOKEN_USER, *PTOKEN_USER;
    ''' </code>
    ''' 
    ''' - <see cref="TokenUser.User"/>: Contains the user's SID and attributes, which identify the user and provide additional information about the user's security context.
    ''' 
    ''' For more information on the TOKEN_USER structure, refer to the official Microsoft documentation:
    ''' <see href="https://learn.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-token_user">TOKEN_USER</see>.
    ''' </remarks>
    <StructLayout(LayoutKind.Sequential)>
    Friend Structure TokenUser

        ''' <summary>
        ''' Contains the security identifier (SID) and associated attributes of the user.
        ''' </summary>
        ''' <remarks>
        ''' The <see cref="SidAndAttributes"/> structure includes a pointer to the SID and bit flags representing attributes related to the user.
        ''' This field is used to identify the user and manage security permissions in the context of the token.
        ''' </remarks>
        Friend User As SidAndAttributes
    End Structure
End Namespace
