# Library Management System

A desktop **Library Management System** built with **C# / WinForms** and **SQL Server** (ADO.NET), with RDLC report support. This was made as a beginner's database project.

## Features

- **Login page** with role-based users (`admin` and `librarian`)
- **Books management** – add, edit, delete, and search books (title, author, category, ISBN)
- **Members management** – add, edit, delete, and search members
- **Borrow / Return** – record book borrowings with borrow date, due date, and return date
- **Reports** – print reports for Books, Members, and Borrowings (RDLC + ReportViewer)

## Requirements

- **Windows 10 / 11**
- **Visual Studio** (2019 or newer)
- **.NET Framework 4.7.2** (comes with Windows 10/11)
- **SQL Server Express** (or any SQL Server) with instance name `.\SQLEXPRESS`

## How to Open the Project

1. Download / clone this repository.
2. Open **`LibraryManagement.sln`** with Visual Studio.
3. Wait for NuGet packages to restore (they are also included in the `packages/` folder).
4. Press **F5** to build and run.

## How to Set Up the Database

1. Open **SQL Server Management Studio (SSMS)**.
2. Connect to your server: `.\SQLEXPRESS`.
3. Open the script **`LibraryManagement\LibraryDB.sql`** (File -> Open -> File).
4. Press **F5** to run it. This creates the **`LibraryDB`** database and inserts sample data (2 users, 10 books, 10 members, 10 borrow records).
5. The script is safe to run again at any time – it deletes and recreates the database.

## Login Credentials

| Username  | Password |
|-----------|----------|
| `admin`   | `123456` |
| `librarian` | `123456` |

## How to Test the App

1. Run the project (F5) or double-click `LibraryManagement.exe`.
2. Log in with `admin` / `123456`.
3. Try the tabs:
   - **Books** – add / edit / delete / search books.
   - **Members** – add / edit / delete / search members.
   - **Borrowings** – borrow a book (choose book + member, dates) and return it.
   - **Reports** – open the Books, Members, and Borrowings reports.

## Connection String

The app connects to `.\SQLEXPRESS` using **Windows authentication**. The connection string is in:

`LibraryManagement\App.config`

```xml
<add name="LibraryDB"
    connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True"
    providerName="System.Data.SqlClient" />
```

If your SQL Server instance is different, change `.\SQLEXPRESS` to your instance name (for example `localhost` or `(localdb)\MSSQLLocalDB`).

## Project Structure

```
LibraryManagement/
├── LibraryManagement.sln          Visual Studio solution
├── LibraryManagement/
│   ├── LoginForm.cs               Login window
│   ├── MainForm.cs                Main window (books, members, borrowings, reports)
│   ├── DatabaseHelper.cs          SQL connection helper
│   ├── Program.cs                 App entry point
│   ├── LibraryDB.sql              Database setup script
│   ├── RptBooks.rdlc              Books report
│   ├── RptMembers.rdlc            Members report
│   └── RptBorrowings.rdlc         Borrowings report
└── packages/                      NuGet packages (ReportViewer, SqlServer.Types)
```

## Technologies

- C# / .NET Framework 4.7.2
- Windows Forms
- ADO.NET (`SqlConnection`, `SqlDataAdapter`)
- SQL Server
- RDLC reports with ReportViewer
