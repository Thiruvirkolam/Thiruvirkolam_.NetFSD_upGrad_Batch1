CREATE DATABASE InventoryDB;
GO

USE InventoryDB;
GO

CREATE TABLE Products (
    ProductId INT PRIMARY KEY IDENTITY,
    ProductName NVARCHAR(100),
    Price DECIMAL(10,2),
    Stock INT
);
GO