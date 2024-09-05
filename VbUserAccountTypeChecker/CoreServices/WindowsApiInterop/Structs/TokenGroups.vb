Namespace CoreServices.WindowsApiInterop.Structs

    ''' <summary>
    ''' Represents a set of security groups associated with a token. 
    ''' Each group is represented by a SID (Security Identifier) and its associated attributes.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="TokenGroups"/> structure is used in Windows API functions to manage and manipulate security groups associated with a token.
    ''' This structure provides a list of groups and their attributes, which can be used for access control and security purposes.
    ''' 
    ''' The following is the C++ signature for the <c>TOKEN_GROUPS</c> structure:
    ''' <code>
    ''' typedef struct _TOKEN_GROUPS {
    '''   DWORD              GroupCount;
    ''' #if ...
    '''   SID_AND_ATTRIBUTES *Groups[];
    ''' #else
    '''   SID_AND_ATTRIBUTES Groups[ANYSIZE_ARRAY];
    ''' #endif
    ''' } TOKEN_GROUPS, *PTOKEN_GROUPS;
    ''' </code>
    ''' 
    ''' - <see cref="TokenGroups.GroupCount"/>: The number of security groups in the array. This field specifies how many entries are in the <see cref="TokenGroups.Groups"/> array.
    ''' - <see cref="TokenGroups.Groups"/>: An array of <see cref="SidAndAttributes"/> structures, where each element represents a security group and its attributes. 
    ''' The array's size is indicated by the <see cref="TokenGroups.GroupCount"/> field. 
    ''' 
    ''' For more information about the TOKEN_GROUPS structure and its use in Windows API, refer to:
    ''' <see href="https://learn.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-token_groups">TOKEN_GROUPS</see>.
    ''' </remarks>
    <StructLayout(LayoutKind.Sequential)>
    Friend Structure TokenGroups

        ''' <summary>
        ''' The number of security groups contained in the <see cref="Groups"/> array.
        ''' </summary>
        ''' <remarks>
        ''' This field indicates the number of entries in the <see cref="Groups"/> array. It is used to determine the size of the array when processing or iterating through the groups.
        ''' </remarks>
        Friend GroupCount As UInteger

        ''' <summary>
        ''' An array of <see cref="SidAndAttributes"/> structures representing the security groups associated with the token.
        ''' </summary>
        ''' <remarks>
        ''' Each entry in this array represents a security group and its associated attributes. The array's size is specified by the <see cref="GroupCount"/> field.
        ''' The <see cref="SidAndAttributes"/> structure contains a SID (Security Identifier) and attributes for each group.
        ''' </remarks>
        Friend Groups() As SidAndAttributes
    End Structure
End Namespace
