# C# Practice: SimpleCalculator

This project is part of the **CSharpPractice** repository, practicing concepts from **Chapter 2: Operators**.

## Topic
**Arithmetic Operators**

## Exercise Requirements
Write a program (SimpleCalculator) that performs arithmetic operations (addition, subtraction, multiplication, division, modulus, exponent) on two numeric variables which entered by prompting user.
Assignment Operators

---

## How to Run

From the repository root directory, execute:
```bash
dotnet run --project SimpleCalculator/SimpleCalculator.csproj
```


---

## 📊 Control Flow Chart

```mermaid
graph TD
    Start([Start]) --> Input[Prompt user for input values]
    Input --> Calc[Perform math/conversion calculation]
    Calc --> Display[Display formatted result to console]
    Display --> End([End])
```

---

## 🧪 Test Cases Spec

| Test Case ID | Test Scenario | Inputs | Expected Output |
| :--- | :--- | :--- | :--- |
| TC01 | Standard Operation | Valid numbers | Correct calculation output shown |
| TC02 | Boundary inputs | Zero / Negative values | Correctly handles calculation with zero/negative |
| TC03 | Non-numeric Input | "abc" | Throws parsing error / asks for retry |
