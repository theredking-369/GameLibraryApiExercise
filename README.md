# 🎮 MAUI Game Library
## 🎓 Student Learning Project

A cross-platform mobile application built with .NET MAUI for managing your personal game collection. This app allows you to catalog, organize, and manage information about your favorite games across different platforms.

> **📚 Educational Purpose**: This project was developed as a class exercise to learn .NET MAUI development, MVVM architecture patterns, cross-platform mobile development, and modern UI/UX design principles. It serves as a practical implementation of course concepts including data binding, validation, navigation, and platform-specific configurations.

## � Learning Objectives

This project demonstrates the following educational concepts and technologies:

### Core Learning Goals
- 🏗️ **MVVM Architecture**: Implementation of Model-View-ViewModel pattern
- 📱 **Cross-Platform Development**: Single codebase for multiple platforms
- 🔄 **Data Binding**: Two-way binding and property change notifications
- ✅ **Input Validation**: Real-time form validation using community toolkits
- 🎨 **UI/UX Design**: Material Design principles and responsive layouts
- 📷 **Media Integration**: Camera and photo library access
- 🗂️ **Data Management**: CRUD operations and data persistence concepts
- 🧩 **Dependency Injection**: Service registration and constructor injection
- 📐 **Software Architecture**: Clean code principles and separation of concerns

### Technical Skills Practiced
- **C# Programming**: Object-oriented programming in .NET ecosystem
- **XAML**: Declarative UI markup and styling
- **Platform-Specific Code**: Android themes and platform configurations
- **Package Management**: NuGet package integration and dependency management
- **Version Control**: Git workflow and repository management
- **Documentation**: Technical writing and project documentation

## �📱 Features

### Core Functionality
- ✅ **Complete Game Management**: Add, edit, and view game information
- ✅ **Image Support**: Add game cover images via media picker or URL
- ✅ **Real-time Validation**: Instant feedback on mandatory fields
- ✅ **Cross-Platform**: Runs on Android, iOS, Windows, and macOS
- ✅ **Modern UI**: Clean, responsive interface with Material Design elements

### Game Information Tracking
- 🏷️ **Game Title** (Required)
- 🎯 **Game Type**: Action, Adventure, RPG, Strategy, etc.
- 🏢 **Company Name** (Required)
- 🎨 **Genre**: Various game genres
- 🔞 **Age Restriction**: E, T, M, AO ratings
- 👥 **Multiplayer Support**: Yes/No toggle
- 📅 **Year Published**: Date picker
- 📝 **Description** (Required)
- 🖼️ **Cover Image** (Required)

## 🛠️ Technology Stack

### Framework & Platform
- **.NET 9.0** - Latest .NET framework
- **.NET MAUI** - Multi-platform App UI framework
- **C#** - Primary programming language

### Architecture & Patterns
- **MVVM (Model-View-ViewModel)** - Clean separation of concerns
- **Dependency Injection** - Built-in .NET DI container
- **Data Binding** - Two-way binding with validation
- **Command Pattern** - For user interactions

### Key Dependencies
```xml
<PackageReference Include="Microsoft.Maui.Controls" Version="9.0.90" />
<PackageReference Include="CommunityToolkit.Maui" Version="12.1.0" />
<PackageReference Include="Microsoft.Extensions.Logging.Debug" Version="9.0.0" />
```

### Validation & UI
- **MAUI Community Toolkit** - Advanced validation behaviors
- **CharactersValidationBehavior** - Real-time field validation
- **Material Design** - Modern Android theming
- **Responsive Grid Layouts** - Adaptive UI across screen sizes

## 🏗️ Project Structure

```
MauiGameLibrarySln/
├── MauiGameLibrary/
│   ├── Models/                    # Data models
│   │   ├── GameInformation.cs     # Main game entity
│   │   ├── GameType.cs           # Game type enumeration
│   │   ├── AgeRestriction.cs     # Age rating system
│   │   └── Genre.cs              # Game genre definitions
│   ├── ViewModels/               # MVVM ViewModels
│   │   ├── BaseViewModel.cs      # Base class with INotifyPropertyChanged
│   │   ├── ListOfGamesViewModel.cs # Games list management
│   │   └── UpdateGameViewModel.cs  # Game editing logic
│   ├── Views/                    # UI Pages
│   │   ├── BasePage.xaml         # Base page template
│   │   ├── ListOfGamesView.xaml  # Games collection display
│   │   └── UpdateGameView.xaml   # Game editing form
│   ├── Services/                 # Business logic
│   │   └── GameDataService.cs    # Data management service
│   ├── Converters/              # XAML value converters
│   │   └── StringToColorConverter.cs # Validation color feedback
│   ├── Platforms/               # Platform-specific code
│   │   ├── Android/             # Android configuration
│   │   ├── iOS/                 # iOS configuration
│   │   ├── Windows/             # Windows configuration
│   │   └── MacCatalyst/         # macOS configuration
│   └── Resources/               # App resources
│       ├── Images/              # Game cover images
│       ├── Fonts/               # Custom fonts
│       └── Styles/              # XAML styles
└── README.md                    # This documentation
```

## 🚀 Getting Started

### Prerequisites
- **Visual Studio 2022** (17.8 or later) with .NET MAUI workload
- **.NET 9.0 SDK** or later
- **Android SDK** (for Android development)
- **Xcode** (for iOS development on macOS)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/apead/MauiGameLibrarySln.git
   cd MauiGameLibrarySln
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Build the solution**
   ```bash
   dotnet build
   ```

4. **Run on specific platform**
   ```bash
   # Android
   dotnet build -t:Run -f net9.0-android
   
   # iOS (macOS only)
   dotnet build -t:Run -f net9.0-ios
   
   # Windows
   dotnet build -t:Run -f net9.0-windows10.0.19041.0
   ```

### Development Setup

1. **Open in Visual Studio 2022**
   - Open `MauiGameLibrarySln.sln`
   - Select your target platform (Android, iOS, Windows)
   - Set startup project to `MauiGameLibrary`

2. **Configure Android Emulator** (Optional)
   - Install Android emulator through Visual Studio
   - Create a virtual device with API level 21+



**📚 Built with ❤️ using .NET MAUI as a Student Learning Project**

*This repository serves as both a functional application and a demonstration of mobile development skills acquired through academic study. The code and documentation reflect learning objectives and best practices taught in modern software development courses.*
