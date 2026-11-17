
select * from Contacts

INSERT INTO Contacts (FirstName, LastName, Email, Phone, Address,DateOfBirth, CountryID,ImagePath)

                             VALUES ('Noha','bekri','Noha@Gmail.com','7848939873','Street333',20/4/2002,100,NULL)
                             SELECT SCOPE_IDENTITY();


INSERT INTO People (NationalNo ,FirstName,SecondName,ThirdName, LastName,DateOfBirth, Gender,
                     Address ,Phone,Email , NationalityCountryID,ImagePath)

                             VALUES ('Noha','9abab', 'xater','bekri',20/4/2002,100,1,
							 'Street333','0993947792', 'Noha@gmailcom',100,NULL)
                             SELECT SCOPE_IDENTITY();
select * from People

SELECT * FROM People  where SecondName like  'm%' 


SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName,
People.ThirdName, People.LastName, Gender = Case 
when Gender = 0 then 'Male'else 'Female'
End , People.DateOfBirth, Countries.CountryName,
People.Phone, People.Email
FROM Countries INNER JOIN
People ON Countries.CountryID = People.NationalityCountryID
where PersonID =  1025;

select * from 
(
SELECT  People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName,
People.LastName, Gender = Case 
when Gender = 0 then 'Male'else 'Female'
End, People.Phone, People.Email
FROM     People INNER JOIN
               Countries ON People.NationalityCountryID = Countries.CountryID) s1
where (s1.Gender LIKE 'm%')



select * from 
(
SELECT  People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName,
People.LastName, Gender = Case 
when Gender = 0 then 'Male'else 'Female'
End,People.DateOfBirth, Countries.CountryName, People.Phone, People.Email
FROM     People INNER JOIN
               Countries ON People.NationalityCountryID = Countries.CountryID) s1
where (s1.CountryName LIKE 'J%')



SELECT  People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName,
People.LastName, People.Gender, People.Phone, People.Email, Countries.CountryName
FROM     People INNER JOIN
               Countries ON People.NationalityCountryID = Countries.CountryID