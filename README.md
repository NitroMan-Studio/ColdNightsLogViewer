**Cold Nights Log Viewer**

A lightweight, fast, and developer-friendly log viewer built with C# (.NET 9) and WPF.
Originally created for debugging the game Cold Nights, but works with any text-based log file.

🔥 Features

✔ Colorized log levels (Info / Warning / Error)
✔ Background highlighting for warnings & errors
✔ Filtering by log type using checkboxes
✔ Built-in search bar (live filtering)
✔ Clean, minimal UI inspired by early-2000s dev tools (Hammer Editor / Source SDK vibes)
✔ Open any log file from disk
✔ Fast loading even for large files

📥 Installation / Running
Option 1 — Download Release
👉 Download the latest release from the Releases tab.

Option 2 — Run from source

Requirements:
.NET 9 SDK or newer
Windows 10 or 11
Rider / Visual Studio / VS Code with WPF support

Clone the repository:
git clone https://github.com/NitroMan-Studio/ColdNightsLogViewer.git


Run the project:
dotnet run --project ColdNightsLogViewer

⚙️ Technologies Used

C# (.NET 9)
WPF (Windows Presentation Foundation)
Lightweight MVVM-like structure

🗺️ Roadmap / Planned Features

 Live auto-refresh (tailing log in real time)
 Icons for log levels (❌ ⚠️ ℹ️)
 Dark mode
 Export filtered logs to file
 Keyword highlighting (coloring search matches)
 Left-side color stripes (VSCode-style severity markers)


👤 Author

NitroMan
Indie game developer and creator of Cold Nights.
This tool was built for debugging purposes and is now shared as open-source.
