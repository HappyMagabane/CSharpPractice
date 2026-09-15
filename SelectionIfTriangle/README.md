# C# Practice: SelectionIfTriangle

This project is part of the **CSharpPractice** repository, practicing concepts from **Chapter 4: Selection Control Statement**.

## Topic
**Selection Control with Boolean Expressions**

## Exercise Requirements
Write a SelectionIfTriangle program that asks the user to enter three numbers and checks if they form a valid triangle (the sum of any two sides is greater than the third side). Display the result using If-Else statements.

---

## How to Run

From the repository root directory, execute:
```bash
dotnet run --project SelectionIfTriangle/SelectionIfTriangle.csproj
```


---

## 📊 Control Flow Chart

```mermaid
graph TD
    Start([Start]) --> Input[Prompt and read user input]
    Input --> Match{Match input using If-Else or Switch}
    Match -- Case A --> ActionA[Execute Case A & Print Output]
    Match -- Case B --> ActionB[Execute Case B & Print Output]
    Match -- Default --> ActionDef[Execute Default/Error Case]
    ActionA --> End([End])
    ActionB --> End
    ActionDef --> End
```

---

## 🧪 Test Cases Spec

| Test Case ID | Test Scenario | Inputs | Expected Output |
| :--- | :--- | :--- | :--- |
| TC01 | Valid Option A | Select option A | Executes option A branch logic |
| TC02 | Valid Option B | Select option B | Executes option B branch logic |
| TC03 | Invalid Option | Out of bounds option | Displays error message or warning |
