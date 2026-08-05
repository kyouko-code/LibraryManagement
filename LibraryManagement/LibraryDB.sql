/* =====================================================
   Library Management System - Database Script
   Run this script in SQL Server Management Studio (SSMS)
   to create the LibraryDB database.
   Login account used by the app: sa / 123456
   ===================================================== */

/*----Create Database LibraryDB----*/
/* Switch to master first, and disconnect any other sessions
   that are using LibraryDB, so the script can always re-run. */
USE master;
GO

IF DB_ID('LibraryDB') IS NOT NULL
BEGIN
    DECLARE @killSql NVARCHAR(MAX) = N'';
    SELECT @killSql = @killSql + 'KILL ' + CONVERT(VARCHAR(10), session_id) + ';'
    FROM sys.dm_exec_sessions
    WHERE database_id = DB_ID('LibraryDB');
    EXEC sp_executesql @killSql;

    ALTER DATABASE LibraryDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE LibraryDB;
END
GO

CREATE DATABASE LibraryDB;
GO
USE LibraryDB;
GO

/*----Table Users (for the login page)----*/
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(50) NOT NULL,
    FullName NVARCHAR(100)
);

/*----Table Book----*/
CREATE TABLE Book (
    BookID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(200) NOT NULL,
    Author NVARCHAR(100),
    Category NVARCHAR(100),
    ISBN NVARCHAR(50),
    Quantity INT NOT NULL DEFAULT 1
);

/*----Table Member (borrowers)----*/
CREATE TABLE Member (
    MemberID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10),
    Phone NVARCHAR(20),
    Email NVARCHAR(100)
);

/*----Table Borrow (who borrowed which book, when)----*/
CREATE TABLE Borrow (
    BorrowID INT PRIMARY KEY IDENTITY(1,1),
    BookID INT,
    MemberID INT,
    BorrowDate DATETIME DEFAULT GETDATE(),
    DueDate DATETIME,
    ReturnDate DATETIME NULL,
    FOREIGN KEY (BookID) REFERENCES Book(BookID),
    FOREIGN KEY (MemberID) REFERENCES Member(MemberID)
);

/*----Insert Users (username / password)----*/
INSERT INTO Users (Username, Password, FullName) VALUES
    ('admin', '123456', 'Administrator'),
    ('librarian', '123456', 'Head Librarian');

/*----Insert Book----*/
INSERT INTO Book (Title, Author, Category, ISBN, Quantity) VALUES
    ('The Great Gatsby', 'F. Scott Fitzgerald', 'Fiction', '9780743273565', 5),
    ('To Kill a Mockingbird', 'Harper Lee', 'Fiction', '9780061120084', 4),
    ('1984', 'George Orwell', 'Science Fiction', '9780451524935', 6),
    ('Pride and Prejudice', 'Jane Austen', 'Romance', '9780141439518', 3),
    ('The Catcher in the Rye', 'J.D. Salinger', 'Fiction', '9780316769488', 4),
    ('Animal Farm', 'George Orwell', 'Satire', '9780451526342', 5),
    ('Brave New World', 'Aldous Huxley', 'Science Fiction', '9780060850524', 3),
    ('The Hobbit', 'J.R.R. Tolkien', 'Fantasy', '9780547928227', 7),
    ('Crime and Punishment', 'Fyodor Dostoevsky', 'Classics', '9780486415871', 2),
    ('The Alchemist', 'Paulo Coelho', 'Adventure', '9780062315007', 6);

/*----Insert Member----*/
INSERT INTO Member (FullName, Gender, Phone, Email) VALUES
    ('Sokha Chan', 'Male', '012345678', 'sokha@email.com'),
    ('Dara Kim', 'Male', '098765432', 'dara@email.com'),
    ('Chan Mony', 'Female', '011223344', 'mony@email.com'),
    ('Srey Pov', 'Female', '099887766', 'sreypov@email.com'),
    ('Vibol Heng', 'Male', '010203040', 'vibol@email.com'),
    ('Sokly Nop', 'Female', '077665544', 'sokly@email.com'),
    ('Rithy Prak', 'Male', '066554433', 'rithy@email.com'),
    ('Bopha Sin', 'Female', '088776655', 'bopha@email.com'),
    ('Kosal Chea', 'Male', '055443322', 'kosal@email.com'),
    ('Sreymom Ouk', 'Female', '044332211', 'sreymom@email.com');

/*----Insert Borrow (some returned, some still borrowed)----*/
INSERT INTO Borrow (BookID, MemberID, BorrowDate, DueDate, ReturnDate) VALUES
    (1, 1, '2026-06-01', '2026-06-15', '2026-06-14'),
    (3, 2, '2026-06-05', '2026-06-19', '2026-06-18'),
    (8, 3, '2026-06-10', '2026-06-24', NULL),
    (2, 4, '2026-06-12', '2026-06-26', NULL),
    (5, 5, '2026-06-15', '2026-06-29', '2026-06-28'),
    (10, 6, '2026-07-01', '2026-07-15', NULL),
    (7, 7, '2026-07-03', '2026-07-17', NULL),
    (4, 8, '2026-07-05', '2026-07-19', '2026-07-18'),
    (6, 9, '2026-07-08', '2026-07-22', NULL),
    (9, 10, '2026-07-10', '2026-07-24', NULL);
