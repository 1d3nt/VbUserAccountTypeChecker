Namespace CoreServices.ProcessManagement

    ''' <summary>
    ''' Provides services related to user account types.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="UserAccountService"/> class is responsible for determining and representing user account types.
    ''' It uses other services to determine the privileges associated with the user account and converts these 
    ''' account types into user-friendly strings.
    ''' </remarks>
    Friend Class UserAccountService
        Implements IUserAccountService

        ''' <summary>
        ''' Determines user privileges based on the process token.
        ''' </summary>
        Private ReadOnly _userPrivilegesDeterminer As IUserPrivilegesDeterminer

        ''' <summary>
        ''' Provides extension methods for the <see cref="UserAccountType"/> enumeration.
        ''' </summary>
        Private ReadOnly _userAccountTypeExtensions As IUserAccountTypeExtensions

        ''' <summary>
        ''' Initializes a new instance of the <see cref="UserAccountService"/> class.
        ''' </summary>
        ''' <param name="userPrivilegesDeterminer">An instance of <see cref="IUserPrivilegesDeterminer"/>.</param>
        ''' <param name="userAccountTypeExtensions">An instance of <see cref="UserAccountTypeExtensions"/> used to convert user account types to friendly strings.</param>
        ''' <remarks>
        ''' The constructor initializes the <see cref="_userPrivilegesDeterminer"/> and <see cref="_userAccountTypeExtensions"/> fields. 
        ''' The <see cref="_userPrivilegesDeterminer"/> is used to determine user privileges, while the <see cref="_userAccountTypeExtensions"/> 
        ''' is used to convert user account types to human-readable strings.
        ''' </remarks>
        Public Sub New(userPrivilegesDeterminer As IUserPrivilegesDeterminer, userAccountTypeExtensions As IUserAccountTypeExtensions)
            _userPrivilegesDeterminer = userPrivilegesDeterminer
            _userAccountTypeExtensions = userAccountTypeExtensions
        End Sub
        ''' <summary>
        ''' Gets the user account type as a friendly string.
        ''' </summary>
        ''' <returns>A user-friendly string representing the user account type.</returns>
        ''' <remarks>
        ''' This method determines the user account type using the <see cref="IUserPrivilegesDeterminer"/> and converts it to a user-friendly string.
        ''' </remarks>
        Friend Function GetFriendlyUserAccountType() As String Implements IUserAccountService.GetFriendlyUserAccountType
            Dim accountType = _userPrivilegesDeterminer.GetUserAccountType()
            Return _userAccountTypeExtensions.ToFriendlyString(accountType)
        End Function
    End Class
End Namespace
