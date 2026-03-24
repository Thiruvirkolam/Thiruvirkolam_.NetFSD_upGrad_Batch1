CREATE DATABASE OrderDB;
GO

USE OrderDB;
GO

CREATE TABLE Orders (
    OrderId INT PRIMARY KEY IDENTITY,
    CustomerName NVARCHAR(100),
    TotalAmount DECIMAL(10,2)
);
GO

CREATE TABLE OrderItems (
    ItemId INT PRIMARY KEY IDENTITY,
    OrderId INT,
    ProductName NVARCHAR(100),
    Quantity INT
);
GO