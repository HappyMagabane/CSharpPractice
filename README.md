# C# .NET Practice Exercises

[![.NET Build](https://github.com/HappyMagabane/CSharpPractice/actions/workflows/dotnet-build.yml/badge.svg)](https://github.com/HappyMagabane/CSharpPractice/actions/workflows/dotnet-build.yml)

Welcome to the **CSharpPractice** repository! This repository contains a structured collection of exercises and practice programs for mastering C# and .NET development, mapped chapter-by-chapter from foundational concepts to advanced concurrent programming.

## 🛠️ Getting Started

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- An IDE such as [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [VS Code](https://code.visualstudio.com/)

### Running a Project
To open and work with these exercises, open the main solution file `CSharpPractice.sln` in your preferred IDE, or use the .NET CLI:

```bash
# Clone the repository
git clone https://github.com/HappyMagabane/CSharpPractice.git

# Navigate into the folder
cd CSharpPractice

# Restore dependencies
dotnet restore

# Run a specific project (replace with project folder name)
dotnet run --project BasicVariables/BasicVariables.csproj
```

---

## 📚 Repository Map & Exercises Index

Below is the structured list of all practice topics and their corresponding projects in this repository:

### Chapter 1: Variables
- [**AdditionalWhileLoop**](./AdditionalWhileLoop) - General: Practice: AdditionalWhileLoop
- [**AgeCalculator**](./AgeCalculator) - General: Practice: AgeCalculator
- [**BMICalculator**](./BMICalculator) - General: Practice: BMICalculator
- [**BasicVariables**](./BasicVariables) - Variable Declaration, Initialization, Assignment and Display: Write a program (BasicVariables) that declares and initializes variables of appropriate data types and specified values.
- [**BooleanVote**](./BooleanVote) - Constants: Write a program (BooleanVote) that prompts the user to enter their age as an integer. Use a Boolean variable canVote to check if the user is eligible to vote (age >= 18). Display a message indicating whether the user can vote or not. NB: Use IF else statement
- [**ConstantVariables**](./ConstantVariables) - Constants: Write a program (ConstantVariables) that define constants for common mathematical values such as PI (π) = 3.1415926536 and the speed of light (C) = 299 792 458 m/s.
- [**ContinueStatementSequence**](./ContinueStatementSequence) - General: Practice: ContinueStatementSequence
- [**ContinueStatementSum**](./ContinueStatementSum) - General: Practice: ContinueStatementSum
- [**DoWhileLoopAverageCalculator**](./DoWhileLoopAverageCalculator) - General: Practice: DoWhileLoopAverageCalculator
- [**DoWhileLoopGuessNumber**](./DoWhileLoopGuessNumber) - General: Practice: DoWhileLoopGuessNumber
- [**DoWhileLoopRollDice**](./DoWhileLoopRollDice) - General: Practice: DoWhileLoopRollDice
- [**GradeCalculator**](./GradeCalculator) - General: Practice: GradeCalculator
- [**LoopsFactorial**](./LoopsFactorial) - General: Practice: LoopsFactorial
- [**MenuSelection**](./MenuSelection) - General: Practice: MenuSelection
- [**MultiplicationNestedForLoop**](./MultiplicationNestedForLoop) - General: Practice: MultiplicationNestedForLoop
- [**NullCoalescingOperator**](./NullCoalescingOperator) - General: Practice: NullCoalescingOperator
- [**NumericForLoops**](./NumericForLoops) - General: Practice: NumericForLoops
- [**NumericWhileLoop**](./NumericWhileLoop) - General: Practice: NumericWhileLoop
- [**PasswordStrengthChecker**](./PasswordStrengthChecker) - General: Practice: PasswordStrengthChecker
- [**SimpleBankingSystem**](./SimpleBankingSystem) - General: Practice: SimpleBankingSystem
- [**SimpleEncryptionProgram**](./SimpleEncryptionProgram) - General: Practice: SimpleEncryptionProgram
- [**StringConcatenationOperators**](./StringConcatenationOperators) - General: Practice: StringConcatenationOperators
- [**StringReversalProgram**](./StringReversalProgram) - General: Practice: StringReversalProgram
- [**TemperatureConverter**](./TemperatureConverter) - General: Practice: TemperatureConverter
- [**TextAnalysisTool**](./TextAnalysisTool) - General: Practice: TextAnalysisTool
- [**TicketPriceCalculator**](./TicketPriceCalculator) - General: Practice: TicketPriceCalculator
- [**WhileLoopPassword**](./WhileLoopPassword) - General: Practice: WhileLoopPassword
- [**dataTypesCasting**](./dataTypesCasting) - Data Types and Casting: Write a program (TypeAndCastCalculator) that performs arithmetic operations (addition +, division /) on two numeric (number1, number2) variables of type integer which entered by prompting user. Store the result of addition into sum variable and store the result of division into quotient variable.

### Chapter 2: Operators
- [**AssignmentCounter**](./AssignmentCounter) - Arithmetic Operators: Implement a AssignmentCounter program using the += operator to increment the counter on variable counter with each iteration. Before each increment, print the counter as shown above. NB: Using While Statement.
- [**CompareNumber**](./CompareNumber) - Comparison Operators: Write a program CompareNumber that compares two numbers (number1 and number2) entered by the user and displays whether the first number is greater, less than, or equal to the second number. Using If else statement
- [**ComparePassword**](./ComparePassword) - Comparison Operators: Implement a program ComparePassword that checks if a user-entered password userPassword matches a predefined constant PASSWORD initialized with myPass@2023 using the equality (=) operator. NB: Using If statement
- [**LogicInRange**](./LogicInRange) - Logical Operators: Write a program LogicInRange that checks if a number entered by the user is within a specified range (e.g., between 1 and 100) using logical operators (And, Or, Not). NB: Using If statement
- [**LogicPass**](./LogicPass) - Logical Operators: Implement a program LogicPass that checks if a student's mark is passing (greater than or equal to 60) and whether their attendance is satisfactory (at least 80% attendance) using logical operators. NB: Using If statement
- [**SimpleCalculator**](./SimpleCalculator) - Arithmetic Operators: Write a program (SimpleCalculator) that performs arithmetic operations (addition, subtraction, multiplication, division, modulus, exponent) on two numeric variables which entered by prompting user.
- [**TernaryMaximum**](./TernaryMaximum) - Logical Operators: Implement a program LogicPass that checks if a student's mark is passing (greater than or equal to 60) and whether their attendance is satisfactory (at least 80% attendance) using logical operators. NB: Using If statement

### Chapter 3: Strings
- [**AccessStringCharacters**](./AccessStringCharacters) - Accessing Strings: Write a AccessStringCharacters program that asks the user to enter a word. Display the first and last letter of the word.
- [**CharacterMethods**](./CharacterMethods) - Accessing Strings: Write a program CharacterMethods which enters a single character and determine if it’s the letter, digit, white space, uppercase, lowercase, both letter and number.
- [**FirstLettersDisplay**](./FirstLettersDisplay) - Typical Programs: Name Initials: Write a program that asks the user to enter a name (which contact first and middle). Display their initials based on the name entered.
- [**StringMethods**](./StringMethods) - General Exercises: Write a program called StringMethods that perform the following using their respective above-mentioned methods:

### Chapter 4: Selection Control Statement
- [**IfAdultProgram**](./IfAdultProgram) - General Exercises: Write a program IfAdult that asks the user to enter their age. If the age is greater than or equal to 18, display a message indicating they are an adult; otherwise, display a message indicating they are a minor.
- [**IfCredentials**](./IfCredentials) - General Exercises: Create a program IfCredentials that asks the user to enter their username and password. If both are correct, display a welcome message; otherwise, display an error message.
- [**IfLeapYearProgram**](./IfLeapYearProgram) - General Exercises: Write a program IfLeapYear that checks if a user-entered year is a leap year. If it is, display a message indicating it's a leap year; otherwise, display a message indicating it's not. Use IsLeapYear() method.
- [**IfPositiveNumber**](./IfPositiveNumber) - General Exercises: Implement a program ifPositiveNumber that checks if a user-entered number is positive, negative, or zero using If-Else statements.
- [**SelectionIfTriangle**](./SelectionIfTriangle) - Selection Control with Boolean Expressions: Write a SelectionIfTriangle program that asks the user to enter three numbers and checks if they form a valid triangle (the sum of any two sides is greater than the third side). Display the result using If-Else statements.
- [**SelectionWithdraw**](./SelectionWithdraw) - Selection Control with Boolean Expressions: Create a SelectionWithdraw program that simulates a simple ATM. Ask the user to enter their account balance and check if it's greater than zero. If it is, allow them to withdraw money; otherwise, display an error message.
- [**SwitchDayOfTheWeek**](./SwitchDayOfTheWeek) - Switch Statements: Implement a program SwitchDayOfTheWeek that asks the user to enter a day of the week (1 for Monday, 2 for Tuesday, etc.) and then displays the corresponding name of the day using a Switch statement.
- [**SwitchMonthProgram**](./SwitchMonthProgram) - Switch Statements: Write a program SwitchMonth that converts a user-entered month number (1 for January, 2 for February, etc.) into the corresponding month name using a Switch statement.
