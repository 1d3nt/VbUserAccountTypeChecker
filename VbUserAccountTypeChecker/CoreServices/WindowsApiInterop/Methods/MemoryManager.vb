Namespace CoreServices.WindowsApiInterop.Methods

    ''' <summary>
    ''' Provides utility methods for managing unmanaged memory in P/Invoke operations.
    ''' </summary>
    ''' <remarks>
    ''' This class contains methods to handle common operations related to unmanaged memory management,
    ''' such as freeing memory if it is not null. It is marked as <c>NotInheritable</c> to
    ''' prevent inheritance and ensure that the utility methods are used as intended.
    ''' </remarks>
    Friend NotInheritable Class MemoryManager

        ''' <summary>
        ''' Frees the unmanaged memory if the pointer is not null.
        ''' </summary>
        ''' <param name="memoryPointer">The pointer to the unmanaged memory to be freed. This should be a valid pointer to memory allocated by  <c>Marshal.AllocHGlobal</c>.
        ''' If it is not equal, it proceeds to free the unmanaged memory using <see cref="Marshal.FreeHGlobal"/>. 
        ''' If the pointer is equal to <see cref="NativeMethods.NullHandleValue"/>, the method does nothing.
        ''' 
        ''' <see href="https://learn.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.marshal.freehglobal">Marshal.FreeHGlobal</see> 
        ''' for more details.
        ''' </remarks>
        Friend Shared Sub FreeMemoryIfNotNull(memoryPointer As IntPtr)
            If Not Equals(memoryPointer, NativeMethods.NullHandleValue) Then
                Marshal.FreeHGlobal(memoryPointer)
            End If
        End Sub
    End Class
End Namespace
