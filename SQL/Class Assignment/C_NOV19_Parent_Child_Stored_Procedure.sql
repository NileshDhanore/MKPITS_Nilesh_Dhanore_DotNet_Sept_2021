Alter procedure getchildByParentid(@ID int)
AS
BEGIN
SELECT childname,age FROM child WHERE parentId=@ID;
END
GO

