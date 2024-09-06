Namespace CoreServices.ProcessManagement.Interfaces

    ''' <summary>
    ''' Interface for determining user privileges and account types.
    ''' </summary>
    ''' <remarks>
    ''' This interface provides methods for determining the type of user account by querying user privileges based on 
    ''' process tokens. It includes functionality for opening process tokens and determining the account type (System, 
    ''' Admin, or User) under which the process is running.
    ''' 
    ''' The <see cref="UsedImplicitlyAttribute"/> indicates that some methods might be used implicitly, either through 
    ''' reflection or external libraries, even if they are not explicitly called in the codebase. This helps prevent code 
    ''' analysis tools from incorrectly flagging these methods as unused and suggesting their removal.
    ''' </remarks>
    Public Interface IUserPrivilegesDeterminer

        ''' <summary>
        ''' Gets the type of user account for the current process.
        ''' </summary>
        ''' <returns>
        ''' An enumeration value of type <see cref="UserAccountType"/> representing the user account type.
        ''' </returns>
        Function GetUserAccountType() As UserAccountType

        ''' <summary>
        ''' Opens the process token for the current process.
        ''' </summary>
        ''' <param name="tokenHandle">
        ''' When this method returns, contains the handle to the process token.
        ''' This parameter is passed by reference and is assigned a valid handle if the method succeeds.
        ''' </param>
        ''' <returns>
        ''' <c>true</c> if the process token was successfully opened; otherwise, <c>false</c>.
        ''' </returns>
        <UsedImplicitly>
        Function OpenProcessToken(ByRef tokenHandle As IntPtr) As Boolean

        ''' <summary>
        ''' Determines whether the specified token handle belongs to a system account.
        ''' </summary>
        ''' <param name="tokenHandle">
        ''' The handle to the process token.
        ''' </param>
        ''' <returns>
        ''' <c>true</c> if the token handle belongs to a system account; otherwise, <c>false</c>.
        ''' </returns>
        <UsedImplicitly>
        Function IsSystemAccount(tokenHandle As IntPtr) As Boolean

        ''' <summary>
        ''' Determines whether the specified token handle belongs to an administrative account.
        ''' </summary>
        ''' <param name="tokenHandle">
        ''' The handle to the process token.
        ''' </param>
        ''' <returns>
        ''' <c>true</c> if the token handle belongs to an administrative account; otherwise, <c>false</c>.
        ''' </returns>
        <UsedImplicitly>
        Function IsAdminAccount(tokenHandle As IntPtr) As Boolean
    End Interface
End Namespace
