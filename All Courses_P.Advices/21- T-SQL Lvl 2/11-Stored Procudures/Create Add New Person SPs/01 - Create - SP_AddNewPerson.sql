CREATE OR Alter PROCEDURE SP_AddNewPerson
    @FirstName NVARCHAR(100),
    @LastName NVARCHAR(100),
    @Email NVARCHAR(255),
	@Phone NVARCHAR(255),
	@Address NVARCHAR(255),
    @NewPersonID INT OUTPUT
AS
BEGIN
    INSERT INTO People (FirstName, LastName, Email,Phone, Address)
    VALUES (@FirstName, @LastName, @Email,@Phone,@Address);

    SET @NewPersonID = SCOPE_IDENTITY();
END


