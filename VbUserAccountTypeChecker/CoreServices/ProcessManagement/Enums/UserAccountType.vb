Namespace CoreServices.ProcessManagement.Enums

    ''' <summary>
    ''' Represents the different types of user accounts that a process can be running under, as displayed in Task Manager.
    ''' </summary>
    ''' <remarks>
    ''' This enumeration includes various types of user accounts that a process might be running under. 
    ''' It covers a range of account types from system and administrative accounts to service accounts and other specialized accounts.
    ''' 
    ''' Note: The <c>&lt;UsedImplicitly&gt;</c> attribute is applied to this enumeration to indicate that while 
    ''' some members may not be directly referenced in the code, they are retained for completeness and potential future use.
    ''' </remarks>
    <UsedImplicitly>
    Friend Enum UserAccountType

        ''' <summary>
        ''' Indicates that the process is running under a system account.
        ''' </summary>
        System

        ''' <summary>
        ''' Indicates that the process is running under an administrative account.
        ''' </summary>
        Admin

        ''' <summary>
        ''' Indicates that the process is running under a standard user account.
        ''' </summary>
        User

        ''' <summary>
        ''' Indicates that the process is running under a local service account.
        ''' </summary>
        <UsedImplicitly>
        LocalService

        ''' <summary>
        ''' Indicates that the process is running under a network service account.
        ''' </summary>
        <UsedImplicitly>
        NetworkService

        ''' <summary>
        ''' Indicates that the process is running under a Desktop Window Manager (DWM) account with index 1.
        ''' </summary>
        <UsedImplicitly>
        Dwm1

        ''' <summary>
        ''' Indicates that the process is running under a Desktop Window Manager (DWM) account with index 2.
        ''' </summary>
        <UsedImplicitly>
        Dwm2

        ''' <summary>
        ''' Indicates that the process is running under a User Mode Font Driver (UMFD) account with index 0.
        ''' </summary>
        <UsedImplicitly>
        Umfd0

        ''' <summary>
        ''' Indicates that the process is running under a User Mode Font Driver (UMFD) account with index 1.
        ''' </summary>
        <UsedImplicitly>
        Umfd1

        ''' <summary>
        ''' Indicates that the process is running under an account type not explicitly listed here.
        ''' </summary>
        <UsedImplicitly>
        Other
    End Enum
End Namespace
