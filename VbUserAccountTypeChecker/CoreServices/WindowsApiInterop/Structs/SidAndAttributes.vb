Namespace CoreServices.WindowsApiInterop.Structs

    ''' <summary>
    ''' Represents a security identifier (SID) and its associated attributes. 
    ''' The SID uniquely identifies a user or a group, and the attributes provide additional information about the SID.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="SidAndAttributes"/> structure is used in Windows API functions to manage and manipulate security identifiers and their attributes.
    ''' 
    ''' The following is the C++ signature for the <c>SID_AND_ATTRIBUTES</c> structure:
    ''' <code>
    ''' typedef struct _SID_AND_ATTRIBUTES {
    ''' #if ...
    '''   PISID Sid;
    ''' #else
    '''   PSID  Sid;
    ''' #endif
    '''   DWORD Attributes;
    ''' } SID_AND_ATTRIBUTES, *PSID_AND_ATTRIBUTES;
    ''' </code>
    ''' 
    ''' - <see cref="SidAndAttributes.Sid"/>: A pointer to a SID (Security Identifier) structure. The SID is used to identify a user or group.
    ''' - <see cref="SidAndAttributes.Attributes"/>: A set of bit flags that define attributes associated with the SID. This typically includes attributes like whether the SID is enabled or disabled.
    ''' 
    ''' For more information on the SID and its attributes, refer to the official Microsoft documentation:
    ''' <see href="https://learn.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-sid_and_attributes">SID_AND_ATTRIBUTES</see>.
    ''' </remarks>
    <StructLayout(LayoutKind.Sequential)>
    Friend Structure SidAndAttributes

        ''' <summary>
        ''' A pointer to a SID (Security Identifier) structure.
        ''' </summary>
        ''' <remarks>
        ''' The SID uniquely identifies a user or group in the Windows security model. 
        ''' This pointer is used by various Windows API functions to represent the SID in a security context.
        ''' </remarks>
        Friend Sid As IntPtr
        
        ''' <summary>
        ''' A set of bit flags that describe attributes associated with the SID.
        ''' </summary>
        ''' <remarks>
        ''' The attributes may include flags that indicate the status or permissions of the SID, such as whether it is enabled or disabled.
        ''' This field is used by the Windows security model to apply security policies and permissions.
        ''' </remarks>
        Friend Attributes As UInteger
    End Structure
End Namespace
