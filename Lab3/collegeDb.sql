CREATE DATABASE GradesDatabase
GO

USE GradesDataBase
GO


CREATE TABLE Students
(
	studentID INT PRIMARY KEY IDENTITY(1,1),
	studentName varchar(20),
	cnp int
)

CREATE TABLE Course
(
	courseID INT PRIMARY KEY IDENTITY(1,1),
	courseName varchar(20),
	val int
)

CREATE TABLE Grade
(
	gradeID INT PRIMARY KEY IDENTITY(1,1),
	val INT,
	gradeDate DATETIME not null,
	studentID INT FOREIGN KEY REFERENCES Students(studentID),
	courseID INT FOREIGN KEY REFERENCES Course(courseID)
)



INSERT INTO Students(studentName, cnp) VALUES ('Ana', 123)

INSERT INTO Course(courseName, val) VALUES ('aba', 3)

SELECT * FROM Students
SELECT * FROM Course

INSERT INTO Grade(val, gradeDate, studentID, courseID) VALUES (9,'2020-11-11 13:23:44', 2,1)
SELECT * FROM Grade