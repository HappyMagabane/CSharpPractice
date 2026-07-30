# C# Practice: StringMethods

This project is part of the **CSharpPractice** repository, practicing concepts from **Chapter 3: Strings**.

## Topic
**General Exercises**

## Exercise Requirements
Write a program called StringMethods that perform the following using their respective above-mentioned methods:
String.Empty

---

## How to Run

From the repository root directory, execute:
```bash
dotnet run --project StringMethods/StringMethods.csproj
```


---

## 📊 Control Flow Chart

```mermaid
graph TD
    Start([Start]) --> Input[Read string/character input from Console]
    Input --> Process[Apply string method / check characters]
    Process --> Output[Display manipulated string / verification output]
    Output --> End([End])
```

---

## 🧪 Test Cases Spec

| Test Case ID | Test Scenario | Inputs | Expected Output |
| :--- | :--- | :--- | :--- |
| TC01 | Standard text | "Test String" | Outputs manipulated string correctly |
| TC02 | Empty string | "" | Handles empty string input without crashing |
| TC03 | Special Characters | "!@#$" | String methods process special characters correctly |
