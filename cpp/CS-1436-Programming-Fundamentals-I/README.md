# CS-1436 — Programming Fundamentals I

C++ code I wrote for **Programming Fundamentals I (COSC 1436)** at **Tarrant County College, Spring 2015**.

The repository contains the 6 graded labs plus a `Programs/` folder of standalone exercises.

## Standard library headers used

| Header        | Used in                                                                                          |
|---------------|--------------------------------------------------------------------------------------------------|
| `<iostream>`  | all programs                                                                                     |
| `<iomanip>`   | Lab 1, Lab 4, Lab 6, Bank Charges, MembershipFeeIncrease, Rainfall Statistics                    |
| `<cmath>`     | Lab 1 (uses `pow`)                                                                                |
| `<fstream>`   | Lab 4, Lab 6                                                           |
| `<string>`    | Lab 5, Lab 6, Test                                                                                |
| `<cctype>`    | Lab 5, Lab 6 (`isupper`, `islower`, `isdigit`)                                                   |
| `<cstdlib>`   | Test (`system("pause")`)                                                                          |

All files use `using namespace std;`.

## Notes

- All programs are console-based; input is read from `stdin` via `std::cin`.
- Lab 4 and Lab 6 write text reports (`GradeBookEH.txt`, `SalesReport.txt`) into the current working directory — sample outputs from the original runs are committed alongside the source.

## File index

### Top-level

- `GradingRubric.docx` — instructor's grading rubric for the course.
- `README.md` — this file.

### Labs

| Lab | Folder                | Source              | Topic                                                                              | Output file        |
|-----|-----------------------|---------------------|------------------------------------------------------------------------------------|--------------------|
| 1   | `Lab1Dimple/`         | `DimplesEH.cpp`     | Golf-ball surface area and dimple count from user-supplied diameter                | —                  |
| 2   | `Lab2Coordinates/`    | `CoordinateEH.cpp`  | Cartesian quadrant / axis / origin classifier                                      | —                  |
| 3   | `Lab3Zodiac/`         | `ZodiacEH.cpp`      | Western zodiac sign from month/day       | —                  |
| 4   | `Lab4GradeBook/`      | `GradeBookEH.cpp`   | Gradebook (labs / quizzes / exams), drops lowest grade, writes a report     | `GradeBookEH.txt`  |
| 5   | `Lab5Passwords/`      | `passwordEH.cpp`    | Password validator (length + upper/lower/digit checks)                                 | —                  |
| 6   | `Lab6VendingMachine/` | `MachineEH.cpp`     | Vending machine simulator with a `struct` array; handles change and writes a sales report | `SalesReport.txt`  |

Each lab folder contains the original assignment spec as a `.docx` (TODO: add a `.md` transcription).

### Programs (`Programs/`)

| Source                      | Topic                                                                                                |
|-----------------------------|------------------------------------------------------------------------------------------------------|
| `Bank Charges.cpp`          | Monthly checking-account fee calculator                                                              |
| `MembershipFeeIncrease.cpp` | 6-year compound fee projection                                                                       |
| `Rainfall Statistics.cpp`   | 12-month rainfall input (incomplete)            |
| `Test.cpp`                  | `struct MovieData` demo using a pointer                     |

## TODO

- Convert every `.docx` (the per-lab spec and `GradingRubric.docx`) to a `.md` file checked into the same folder so visitors can read the original assignment alongside the code and verify what each program was asked to do.

---

*Original 2015 coursework, uploaded to GitHub in January 2020. Edited June 2026.*
