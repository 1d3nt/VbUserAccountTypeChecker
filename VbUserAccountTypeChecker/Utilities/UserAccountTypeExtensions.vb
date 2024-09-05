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

        ''' <summary>
        ''' Provides a custom string representation for the <see cref="UserAccountType"/> enum.
        ''' </summary>
        ''' <param name="accountType">The <see cref="UserAccountType"/> value to convert to a string.</param>
        ''' <returns>
        ''' A string that represents the <see cref="UserAccountType"/> value:
        ''' <list type="bullet">
        ''' <item><description>"System Account" for <see cref="UserAccountType.System"/>.</description></item>
        ''' <item><description>"Administrative Account" for <see cref="UserAccountType.Admin"/>.</description></item>
        ''' <item><description>"Standard User Account" for <see cref="UserAccountType.User"/>.</description></item>
        ''' <item><description>"Local Service Account" for <see cref="UserAccountType.LocalService"/>.</description></item>
        ''' <item><description>"Network Service Account" for <see cref="UserAccountType.NetworkService"/>.</description></item>
        ''' <item><description>"UMFD-0 Account" for <see cref="UserAccountType.Umfd0"/>.</description></item>
        ''' <item><description>"UMFD-1 Account" for <see cref="UserAccountType.Umfd1"/>.</description></item>
        ''' <item><description>"DWM-1 Account" for <see cref="UserAccountType.Dwm1"/>.</description></item>
        ''' <item><description>"Unknown Account Type" for any other values.</description></item>
        ''' </list>
        ''' </returns>
        ''' <remarks>
        ''' This method converts the <see cref="UserAccountType"/> enum values into human-readable strings. 
        ''' It helps in displaying user-friendly descriptions of account types.
        ''' </remarks>
        ''' <exception cref="ArgumentException">Thrown when the <paramref name="accountType"/> is not a valid <see cref="UserAccountType"/>.</exception>
        Friend Shared Function ToFriendlyString(accountType As UserAccountType) As String
            Select Case accountType
                Case UserAccountType.System
                    Return "System Account"
                Case UserAccountType.Admin
                    Return "Administrative Account"
                Case UserAccountType.User
                    Return "Standard User Account"
                Case UserAccountType.LocalService
                    Return "Local Service Account"
                Case UserAccountType.NetworkService
                    Return "Network Service Account"
                Case UserAccountType.Umfd0
                    Return "UMFD-0 Account"
                Case UserAccountType.Umfd1
                    Return "UMFD-1 Account"
                Case UserAccountType.Dwm1
                    Return "DWM-1 Account"
                Case Else
                    Return "Unknown Account Type"
            End Select
        End Function
    End Class
End Namespace