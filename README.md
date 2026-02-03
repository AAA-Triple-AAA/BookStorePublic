# Book Store Management System

![.NET Version](https://img.shields.io/badge/.NET-8.0-512bd4?style=for-the-badge&logo=dotnet)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![Language](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=csharp)
![SQL Server](https://img.shields.io/badge/SQL%20Server%20LocalDB-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-Windows-0078d7?style=for-the-badge&logo=windows)

A comprehensive desktop application designed to manage bookstore operations, including inventory tracking, sales processing, and personnel management. Developed as a final group project for COP 4226.

## 🚀 Features

* **User Authentication**: Secure entry point simulation via `frmLogin`.
* **Inventory Management**: Complete maintenance modules for authors, publishers, titles, and store locations.
* **Sales & Ordering**: Process customer orders with integrated discount logic.
* **Detailed Reporting**: Generate sales reports and order summary invoices.
* **Personnel Management**: Manage employee records and job roles.
* **Data Persistence**: SQL Server (LocalDB) integration using Entity Framework Core.

## 🏗️ Architecture

The project follows a layered architecture to maintain a clear separation of concerns:

* **BookStoreUI**: Presentation layer built with Windows Forms.
* **BookStoreBO (Business Objects)**: Logic layer containing business rules, DTOs, and validation.
* **BookStoreDO (Data Objects)**: Data access layer managing the EF Core context and models.

## 🛠️ Tech Stack

* **Language**: C#
* **Framework**: WinForms .NET 8.0
* **Database**: Microsoft SQL Server (LocalDB)
* **ORM**: Entity Framework Core

## 🏁 Getting Started

### Prerequisites
* Visual Studio 2022 or JetBrains Rider
* .NET 8.0 SDK

### Setup Instructions
1. **Clone the repository**:
   ```bash
   git clone [https://github.com/AAA-Triple-AAA/BookStore.git](https://github.com/AAA-Triple-AAA/BookStore.git)
   ```
2. Configure Database:
   - Move or copy BookStore.MDF from the `Resources/Database/` folder into `./BookStoreUI/bin/Debug/net8.0-windows.`
3. Run:
   - Open the solution and run the project. Use the optional `DatabaseConnectionTest` in `Program.cs` to verify connectivity if needed.
