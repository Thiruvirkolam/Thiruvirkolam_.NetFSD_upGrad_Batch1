--DB Creation
create database Assignment_Edu_Domain

--DB Selection
use Assignment_Edu_Domain

--Assignment 1 – Create Tables (DDL) & Assignment 2 – Constraints
CREATE TABLE Departments(
DepartmentID INT PRIMARY KEY IDENTITY(1,1),
DepartmentName VARCHAR(100) UNIQUE NOT NULL,
Location VARCHAR(100)
)

CREATE TABLE Teachers(
TeacherID INT PRIMARY KEY IDENTITY(1,1),
TeacherName VARCHAR(100) NOT NULL,
Email VARCHAR(100) UNIQUE NOT NULL,
DepartmentID INT,
HireDate DATE,
FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
)

CREATE TABLE Students(
StudentID INT PRIMARY KEY IDENTITY(1,1),
FirstName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
DateOfBirth DATE,
Gender CHAR(1) CHECK (Gender IN ('M','F')),
DepartmentID INT,
AdmissionDate DATE,
FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
)

CREATE TABLE Courses(
CourseID INT PRIMARY KEY IDENTITY(1,1),
CourseName VARCHAR(100) NOT NULL,
Credits INT CHECK (Credits BETWEEN 1 AND 5),
DepartmentID INT,
TeacherID INT,
FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID),
FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID)
)

CREATE TABLE Enrollments(
EnrollmentID INT PRIMARY KEY IDENTITY(1,1),
StudentID INT,
CourseID INT,
EnrollmentDate DATE DEFAULT GETDATE(),
FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
)

CREATE TABLE Exams(
ExamID INT PRIMARY KEY IDENTITY(1,1),
CourseID INT,
ExamDate DATE,
ExamType VARCHAR(50),
FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
)

CREATE TABLE Marks(
MarkID INT PRIMARY KEY IDENTITY(1,1),
StudentID INT,
ExamID INT,
MarksObtained INT CHECK (MarksObtained BETWEEN 0 AND 100),
FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
)


--Assignment 3 - Aleter Tables
-- 1. Add PhoneNumber to Students
ALTER TABLE Students
ADD PhoneNumber VARCHAR(15);

-- 2. Add Salary to Teachers
ALTER TABLE Teachers
ADD Salary DECIMAL(10,2);

-- 3. Modify Salary datatype
ALTER TABLE Teachers
ALTER COLUMN Salary DECIMAL(12,2);

-- 4. Add CHECK constraint to Salary
ALTER TABLE Teachers
ADD CONSTRAINT CHK_Salary CHECK (Salary > 20000);

-- 5. Drop PhoneNumber column
ALTER TABLE Students
DROP COLUMN PhoneNumber;

-- 6. Rename a column
EXEC sp_rename 'Exams.ExamType', 'ExamCategory', 'COLUMN';


--Assignment 4 Insert Sample Data
INSERT INTO Departments (DepartmentName, Location) VALUES
('Computer Science','Block A'),
('Electrical & Electronics','Block B'),
('Mechanical','Block C'),
('Civil','Block D'),
('Information Technology','Block E')

INSERT INTO Teachers (TeacherName, Email, DepartmentID, HireDate, Salary) VALUES
('Arun Kumar','arun@college.com',1,'2018-06-10',45000),
('Ashwin Ravi','ashwin@college.com',2,'2019-07-15',42000),
('Rahul Saravanan','rahul@college.com',3,'2017-05-20',50000),
('Shreyas Iyer','shreyas@college.com',4,'2020-03-11',38000),
('Vikram Vinoth','vikram@college.com',5,'2016-01-25',55000),
('Kishore Srinath','kishore@college.com',1,'2021-02-10',35000),
('Rithick Mani','rithick@college.com',2,'2018-09-09',41000),
('Kowshik Krish','Kowshik@college.com',3,'2019-10-19',43000),
('Krishna India','krishna@college.com',4,'2020-12-01',36000),
('Naveen Kanna','naveen@college.com',5,'2017-08-14',47000)

