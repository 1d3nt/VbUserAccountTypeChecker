# VbUserAccountTypeChecker

## Overview

**VbUserAccountTypeChecker** is a VB.NET application that uses P/Invoke to determine the type of user account (system, admin, or user) under which the current process is running. This tool interacts directly with Windows API functions to provide detailed information about the privileges of the running application. It is designed for Windows 10 and later versions.

In addition to leveraging P/Invoke, **VbUserAccountTypeChecker** utilizes dependency injection to manage its service dependencies. This approach ensures that services such as process token management, user privilege determination, and error handling are decoupled and easily testable. The application is configured to use .NET's built-in dependency injection framework, which allows for flexible and maintainable code by injecting the required services at runtime. This design pattern aligns with modern software development practices and enhances the application's overall architecture.

## Background

The `VbUserAccountTypeChecker` project builds upon the approach established in the `VbWorkerServicePinvokeLauncher` project. It is a .NET 8.0 application developed in Visual Basic that leverages P/Invoke to interact with Windows API functions.

The `VbWorkerServicePinvokeLauncher` project involved launching processes under specific user accounts, including the SYSTEM account, by duplicating process tokens using P/Invoke. This project served as a practical implementation of P/Invoke to manage different user contexts and elevated privileges.

Building on this foundation, `VbUserAccountTypeChecker` was created to determine the type of user account under which the current process is running. Unlike the previous project, which focused on launching processes, this tool is dedicated to querying process tokens and performing low-level checks to identify whether the account is a system account, administrative account, or a standard user account.

The key focus of `VbUserAccountTypeChecker` is to provide a precise and efficient method for account type determination directly through Windows API calls. This aligns with the use of P/Invoke demonstrated in `VbWorkerServicePinvokeLauncher`, emphasizing a consistent approach to handling Windows-specific functionalities across different types of applications.

## Features

- Determine the type of user account for the current process.
- Utilize P/Invoke to interact with Windows APIs.
- Output account type information: SYSTEM, ADMIN, or USER.
- Employ dependency injection for flexible and maintainable service management, including process token management, user privilege determination, and error handling.

## Installation

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- A compatible development environment (e.g., Visual Studio 2022 or later).

### Steps to Install

1. **Clone the Repository**

   ```bash
   git clone https://github.com/1d3nt/VbUserAccountTypeChecker.git

### Navigate to the Project Directory

   ```bash
   cd VbUserAccountTypeChecker
   ```

### Build the Project

Open the project in Visual Studio and build it to generate the executable.

### Usage

1. **Run the Application**

Execute the built application from the command line or Visual Studio. It will output the type of user account under which it is currently running.

   ```bash
   VbUserAccountTypeChecker.exe
   ```

2. **Review Output**

The application will display the account type: SYSTEM, ADMIN, or USER.

### Contributing

Contributions to enhance the functionality or improve the integration are welcome. Please refer to the project's issues page for open tasks and discussions.


