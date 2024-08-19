
# OrangeHRMliveAutomationUsingPlaywright

## Description

This repository contains automated test scripts for the OrangeHRM live demo application. Using Playwright and NUnit, these tests cover login functionality, user management, employee addition, and leave module operations.

## Features

- Automated login and user management tests
- Employee addition and leave module tests
- Integration with ExtentReports for detailed test reports and screenshots
- Video recording of test sessions

## Requirements

- .NET Framework
- Playwright
- NUnit
- ExtentReports
- Browser (ChromeDriver or equivalent)

## Installation

1. Clone the repository from GitHub.
2. Open the project in Visual Studio.
3. Restore the NuGet packages.
4. Ensure you have the necessary Playwright browsers installed.

## Usage

1. Open the project in Visual Studio.
2. Build the solution.
3. Run the tests using the Test Explorer in Visual Studio.

## ExtentReports Integration

The `ExtentReport` class is used for logging and reporting test results:

- **LogReport(string testcase)**: Initializes the ExtentReports instance and sets up the HTML reporter.
- **TakeScreenshot(IPage Page, Status status, string stepDetail)**: Captures screenshots of the test execution and logs them with the test report.

Make sure the following paths are correctly set in your project:

- `dirpath` for test execution reports
- `path` for screenshots

## Contributing

If you would like to contribute, please fork the repository, make your changes, and submit a pull request.

