# C# Practice: IfLeapYearProgram

This project is part of the **CSharpPractice** repository, practicing concepts from **Chapter 4: Selection Control Statement**.

## Topic
**General Exercises**

## Exercise Requirements
Write a program IfLeapYear that checks if a user-entered year is a leap year. If it is, display a message indicating it's a leap year; otherwise, display a message indicating it's not. Use IsLeapYear() method.

---

## How to Run

From the repository root directory, execute:
```bash
dotnet run --project IfLeapYearProgram/IfLeapYearProgram.csproj
```


---

## 📊 Control Flow Chart

```mermaid
graph TD
    Start([Start]) --> Input[Prompt and read user input]
    Input --> Parse[Parse input to appropriate data type]
    Parse --> Check{Check condition}
    Check -- Yes --> TrueBlock[Execute positive branch & display message]
    Check -- No --> FalseBlock[Execute negative branch & display message]
    TrueBlock --> End([End])
    FalseBlock --> End
```

---

## 🧪 Test Cases Spec

| Test Case ID | Test Scenario | Inputs | Expected Output |
| :--- | :--- | :--- | :--- |
| TC01 | Passing Threshold | Positive boundary value | Display success/eligible output |
| TC02 | Failing Boundary | Value below threshold | Display failure/minor/not eligible output |
| TC03 | Edge Input | Null or non-numeric | Handles input parsing exception gracefully |
