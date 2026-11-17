
USE [ContactsDB]
GO

SELECT CountryName FROM Countries
where CountryID = 3;

delete from Countries
where CountryID = 9

select Found = 1 from Countries
where CountryID = 1

SELECT * FROM Contacts
where  FirstName like 's%'

SELECT * FROM Countries
order by CountryName



alter table countries 
add Code nvarchar(3);

alter table countries 
add  PhoneCode nvarchar(3);