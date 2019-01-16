alter procedure sp_SaveMember
 @mbrID varchar(5), @lName varchar(30), @fName varchar(30)
,@address varchar(50), @city varchar(30), @state varchar(2), @zip varchar(10),@phone varchar(15), @datejoined smalldatetime
,@email varchar(40), @progid varchar(5), @photopath varchar(150)
as
Declare @countExists int
select @countExists = count(0) from MEMBER where @mbrID = MBRID
IF (@countExists = 0)
BEGIN	

	INSERT INTO [dbo].MEMBER
			   ([MBRID]
			   ,[LName]
			   ,[FName]
			   ,[Address]
			   ,[City]
			   ,[State]
			   ,[Zip]
			   ,[Phone]
			   ,[DateJoined]
			   ,[Email]
			   ,[ProgID]
			   ,[PhotoPath])
		 VALUES
			   (@mbrID
			   ,@lName
			   ,@fName
			   ,@address
			   ,@city
			   ,@state
			   ,@zip
			   ,@phone
			   ,@datejoined
			   ,@email
			   ,@progID
			   ,@photopath)
END
ELSE
BEGIN
	UPDATE [dbo].[MEMBER]
	SET 
      [LNAME] = @lName
      ,[FNAME] = @fName
      ,[ADDRESS] = @address
      ,[CITY] = @city
      ,[STATE] = @state
      ,[ZIP] = @zip
      ,[PHONE] = @phone
      ,[DATEJOINED] = @datejoined
      ,[EMAIL] = @email
      ,[PROGID] = @progID
	  ,[PHOTOPATH] = @photopath
   	WHERE MBRID = @mbrID
END
return @@error