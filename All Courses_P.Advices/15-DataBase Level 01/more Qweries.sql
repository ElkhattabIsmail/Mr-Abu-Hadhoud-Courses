USE [ContactsDB]
GO

UPDATE [dbo].[Countries]
   SET [CountryName] = @CountryName
 WHERE CountryID = @CountryID


 select * from Contacts



