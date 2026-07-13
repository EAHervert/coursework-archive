# MATH-6313 — Graduate Numerical Analysis

_MATLAB implementations for MATH-6313 at UT Dallas, Fall 2017._

This repo collects the homework sets from the graduate numerical-analysis
course at UT Dallas, covering floating-point arithmetic, root finding,
polynomial and spline interpolation, numerical differentiation, Gaussian
and adaptive quadrature, and Taylor-series + Runge-Kutta methods for ODE
problems.

This repo is a reconstruction from the fourteen homework PDFs, which are
checked in alongside the reconstructed code for reference.

## Curriculum flow

    HW 1                §2.1                    Machine epsilon
    HW 2                §2.1                    Marc-32 floating-point analysis
    HW 2.2              §2.2                    Loss of significance
    HW 3.1              §3.1                    Bisection method
    HW 3.2              §3.2                    Newton's method
    HW 3.4_6.1_6.2      §3.4, §6.1, §6.2        Fixed-point iteration
    HW 6.1_6.4          §6.1, §6.4              Chebyshev polynomials, splines
    HW 6.2              §6.2                    Newton divided-difference
    HW 6.4_6.8          §6.4, §6.8              Cubic spline, least-squares approx
    HW 6.12_6.13        §6.12, §6.13            Trigonometric interpolation + FFT
    HW 7.1              §7.1                    Numerical differentiation
    HW 7.2_7.3          §7.2, §7.3              Interp + Gaussian quadrature
    HW 7.3_7.5_8.1_8.2  §7.3, §7.5, §8.1, §8.2  Adaptive quadrature; ODE prelim
    HW 8.2_8.3          §8.2, §8.3              Taylor-series + RK4

## Notes

- Most numerical work is in MATLAB; **HW 1** was submitted in Java (`machineEpsilon.java`).
- Programs are self-contained functions; drivers hard-code problem parameters from the corresponding homework.
- Textbook: **Kincaid & Cheney**, *Numerical Analysis: Mathematics of Scientific Computing*, 3rd ed. 

## File index

### Top-level

- `docs/` — the original homework PDFs, preserved for reference.
- `README.md` — this file.

### Source (`src/`)

Programs are grouped by section, with a co-located `.md` writeup in each folder.

| # | Folder                        | K&C §                                | Sources                                                                             |
|---|-------------------------------|--------------------------------------|-------------------------------------------------------------------------------------|
| 1 | `sec1-floating-point/`        | §2.1, §2.2                           | `machineEpsilon.java`, `sqrtDiffNaive.m`, `sqrtDiffReliable.m`, `piecewiseEval.m`   |
| 2 | `sec2-root-finding/`          | §3.1, §3.2, §3.4                     | `bisection.m`, `newtonScalar.m`, `newtonSystem.m`                                   |
| 3 | `sec3-interpolation/`         | §6.1, §6.2, §6.4, §6.8, §6.12, §6.13 | `newtonInterp.m`, `cubicSpline.m`                                                   |
| 4 | `sec4-diff-and-quadrature/`   | §7.1, §7.2, §7.3, §7.5               | `richardson.m`, `adapSimp.m`                                                        |
| 5 | `sec5-ode-ivp/`               | §8.1, §8.2, §8.3                     | `taylorOrd5.m`, `rungeKutta4.m`                                                     |

Each `secN-<topic>/` also contains a `secN-<topic>.md` writeup (Markdown + LaTeX math via `$...$` and `$$...$$`) that transcribes the written derivations from that section's homework sets.

## TODO

- Recreate each program listed in the file index from its PDF source into the corresponding `src/secN-<topic>/` folder.
- Transcribe each section's written derivations (across all homework sets that touched that section) into the co-located `secN-<topic>.md`.

### Bugs to fix during recreation

Remove each item as it's corrected.

- **`richardson.m`** (Richardson extrapolation) — off-by-one exponent; original yielded only 7 accurate digits vs the expected 15.
- **`taylorOrd5.m`** — coefficient typo in the 5th-derivative term, effectively reducing the method's order from 5 to 4.
- **`adapSimp.m`** (Adaptive Simpson) — spurious stack push in the else branch; test integral returned 0.6578 instead of 2/3.
- **`newtonScalar.m`, `newtonSystem.m`** — logical-OR where AND was intended in the loop condition; both always ran to the max-iteration cap regardless of tolerance.
- **`sqrtDiffReliable.m`** — off-by-one loop bound silently skipped the last data point.

### Unfinished problems to note during transcription

Annotated *"Did not finish"* in the original writeups: 

- **HW 2.2 Problem 3** — loss-of-significance derivation
- **HW 3.2 Problem 15** — Newton convergence analysis
- **HW 7.3 Problem 7** — Gaussian-quadrature exactness
- **HW 8.2 Problem 6** — implicit relation `arctan(x/t) = ln √(x² + t²)`

---

*Reconstructed 2026 from original 2017-era coursework PDFs.*
