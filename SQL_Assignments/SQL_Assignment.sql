--Database
create database Assignment1

--Selecting DB
use Assignment1

--Table 1
CREATE TABLE Worker (
	WORKER_ID INT PRIMARY KEY IDENTITY(1,1),
	FIRST_NAME VARCHAR(25),
	LAST_NAME VARCHAR(25),
	SALARY INT,
	JOINING_DATE DATETIME,
	DEPARTMENT CHAR(25)
);

--Table 2
CREATE TABLE Bonus (
	WORKER_REF_ID INT,
	BONUS_AMOUNT INT,
	BONUS_DATE DATETIME,
	FOREIGN KEY (WORKER_REF_ID)
		REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);

--Table 3
CREATE TABLE Title (
	WORKER_REF_ID INT,
	WORKER_TITLE CHAR(25),
	AFFECTED_FROM DATETIME,
	FOREIGN KEY (WORKER_REF_ID)
		REFERENCES Worker(WORKER_ID)
        ON DELETE CASCADE
);

--Insert data into Worker table
INSERT INTO Worker (FIRST_NAME, LAST_NAME, SALARY, JOINING_DATE, DEPARTMENT) VALUES
('Monika', 'Arora', 100000, '2014-02-20 09:00:00', 'HR'),
('Niharika', 'Verma', 80000, '2014-06-11 09:00:00', 'Admin'),
('Vishal', 'Singhal', 300000, '2014-02-20 09:00:00', 'HR'),
('Amitabh', 'Singh', 500000, '2014-02-20 09:00:00', 'Admin'),
('Vivek', 'Bhati', 500000, '2014-06-11 09:00:00', 'Admin'),
('Vipul', 'Diwan', 200000, '2014-06-11 09:00:00', 'Account'),
('Satish', 'Kumar', 75000, '2014-01-20 09:00:00', 'Account'),
('Geetika', 'Chauhan', 90000, '2014-04-11 09:00:00', 'Admin');

--Viewing the table Worker
select * from Worker

--Insert data into Bonus table
INSERT INTO Bonus (WORKER_REF_ID, BONUS_DATE, BONUS_AMOUNT) VALUES
(1, '2016-02-20 00:00:00', 5000),
(2, '2016-06-11 00:00:00', 3000),
(3, '2016-02-20 00:00:00', 4000),
(1, '2016-02-20 00:00:00', 4500),
(2, '2016-06-11 00:00:00', 3500);

--Viewing the table Bonus
select * from Bonus

--Insert data into Title table
INSERT INTO Title (WORKER_REF_ID, WORKER_TITLE, AFFECTED_FROM) VALUES
(1, 'Manager', '2016-02-20 00:00:00'),
(2, 'Executive', '2016-06-11 00:00:00'),
(8, 'Executive', '2016-06-11 00:00:00'),
(5, 'Manager', '2016-06-11 00:00:00'),
(4, 'Asst. Manager', '2016-06-11 00:00:00'),
(7, 'Executive', '2016-06-11 00:00:00'),
(6, 'Lead', '2016-06-11 00:00:00'),
(3, 'Lead', '2016-06-11 00:00:00');

--Viewing the table Title
select * from Title

--Assignment Queries
--1. Write an SQL query to fetch “FIRST_NAME” from Worker table using the alias name as <WORKER_NAME>.
SELECT FIRST_NAME AS WORKER_NAME FROM Worker;

--2. Write an SQL query to fetch “FIRST_NAME” from Worker table in upper case.
SELECT UPPER(FIRST_NAME) AS WORKER_NAME FROM Worker;

--3. Write an SQL query to fetch unique values of DEPARTMENT from Worker table.
SELECT DISTINCT DEPARTMENT FROM Worker;

--4. Write an SQL query to print the first three characters of FIRST_NAME from Worker table.
SELECT SUBSTRING(FIRST_NAME,1,3) FROM Worker;

--5. Write an SQL query to find the position of the alphabet (‘a’) in the first name column ‘Amitabh’ from Worker table.
SELECT CHARINDEX('a', FIRST_NAME) FROM Worker WHERE FIRST_NAME = 'Amitabh';

--6. Write an SQL query to print the FIRST_NAME from Worker table after removing white spaces from the right side.
SELECT RTRIM(FIRST_NAME) FROM Worker;

-- 7. Print DEPARTMENT after removing left side white spaces
SELECT LTRIM(DEPARTMENT) AS DEPARTMENT FROM Worker;

-- 8. Fetch unique DEPARTMENT values and print their length
SELECT DISTINCT DEPARTMENT, LEN(DEPARTMENT) AS LENGTH FROM Worker;

-- 9. Print FIRST_NAME after replacing 'a' with 'A'
SELECT REPLACE(FIRST_NAME, 'a', 'A') AS FIRST_NAME FROM Worker;

-- 10. Print FIRST_NAME and LAST_NAME as COMPLETE_NAME
SELECT FIRST_NAME + ' ' + LAST_NAME AS COMPLETE_NAME FROM Worker;

-- 11. Print all Worker details order by FIRST_NAME Ascending
SELECT * FROM Worker ORDER BY FIRST_NAME ASC;

-- 12. Print all Worker details order by FIRST_NAME Asc and DEPARTMENT Desc
SELECT * FROM Worker ORDER BY FIRST_NAME ASC, DEPARTMENT DESC;

-- 13. Print details for Workers with FIRST_NAME as 'Vipul' and 'Satish'
SELECT * FROM Worker WHERE FIRST_NAME IN ('Vipul', 'Satish');

-- 14. Print details excluding FIRST_NAME 'Vipul' and 'Satish'
SELECT * FROM Worker WHERE FIRST_NAME NOT IN ('Vipul', 'Satish');

-- 15. Print details of Workers with DEPARTMENT as 'Admin'
SELECT * FROM Worker WHERE DEPARTMENT = 'Admin';

-- 16. Print details of Workers whose FIRST_NAME contains 'a'
SELECT * FROM Worker WHERE FIRST_NAME LIKE '%a%';

-- 17. Print details of Workers whose FIRST_NAME ends with 'a'
SELECT * FROM Worker WHERE FIRST_NAME LIKE '%a';

-- 18. Print details of Workers whose FIRST_NAME ends with 'h' and has six alphabets
SELECT * FROM Worker WHERE FIRST_NAME LIKE '_____h';

-- 19. Print details of Workers whose SALARY between 100000 and 500000
SELECT * FROM Worker WHERE SALARY BETWEEN 100000 AND 500000;

-- 20. Print details of Workers who joined in Feb 2014
SELECT * FROM Worker WHERE MONTH(JOINING_DATE) = 2 AND YEAR(JOINING_DATE) = 2014;

-- 21. Fetch worker names with salary >= 50000 and <= 100000
SELECT FIRST_NAME, LAST_NAME FROM Worker WHERE SALARY BETWEEN 50000 AND 100000;

-- 22. Fetch number of workers for each department in descending order
SELECT DEPARTMENT, COUNT(*) AS NO_OF_WORKERS FROM Worker GROUP BY DEPARTMENT ORDER BY NO_OF_WORKERS DESC;

-- 23. Print details of Workers who are also Managers
SELECT W.* FROM Worker W JOIN Title T ON W.WORKER_ID = T.WORKER_REF_ID WHERE T.WORKER_TITLE = 'Manager';

-- 24. Show current date and time
SELECT GETDATE() AS CURRENT_DATE_TIME;

-- 25. Show top 10 records of Worker table
SELECT TOP 10 * FROM Worker;