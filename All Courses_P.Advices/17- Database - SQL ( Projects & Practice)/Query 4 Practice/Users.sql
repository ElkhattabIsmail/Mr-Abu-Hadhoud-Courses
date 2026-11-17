

SELECT  Users.UserID, Users.UserName, Users.Password, Users.IsActive, People.NationalNo,
People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.DateOfBirth, 
People.Gender, People.Address, People.Phone, People.Email, People.NationalityCountryID, People.ImagePath
FROM     Users INNER JOIN
               People ON Users.PersonID = People.PersonID
where UserID = 1

select * from Users
where UserID = 1