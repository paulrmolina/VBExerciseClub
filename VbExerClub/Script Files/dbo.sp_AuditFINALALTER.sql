CREATE procedure sp_Audit
@EmpID varchar(5), @AccessTimeStamp datetime, @success varchar(5)

as

BEGIN	
DECLARE @nextID INT


	SELECT @nextID = MAX(AUDITID) + 1 FROM AUDIT

	INSERT INTO [dbo].AUDIT
			   ([AUDITID]
			   ,[EMPID]
			   ,[ACCESSTIMESTAMP]
			   ,[SUCCESS]
			   )
		 VALUES
			   (@nextID
			   ,@EmpID
			   ,@AccessTimeStamp
			   ,@success
			  )
END
return 0