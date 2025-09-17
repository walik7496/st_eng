# Word Trainer (C# WinForms)

A simple program to practice translating words from English to Russian.  
The program displays an English word and offers 4 options in Russian, one of which is correct.

---

## Features

- Displays a word from `e.txt`.
- Buttons show translations from `r.txt`: 1 correct + 3 random options.
- Counters for correct and wrong answers update automatically.
- Words can be learned in small batches (e.g., 10–20) from a large database (~8000 words).
- When all words are finished, the program notifies that the list is complete.

---

## Requirements

- Windows
- .NET Framework or .NET 6 (WinForms)
- Visual Studio (recommended for editing and running)

---

## How to Run

1. Download or clone the project.
2. Make sure the following files are in the same folder as the executable:
   - `e.txt` — English words (one per line)
   - `r.txt` — Russian translations (one per line, in the same order)
3. Open the project in Visual Studio.
4. Build and run the project (Debug or Release).

---

## Word Files

- `e.txt` — list of English words.  
- `r.txt` — corresponding Russian translations. Each line should match the line in `e.txt`.

> Recommended to practice in small batches (10–20 words) to make learning easier.

---

## Usage

1. The program shows the first English word.
2. Choose one of the 4 Russian options on the buttons.
3. Correct and wrong answer counters update automatically.
4. The next word is loaded after each choice.
5. When all words are done, the program displays “All words are finished!”.
