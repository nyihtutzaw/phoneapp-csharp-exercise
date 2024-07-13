
# phoneApp Project

This repository contains a C# project along with a test project to demonstrate the functionality of the OldPhonePad class.

## Project Setup

### Prerequisites

- .NET 8.0 SDK or later

### Steps to Set Up the Project

1. Clone the repository:
    ```bash
    git clone 
    cd  folder
    ```

2. Restore the packages:
    ```bash
    cd phoneApp
    dotnet restore

    ```


## Running the Program

To run the main program, use the following command:

```bash
dotnet run --project phoneApp
```

The program contains example usage of the `OldPhonePad` class. You can modify the `Program.cs` file to test different inputs.

## Running the Tests

To run the tests, navigate to the test project directory and use the `dotnet test` command:

```bash
cd phoneApp.Tests
dotnet test
```

The test project includes several test cases for the `OldPhonePad` class using the xUnit framework.

## Project Structure

```
/phoneAppSolution
    /phoneApp
        phoneApp.csproj
        Program.cs
        OldPhonePad.cs
    /phoneApp.Tests
        phoneApp.Tests.csproj
        OldPhonePadTests.cs
```

- `phoneApp/`: Contains the main project code.
- `phoneApp.Tests/`: Contains the test project code.

## Example Test Cases

- `OldPhonePad("33#")` => "E"
- `OldPhonePad("227*#")` => "B"
- `OldPhonePad("4433555 555666#")` => "HELLO"
- `OldPhonePad("8 88777444666*664#")` => "TURING"
- `OldPhonePad("669994440448 88 80999929#")` => "NYI HTUT ZAW"
