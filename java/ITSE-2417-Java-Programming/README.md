# ITSE-2417 — Java Programming

Java coursework from **Tarrant County College**, Fall 2016.
Covers Java fundamentals through OOP, file I/O, JavaFX GUIs, and a graph algorithm (BFS shortest path).

## Standard library packages used

| Package | Used in |
| --- | --- |
| `java.util.Scanner` | Most Project / Quiz programs (anything that reads stdin) |
| `java.lang.Math` | `RainbowHeightEH`, `HeptScoreEH`, `Triangle` |
| `java.util.Date` | `GeometricObject` (Project 3) |
| `java.io.File`, `java.io.IOException` | `JudoMatchesEH`, `WrestlingEH`, `OutputEDWordsEH`, `ShortPathEH` |
| `java.io.FileInputStream` / `FileOutputStream` / `ObjectInputStream` / `ObjectOutputStream` / `FileNotFoundException` | `BinTesterEH` (Quiz 3) |
| `java.util.LinkedList`, `java.util.Queue`, `java.util.Vector` | `ShortPathEH` (Project 6 BFS) |
| `javafx.*` (Application, Scene/Stage/Group, layout, geometry, paint, text, image, control, chart, shape, collections, event, animation) | `ShowText`, `GUIKittenPicEH`, `GUIPieChartEH`, `YoYoEH` |

## Notes
- Four JavaFX apps (`ShowText`, `GUIKittenPicEH`, `GUIPieChartEH`, `YoYoEH`) require a JavaFX runtime. 
- Five file-I/O programs (`JudoMatchesEH`, `WrestlingEH`, `OutputEDWordsEH`, `ShortPathEH`, `BinTesterEH`) read paths from stdin or write to a fixed file.
- Quiz 4 is a paper quiz; the folder contains only a `.pdf` and a `.docx`, no Java source.
- `Programs/GeometricObject.java` is a companion class for `Programs/TestGeometricObject.java`
	- the same class lives at `Projects/Project Set 3 - ITSE 2417/TestTriangleEH/GeometricObject.java` in the repo.

## File index

### Top-level
- `ITSE-2417-86001.pdf` — course syllabus (section 86001)

### Projects (`Projects/`)

| # | Folder | Source | Topic | I/O |
| --- | --- | --- | --- | --- |
| 1 | `Project Set 1 - ITSE 2417/RainbowHeightEH/` | `RainbowHeightEH.java` | Apparent rainbow height from observer height + distance (42.3° refraction angle) | stdin name / height / distance → stdout height |
| 1 | `Project Set 1 - ITSE 2417/SexyNumbersEH/` | `SexyNumbersEH.java` | Checks whether two ints in 1..3000 are *sexy primes* (differ by 6 and both prime) | stdin two ints → stdout verdict |
| 2 | `Project Set 2 - ITSE 2417/HeptScoreEH/` | `HeptScoreEH.java` | Heptathlon score from 7 event values (running vs. non-running formulas) | stdin 7 doubles → stdout total |
| 2 | `Project Set 2 - ITSE 2417/VowelsInWordsEH/` | `VowelsInWordsEH.java` | Checks whether a word contains A, E, I, O, U **in order** | stdin word → stdout verdict |
| 3 | `Project Set 3 - ITSE 2417/OOTestResistanceEH/` | `OOTestResistanceEH.java` + `Resistor.java` | Resistor color-band → resistance value + tolerance | stdin 4 colors → stdout ohms + tolerance |
| 3 | `Project Set 3 - ITSE 2417/TestTriangleEH/` | `TestTriangleEH.java` + `Triangle.java` + `GeometricObject.java` | `Triangle extends GeometricObject`; Heron's formula for area | stdin color / filled / 3 sides → stdout area + perimeter |
| 4 | `Project Set 4 - ITSE 2417/GUIKittenPicEH/` | `GUIKittenPicEH.java` | **JavaFX** — displays a kitten image in an `HBox` pane | hardcoded image path |
| 4 | `Project Set 4 - ITSE 2417/GUIPieChartEH/` | `GUIPieChartEH.java` | **JavaFX** — budget pie chart from 4 text fields (Housing / Food / Transportation / Other) | GUI input → pie chart |
| 5 | `Project Set 5 - ITSE 2417/JudoMatchesEH/Judo Games/` | `JudoMatchesEH.java` | Judo bracket reader — determines winner by Ippon / Waza-ari / Yuko | reads `judo.txt` / `judo2.txt` |
| 5 | `Project Set 5 - ITSE 2417/WrestlingEH/` | `WrestlingEH.java` | Wrestling bracket reader — assigns Classification Points (ST / SP / PO / PP) | reads `wrestle.txt` |
| 6 | `Project Set 6 - ITSE 2417/ShortPathEH/` | `ShortPathEH.java` | Reads an adjacency matrix from a file, runs BFS to find the shortest path between two vertices | file path + 2 vertices from stdin |
| 6 | `Project Set 6 - ITSE 2417/YoYoEH/` | `YoYoEH.java` | **JavaFX** — animated yo-yo (`Circle` + `Line`) bouncing between top and bottom of the pane | none — animation |

