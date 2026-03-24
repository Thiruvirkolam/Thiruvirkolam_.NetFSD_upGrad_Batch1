create database StudentDB;

use StudentDB;

CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Age INT,
    Grade NVARCHAR(10)
);