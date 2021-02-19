USE GradesDatabase
GO

CREATE FUNCTION vallidateGradeVal(@val INT) RETURNS INT AS
BEGIN
	DECLARE @return INT
	SET @return=0
	IF(@val > 0 AND @val <= 10)
		SET @return = 1

	return @return
END

GO

CREATE FUNCTION validateCourseName(@name varchar(20)) RETURNS INT AS
BEGIN
	DECLARE @return INT
	SET @return=0
	IF(NOT @name LIKE '%[^a-Z ''-]%')
		SET @return = 1
	return @return
END

GO

CREATE FUNCTION validateStudentName(@name varchar(20)) RETURNS INT AS
BEGIN
	DECLARE @return INT
	SET @return=0
	IF(NOT @name LIKE '%[^a-Z ''-]%')
		SET @return = 1
	return @return
END

GO

CREATE FUNCTION validateDate(@date datetime) RETURNS INT AS
BEGIN
	DECLARE @return INT
	SET @return=0
	IF(getDate() < @date)
		SET @return = 1
	return @return
END

GO

SELECT dbo.vallidateGradeVal(11)
SELECT dbo.validateCourseName('Sisteme de operare')
SELECT dbo.validateStudentName('An?a')
SELECT DBO.validateDate('2020-11-11 13:23:44')