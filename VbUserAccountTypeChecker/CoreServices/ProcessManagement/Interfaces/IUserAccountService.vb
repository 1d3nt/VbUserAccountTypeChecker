Namespace CoreServices.ProcessManagement.Interfaces

    ''' <summary>
    ''' Interface for user account services.
    ''' </summary>
    Public Interface IUserAccountService

        ''' <summary>
        ''' Gets the user account type as a friendly string.
        ''' </summary>
        ''' <returns>A user-friendly string representing the user account type.</returns>
        Function GetFriendlyUserAccountType() As String
    End Interface
End Namespace
