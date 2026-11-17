USE [DVLD]
GO

INSERT INTO People (NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,
				Gender,Address,Phone,Email,NationalityCountryID,ImagePath)
     VALUES ('n6', '33','test','test','@@',20/4/2000,1,'222','3333','test@gmail.com',90,NULL)
     SELECT SCOPE_IDENTITY();

select * from Drivers
select * from People

delete from People 
where PersonID = 1024

delete from Drivers
where PersonID = 1025

select found = 1 from People
Where NationalNo = 'n4'

select * from Countries

SELECT  PersonID, People.NationalNo, People.FirstName, People.SecondName,
                           People.ThirdName, People.LastName, Gender = Case when Gender = 0 then 'Male'else 'Female' End,People.DateOfBirth,Countries.CountryName,
                            People.Phone, People.Email FROM     People INNER JOIN
                                         Countries ON People.NationalityCountryID = Countries.CountryID