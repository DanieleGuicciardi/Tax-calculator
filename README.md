# Tax Calculator (C#)

This is a simple **tax calculator** written in C# that determines the amount of taxes owed based on annual income.

## Features
- Calculates income tax using predefined tax brackets.
- Validates tax code before processing.
- Allows users to input their annual income.
- Displays a detailed tax summary including name, birth date, residence, and total tax owed.

## How It Works
1. The user enters their **tax code (Codice Fiscale)**.
2. **Only the tax code `MRORSI61LIKSNNNS` is accepted**; any other tax code will not work.
3. If the tax code matches, the user is prompted to enter their **annual income**.
4. The program calculates the **tax amount** based on income brackets.
5. A receipt is generated with all relevant details.

## Tax Brackets Used
| Income Range (€)   | Tax Rate  |
|--------------------|----------|
| 0 - 15,000        | 23%      |
| 15,001 - 28,000   | 27% on excess over 15K + €3,450 |
| 28,001 - 55,000   | 38% on excess over 28K + €6,960 |
| 55,001 - 75,000   | 41% on excess over 55K + €17,220 |
| Over 75,000       | 43% on excess over 75K + €25,420 |

