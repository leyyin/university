USE test_example_dbms
GO


BEGIN TRAN
	UPDATE Users SET AGE = 100 WHERE uid = 1
COMMIT TRAN
