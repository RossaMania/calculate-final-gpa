# Calculate Final GPA

This is a simple C# console application that calculates and displays a student's final GPA based on their course grades and credit hours.

## Project Structure

The project consists of two main files:

- `Program.cs`: This is the main program file. It contains the logic for calculating the GPA and displaying the results.
- `calculate-final-gpa.test.cs`: This is the test file. It contains a unit test that checks the GPA calculation and output.

## How to Run

To run the program, you need to have .NET 8.0 installed on your machine. Once you have that, you can run the program using the `dotnet run` command in the terminal.

## How to Test

To run the tests, use the `dotnet test` command in the terminal.

## Code Overview

The `Program.cs` file defines a `Program` class with a `Main` method. This method calculates the GPA based on hardcoded course grades and credit hours, and then prints the student's name, course grades, credit hours, and final GPA to the console.

The `calculate-final-gpa.test.cs` file defines a `Tests` class with a `TestGpaOutput` method. This method runs the `Main` method of the `Program` class, captures its console output, and checks if the expected GPA string is present in the output.

## Project Configuration

The project configuration is defined in the `calculate-final-gpa.csproj` file. The project is set up to produce an executable (.exe) file, targets the .NET 8.0 framework, and has implicit usings and nullable reference types enabled.