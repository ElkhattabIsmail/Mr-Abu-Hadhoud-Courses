-- ADD New
CREATE OR ALTER PROCEDURE SP_AddNewSale
     @CustomerID INT ,
	 @FK_ProductID int,
	 @FK_UserID int,
	 @SaleDate date,
	 @ProductQuantity int
AS
BEGIN
    -- Insert the new Sale
    INSERT INTO SaleDetails (CustomerID,FK_ProductID,FK_UserID,SaleDate,ProductQuantity)
    VALUES (@CustomerID,@FK_ProductID,@FK_UserID,@SaleDate,@ProductQuantity );
    -- Return the newly generated SaleID
    SELECT SCOPE_IDENTITY() AS NewSaleID;
END
-- OUTPUT INSERTED.EmployeeID -- Return the generated EmployeeID

--delete  from SaleDetails
--select * from SaleDetails
--alter table SaleDetails
--ADD Constraint UQ_PesonID UNIQUE (SaleIDID);

-- UPDATE
CREATE or alter  PROCEDURE SP_UpdateSale
	@SaleID INT,
     @SaleID INT ,
AS
BEGIN
    Update SaleDetails
    Set  SaleName = 
	where SaleID  = @SaleID
END

-- Delete
create or alter  Procedure SP_DeleteSaleByID
	@SaleID INT
AS
BEGIN
    Delete SaleDetails 
	where @SaleID = SaleID
END

create or alter Procedure SP_GetAllSaleDetails
as
begin
	select * from dbo.SaleDetails;
end
exec SP_GetAllSaleDetails;

-- IsExist
create or alter Procedure SP_IsSaleExist
@SaleID int
as
begin
	if Exists (select Found = 1 from SaleDetails where SaleID = @SaleID)
		return 1;
	else
		return 0;
end

-- GetByID
create or alter Procedure SP_GetSaleByID
@SaleID int
as
begin
	 select * from SaleDetails where @SaleID = @SaleID
end