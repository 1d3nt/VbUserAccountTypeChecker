Namespace CoreServices.ProcessManagement.Interfaces

    ''' <summary>
    ''' Interface for checking if a given token handle belongs to an admin account.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="UsedImplicitlyAttribute"/> indicates that the method is used implicitly, either through reflection or external 
    ''' libraries, even if it appears unused in the current codebase. This helps prevent code analysis tools from incorrectly 
    ''' flagging the method as unused and suggesting its removal.
    ''' 
    ''' In this context, <c>IsAdminAccount</c> may be invoked by external services or libraries that manage tokens, and 
    ''' therefore, it is necessary to annotate the method to ensure its inclusion and avoid premature optimization issues.
    ''' </remarks>
    Public Interface IAdminAccountChecker

        ''' <summary>
        ''' Determines whether the specified token handle belongs to an admin account.
        ''' </summary>
        ''' <param name="tokenHandle">The handle to the process token.</param>
        ''' <returns>
        ''' <c>true</c> if the token handle belongs to an admin account; otherwise, <c>false</c>.
        ''' </returns>
        ''' <remarks>
        ''' The <see cref="UsedImplicitlyAttribute"/> ensures that the method is retained even if code analysis suggests it is unused.
        ''' It may be required by external libraries or frameworks.
        ''' </remarks>
        <UsedImplicitly>
        Function IsAdminAccount(tokenHandle As IntPtr) As Boolean
    End Interface
End Namespace
