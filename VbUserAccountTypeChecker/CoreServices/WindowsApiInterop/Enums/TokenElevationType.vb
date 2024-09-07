Namespace CoreServices.WindowsApiInterop.Enums

    ''' <summary>
    ''' Defines the elevation type of access token.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="TokenElevationType"/> enumeration specifies the level of elevation for an access token.
    ''' This information is typically used in security contexts to determine whether a process is running with elevated privileges.
    ''' 
    ''' The values in this enumeration correspond to the <c>TOKEN_ELEVATION_TYPE</c> enumeration in C++.
    ''' 
    ''' The C++ signature for this enumeration is:
    ''' <code>
    ''' typedef enum _TOKEN_ELEVATION_TYPE {
    '''   TokenElevationTypeDefault = 1,
    '''   TokenElevationTypeFull,
    '''   TokenElevationTypeLimited
    ''' } TOKEN_ELEVATION_TYPE, *PTOKEN_ELEVATION_TYPE;
    ''' </code>
    ''' 
    ''' For more information about token elevation types, refer to the official Microsoft documentation:
    ''' <see href="https://learn.microsoft.com/en-us/windows/win32/api/winnt/ne-winnt-token_elevation_type">TOKEN_ELEVATION_TYPE</see>.
    ''' 
    ''' Note: The <see cref="UsedImplicitlyAttribute"/> attribute is applied to some members of this enumeration to indicate that 
    ''' while they may not be directly referenced in the code, they are retained for completeness and potential future use.
    ''' </remarks>
    Friend Enum TokenElevationType As Integer

        ''' <summary>
        ''' The token elevation type is default. This value is used when the elevation type is not explicitly specified or when it is not applicable.
        ''' </summary>
        ''' <remarks>
        ''' This member is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenElevationTypeDefault = 1

        ''' <summary>
        ''' The token elevation type is full. This indicates that the process is running with full administrative privileges.
        ''' </summary>
        ''' <remarks>
        ''' This member is retained for completeness and potential future use.
        ''' </remarks>
        TokenElevationTypeFull

        ''' <summary>
        ''' The token elevation type is limited. This indicates that the process is running with limited administrative privileges.
        ''' </summary>
        ''' <remarks>
        ''' This member is marked with <see cref="UsedImplicitlyAttribute"/> since it is not currently used but retained for completeness.
        ''' </remarks>
        <UsedImplicitly>
        TokenElevationTypeLimited
    End Enum
End Namespace
