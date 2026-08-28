![PreAlpha Stock Control banner](preAlphaStockControl/Assets/b1.png)

# PreAlpha Stock Control

> A pre-alpha WPF inventory-control desktop app for Windows.

PreAlpha Stock Control is an early C#/.NET desktop application for shaping a modern stock-management experience. The project currently focuses on the application shell, navigation, theme behavior, and the first set of inventory-oriented screens that will later grow into a complete workflow.

This repository is still experimental. It is useful as a design and technical sandbox, not as a production-ready inventory system yet.

## Current Status

**Pre-alpha / active prototype**

The app currently includes:

- a WPF desktop shell using the Fluent resource dictionary;
- sidebar navigation with search-box styling;
- light, dark, and system theme selection;
- placeholder pages for Dashboard, Products, Documents, Suppliers, Requesters, Reports, and Settings;
- DPI-change diagnostics in the main window;
- project references prepared for future EF Core and PostgreSQL-backed data access.

## Tech Stack

- **C#**
- **WPF**
- **.NET 10** targeting `net10.0-windows`
- **Fluent WPF resources** from `PresentationFramework.Fluent`
- **Entity Framework Core**
- **Npgsql / PostgreSQL provider**

## Getting Started

### Requirements

- Windows
- .NET 10 SDK
- Visual Studio 2026, JetBrains Rider, or another IDE that supports modern .NET WPF projects

### Build

```powershell
dotnet build .\preAlphaStockControl\preAlphaStockControl.csproj
```

### Run

```powershell
dotnet run --project .\preAlphaStockControl\preAlphaStockControl.csproj
```

You can also open the solution directly:

```text
preAlphaStockControl.slnx
```

## Repository Layout

```text
.
|-- LICENSE
|-- README.md
|-- preAlphaStockControl.slnx
`-- preAlphaStockControl/
    |-- App.xaml
    |-- App.xaml.cs
    |-- AssemblyInfo.cs
    |-- MainWindow.xaml
    |-- MainWindow.xaml.cs
    |-- preAlphaStockControl.csproj
    |-- Assets/
    |   |-- StockControl_Icon.ico
    |   `-- b1.png
    `-- Views/
        |-- DashboardPage.xaml
        |-- DashboardPage.xaml.cs
        |-- DocumentsPage.xaml
        |-- DocumentsPage.xaml.cs
        |-- ProductsPage.xaml
        |-- ProductsPage.xaml.cs
        |-- RequestersPage.xaml
        |-- RequestersPage.xaml.cs
        |-- ReportsPage.xaml
        |-- ReportsPage.xaml.cs
        |-- SettingsPage.xaml
        |-- SettingsPage.xaml.cs
        |-- SuppliersPage.xaml
        `-- SuppliersPage.xaml.cs
```

The project file also reserves folders for future `Models`, `Data`, `Services`, and `ViewModels` layers as the application moves beyond placeholder screens.

## Planned Direction

Possible next areas of work include:

- product and category management;
- document and stock movement workflows;
- supplier and requester records;
- reporting and analytics;
- validation and error handling;
- database-backed persistence;
- import/export tools;
- packaging and deployment.

## Important Note

This is an experimental pre-alpha project. Screens, workflows, architecture, and dependencies may change as the application direction becomes clearer.

## License

This project is licensed under the terms included in the [LICENSE](LICENSE) file.