*Each project-set folder also contains the assignment PDF; most programs ship with `.txt` test cases.*

### Quizzes (`Quizes/`, single-z typo)

| # | Folder | Source | Topic | I/O |
| --- | --- | --- | --- | --- |
| 1 | `Quiz 1 - ITSE 2417/` | `PrimeFactNormFormEH.java` | Prime factorization in normal form, e.g. `(2^3)(5)(7^2)` | stdin int → stdout factorization |
| 2 | `Quiz 2 - ITSE 2417/` | `OutputEDWordsEH.java` | Reads words from a file, prints those ending in `ED` / `ed` (3 per row in 20-char columns) | file path from stdin |
| 3 | `Quiz 3 - ITSE 2417/BinTesterEH/` | `BinTesterEH.java` | Writes user-entered doubles to `data.bin`, then reads them back and prints count + average | binary file I/O |
| 4 | `Quiz 4 - ITSE 2417/` | *(paper quiz — no Java source)* | — | — |

*Each quiz folder contains the quiz handout PDF and the student's `.docx` response.*

### Programs (`Programs/`)
*Textbook / lecture demos and standalone exercises not tied to a project set.*

| File | Topic |
| --- | --- |
| `Account.java` | `Account` + `Customer` class pair — basic OOP composition (number / type / balance, no `main`) |
| `BottlesOfBeer.java` | Classic "99 bottles of beer" loop with a `switch` for the final cases |
| `Chapter11Test.java` | Inline `GeometricObject` / `Circle` / `rectangle` inheritance demo (textbook Chapter 11) |
| `GeometricObject.java` | Companion class for `TestGeometricObject.java` — same as the file at `Projects/…/TestTriangleEH/GeometricObject.java` (local-only; not yet committed) |
| `ShowText.java` | **JavaFX** — three `Text` nodes with `Font` / `FontWeight` / `FontPosture` / underline / strikethrough |
| `SqrtException.java` | Throws `ArithmeticException` for `Math.sqrt` of a negative number |
| `Test.java` | Tiny driver that exercises `Account` / `Customer` |
| `TestGeometricObject.java` | Driver for `GeometricObject` — sets color / filled, prints `toString()` |

## TODO
- Rename `Projects/Project Set 5 - ITSE 2417/WrestlingEH/WrestlingEHTestCase.txt` → `WrestlingEHTestCases.txt` to match the plural convention used by the other test-case files.
- Rename `Quiz2FL16EH.docx` and `Quiz3FL16EH.docx` → `Quiz2F16EH.docx` / `Quiz3F16EH.docx` (the `FL` looks like a typo of `F` used by Quiz 1 and Quiz 4).
- Convert `.docx` test-case and quiz files to Markdown: `GUIPieChartEHTestCases.docx`, `YoYoEHTestCases.docx`, `Quiz1F16EH.docx`, `Quiz2FL16EH.docx`, `Quiz3FL16EH.docx`, `Quiz4F16EH.docx`.
- Rename project-set and quiz folders to drop the `- ITSE 2417` suffix (e.g., `Project Set 1 - ITSE 2417/` → `Project Set 1/`, `Quiz 1 - ITSE 2417/` → `Quiz 1/`).
- Commit `Programs/GeometricObject.java` to the repo (after confirming it matches the `TestTriangleEH/` copy).
- Replace the hardcoded image path in `GUIKittenPicEH.java` with a relative path and add the sample image to the folder.
- `GUIKittenPicEH.java` has a hardcoded Windows path (`C:/Users/EsauH/Desktop/kitten.bmp`); it will not run as-is on macOS or Linux.

---
*Original 2016 coursework, uploaded to GitHub in January 2020. Edited June 2026.*