INSERT INTO Students (FirstName, LastName, DateOfBirth, Gender, DepartmentID, AdmissionDate) VALUES
('Amit','Shah','2004-01-10','M',1,'2023-06-01'),
('Riya','Patel','2005-02-12','F',2,'2023-06-01'),
('Kunal','Joshi','2004-03-22','M',3,'2023-06-01'),
('Anjali','Nair','2005-04-18','F',4,'2023-06-01'),
('Rohit','Kumar','2004-05-11','M',5,'2023-06-01'),
('Sneha','Gupta','2005-06-09','F',1,'2023-06-01'),
('Vikas','Yadav','2004-07-07','M',2,'2023-06-01'),
('Pooja','Singh','2005-08-14','F',3,'2023-06-01'),
('Arjun','Reddy','2004-09-30','M',4,'2023-06-01'),
('Meena','Pillai','2005-10-05','F',5,'2023-06-01'),
('Deepak','Verma','2004-11-02','M',1,'2023-06-01'),
('Kavya','Menon','2005-12-12','F',2,'2023-06-01'),
('Manoj','Das','2004-01-17','M',3,'2023-06-01'),
('Divya','Iyer','2005-02-21','F',4,'2023-06-01'),
('Harish','Naidu','2004-03-28','M',5,'2023-06-01'),
('Nisha','Bose','2005-04-13','F',1,'2023-06-01'),
('Ajay','Mishra','2004-05-25','M',2,'2023-06-01'),
('Lakshmi','Rao','2005-06-19','F',3,'2023-06-01'),
('Tarun','Kapoor','2004-07-03','M',4,'2023-06-01'),
('Swathi','Krishnan','2005-08-29','F',5,'2023-06-01')

INSERT INTO Courses (CourseName, Credits, DepartmentID, TeacherID) VALUES
('Database Systems',4,1,1),
('Power Systems',3,2,2),
('Thermodynamics',4,3,3),
('Structural Analysis',3,4,4),
('Computer Networks',4,5,5),
('Data Structures',3,1,6),
('Electrical Machines',4,2,7),
('Fluid Mechanics',3,3,8),
('Surveying',2,4,9),
('Microprocessors',4,5,10)

INSERT INTO Enrollments (StudentID, CourseID) VALUES
(1,1),(2,2),(3,3),(4,4),(5,5),
(6,6),(7,7),(8,8),(9,9),(10,10),
(11,1),(12,2),(13,3),(14,4),(15,5),
(16,6),(17,7),(18,8),(19,9),(20,10),
(1,6),(2,7),(3,8),(4,9),(5,10),
(6,1),(7,2),(8,3),(9,4),(10,5)

INSERT INTO Exams (CourseID, ExamDate, ExamCategory) VALUES
(1,'2024-11-01','Midterm'),
(2,'2024-11-02','Midterm'),
(3,'2024-11-03','Midterm'),
(4,'2024-11-04','Final'),
(5,'2024-11-05','Final')

INSERT INTO Marks (StudentID, ExamID, MarksObtained) VALUES
(1,1,85),(2,2,78),(3,3,69),(4,4,88),(5,5,91),
(6,1,72),(7,2,66),(8,3,74),(9,4,81),(10,5,90),
(11,1,64),(12,2,77),(13,3,83),(14,4,59),(15,5,95),
(16,1,68),(17,2,73),(18,3,70),(19,4,86),(20,5,79),
(1,2,82),(2,3,75),(3,4,80),(4,5,87),(5,1,76),
(6,2,69),(7,3,71),(8,4,84),(9,5,88),(10,1,92)


--Assignment 5 Filtering Data
-- 1. Find students from Computer Science department
SELECT * FROM Students WHERE DepartmentID = (SELECT DepartmentID FROM Departments WHERE DepartmentName = 'Computer Science')

-- 2. Find teachers hired after 2022
SELECT * FROM Teachers WHERE HireDate > '2022-01-01'

-- 3. Find students whose name starts with 'A'
SELECT * FROM Students WHERE FirstName LIKE 'A%'

-- 4. Find courses having credits greater than 3
SELECT * FROM Courses WHERE Credits > 3

-- 5. Find students born between 2005 and 2008
SELECT * FROM Students WHERE DateOfBirth BETWEEN '2005-01-01' AND '2008-12-31'

