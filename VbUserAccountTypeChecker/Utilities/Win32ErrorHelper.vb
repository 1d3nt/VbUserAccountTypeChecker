Namespace Utilities

    ''' <summary>
    ''' Provides utility methods for handling Win32 errors.
    ''' </summary>
    ''' <remarks>
    ''' In the context of managed code, using the <see cref="Marshal.GetLastWin32Error"/> method 
    ''' is essential instead of calling the Win32 <c>GetLastError</c> API directly.
    ''' This is because the CLR may make additional system calls while transitioning 
    ''' from unmanaged to managed code, which can overwrite the last error code.
    ''' For more details, see Adam Nathan's blog post:
    ''' <a href="https://web.archive.org/web/20151221201611/http://blogs.msdn.com/b/adam_nathan/archive/2003/04/25/56643.aspx">
    ''' Archived Version</a> or the 
    ''' <a href="http://blogs.msdn.com/b/adam_nathan/archive/2003/04/25/56643.aspx">Original URL</a>.
    ''' </remarks>
    Friend Class Win32ErrorHelper
        Implements IWin32ErrorHelper

        ''' <summary>
        ''' Retrieves the last Win32 error code.
        ''' </summary>
        ''' <returns>The last Win32 error code saved by the CLR.</returns>
        ''' <remarks>
        ''' The <see cref="Marshal.GetLastWin32Error"/> method should be used in managed code 
        ''' to retrieve error information after a P/Invoke call. 
        ''' This ensures the error code returned is reliable, as the CLR saves the result 
        ''' of <c>GetLastError</c> immediately after the unmanaged API call completes, preventing 
        ''' overwrites by other system calls made by the CLR.
        ''' </remarks>
        Friend Function GetLastWin32Error() As Integer Implements IWin32ErrorHelper.GetLastWin32Error
            Return Marshal.GetLastWin32Error()
        End Function
    End Class
End Namespace
