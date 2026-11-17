CREATE OR ALTER PROCEDURE SP_AddNewCustomer
    @PersonID INT
AS
BEGIN
    -- Insert the new Customer
    INSERT INTO Customers (PersonID)
    VALUES (@PersonID);
    -- Return the newly generated CustomerID
    SELECT SCOPE_IDENTITY() AS NewCustomerID;
END
-- OUTPUT INSERTED.EmployeeID -- Return the generated EmployeeID

--delete  from Customers
--select * from Customers
alter table Customers
ADD Constraint UQ_Customer UNIQUE (PersonID);


CREATE or alter PROCEDURE SP_UpdateCustomer
	@CustomerID INT,
	@PersonID INT
AS
BEGIN
    Update Customers 
    Set PersonID = @PersonID
	where CustomerID = @CustomerID
END


create or alter Procedure SP_DeleteCustomerByID
	@CustomerID INT
AS
BEGIN
    Delete Customers 
	where CustomerID = @CustomerID
END

create Procedure SP_GetAllCustomers
as
begin
	select * from Customers;
end

exec SP_GetAllCustomers;

create Procedure SP_IsCustomerExist
@CustomerID int
as
begin
	if Exists (select Found = 1 from Customers where CustomerID = @CustomerID)
		return 1;
	else
		return 0;
end


--select * from Customers;

create or alter Procedure SP_GetCustomerByID
@CustomerID int
as
begin
	 select * from Customers where CustomerID = @CustomerID
end
