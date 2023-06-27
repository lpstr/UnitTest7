
# Running Unit Tests

This repository includes unit tests for two classes - `PlayerAnalyzer` and `StudentConverter`. These tests are designed to ensure the correctness of the methods `CalculateScore` and `ConvertStudents` respectively under a variety of scenarios.

## Prerequisites

Make sure you have .NET 6.0 SDK installed on your machine. You can download it from [Microsoft's official .NET download page](https://dotnet.microsoft.com/download).

## Running the Tests

1. **Open your terminal** - You can do this by searching for `cmd` (Windows) or `terminal` (macOS/Linux) in your system's search bar.

2. **Navigate to the project directory** - Using the `cd` command followed by the path to the directory containing your .csproj file. For example:
```
cd /path/to/your/project
```

3. **Run the tests** - Execute the `dotnet test` command in the terminal:
```
dotnet test
```
The command will automatically find and run all the tests in the project, compiling the necessary files. The results will be displayed in the terminal window.

For example, successful tests will be marked as 'Passed', while failed tests will be marked as 'Failed', along with a description of the failure to aid in debugging.

## Important Note

For the tests to execute correctly, the `PlayerAnalyzer` and `StudentConverter` classes, as well as the `Player` and `Student` models need to be present in the same solution or project. Ensure you have the necessary `using` statements added to the test file.

By following the aforementioned steps, you will be able to run all the unit tests locally on your machine.