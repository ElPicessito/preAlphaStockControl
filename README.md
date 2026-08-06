# PreAlpha Stock Control

> A modern WPF inventory-management experiment for Windows.

PreAlpha Stock Control is a small C#/.NET desktop application used to explore what a cleaner, more consistent stock-control experience could become. It currently acts as a sandbox: a place to test interface ideas, navigation patterns, product views, dashboard concepts, and the overall feel of a future inventory tool before committing to a larger, production-ready architecture.

This repository is intentionally early-stage. It is not meant to be treated as a finished product yet, but as a working laboratory for design, workflow, and technical direction.

## Project Status

**Pre-alpha / sandbox**

The goal of this version is learning and iteration. Features may change quickly, UI decisions may be rewritten, and internal structure may evolve as the project becomes clearer.

Use this repository as:

- a visual and technical prototype;
- a playground for WPF layout and interaction ideas;
- a foundation for a possible future stable version;
- a reference point for what the final stock-control application could feel like.

## What It Explores

- Modern Windows desktop UI with WPF
- Inventory-oriented navigation and screens
- Dashboard, product, customer, report, and settings areas
- A lightweight application shell for future business workflows
- A cleaner user experience for stock and product management

## Tech Stack

- **C#**
- **WPF**
- **.NET 10**
- **Windows desktop**

## Getting Started

### Requirements

- Windows
- .NET 10 SDK
- Visual Studio 2026 or a compatible .NET IDE

### Run From The Command Line

```powershell
dotnet build .\preAlphaStockControl\preAlphaStockControl.csproj
dotnet run --project .\preAlphaStockControl\preAlphaStockControl.csproj
```

You can also open the solution file directly in Visual Studio:

```text
preAlphaStockControl.slnx
```

## Repository Layout

```text
.
|-- preAlphaStockControl.slnx
|-- README.md
|-- LICENSE
`-- preAlphaStockControl/
    |-- App.xaml
    |-- MainWindow.xaml
    |-- MainWindow.xaml.cs
    |-- StockControl_Icon.ico
    `-- preAlphaStockControl.csproj
```

## Future Direction

If the sandbox proves useful, the next step would be to shape it into a more consistent version with clearer application boundaries, real data persistence, stronger domain models, validation, testing, and a more complete stock-management workflow.

Potential future areas include:

- product and category management;
- stock movement history;
- customer and supplier records;
- reporting and analytics;
- authentication and roles;
- database-backed persistence;
- import/export tools;
- packaging and deployment.

## Important Note

This project is experimental. APIs, screens, names, and workflows can change without notice while the idea is still being shaped.

## License

This project is licensed under the terms included in the [LICENSE](LICENSE) file.
