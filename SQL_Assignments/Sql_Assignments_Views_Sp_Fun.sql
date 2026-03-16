--1. Views Assignment
-- ASSIGNMENT 1
CREATE VIEW vw_StudentDepartment AS
SELECT s.StudentID,
s.FirstName + ' ' + s.LastName AS StudentName,
d.DepartmentName,
s.AdmissionDate
FROM Students s
JOIN Departments d
ON s.DepartmentID = d.DepartmentID
GO

SELECT * 
FROM vw_StudentDepartment

SELECT *
FROM vw_StudentDepartment
WHERE DepartmentName = 'Computer Science'

DROP VIEW vw_StudentDepartment
GO


-- ASSIGNMENT 2
CREATE VIEW vw_StudentCourses AS
SELECT s.StudentID,
s.FirstName + ' ' + s.LastName AS StudentName,
c.CourseName,
e.EnrollmentDate
FROM Students s
JOIN Enrollments e
ON s.StudentID = e.StudentID
JOIN Courses c
ON e.CourseID = c.CourseID
GO

SELECT *
FROM vw_StudentCourses
WHERE StudentID = 5

SELECT StudentName, COUNT(CourseName) AS TotalCourses
FROM vw_StudentCourses
GROUP BY StudentName

SELECT *
FROM vw_StudentCourses
WHERE EnrollmentDate > '2024-01-01'
GO


-- ASSIGNMENT 3 - Exam Result View
CREATE VIEW vw_ExamResults AS
SELECT s.FirstName + ' ' + s.LastName AS StudentName,
c.CourseName,
e.ExamCategory AS ExamType,
m.MarksObtained
FROM Students s
JOIN Marks m
ON s.StudentID = m.StudentID
JOIN Exams e
ON m.ExamID = e.ExamID
JOIN Courses c
ON e.CourseID = c.CourseID
GO

-- 1
SELECT *
FROM vw_ExamResults
WHERE MarksObtained > 80

-- 2
SELECT *
FROM vw_ExamResults v
WHERE MarksObtained = (
SELECT MAX(MarksObtained)
FROM vw_ExamResults
WHERE ExamType = v.ExamType
)

-- 3
SELECT *
FROM vw_ExamResults
WHERE MarksObtained < 40
GO


-- ASSIGNMENT 4 - Aggregate View
CREATE VIEW vw_DepartmentStudentCount AS
SELECT d.DepartmentName,
COUNT(s.StudentID) AS TotalStudents
FROM Departments d
JOIN Students s
ON d.DepartmentID = s.DepartmentID
GROUP BY d.DepartmentName
GO

-- 1
SELECT *
FROM vw_DepartmentStudentCount
WHERE TotalStudents > 10

-- 2
SELECT *
FROM vw_DepartmentStudentCount
ORDER BY TotalStudents DESC
GO

--2. Stored Procedures Assignment
-- ASSIGNMENT 1
CREATE PROCEDURE sp_InsertStudent
@FirstName VARCHAR(50),
@LastName VARCHAR(50),
@Gender CHAR(1),
@DepartmentID INT,
@AdmissionDate DATE AS
INSERT INTO Students(FirstName, LastName, Gender, DepartmentID, AdmissionDate)
VALUES(@FirstName,@LastName,@Gender,@DepartmentID,@AdmissionDate)
EXEC sp_InsertStudent 'Ravi','Kumar','M',1,'2024-06-01'
SELECT * FROM Students
GO

-- ASSIGNMENT 2
CREATE PROCEDURE sp_GetStudentsByDepartment
@DepartmentID INT AS
SELECT StudentID,
FirstName + ' ' + LastName AS StudentName,
AdmissionDate
FROM Students
WHERE DepartmentID = @DepartmentID
EXEC sp_GetStudentsByDepartment 2
EXEC sp_GetStudentsByDepartment 3
GO


