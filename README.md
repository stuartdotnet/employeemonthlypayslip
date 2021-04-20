# employeemonthlypayslip

## Introduction

Small project I did for an coding challenge for a finance company

## Running the application

In a console window navigate to the EmployeeMonthlyPayslip\EmployeeMonthlyPayslip folder where the .csproj file is.

Enter the following command:

    dotnet build --configuration Release

Then run

    bin\Release\netcoreapp3.1\EmployeeMonthlyPayslip.exe

in the command line, then enter 

    GenerateMonthlyPayslip "<name>" <annualsalary>


## Assumptions:

* We're only working with whole dollars, so there won't be any incomes of for example $20,000.50 (as it's not clear which bracket this would fall into)
* Nobody will ever earn more than the decimal.MaxValue 79228162514264337593543950334. I could have used 0, but this seemed cleaner
* There may be other tax codes created in the future or used for other jurisdictions
* There will always be 12 months in a year :)
