
SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName,
People.LastName, People.DateOfBirth,
People.Gender, People.Address, People.Phone, People.Email,Countries.CountryID, Countries.CountryName , People.ImagePath
FROM   People INNER JOIN
            Countries ON People.NationalityCountryID = Countries.CountryID
where NationalNo = 'n4'

select * from People
select * from Countries