-- ADD New
CREATE OR ALTER PROCEDURE SP_AddNewUser
    @PersonID INT,
    @UserName NVARCHAR(50),
    @Password NVARCHAR(100),
    @Permission INT,
    @IsActive BIT
AS
BEGIN
    -- Insert the new user
    INSERT INTO Users (PersonID, UserName, Password, Permission, IsActive)
    VALUES (@PersonID, @UserName, @Password, @Permission, @IsActive);

    -- Return the newly generated UserID
    SELECT SCOPE_IDENTITY() AS NewUserID;
END
-- OUTPUT INSERTED.EmployeeID -- Return the generated EmployeeID

--delete  from Users
--select * from Users
--alter table Users
--ADD Constraint UQ_PesonID UNIQUE (PersonID);

-- UPDATE
CREATE or alter PROCEDURE SP_UpdateUser
	@UserID INT,
    @PersonID int,
	@UserName nvarchar(50),
	@Password nvarchar(100),
	@Permission int,
	@IsActive bit
AS
BEGIN
    Update Users 
    Set PersonID =@PersonID, UserName = @UserName , Password = @Password,
	Permission = @Permission, IsActive = @IsActive
	where UserID = @UserID
END

-- Delete
create or alter Procedure SP_DeleteUserByID
	@UserID INT
AS
BEGIN
    Delete Users 
	where @UserID = UserID
END

create Procedure SP_GetAllUsers
as
begin
	select * from Users;
end
exec SP_GetAllUsers;

-- IsExist
create Procedure SP_IsUserExist
@UserID int
as
begin
	if Exists (select Found = 1 from Users where UserID = @UserID)
		return 1;
	else
		return 0;
end


-- GetByID
create Procedure SP_GetUserByID
@UserID int
as
begin
	 select * from Users where UserID = @UserID
end
