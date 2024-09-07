Namespace Application

    ''' <summary>
    ''' Represents an application that uses dependency injection to obtain services and perform operations.
    ''' </summary>
    ''' <remarks>
    ''' The <see cref="AppRunner"/> class relies on dependency injection to obtain an <see cref="IServiceProvider"/> 
    ''' which is used to retrieve services throughout the application. The main functionality of the class is to 
    ''' retrieve the <see cref="IUserAccountService"/> service and use it to display the user's account type.
    ''' </remarks>
    Friend Class AppRunner

        ''' <summary>
        ''' The service provider used for retrieving services.
        ''' </summary>
        Private ReadOnly _serviceProvider As IServiceProvider

        ''' <summary>
        ''' Initializes a new instance of the <see cref="AppRunner"/> class.
        ''' </summary>
        ''' <param name="serviceProvider">
        ''' An instance of <see cref="IServiceProvider"/> used to resolve dependencies and obtain services.
        ''' </param>
        ''' <remarks>
        ''' The constructor takes an <see cref="IServiceProvider"/> as a parameter and assigns it to the
        ''' <see cref="_serviceProvider"/> field. This service provider is used throughout the class to obtain 
        ''' necessary services.
        ''' </remarks>
        Friend Sub New(serviceProvider As IServiceProvider)
            _serviceProvider = serviceProvider
        End Sub

        ''' <summary>
        ''' Runs the application.
        ''' </summary>
        ''' <remarks>
        ''' The <see cref="Run"/> method retrieves the <see cref="IUserAccountService"/> from the service provider,
        ''' uses it to get the friendly user account type, and prints it to the console. The method then waits 
        ''' for the user to press Enter before terminating.
        ''' </remarks>
        Friend Sub Run()
            Dim userAccountService = _serviceProvider.GetService(Of IUserAccountService)()
            Dim friendlyAccountType As String = userAccountService.GetFriendlyUserAccountType()
            Console.WriteLine($"You are running as: {friendlyAccountType}")
            Console.ReadLine()
        End Sub
    End Class
End Namespace
