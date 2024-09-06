Namespace Utilities.Interfaces

    ''' <summary>
    ''' Provides an interface for handling Win32 errors.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="IWin32ErrorHelper"/> interface defines a method for retrieving the last Win32 error code.
    ''' Implementations of this interface should provide a mechanism to obtain the last error code 
    ''' as saved by the CLR after a P/Invoke call.
    ''' 
    ''' The <see cref="UsedImplicitlyAttribute"/> indicates that the method is used implicitly, either through reflection or external 
    ''' libraries, even if it appears unused in the current codebase. This helps prevent code analysis tools from incorrectly 
    ''' flagging the method as unused and suggesting its removal.
    ''' 
    ''' For more details on how to handle Win32 errors in managed code, refer to 
    ''' <a href="https://web.archive.org/web/20151221201611/http://blogs.msdn.com/b/adam_nathan/archive/2003/04/25/56643.aspx">
    ''' Archived Version</a> or the 
    ''' <a href="http://blogs.msdn.com/b/adam_nathan/archive/2003/04/25/56643.aspx">Original URL</a>.
    ''' </remarks>
    Public Interface IWin32ErrorHelper

        ''' <summary>
        ''' Retrieves the last Win32 error code.
        ''' </summary>
        ''' <returns>
        ''' The last Win32 error code saved by the CLR. This code is typically retrieved after a P/Invoke call 
        ''' to ensure it accurately reflects the error state of the unmanaged API call.
        ''' </returns>
        ''' <remarks>
        ''' The <see cref="Marshal.GetLastWin32Error"/> method should be used to retrieve the error code. 
        ''' This is important because the CLR saves the result of <c>GetLastError</c> immediately after the unmanaged API call completes, 
        ''' preventing it from being overwritten by subsequent system calls made by the CLR.
        ''' </remarks>
        Function GetLastWin32Error() As Integer
    End Interface
End Namespace