-- ASSIGNMENT 3
CREATE PROCEDURE sp_EnrollStudent
@StudentID INT,
@CourseID INT AS
INSERT INTO Enrollments(StudentID, CourseID, EnrollmentDate)
VALUES(@StudentID,@CourseID,GETDATE())
EXEC sp_EnrollStudent 3,2
GO


-- ASSIGNMENT 4
CREATE PROCEDURE sp_GetStudentMarks
@StudentID INT AS
SELECT s.FirstName + ' ' + s.LastName AS StudentName,
c.CourseName,
e.ExamCategory AS ExamType,
m.MarksObtained
FROM Students s
JOIN Marks m ON s.StudentID = m.StudentID
JOIN Exams e ON m.ExamID = e.ExamID
JOIN Courses c ON e.CourseID = c.CourseID
WHERE s.StudentID = @StudentID
EXEC sp_GetStudentMarks 5
GO


-- ASSIGNMENT 5
CREATE PROCEDURE sp_UpdateMarks
@MarkID INT,
@NewMarks INT AS
UPDATE Marks
SET MarksObtained = @NewMarks
WHERE MarkID = @MarkID
EXEC sp_UpdateMarks 1,90
SELECT * FROM Marks WHERE MarkID = 1
GO


-- ASSIGNMENT 6
CREATE PROCEDURE sp_DeleteEnrollment
@EnrollmentID INT
AS
DELETE FROM Enrollments
WHERE EnrollmentID = @EnrollmentID
EXEC sp_DeleteEnrollment 2
SELECT * FROM Enrollments
GO


--3. User Defined Functions Assignments
-- ASSIGNMENT 1
CREATE FUNCTION fn_GetGrade (@Marks INT)
RETURNS VARCHAR(10) AS
BEGIN
DECLARE @Grade VARCHAR(10)
IF @Marks >= 90
SET @Grade = 'A'
ELSE IF @Marks >= 75
SET @Grade = 'B'
ELSE IF @Marks >= 60
SET @Grade = 'C'
ELSE
SET @Grade = 'Fail'
RETURN @Grade
END
GO

SELECT s.FirstName + ' ' + s.LastName AS StudentName,
c.CourseName,
m.MarksObtained,
dbo.fn_GetGrade(m.MarksObtained) AS Grade
FROM Students s
JOIN Marks m ON s.StudentID = m.StudentID
JOIN Exams e ON m.ExamID = e.ExamID
JOIN Courses c ON e.CourseID = c.CourseID
GO



-- ASSIGNMENT 2
CREATE FUNCTION fn_GetStudentAge (@DOB DATE)
RETURNS INT
AS
BEGIN
RETURN DATEDIFF(YEAR,@DOB,GETDATE())
END
GO
SELECT FirstName,
LastName,
dbo.fn_GetStudentAge(DateOfBirth) AS Age
FROM Students
GO


-- ASSIGNMENT 3
CREATE FUNCTION fn_GetTotalMarks (@StudentID INT)
RETURNS INT
AS
BEGIN
DECLARE @Total INT
SELECT @Total = SUM(MarksObtained)
FROM Marks
WHERE StudentID = @StudentID
RETURN @Total
END
GO
SELECT StudentID,
dbo.fn_GetTotalMarks(StudentID) AS TotalMarks
FROM Students
GO


-- ASSIGNMENT 4
CREATE FUNCTION fn_GetStudentCourses (@StudentID INT)
RETURNS TABLE
AS
RETURN
(
SELECT c.CourseName,
e.EnrollmentDate
FROM Enrollments e
JOIN Courses c
ON e.CourseID = c.CourseID
WHERE e.StudentID = @StudentID
)
GO
SELECT * 
FROM dbo.fn_GetStudentCourses(5)
GO


-- ASSIGNMENT 5
CREATE FUNCTION fn_GetDepartmentStudents (@DepartmentID INT)
RETURNS TABLE
AS
RETURN
(
SELECT StudentID,
FirstName + ' ' + LastName AS StudentName,
AdmissionDate
FROM Students
WHERE DepartmentID = @DepartmentID
)
GO
SELECT *
FROM dbo.fn_GetDepartmentStudents(1)
