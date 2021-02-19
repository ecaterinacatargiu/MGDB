USE GradesDatabase

CREATE PROCEDURE addAGrade

	@studentName varchar(20),
	@cnp int,
	@courseName varchar(20),
	@valCourse int,
	@valGrade int,
	@gradeDate datetime

	AS
		BEGIN
			BEGIN TRAN
				BEGIN TRY
					IF(dbo.validateStudentName(@studentName)<>1)
						BEGIN
						RAISERROR('Invalid name',14,1)
						END

					IF(dbo.validateCourseName(@courseName)<>1)
						BEGIN
						RAISERROR('Invalid name',14,1)
						END

					IF(dbo.vallidateGradeVal(@valCourse)<>1)
						BEGIN
						RAISERROR('Invalid val',14,1)
						END

					IF(dbo.vallidateGradeVal(@valGrade)<>1)
						BEGIN
						RAISERROR('Invalid val',14,1)
						END

					IF(dbo.validateDate(@gradeDate)<>1)
						BEGIN
						RAISERROR('Invalid date', 14,1)
						END

					INSERT INTO Students(studentName, cnp) VALUES (@studentName, @cnp)
					DECLARE @sid INT
					SET @sid = (SELECT IDENT_CURRENT('Student'))

					INSERT INTO Course(courseName, val) VALUES (@courseName, @valCourse)
					DECLARE @cid INT
					SET @cid = (SELECT IDENT_CURRENT('Course'))

					INSERT INTO Grade(val, gradeDate, studentID, courseID) VALUES (@valGrade, @gradeDate, @sid, @cid)
					COMMIT TRAN
					SELECT 'Transaction commited'


				END TRY

				BEGIN CATCH
					PRINT ERROR_MESSAGE()
					PRINT 'Transaction rollback'
					ROLLBACK TRAN

				END CATCH

		END


-- nice case
EXEC addAGrade 'etc', 1234,  'Sisteme de Operaree', 4, 8, '2020-11-11 11:23:44'

--bad case: name verification failed
EXEC addAGrade 'Mari?a', 12344, 'Mate', 4, 6, '2020-11-11 11:23:44'


SELECT * FROM Student
SELECT * FROM Course
SELECT * FROM Grades
