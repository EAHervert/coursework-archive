# PHYS-2321 — Computational Physics

C++ code I wrote for **Computational Physics (PHYS 2321)** at **the University of Texas at Arlington, Fall 2015**.

The repository contains 10 numerical-methods assignments under `Assignments/` plus a `Derivations/` folder of math writeups. 
Each assignment ships with a `.cpp` solver, a `.docx` writeup, and the `.txt` / `.xlsx` data used for plots.

## Standard library headers used

| Header        | Used in                                                                                          |
|---------------|--------------------------------------------------------------------------------------------------|
| `<iostream>`  | all programs                                                                                     |
| `<cmath>`     | all programs (`pow`, `sqrt`, `exp`, etc.)                                                        |
| `<iomanip>`   | all except `Nuclear Decay.cpp`                                                                   |
| `<fstream>`   | all except `Displacement.cpp` and `Trapezoid Rule.cpp`                                           |
| `<stdio.h>`   | Final Exam, Orbits, RandomWalk, Random Number, Test 2 - Bike, ThePlanets                         |
| `<ctime>`     | RandomWalk (`time(NULL)` seed for `srand`)                                                       |
| `<cstdlib>`   | RandomWalk (`rand`, `srand`)                                                                     |

All files use `using namespace std;`.

## Notes

- All programs are console-based C++ and self-contained — a single `.cpp` per assignment, standard library only.
- Programs that write `.txt` output files do so in the current working directory.
- The `.xlsx` files hold the raw simulation data and the plots used in the writeups; the `.txt` files are the raw simulator dumps.
- Several programs include `<stdio.h>` alongside `<iostream>` — used for the C `rename()` call that renames each per-run output file (e.g., `Orbitfile.txt` → `Venus.txt`), **not** for `printf`-style I/O. All actual I/O goes through `<iostream>` / `<fstream>`.

## File index

### Top-level

- `README.md` — this file.

### Assignments

| Folder | Source | Topic | Output files |
|---|---|---|---|
| `Displacement/` | `Displacement.cpp` | 1-D kinematics — closed-form `x = x₀ + v₀t + ½at²` printed at each time step (`dt=.05`, t ∈ [0, 5]); no integration, just the equation evaluated in a loop | — (stdout only) |
| `Bike/` | `BicyclesHomework.cpp` | Bicycle velocity by Euler method — Problem 2.2 (baseline + `+55 W` power case + `-30%` frontal-area case, all under quadratic drag) and Problem 2.3 (linear + quadratic drag in air vs. water; smaller `dt` for water) | `2.2.txt`, `2.3.txt`, `2.3-2.txt` |
| `Trapezoid Rule/` | `Trapezoid Rule.cpp` | Composite trapezoidal rule for ∫₋₁¹ (4x³ + 3x + 1) dx with `dx = .005`; prints the integral to stdout | — (stdout only) |
| `Nuclear/` | `Nuclear Decay.cpp` | Radioactive decay ODE `dN/dt = -N/τ` by Euler (τ=1, N₀=100, `dt=.01`, t up to 5 s) | `Nuclear.txt` |
| `Oscillation/` | `Oscillation.cpp` | Small-angle pendulum (θ₀=3°, g=9.81, L=1) — Euler vs Euler–Cromer; tracks angle, angular velocity, and energy over 1000 `dt=.01` steps | `Euler.txt`, `Euler-Cromer.txt` |
| `The Planets/` | `ThePlanets.cpp` | Planetary orbits in AU/year units (μ = 4π²) via Euler–Cromer for Venus, Earth, Jupiter, and Saturn (Mars commented out); reports `T²/A³` for each | one `.txt` and one `.xlsx` per planet |
| `Orbit/` | `Orbits.cpp` | Parameterized orbit under `F ∝ 1/r^B` by Euler–Cromer; 6-run sweep — `dt ∈ {.1, .01, .001}` at `B=2`, and `B ∈ {1.5, 2.5, 3}` at `dt=.01` | 6 `dt = …, B = ….txt` files |
| `Random Walk/` | `RandomWalk.cpp` | 2-D random walk (independent ±step in x and y) averaged over 1, 10, 100, and 1000 runs of 1000 steps each; reports ⟨R²⟩ vs step number | 4 `1, 10000, N.txt` files |
| `Random Walk/Random/` | `Random Number.cpp` | Linear-congruential-generator (LCG) search — brute-force scans `(seed, A, C) ∈ [1, 19]³` with `M = 20` and writes the parameter sets whose first 4 lag-distinctness tests pass | `Random.txt` |
| `Test 2 - Bike/` | `Test 2 - Bike.cpp` | Test 2 — bike Euler integration with constant 50 N driving force and quadratic drag; 6-case sweep over initial velocity `{0, 25} m/s`, `dt ∈ {.001, .01, .1, .5}`, and air density `ρ ∈ {1.225, 1.425}`; terminal velocity reported ≈ 22.24 m/s | 6 `Initial Velocity = …, Time Interval = …, Density = ….txt` files |
| `Final Exam - Population Equations/` | `Final Exam - Population Equations.cpp` | Generalized-logistic ODE `dN/dt = aN − bN^p` by Euler (a single state variable, not coupled); 7-case sweep over `(a, b, p, N₀)` — A (pure growth), B (quadratic damping), C (`p=1.5`), D₁/D₂ (`p>2` vs `p<2`), E₁/E₂ (bacteria-scale `a=2, N₀=1`) | `Part A.txt`–`Part E, 2 of 2.txt` |

Each assignment folder contains the original assignment writeup as a `.docx` and (where applicable) the raw data and plots in an `.xlsx` (TODO: add a `.md` transcription).

### Derivations (`Derivations/`)

- `Energy Derivation.docx`
- `Gaussian Derivation.docx`
- `Homework 2 - Proof.docx`
- `Special Problem.docx`

## TODO

- Convert every assignment `.docx` writeup and every derivation `.docx` to a `.md` file.

---

*Original 2015 coursework, uploaded to GitHub in January 2020. Edited June 2026.*
