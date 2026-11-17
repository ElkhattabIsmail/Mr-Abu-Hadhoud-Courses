
CREATE PROCEDURE SP_CheckPersonExists
    @PersonID INT
AS
BEGIN
    IF EXISTS(SELECT * FROM People WHERE PersonID = @PersonID)
        RETURN 1;  -- Person exists
    ELSE
        RETURN 0;  -- Person does not exist
END




IF OBJECT_ID('SP_AddNewPerson', 'P') IS NOT NULL
    DROP PROCEDURE SP_AddNewPerson;
GO

create PROCEDURE dbo.SP_AddNewPerson
    @FirstName NVARCHAR(100),
    @LastName NVARCHAR(100),
    @Email NVARCHAR(255),
	@NationalNo NVARCHAR(50),
	@Gender int , @Phone nvarchar(50) , @NationalityCountryID int ,@Address nvarchar(500),
    @NewPersonID INT OUTPUT
AS
BEGIN
    INSERT INTO People (FirstName, LastName, Email,NationalNo,Gender ,NationalityCountryID)
    VALUES (@FirstName, @LastName, @Email,@NationalNo,@Gender,@NationalityCountryID);


    SET @NewPersonID = SCOPE_IDENTITY();
END


select * from Users
select * from People
select * from ApplicationTypes
select * from Licenses
select * from LocalDrivingLicenseApplications
select * from InternationalLicenses
where IssuedUsingLocalLicenseID = 22;
Delete from Applications
where ApplicationID in (69,1085,1088);
--where DriverID = 9 ;
select  found = 1 from InternationalLicenses
                            where DriverID = 15 and IsActive = 0

select  * from Drivers
select  * from TestTypes
select  * from Applications
select * from LicenseClasses


select * from Applications where ApplicationID = 1080;Delete From Applications where ApplicationID = 1080;

select * from DetainedLicenses
select isDriver = 1 from Drivers
where PersonID = 3068;

select * from Licenses
select  * from Tests
select  * from TestAppointments
select  * from LocalDrivingLicenseApplications
-- Delete Test First
delete from TestAppointments
where TestAppointmentID in (92,93,94);
select * from Drivers
where DriverID = 17;
delete from LocalDrivingLicenseApplications
where 73 = 73;
-- 2
delete from TestAppointments
where LocalDrivingLicenseApplicationID = 1037;
-- 3
delete from LocalDrivingLicenseApplications
where LocalDrivingLicenseApplicationID = 1037;


SELECT TotalTrialsPerTest = count(TestID)
FROM LocalDrivingLicenseApplications INNER JOIN
     TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
	 INNER JOIN
     Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
WHERE
(LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 30) 
AND(TestAppointments.TestTypeID = 3)



SELECT       top 1 *
                FROM            TestAppointments
                WHERE        (TestTypeID =2) 
                AND (LocalDrivingLicenseApplicationID = 31) 
                order by TestAppointmentID Desc
-- Create My Local_D_L_view
--create view Local_D_L_view as (



--select  * from ApplicationStatus

select * from LicenseClasses
where LicenseClassID = 3;

select ClassName from LicenseClasses



SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = 52;
select  * from LocalDrivingLicenseApplications_View
select * from Applications

delete from Applications
where ApplicantPersonID = 3066

-- get information of user
select UserName ,Password ,IsActive from Users 

select found = 1 from Users where PersonID = 999; 
-- confirm infos

--SELECT  Users.UserID, People.PersonID,FullName = People.FirstName +' '+ People.SecondName +' '+ People.ThirdName +' '+
--People.LastName ,Users.UserName, Users.IsActive
--FROM     Users INNER JOIN
--               People ON Users.PersonID = People.PersonID

--SELECT  Users.UserID, People.PersonID,FullName = People.FirstName +' '+ People.SecondName +' '+ People.ThirdName +' '+
--People.LastName ,Users.UserName, Users.IsActive
--FROM     Users INNER JOIN
--               People ON Users.PersonID = People.PersonID


			INSERT INTO Users (PersonID,UserName,Password,IsActive)
     VALUES (2044, 'Jina444','1234',1)
     SELECT SCOPE_IDENTITY();

UPDATE Users
SET PersonID = 2044,UserName = 'Jina44', Password = '1234',IsActive = 1
where UserID = 16;