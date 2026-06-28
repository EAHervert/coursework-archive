# ITSE-1430 — Introduction to C# Programming

This is the C# code I wrote for **Introduction to C# Programming** at **Tarrant County College** in the Fall of 2016.

The files are organized into **6 projects** and **4 quizzes**, covering core C# topics from console programs and functional decomposition through GUI development, file I/O, XML, and ASP.NET web applications.

## Standard library namespaces used

| Namespace                    | Used in                                                          |
|------------------------------|------------------------------------------------------------------|
| `System`                     | all programs                                                     |
| `System.Collections.Generic` | MatrixTranspose (`List<List<double>>`)                           |
| `System.IO`                  | Darts (`StreamReader`, `FileStream`)                             |
| `System.Drawing`             | IrishFlag (`Graphics`, `Brush`, `SolidBrush`, `Color`)           |
| `System.Windows.Forms`       | IrishFlag, XMLStateAbb, GuessNummber                             |
| `System.Xml.Linq`            | XMLStateAbb (`XDocument`, `Descendants`)                         |
| `System.Web.UI` (`Page`)     | ASPWebShirts                                                     |

All console / Windows Forms programs declare a `namespace ITSE_1430`.

## Notes

- Most programs are console-based; input is read from `stdin` via `Console.ReadLine()` and output is written via `Console.Out.Write` / `Console.Out.WriteLine`.
- `IrishFlagEH`, `XMLStateAbbEH`, and `GuessNummberEH` are Windows Forms apps (interactive GUI).
- `ASPWebShirtsEH` is an ASP.NET Web Forms page (browser form with server-side handlers).
- Each project set and quiz folder includes a `*TestCases.txt` (or `*TestCases.docx`) file with sample inputs / expected outputs from the original submissions.

## File index

### Top-level

- `ITSE-1430-Syllabus.pdf` — course syllabus.
- `README.md` — this file.

### Projects

| # | Folder | Source | Topic | I/O |
|---|---|---|---|---|
| 1 | `Project Set 1 - ITSE 1430/EvilNosEH/` | `EvilNosEH.cs` | Decimal → binary conversion; detect "evil" numbers (even number of 1-bits) | stdin: positive int ≤ 1000 → stdout: binary form + "is / is not evil" |
| 1 | `Project Set 1 - ITSE 1430/EvilNosEH/` | `ExcelColsEH.cs` | Convert column number 1–1000000 to Excel-style letter column (base-26 with offset) | stdin: int 1–1000000 → stdout: letter column (e.g. 28 → AB) |
| 2 | `Project Set 2 - ITSE 1430/MatrixTransposeEH/` | `MatrixTransposeEH.cs` | Read an m×n matrix (≤ 5×5) into `List<List<double>>` and print its transpose | stdin: rows, cols, m·n values → stdout: matrix + transpose |
| 2 | `Project Set 2 - ITSE 1430/PingPongEH/` | `PingPongEH.cs` | Simulate a table-tennis match between two players given skill levels, using seeded `Random` | stdin: two skill levels 0–10 → stdout: per-player scores + overall winner |
| 3 | `Project Set 3 - ITSE 1430/IrishFlagEH/` | `IrishFlagEH.cs` (+ `.Designer.cs`, `.resx`) | Windows Forms app that paints the flag of Ireland using `Graphics.FillRectangle` with green / white / orange `SolidBrush` | GUI window → painted tricolour |
| 3 | `Project Set 3 - ITSE 1430/ShutTheBoxEH/` | `ShutTheBoxEH.cs` | Console version of the "Shut the Box" dice game over 12 boxes; rolls two dice until upper boxes are shut, then one die | interactive stdin / stdout, final roll count |
| 4 | `Project Set 4 - ITSE 1430/TestAnswerMachineEH/` | `TestAnswerMachineEH.cs` | Define `MissedCall` and `AnsweringMachine` classes; demo storing up to 5 missed calls ordered by `DateTime` | stdout: list of calls with name / number / timestamp |
| 4 | `Project Set 4 - ITSE 1430/TestShipsEH/` | `TestShipEH.cs` | `Ship` base class with `CruiseShip` and `CargoShip` derived classes; `virtual` / `override` `ToString` (extra credit) | stdout: formatted info for each ship |
| 5 | `Project Set 5 - ITSE 1430/DartsEH/` | `DartsEH.cs` (+ `Darts Files/darts.txt`, `darts2.txt`) | Read dart-throw coordinates from a text file; score each player by ring (radius bands 3 / 6 / 9 / 12 / 15) and declare winner | stdin: file path → stdout: scores + winner per game |
| 6 | `Project Set 6 - ITSE 1430/ASPWebShirtsEH/ASPWebShirtsEH/` | `ASPWebShirtsEH.aspx` + `.aspx.cs` | ASP.NET Web Forms T-shirt order form (TCC Southeast CS Club); collects customer info + shirt counts and computes totals with 7% tax | browser form → totals displayed on the same page |
| 6 | `Project Set 6 - ITSE 1430/XMLStateAbbEH/XMLStateAbbreviationEH/` | `XMLStateAbbEH.cs` (+ `.Designer.cs`, `.resx`, `USStates.xml`) | Windows Forms app that looks up a US-state name from a 2-letter abbreviation using `XDocument` / LINQ-to-XML queries | GUI: abbreviation → state name |

Each project set folder contains the original assignment spec as a `.pdf` (TODO: add a `.md` transcription).

### Quizzes

| # | Folder | Source | Topic | I/O |
|---|---|---|---|---|
| 1 | `Quiz 1 - ITSE 1430/RepeatDecimalsEH/` | `RepeatDecimalsEH.cs` | Compute the decimal expansion of `numerator / denominator` and detect repeating digits (extra credit) | stdin: numerator + denominator (loops until denominator is 0) → stdout: decimal expansion + repeat info |
| 2 | `Quiz 2 - ITSE 1430/PennyPinchEH/` | `PennyPitchEH.cs` | "Penny Pitch" game: toss up to 5 pennies onto a 5×5 board (1 / 2 / 3 point rings), accumulating score; press Enter between tosses | interactive console + final score |
| 3 | `Quiz 3 - ITSE 1430/GuessNummberEH/` | `GuessNummberEH.cs` (+ `.Designer.cs`, `.resx`) | Windows Forms guessing game with 5 radio buttons; mouse-hover on the label shows a hint; one correct button (extra credit) | GUI: pick button → "You Won" / "You Lost" |
| 4 | `Quiz 4 - ITSE 1430/` | _(no `.cs` solution — paper quiz; see `Quiz 4 - ITSE 1430.pdf` and `Quiz4F16EH.docx`)_ | — | — |

Each quiz folder contains the quiz prompt as a `.pdf` and the writeup as a `.docx` (TODO: add a `.md` transcription).

## TODO

- Convert every `.docx` / `.txt` test-case writeup and every per-project / quiz `.pdf` spec to a `.md` file.
- Rename project-set and quiz folders to drop the `- ITSE 1430` suffix.

---

*Original 2016 coursework, uploaded to GitHub in January 2020. Edited June 2026.*
