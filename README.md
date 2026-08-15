# Logan Launcher

A customizable Windows desktop application launcher built with C# and Windows Forms.

## Features

* 🎮 Launch Windows applications with one click
* ➕ Add custom applications
* 📁 Browse for `.exe` files using Windows File Explorer
* 🖼️ Automatically retrieve application icons from executables
* 📐 Automatically center launcher buttons
* 💾 Save applications between launches
* 🗑️ Remove applications with a right-click
* 🎨 Custom background image
* 🚀 Lightweight Windows desktop application

## How It Works

Logan Launcher stores your configured applications in a local `launcherApps.json` file.

Each application contains:

* **Name** — The name displayed on the launcher button
* **Executable Path** — The location of the application's `.exe` file

When Logan Launcher starts, it reads the saved applications and automatically creates the launcher buttons.

## Adding an Application

1. Click the **+** button at the bottom of the launcher.
2. Enter the application name.
3. Click **Browse...**
4. Select the application's `.exe` file.
5. Click **Add Application**.

The application will appear on the launcher and will be saved automatically.

## Removing an Application

Right-click an application tile and confirm the removal.

Removing an application from Logan Launcher **does not uninstall the application**. It only removes the application from the launcher.

## Requirements

* Windows 10 or newer
* .NET 10
* Windows Forms

## Building From Source

Clone the repository:

```bash
git clone https://github.com/YOUR-USERNAME/LoganLauncher.git
```

Open the solution in **Visual Studio** and build the project.

The project can then be published as a Windows executable using Visual Studio's **Publish** feature.

## Project Structure

```text
LoganLauncher/
├── Form1.cs
├── Form1.Designer.cs
├── AddApplicationForm.cs
├── AddApplicationForm.Designer.cs
├── LauncherApp.cs
├── Program.cs
├── LoganLauncher.csproj
└── .gitignore
```

## Roadmap

Planned features include:

* [ ] Improved launcher tile design
* [ ] Rounded application tiles
* [ ] Better hover effects
* [ ] Custom application icons
* [ ] Drag-and-drop application adding
* [ ] Application editing
* [ ] Application categories
* [ ] Search
* [ ] Custom themes
* [ ] Startup with Windows
* [ ] Settings window
* [ ] Import/export launcher configurations

## License

This project is currently provided for personal and educational use.
