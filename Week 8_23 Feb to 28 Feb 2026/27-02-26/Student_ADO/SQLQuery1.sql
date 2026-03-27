CREATE DATABASE UniversityDB;
GO

USE UniversityDB;
GO

-- Departments Table
CREATE TABLE Departments (
    DeptId INT PRIMARY KEY IDENTITY(1,1),
    DeptName NVARCHAR(100) NOT NULL
);

-- Courses Table
CREATE TABLE Courses (
    CourseId INT PRIMARY KEY IDENTITY(1,1),
    CourseName NVARCHAR(100) NOT NULL,
    DeptId INT,
    FOREIGN KEY (DeptId) REFERENCES Departments(DeptId)
);

-- Students Table
CREATE TABLE Students (
    StudentId INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    DeptId INT,
    FOREIGN KEY (DeptId) REFERENCES Departments(DeptId)
);

-- Enrollments Table
CREATE TABLE Enrollments (
    EnrollmentId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT,
    CourseId INT,
    Grade CHAR(2),
    FOREIGN KEY (StudentId) REFERENCES Students(StudentId),
    FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
);

-- Insert Departments
INSERT INTO Departments (DeptName)
VALUES 
('Computer Science'),
('Mathematics'),
('Physics');

-- Insert Courses
INSERT INTO Courses (CourseName, DeptId)
VALUES
('Data Structures', 1),
('Algorithms', 1),
('Linear Algebra', 2),
('Quantum Mechanics', 3);

-- Insert Students
INSERT INTO Students (FirstName, LastName, Email, DeptId)
VALUES
('Alice', 'Johnson', 'alice@uni.com', 1),
('Bob', 'Smith', 'bob@uni.com', 2),
('Charlie', 'Brown', 'charlie@uni.com', 3);

-- Insert Enrollments
INSERT INTO Enrollments (StudentId, CourseId, Grade)
VALUES
(1, 1, 'A'),
(1, 2, 'B'),
(2, 3, 'A'),
(3, 4, 'C');

CREATE PROCEDURE sp_InsertStudent
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Email NVARCHAR(100),
    @DeptId INT
AS
BEGIN
    INSERT INTO Students (FirstName, LastName, Email, DeptId)
    VALUES (@FirstName, @LastName, @Email, @DeptId);
END
GO

CREATE PROCEDURE sp_GetAllStudents
AS
BEGIN
    SELECT 
        s.StudentId,
        s.FirstName,
        s.LastName,
        s.Email,
        d.DeptName
    FROM Students s
    INNER JOIN Departments d
    ON s.DeptId = d.DeptId;
END
GO

CREATE PROCEDURE sp_GetStudentById
    @StudentId INT
AS
BEGIN
    SELECT *
    FROM Students
    WHERE StudentId = @StudentId;
END
GO

CREATE PROCEDURE sp_UpdateStudent
    @StudentId INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Email NVARCHAR(100),
    @DeptId INT
AS
BEGIN
    UPDATE Students
    SET 
        FirstName = @FirstName,
        LastName = @LastName,
        Email = @Email,
        DeptId = @DeptId
    WHERE StudentId = @StudentId;
END
GO

CREATE PROCEDURE sp_DeleteStudent
    @StudentId INT
AS
BEGIN
    DELETE FROM Students
    WHERE StudentId = @StudentId;
END
GO

EXEC sp_InsertStudent 'John', 'Doe', 'john@uni.com', 1;
EXEC sp_GetAllStudents;
EXEC sp_GetStudentById 1;
EXEC sp_UpdateStudent 1, 'John', 'Smith', 'johnsmith@uni.com', 2;
--FInal Check
Select * from Students;