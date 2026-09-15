# C# Practice: CharacterMethods

This project is part of the **CSharpPractice** repository, practicing concepts from **Chapter 3: Strings**.

## Topic
**Accessing Strings**

## Exercise Requirements
Write a program CharacterMethods which enters a single character and determine if it’s the letter, digit, white space, uppercase, lowercase, both letter and number.

---

## How to Run

From the repository root directory, execute:
```bash
dotnet run --project CharacterMethods/CharacterMethods.csproj
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
