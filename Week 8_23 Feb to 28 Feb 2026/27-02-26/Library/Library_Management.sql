CREATE DATABASE LibraryDB;
GO
USE LibraryDB;
GO

-- Members Table
CREATE TABLE Members (
    MemberId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Email NVARCHAR(100)
);

-- Books Table
CREATE TABLE Books (
    BookId INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(150),
    Author NVARCHAR(100),
    Available BIT DEFAULT 1
);

-- Borrow Records Table
CREATE TABLE BorrowRecords (
    BorrowId INT PRIMARY KEY IDENTITY(1,1),
    MemberId INT FOREIGN KEY REFERENCES Members(MemberId),
    BookId INT FOREIGN KEY REFERENCES Books(BookId),
    BorrowDate DATE,
    ReturnDate DATE NULL
);

-- Members
INSERT INTO Members (Name, Email)
VALUES
('Aman Verma', 'aman@mail.com'),
('Riya Sharma', 'riya@mail.com');

-- Books
INSERT INTO Books (Title, Author)
VALUES
('C# Programming', 'Microsoft'),
('Database Systems', 'Navathe'),
('Operating Systems', 'Silberschatz');

GO
CREATE PROCEDURE GetAllBooks
AS
BEGIN
    SELECT * FROM Books;
END
GO

CREATE PROCEDURE InsertBook
    @Title NVARCHAR(150),
    @Author NVARCHAR(100)
AS
BEGIN
    INSERT INTO Books (Title, Author)
    VALUES (@Title, @Author);
END
GO

CREATE PROCEDURE UpdateBookAvailability
    @BookId INT,
    @Available BIT
AS
BEGIN
    UPDATE Books
    SET Available = @Available
    WHERE BookId = @BookId;
END
GO

USE LibraryDB;
GO

EXEC GetAllBooks;

EXEC InsertBook 
    @Title = 'Computer Networks', 
    @Author = 'Andrew Tanenbaum';
    EXEC GetAllBooks;

    EXEC UpdateBookAvailability 
    @BookId = 1, 
    @Available = 0;

    EXEC UpdateBookAvailability 
    @BookId = 1, 
    @Available = 1;

    SELECT * FROM Books;