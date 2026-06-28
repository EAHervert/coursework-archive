# MATH-3345 — Undergraduate Numerical Analysis

_C++ implementations of the numerical methods covered in MATH-3345 at UT Arlington, Fall 2016._

This repo collects the homework programs from a semester undergraduate course in numerical analysis.
The fourteen homework sets follow the course textbook in a natural format that tracks the textbook's progression directly: 
	mathematical preliminaries → root finding → interpolation → numerical integration → ordinary differential equations (initial-value problems). 

## Curriculum flow

A textual map of the fourteen homework sets and their textbook sections:

    HW 1   §1.1                 Function evaluation, max/min
    HW 2   §1.2, 1.3, 2.1       Error analysis; Bisection
    HW 3   §2.2, 2.3            Fixed-point iteration
    HW 4   §2.4, 2.5, 2.6       Newton, Secant, False Position, Müller
    HW 5   §3.1, 3.2            Lagrange / divided-difference interpolation
    HW 6   §3.3                 Hermite interpolation
    HW 7   §3.4, 4.1            Cubic splines; numerical differentiation
    HW 8   §4.2, 4.3            Trapezoid rule; Simpson's rule
    HW 9   §4.4, 4.5, 4.7       Composite / adaptive quadrature; Romberg
    HW 10  §4.8, 4.9            Double integrals; improper integrals
    HW 11  §5.1                 ODE theory; initial-value problems
    HW 12  §5.2, 5.3, 5.4, 5.5  Euler, Modified Euler, RK4, Runge-Kutta-Fehlberg
    HW 13  §5.6                 Adams-Bashforth / Adams-Moulton; Milne-Simpson
    HW 14  §5.9                 Higher-order ODEs and ODE systems via RK4


## Standard library headers used

| Header        | Used in                                                                                     |
|---------------|---------------------------------------------------------------------------------------------|
| `<iostream>`  | all programs                                                                                |
| `<iomanip>`   | most programs (formatted tabular output of iterates and errors)                             |
| `<cmath>`     | every method that evaluates `f(x)` symbolically (`exp`, `sin`, `cos`, `log`, `pow`, etc.)   |
| `<fstream>`   | HW 12–14 programs that write `h = ....txt` output files                                     |
| `<vector>`    | iterative methods that retain history (Adams-Bashforth / Adams-Moulton, RK systems)         |
| `<string>`    | output-filename construction in HW 12–14                                                    |

All files use `using namespace std;`.

## Notes

- All programs are console-based and self-contained:
  - The target function `f(x)` (and its derivative where needed) is hard-coded inside each `.cpp` file rather than read from input.
- HW 12–14 programs write iterate tables to `.txt` files in the working directory.
- The textbook is Burden, Faires & Burden, *Numerical Analysis*. 
- Programs that write `.txt` output files do so in the current working directory.

## File index

### Top-level

- `Math3345_Syllabus_16.pdf` — course syllabus.
- `README.md` — this file.

### Homework

| #  | Folder         | Sections             | Sources                                                                                                                                                  |
|----|----------------|----------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------|
| 1  | `Homework 1/`  | §1.1                 | `Function Evaluation.cpp`, `Function Max-Min.cpp`                                                                                                        |
| 2  | `Homework 2/`  | §1.2, 1.3, 2.1       | `Bisection Method.cpp`                                                                                                                                    |
| 3  | `Homework 3/`  | §2.2, 2.3            | `Fixed Point Iteration.cpp`                                                                                                                               |
| 4  | `Homework 4/`  | §2.4, 2.5, 2.6       | `Bisection Method.cpp`, `False Position.cpp`, `Newton Method.cpp`, `Secant Method.cpp`, `Muller's Method.cpp`                                             |
| 5  | `Homework 5/`  | §3.1, 3.2            | `Divided Difference.cpp`                                                                                                                                  |
| 6  | `Homework 6/`  | §3.3                 | *(writeup only — no `.cpp`)*                                                                                                                              |
| 7  | `Homework 7/`  | §3.4, 4.1            | *(writeup only — no `.cpp`)*                                                                                                                              |
| 8  | `Homework 8/`  | §4.2, 4.3            | `Trapezoid Rule.cpp`, `Simpson's Rule.cpp`                                                                                                                |
| 9  | `Homework 9/`  | §4.4, 4.5, 4.7       | `Roberg Integration.cpp` *(filename misspells "Romberg" — TODO: rename)*                                                                                  |
| 10 | `Homework 10/` | §4.8, 4.9            | `Double Integral.cpp`                                                                                                                                     |
| 11 | `Homework 11/` | §5.1                 | *(writeup only — no `.cpp`)*                                                                                                                              |
| 12 | `Homework 12/` | §5.2, 5.3, 5.4, 5.5  | `Euler Method/`, `Modified Euler Method/`, `Runge-Kutta 4/`, `Runge-Kutta-Fehlberg/` — each with one `.cpp` and one or more `h = ....txt` sample outputs  |
| 13 | `Homework 13/` | §5.6                 | `Adams-Bashforth Two/Three/Four/Five-Step/`, `Adams-Moulton Three-Step/`, `Milne-Simpson/` — each with one `.cpp` and an output `.txt`                    |
| 14 | `Homework 14/` | §5.9                 | `Runge-Kutta System/` (first-order system), `Runge-Kutta System Second Order ODE/` (second-order ODE) — each with one `.cpp` and an output `.txt`         |

Each homework folder contains the original assignment writeup as a `.docx` (TODO: add a `.md` transcription).

### Other (`Other/`)

`Other/Extra/` — exploration outside the assigned set:

| Source                      | Topic                                                            |
|-----------------------------|------------------------------------------------------------------|
| `2D linear Equations.cpp`   | Direct solver for a 2×2 linear system                            |
| `Adams-Bashforth.cpp`       | Alternative Adams-Bashforth driver (separate from HW 13)         |
| `Lagrange Method.cpp`       | Standalone Lagrange interpolation (separate from HW 5)           |
| `Extra Homework.docx`       | Writeup for the extra problems                                   |

`Other/Incomplete/` — assignment started but not finished:

| Folder          | Sections      | Status                                                                 |
|-----------------|---------------|------------------------------------------------------------------------|
| `Homework 15/`  | §5.10, 5.11   | Writeup only; never implemented. Topic: boundary-value problems.       |



## TODO

- Convert every homework `.docx` writeup to a `.md` file checked into the same folder.
- Rename `Homework 9/Roberg Integration.cpp` → `Homework 9/Romberg Integration.cpp`.
- Normalize the en-dash in `Homework 1/Homework 1 – 1.1.docx` to a regular hyphen.
- Resolve `Other/Incomplete/Homework 15/`.

---

*Original 2016 coursework, uploaded to GitHub. Edited June 2026.*