-- 6. Find students not belonging to Mechanical department
SELECT * FROM Students WHERE DepartmentID <> (SELECT DepartmentID FROM Departments WHERE DepartmentName = 'Mechanical')

-- 7. Find teachers whose salary between 40000 and 70000
SELECT * FROM Teachers WHERE Salary BETWEEN 40000 AND 70000

-- 8. Find courses not taught by TeacherID = 3
SELECT * FROM Courses WHERE TeacherID <> 3


--Assignment 6 - Grouping Data 
-- 1.  Count students in each department
SELECT DepartmentID, COUNT(StudentID) AS TotalStudents FROM Students GROUP BY DepartmentID

-- 2. Find average marks per exam
SELECT ExamID, AVG(MarksObtained) AS AverageMarks FROM Marks GROUP BY ExamID

-- 3. Find total students enrolled per course
SELECT CourseID, COUNT(StudentID) AS TotalStudents FROM Enrollments GROUP BY CourseID

-- 4. Find maximum marks scored in each exam
SELECT ExamID, MAX(MarksObtained) AS MaxMarks FROM Marks GROUP BY ExamID

-- 5. Find minimum marks per course
SELECT e.CourseID, MIN(m.MarksObtained) AS MinMarks FROM Marks m JOIN Exams e ON m.ExamID = e.ExamID GROUP BY e.CourseID

-- 6. Find departments having more than 5 students
SELECT DepartmentID, COUNT(StudentID) AS TotalStudents FROM Students GROUP BY DepartmentID HAVING COUNT(StudentID) > 5


--Assignment 7 - Joins
-- 1
SELECT s.FirstName, s.LastName, d.DepartmentName
FROM Students s JOIN Departments d ON s.DepartmentID = d.DepartmentID

-- 2
SELECT c.CourseName, t.TeacherName
FROM Courses c JOIN Teachers t ON c.TeacherID = t.TeacherID

-- 3
SELECT s.FirstName, s.LastName, c.CourseName
FROM Students s JOIN Enrollments e ON s.StudentID = e.StudentID JOIN Courses c ON e.CourseID = c.CourseID

-- 4
SELECT s.FirstName, s.LastName, m.MarksObtained, e.ExamCategory
FROM Students s JOIN Marks m ON s.StudentID = m.StudentID JOIN Exams e ON m.ExamID = e.ExamID

-- 5
SELECT c.CourseName, t.TeacherName 
FROM Courses c LEFT JOIN Teachers t ON c.TeacherID = t.TeacherID

-- 6
SELECT t.TeacherName
FROM Teachers t LEFT JOIN Courses c ON t.TeacherID = c.TeacherID WHERE c.TeacherID IS NULL


--Assignment 8
-- 1  (Scalar Subquery)
SELECT * FROM Marks WHERE MarksObtained > (SELECT AVG(MarksObtained) FROM Marks)

-- 2  (= ALL)
SELECT * FROM Courses WHERE Credits >= ALL (SELECT Credits FROM Courses)

-- 3  (Correlated Subquery with EXISTS)
SELECT *
FROM Students s WHERE EXISTS (SELECT 1 FROM Enrollments e WHERE e.StudentID = s.StudentID  
GROUP BY e.StudentID HAVING COUNT(e.CourseID) > 2)

-- 4  (IN)
SELECT * FROM Teachers WHERE DepartmentID IN (SELECT DepartmentID FROM Teachers WHERE TeacherName = 'John')

-- 5  (= ANY)
SELECT *
FROM Marks WHERE MarksObtained = ANY (SELECT MAX(MarksObtained) FROM Marks GROUP BY ExamID)

-- 6  (= ALL)
SELECT *
FROM Departments WHERE DepartmentID = (SELECT TOP 1 DepartmentID FROM Students 
GROUP BY DepartmentID ORDER BY COUNT(StudentID) DESC)


--Assignment 10 - Indexes
-- 1
CREATE INDEX idx_students_lastname ON Students(LastName)

-- 2
CREATE INDEX idx_teachers_email ON Teachers(Email)

-- 3
CREATE INDEX idx_enrollments_student_course ON Enrollments(StudentID, CourseID)

-- 4
CREATE UNIQUE INDEX idx_departments_name ON Departments(DepartmentName)

-- 5
DROP INDEX idx_students_lastname ON Students