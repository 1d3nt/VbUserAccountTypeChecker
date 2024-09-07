Namespace Utilities

    ''' <summary>
    ''' Provides extension methods for the <see cref="UserAccountType"/> enumeration.
    ''' </summary>
    ''' <remarks>
    ''' This class contains methods that extend the functionality of the <see cref="UserAccountType"/> enumeration, 
    ''' including custom string representations. These methods are designed to make working with user account 
    ''' types more convenient and readable.
    ''' </remarks>
    Friend Class UserAccountTypeExtensions
        Implements IUserAccountTypeExtensions

        ''' <summary>
        ''' Dictionary to map enum values to their friendly string representations.
        ''' </summary>
        ''' <remarks>
        ''' This dictionary allows easy lookup of the friendly string representations of the <see cref="UserAccountType"/> enum values.
        ''' </remarks>
        Private Shared ReadOnly FriendlyDescriptions As New Dictionary(Of UserAccountType, String)() From {
            {UserAccountType.System, "System Account"},
            {UserAccountType.Admin, "Administrative Account"},
            {UserAccountType.User, "Standard User Account"},
            {UserAccountType.LocalService, "Local Service Account"},
            {UserAccountType.NetworkService, "Network Service Account"},
            {UserAccountType.Umfd0, "UMFD-0 Account"},
            {UserAccountType.Umfd1, "UMFD-1 Account"},
            {UserAccountType.Dwm1, "DWM-1 Account"}
        }

        ''' <summary>
        ''' Provides a custom string representation for the <see cref="UserAccountType"/> enum.
        ''' </summary>
        ''' <param name="accountType">The <see cref="UserAccountType"/> value to convert to a string.</param>
        ''' <returns>
        ''' A string that represents the <see cref="UserAccountType"/> value. 
        ''' If the value is not found in the dictionary, "Unknown Account Type" is returned.
        ''' </returns>
        ''' <remarks>
        ''' This method converts the <see cref="UserAccountType"/> enum values into human-readable strings using a dictionary lookup.
        ''' </remarks>
        ''' <exception cref="ArgumentException">Thrown when the <paramref name="accountType"/> is not a valid <see cref="UserAccountType"/>.</exception>
        Friend Function ToFriendlyString(accountType As UserAccountType) As String Implements IUserAccountTypeExtensions.ToFriendlyString
            Dim description As String = Nothing

            If FriendlyDescriptions.TryGetValue(accountType, description) Then
                Return description
            Else
                Return "Unknown Account Type"
            End If
        End Function
    End Class
End Namespace
