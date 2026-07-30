# C# Practice: AccessStringCharacters

This project is part of the **CSharpPractice** repository, practicing concepts from **Chapter 3: Strings**.

## Topic
**Accessing Strings**

## Exercise Requirements
Write a AccessStringCharacters program that asks the user to enter a word. Display the first and last letter of the word.
Character Methods

---

## How to Run

From the repository root directory, execute:
```bash
dotnet run --project AccessStringCharacters/AccessStringCharacters.csproj
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
