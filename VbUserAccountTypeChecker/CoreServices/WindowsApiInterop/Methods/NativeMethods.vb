Namespace CoreServices.WindowsApiInterop.Methods

    ''' <summary>
    ''' Provides methods for interacting with native Windows APIs. 
    ''' This class contains P/Invoke declarations for various functions used for process and token management.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="NativeMethods"/> class uses the <c>DllImport</c> attribute to define methods that are imported 
    ''' from unmanaged DLLs. These methods are used to interact with the Windows operating system at a low level.
    ''' 
    ''' The <c>SuppressUnmanagedCodeSecurity</c> attribute is applied to this class to improve performance when
    ''' calling unmanaged code. This attribute disables code access security checks for unmanaged code, which
    ''' can reduce overhead in performance-critical applications. Use this attribute with caution, as it bypasses
    ''' some of the security measures provided by the .NET runtime.
    ''' </remarks>
    <Security.SuppressUnmanagedCodeSecurity>
    Friend NotInheritable Class NativeMethods

        ''' <summary>
        ''' Represents a null handle value used in P/Invoke calls.
        ''' </summary>
        ''' <remarks>
        ''' This field is used to represent a null handle (IntPtr.Zero) in P/Invoke calls to unmanaged code.
        ''' </remarks>
        Friend Shared ReadOnly NullHandleValue As IntPtr = IntPtr.Zero

        ''' <summary>
        ''' Opens the access token associated with a process.
        ''' </summary>
        ''' <param name="processHandle">
        ''' A handle to the process whose access token is opened. The process handle must have appropriate access rights,
        ''' such as <see cref="AccessMask.TokenDuplicate"/> or <see cref="AccessMask.QueryInformation"/>, depending on 
        ''' the desired access to the token. This parameter is passed with the <c>[In]</c> attribute.
        ''' </param>
        ''' <param name="desiredAccess">
        ''' Specifies an access mask that specifies the requested types of access to the access token. For example, to duplicate
        ''' the token, you might use <see cref="AccessMask.TokenDuplicate"/>. This parameter is passed with the <c>[In]</c> attribute.
        ''' </param>
        ''' <param name="tokenHandle">
        ''' A pointer to a handle that receives the access token for the process when the function returns. This handle is used
        ''' to identify the token. This parameter is written to by the function and is passed with the <c>[Out]</c> attribute.
        ''' </param>
        ''' <returns>
        ''' If the function succeeds, the return value is <c>True</c>. If the function fails, the return value is <c>False</c>.
        ''' To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        ''' </returns>
        ''' <remarks>
        ''' For more details, refer to the <see href="https://docs.microsoft.com/en-us/windows/desktop/api/processthreadsapi/nf-processthreadsapi-openprocesstoken">OpenProcessToken</see> documentation.
        ''' 
        ''' The function signature in C++ is:
        ''' <code>
        ''' BOOL OpenProcessToken(
        '''   [in]  HANDLE  ProcessHandle,
        '''   [in]  DWORD   DesiredAccess,
        '''   [out] PHANDLE TokenHandle
        ''' );
        ''' </code>
        ''' </remarks>
        <DllImport(ExternDll.Advapi32, SetLastError:=True)>
        Friend Shared Function OpenProcessToken(
            <[In]> processHandle As IntPtr,
            <[In]> desiredAccess As AccessMask,
            <[Out]> ByRef tokenHandle As IntPtr
        ) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function

        ''' <summary>
        ''' Retrieves a specified type of information about an access token.
        ''' </summary>
        ''' <param name="tokenHandle">
        ''' A handle to an access token from which information is retrieved. This parameter is passed with the <c>[In]</c> attribute.
        ''' </param>
        ''' <param name="tokenInformationClass">
        ''' Specifies a value from the <see cref="TokenInformationClass"/> enumerated type to identify the type of information the function retrieves. 
        ''' This parameter is passed with the <c>[In]</c> attribute.
        ''' </param>
        ''' <param name="tokenInformation">
        ''' A pointer to a buffer that the function fills with the requested information. If the function fails, this buffer may not be valid. 
        ''' This parameter is passed with the <c>[Out], [Optional]</c> attributes.
        ''' </param>
        ''' <param name="tokenInformationLength">
        ''' Specifies the size, in bytes, of the <paramref name="tokenInformation"/> buffer. This parameter is passed with the <c>[In]</c> attribute.
        ''' </param>
        ''' <param name="returnLength">
        ''' A pointer to a variable that receives the number of bytes needed for the buffer pointed to by the <paramref name="tokenInformation"/> parameter. 
        ''' This parameter is passed with the <c>[Out]</c> attribute.
        ''' </param>
        ''' <returns>
        ''' If the function succeeds, the return value is <c>True</c>. If the function fails, the return value is <c>False</c>. To get extended error information, 
        ''' call <see cref="Marshal.GetLastWin32Error"/>.
        ''' </returns>
        ''' <remarks>
        ''' For more details, refer to the <see href="https://learn.microsoft.com/en-us/windows/win32/api/securitybaseapi/nf-securitybaseapi-gettokeninformation">GetTokenInformation</see> documentation.
        ''' 
        ''' The function signature in C++ is:
        ''' <code>
        ''' BOOL GetTokenInformation(
        '''   [in]            HANDLE                  TokenHandle,
        '''   [in]            TOKEN_INFORMATION_CLASS TokenInformationClass,
        '''   [out, optional] LPVOID                  TokenInformation,
        '''   [in]            DWORD                   TokenInformationLength,
        '''   [out]           PDWORD                  ReturnLength
        ''' );
        ''' </code>
        ''' </remarks>
        <DllImport(ExternDll.Advapi32, SetLastError:=True)>
        Friend Shared Function GetTokenInformation(
            <[In]> tokenHandle As IntPtr,
            <[In]> tokenInformationClass As TokenInformationClass,
            <[Out], [Optional]> tokenInformation As IntPtr,
            <[In]> tokenInformationLength As UInteger,
            <[Out]> ByRef returnLength As UInteger
        ) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function

        ''' <summary>
        ''' Closes an open object handle.
        ''' </summary>
        ''' <param name="hObject">
        ''' A valid handle to an open object. This handle is typically obtained from functions like <c>CreateFile</c>,
        ''' <c>OpenProcess</c>, or <c>OpenThread</c>. This parameter is passed with the <c>[In]</c> attribute.
        ''' </param>
        ''' <returns>
        ''' If the function succeeds, the return value is nonzero (<c>True</c>). If the function fails, the return value is
        ''' zero (<c>False</c>). To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
        ''' </returns>
        ''' <remarks>
        ''' The <c>CloseHandle</c> function is used to close an open handle to an object. It is crucial to call this function
        ''' to free system resources when a handle is no longer needed.
        ''' 
        ''' For more details, refer to the <see href="https://learn.microsoft.com/en-us/windows/desktop/api/handleapi/nf-handleapi-closehandle">CloseHandle</see> documentation.
        ''' 
        ''' The function signature in C++ is:
        ''' <code>
        ''' BOOL CloseHandle(
        '''   [in] HANDLE hObject
        ''' );
        ''' </code>
        ''' </remarks>
        <DllImport(ExternDll.Kernel32, SetLastError:=True)>
        Friend Shared Function CloseHandle(
            <[In]> hObject As IntPtr
        ) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function

        ''' <summary>
        ''' Retrieves a pseudo-handle for the current process.
        ''' </summary>
        ''' <remarks>
        ''' The <see cref="GetCurrentProcess"/> function is a Windows API call that returns a pseudo-handle to the current process.
        ''' A pseudo-handle is a special constant that is interpreted as the current process handle.
        ''' It can be used wherever a real handle to the current process is required, such as in functions like <c>GetProcessId</c> or <c>TerminateProcess</c>.
        ''' 
        ''' The pseudo-handle does not need to be closed when it is no longer needed. Calling <c>CloseHandle</c> with this pseudo-handle has no effect.
        ''' 
        ''' This function is commonly used when a process needs to retrieve information about itself without having to explicitly open a handle to itself.
        ''' 
        ''' <para>The following is the C++ signature for the <c>GetCurrentProcess</c> function:</para>
        ''' <code>
        ''' HANDLE GetCurrentProcess();
        ''' </code>
        ''' 
        ''' For more details, refer to the <see href="https://learn.microsoft.com/en-us/windows/win32/api/processthreadsapi/nf-processthreadsapi-getcurrentprocess">GetCurrentProcess function (processthreadsapi.h)</see> documentation.
        ''' </remarks>
        ''' <returns>
        ''' An <see cref="IntPtr"/> that represents a pseudo-handle to the current process.
        ''' </returns>
        <DllImport(ExternDll.Kernel32, SetLastError:=True)>
        Friend Shared Function GetCurrentProcess() As IntPtr
        End Function

        ''' <summary>
        ''' Determines whether the user of the current thread is a member of the Administrators group.
        ''' </summary>
        ''' <returns>
        ''' <c>True</c> if the user is an admin, otherwise <c>False</c>.
        ''' </returns>
        ''' <remarks>
        ''' The <see cref="IsUserAnAdmin"/> function determines if the currently logged-in user belongs to the Administrators group. 
        ''' This function is commonly used to check administrative privileges before performing actions that require elevated rights.
        ''' 
        ''' <para>The function signature in C++ is:</para>
        ''' <code>
        ''' BOOL IsUserAnAdmin();
        ''' </code>
        ''' 
        ''' <para>Note: The <see cref="IsUserAnAdmin"/> function is deprecated in newer Windows versions and may not be available. 
        ''' While it is no longer recommended for use in modern applications, it is retained here for completeness and relevance to the project's objectives. 
        ''' Although it is not currently used in the project, it has been kept for reference and potential future use based on the project's goals and requirements. 
        ''' It is marked as <see cref="UsedImplicitlyAttribute"/> to indicate its purpose and possible future utility.</para>
        ''' 
        ''' <para>For more details, refer to the <see href="https://learn.microsoft.com/en-us/windows/win32/api/shlobj_core/nf-shlobj_core-isuseranadmin">IsUserAnAdmin</see> documentation.</para>
        ''' </remarks>
        ''' <seealso href="https://learn.microsoft.com/en-us/windows/win32/api/shlobj_core/nf-shlobj_core-isuseranadmin">IsUserAnAdmin documentation</seealso>
        <UsedImplicitly, DllImport(ExternDll.Shell32, SetLastError:=True)>
        Friend Shared Function IsUserAnAdmin() As Boolean
        End Function
    End Class
End Namespace
