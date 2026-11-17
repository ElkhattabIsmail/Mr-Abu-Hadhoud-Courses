USE [ContactsDB]


INSERT INTO [dbo].[Contacts]
           ([FirstName]
           ,[LastName]
           ,[Email]
           ,[Phone]
           ,[Address]
           ,[CountryID])
     VALUES
           ( 'Ali' ,'Omar' , 'Email' ,'012364' ,'fly street' , 1)

select SCOPE_IDENTITY()  --fun return the last Added Idendity

select * from Contacts

 


