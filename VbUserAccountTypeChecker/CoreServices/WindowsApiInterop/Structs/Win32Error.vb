Namespace CoreServices.WindowsApiInterop.Structs

    ''' <summary>
    ''' Provides a set of constants representing various Win32 error codes.
    ''' </summary>
    ''' <remarks>
    ''' This class defines constants for common Win32 error codes used by Windows API functions.
    ''' Although implemented as a class, it is included in the <c>Structs</c> namespace due to its role in
    ''' representing a collection of related constants that are utilized throughout the application for error
    ''' handling and system interactions. This organization aligns with the project's structure, where 
    ''' <c>Structs</c> serves as a namespace for constants and data representations.
    ''' 
    ''' The constants provided in this class include error codes such as <c>ERROR_INSUFFICIENT_BUFFER</c>, which 
    ''' indicates specific failure conditions when interacting with the Windows API. For comprehensive details 
    ''' about these error codes, refer to the official Microsoft documentation:
    ''' <a href="https://learn.microsoft.com/en-us/windows/win32/debug/system-error-codes--0-499-">System Error Codes (0-499)</a>.
    ''' </remarks>
    Friend NotInheritable Class Win32Error

        ''' <summary>
        ''' Error code indicating that the buffer size provided is insufficient to hold the data.
        ''' </summary>
        ''' <remarks>
        ''' The value <c>122</c> corresponds to the <c>ERROR_INSUFFICIENT_BUFFER</c> error code. This error occurs 
        ''' when the buffer provided to a Windows API function is too small to contain the data that needs to be 
        ''' returned. To resolve this error, allocate a larger buffer and retry the operation.
        ''' </remarks>
        Friend Const ErrorInsufficientBuffer As Integer = 122
    End Class
End Namespace
