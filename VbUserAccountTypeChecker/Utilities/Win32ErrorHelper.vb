Namespace Utilities

    ''' <summary>
    ''' Provides utility methods for handling Win32 errors.
    ''' </summary>
    Friend Class Win32ErrorHelper

        ''' <summary>
        ''' Retrieves the last Win32 error code.
        ''' </summary>
        ''' <returns>The last Win32 error code.</returns>
        Friend Shared Function GetLastWin32Error() As Integer
            Return Marshal.GetLastWin32Error()
        End Function
    End Class
End Namespace
