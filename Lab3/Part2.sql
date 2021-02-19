USE GradesDatabase
GO

CREATE PROCEDURE addGradesRecovery
	@studentName varchar(20),
	@cnp int,
	@courseName varchar(20),
	@valCourse int,
	@valGrade int,
	@gradeDate datetime

	AS	
		BEGIN
			DECLARE @fail INT
			SET @fail = 0
			BEGIN TRAN
				BEGIN TRY
					IF(dbo.validateStudentName(@studentName)<>1)
						BEGIN
						RAISERROR('Invalid name',14,1)
						END

					insert into Students(studentName, cnp) VALUES (@studentName, @cnp)
					DECLARE @sid INT
					SET @sid = (SELECT IDENT_CURRENT('Student'))

					SAVE TRAN  Students_Point
					print 'Saved student'
				END TRY

				BEGIN CATCH
					PRINT ERROR_MESSAGE()
					PRINT 'Could not save student'
					SET @fail = 1
				END CATCH

				BEGIN TRY
					IF(dbo.validateCourseName(@courseName)<>1)
						BEGIN
						RAISERROR('Invalid name',14,1)
						END

					IF(dbo.vallidateGradeVal(@valCourse)<>1)
						BEGIN
						RAISERROR('Invalid val',14,1)
						END

					INSERT INTO Course(courseName, val) VALUES (@courseName, @valCourse)
					DECLARE @cid INT
					SET @cid = (SELECT IDENT_CURRENT('Course'))

					SAVE TRAN Course_Point
					PRINT 'Saved Course'
				END TRY

				BEGIN CATCH
					print ERROR_MESSAGE()
					print 'Could not save Course'
					ROLLBACK TRAN Course_Point
					SET @fail = 1
				END CATCH

				IF(@fail = 0)
					BEGIN
						BEGIN TRY
							IF(dbo.vallidateGradeVal(@valGrade)<>1)
								BEGIN
								RAISERROR('Invalid val',14,1)
								END
							IF(dbo.validateDate(@gradeDate)<>1)
								BEGIN
								RAISERROR('Invalid date', 14,1)
								END

								INSERT INTO Grade(val, gradeDate, studentID, courseID) VALUES (@valGrade, @gradeDate, @sid, @cid)
								COMMIT TRAN
								PRINT 'Saved grade'
								PRINT 'Fully saved instances'
						END TRY

						BEGIN CATCH
							print ERROR_MESSAGE()
							print 'Transaction rollbacked for Grade'
							ROLLBACK TRAN Grade_Point
						END CATCH
					END
				ELSE
					BEGIN
						print 'Grade could not be saved'
						COMMIT TRAN
					END
		END


-- nice case
EXEC addGradesRecovery 'Catii', 12345, 'OOP', 6, 9, '2020-11-11 11:23:44'
--bad case: name verification failed
EXEC addGradesRecovery 'Mari?a', 12344, 'Mate', 4, 6, '2020-11-11 11:23:44'

SELECT * FROM Grades