# CS-1437 — Programming Fundamentals II

C++ code I wrote for **Programming Fundamentals II (COSC 1437)** at **Tarrant County College, Fall 2016**.

The repository contains 6 graded project sets, 4 quizzes, and a `Programs/` folder of Chapter 7 exercises.

## Standard library headers used

| Header                     | Used in                                                                            |
|----------------------------|------------------------------------------------------------------------------------|
| `<iostream>`               | all programs                                                                       |
| `<string>`                 | RPSLS, Bowling, TestMusicComp, LinkedPigLatin, IndexOfCoincidence, TestFriendship  |
| `<vector>`                 | TestPoly, EenyMeeny, JumpIt, Chapter 7 pt.4                                        |
| `<algorithm>`              | EenyMeeny (`rotate`), IndexOfCoincidence (`remove_if`)                             |
| `<cmath>` / `<math.h>`     | CarbonDating (`log`), Poker (`pow`), PrintGrayCode (`pow`)                         |
| `<cstdlib>` / `<stdlib.h>` | RPSLS (`rand`), TestPopulation (`exit`, `EXIT_FAILURE`)                            |
| `<cstdio>` / `<stdio.h>`   | RPSLS                                                                              |
| `<ctime>` / `<time.h>`     | RPSLS (`srand(time(NULL))`)                                                        |
| `<iomanip>`                | TestPoly, TestPopulation, IndexOfCoincidence                                       |
| `<cctype>`                 | IndexOfCoincidence (`tolower`, `isspace`)                                          |

All files use `using namespace std;`.

## Notes

- All programs are console-based; input is read from `stdin` via `std::cin`.
- Each project set and quiz folder includes a `*TestCases.txt` file with sample inputs from the original submissions.

## File index

### Top-level

- `Projects/Grading Rubric.pdf` — instructor's grading rubric.
- `Syllabus COSC1437.pdf` — course syllabus.
- `README.md` — this file.

### Project Sets

| # | Folder                                                 | Source                 | Topic                                                                       |
|---|--------------------------------------------------------|------------------------|-----------------------------------------------------------------------------|
| 1 | `Project Set 1 - COSC 1437/`                  | `CarbonDatingEH.cpp`   | Carbon-14 dating estimator (half-life formula)                              |
| 1 | `Project Set 1 - COSC 1437/`                  | `RPSLSEH.cpp`          | Rock-Paper-Scissors-Lizard-Spock vs. random (best 2 of 3)                |
| 2 | `Project Set 2 - COSC 1437/`                  | `BowlingEH.cpp`        | Bowling score calculator from a frame-encoded string (`X`, `/`, digits)     |
| 3 | `Project Set 3 - COSC 1437/`                  | `PokerEH.cpp`          | Two-player poker hand evaluator (all 9 hand ranks, winner declared)         |
| 4 | `Project Set 4 - COSC 1437/TestPopulationEH/` | `TestPopulationEH.cpp` | `Population` class with birth/death-rate methods         |
| 4 | `Project Set 4 - COSC 1437/TestPolyEH/`       | `TestPolyEH.cpp`       | `Polynomial` class with overloaded add, subtract, and product               |
| 5 | `Project Set 5 - COSC 1437/TestABCEH/`        | `TestABCEH.cpp`        | Abstract `BasicShape` → `Circle`, `Rectangle` (pure virtual `calcArea`)     |
| 5 | `Project Set 5 - COSC 1437/TestMusicCompEH/`  | `TestMusicCompEH.cpp`  | `MusicalComposition` → `NationalAnthem` (method overriding)                 |
| 6 | `Project Set 6 - COSC 1437/EenyMeenyEH/`      | `EenyMeenyEH.cpp`      | Josephus-style elimination using `std::vector` + `std::rotate`              |
| 6 | `Project Set 6 - COSC 1437/LinkedPigLatinEH/` | `LinkedPigLatinEH.cpp` | Pig Latin translator over a hand-built singly-linked list of `char` nodes   |

Each project set folder contains the original assignment spec as a `.pdf` (TODO: add a `.md` transcription).

### Quizzes

| # | Folder                       | Source                     | Topic                                                            |
|---|------------------------------|----------------------------|------------------------------------------------------------------|
| 1 | `Quiz 1 - COSC 1437/`   | `PrintGrayCodeEH.cpp`      | Gray code generator (extra credit; sizes 0–3)                    |
| 2 | `Quiz 2 - COSC 1437/`   | `IndexOfCoincidenceEH.cpp` | Index-of-Coincidence statistic on two strings                    |
| 3 | `Quiz 3 - COSC 1437/`   | `TestFriendship.cpp`       | `friend` functions across two classes via forward declaration    |
| 4 | `Quiz 4 - COSC 1437/`   | `JumpItEH.cpp`             | "Jump It" shortest-path with greedy 3-cell lookahead             |

Each quiz folder contains the quiz spec as a `.pdf` and the writeup as a `.docx` (TODO: add `.md` transcriptions).

### Programs (`Programs/`)

Standalone Chapter 7 textbook exercises — a progression through array dimensionality and into `std::vector`.

| Source                | Topic                                                                                       |
|-----------------------|---------------------------------------------------------------------------------------------|
| `Chapter 7 pt.1.cpp`  | 1D array of 10 `int`s; range-based `for`; computes sum, average, min, max; passes array to a function |
| `Chapter 7 pt 2.cpp`  | 2D `int[ ][2]` matrix with separate fill and display functions                              |
| `Chapter 7 pt.3.cpp`  | 3D `int[2][2][2]` array with triple-nested loops for input and output                       |
| `Chapter 7 pt.4.cpp`  | User-sized `std::vector<int>` demonstrating dynamic sizing and `.size()`                    |

## TODO

- Convert every quiz `.docx` writeup and every per-project-set `.pdf` spec to a `.md` file.
- Drop the double extension on `Quiz/Quiz 1 - COSC 1437/Quiz1FL16EH.doc.docx` → `Quiz1FL16EH.docx`.
- Normalize project-set spec filenames.
- Rename project-set and quiz folders to drop the `- COSC 1437` suffix (e.g., `Project Set 1 - COSC 1437/` → `Project Set 1/`).

---

*Original 2016 coursework, uploaded to GitHub in January 2020. Edited June 2026.*
