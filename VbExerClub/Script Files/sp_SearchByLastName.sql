CREATE PROCEDURE [dbo].sp_SearchByLastName
	@lname varchar(30)
AS
	SELECT * FROM MEMBER
	WHERE LNAME LIKE '*' + @lname + '*'
	ORDER BY LNAME, FNAME;
RETURN 0