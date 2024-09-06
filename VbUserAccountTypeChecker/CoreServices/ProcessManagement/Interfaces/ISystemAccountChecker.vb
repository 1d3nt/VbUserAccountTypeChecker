Namespace CoreServices.ProcessManagement.Interfaces

    ''' <summary>
    ''' Interface for checking if a given token handle belongs to a system account.
    ''' </summary>
    ''' <remarks>
    ''' This interface provides a method for checking whether a specific token handle belongs to a system account. 
    ''' 
    ''' The <see cref="UsedImplicitlyAttribute"/> indicates that the method might be used implicitly, either through 
    ''' reflection or external libraries, even if it appears unused in the current codebase. This helps prevent code 
    ''' analysis tools from incorrectly flagging the method as unused and suggesting its removal.
    ''' </remarks>
    Public Interface ISystemAccountChecker

        ''' <summary>
        ''' Determines whether the specified token handle belongs to a system account.
        ''' </summary>
        ''' <param name="tokenHandle">The handle to the process token.</param>
        ''' <returns>
        ''' <c>true</c> if the token handle belongs to a system account; otherwise, <c>false</c>.
        ''' </returns>
        ''' <remarks>
        ''' The <see cref="UsedImplicitlyAttribute"/> indicates that this method may be used implicitly by external 
        ''' services or libraries that check system account status, even if it seems unused in the current implementation. 
        ''' This ensures that the method is preserved and not removed during code optimizations.
        ''' </remarks>
        <UsedImplicitly>
        Function IsSystemAccount(tokenHandle As IntPtr) As Boolean
    End Interface
End Namespace
