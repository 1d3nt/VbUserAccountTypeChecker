# VbUserAccountTypeChecker

## Overview

**VbUserAccountTypeChecker** is a VB.NET application that uses P/Invoke to determine the type of user account (system, admin, or user) under which the current process is running. This tool interacts directly with Windows API functions to provide detailed information about the privileges of the running application. It is designed for Windows 10 and later versions.

## Background

In a previous project, **VbWorkerServicePinvokeLauncher**, we demonstrated using P/Invoke to duplicate process tokens and launch processes with elevated privileges or different user contexts. For testing purposes, that project utilized Windows Principal to determine the account type of the launched process.

To provide a more complete example and showcase the use of P/Invoke for querying user account types directly, **VbUserAccountTypeChecker** was developed. This application replaces the Windows Principal approach with a full P/Invoke implementation to check the account type of the running process.

## Features

- Determine the type of user account for the current process.
- Utilize P/Invoke to interact with Windows APIs.
- Output account type information: SYSTEM, ADMIN, or USER.

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

   **1. Run the Application**

      Execute the built application from the command line or Visual Studio. It will output the type of user account under which it is currently running.

```bash
VbUserAccountTypeChecker.exe
```

   **2. Review Output**

      The application will display the account type: SYSTEM, ADMIN, or USER.

### Contributing

Contributions to enhance the functionality or improve the integration are welcome. Please refer to the project's issues page for open tasks and discussions.


