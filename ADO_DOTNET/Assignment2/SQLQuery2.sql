CREATE DATABASE EmployeeDB;
GO

USE EmployeeDB;
GO

CREATE TABLE Employees (
    EmpId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Salary DECIMAL(10,2),
    Department NVARCHAR(50)
);
GO

CREATE PROCEDURE InsertEmployee
@Name NVARCHAR(100),
@Salary DECIMAL(10,2),
@Department NVARCHAR(50)
AS
BEGIN
    INSERT INTO Employees VALUES (@Name, @Salary, @Department)
END
GO

CREATE PROCEDURE UpdateSalary
@EmpId INT,
@Salary DECIMAL(10,2)
AS
BEGIN
    UPDATE Employees SET Salary=@Salary WHERE EmpId=@EmpId
END
GO