CREATE OR ALTER PROCEDURE SP_AddNewProduct
	@ProductName int,
	@Price Money,
	@CategoryID int,
	@Description nvarchar(100),
	@ProductQuantityInStock int,
	@ImageUrl nvarchar(100),
	@DateAdded datetime,
	@LastUpdated datetime
AS
BEGIN
    -- Insert the new Product
    INSERT INTO Products (ProductName , Price, FK_CategoryID,Description,ProductQuantityInStock,
		ImageUrl,DateAdded, LastUpdated)
    VALUES (@ProductName,@Price,@CategoryID,@Description,@ProductQuantityInStock,
	@ImageUrl,@DateAdded,@LastUpdated);
    -- Return the newly generated ProductID
    SELECT SCOPE_IDENTITY() AS NewProductID;
END

-- OUTPUT INSERTED.EmployeeID -- Return the generated EmployeeID

--delete  from Products
--select * from Products
--alter table Products
--ADD Constraint UQ_ProductID UNIQUE (ProductIDID);


CREATE or alter PROCEDURE SP_UpdateProduct
	@ProductID int,
	@ProductName int,
	@Price Money,
	@CategoryID int,
	@Description nvarchar(100),
	@ProductQuantityInStock int,
	@ImageUrl nvarchar(100),
	@DateAdded datetime,
	@LastUpdated datetime
AS
BEGIN
    Update Products 
    Set ProductID = @ProductID,ProductName = @ProductName ,Price = @Price, FK_CategoryID = @CategoryID,
	Description = @Description,ProductQuantityInStock =  @ProductQuantityInStock,
	ImageUrl = @ImageUrl , DateAdded = @DateAdded, LastUpdated = @LastUpdated
	where ProductID = @ProductID
END


create or alter Procedure SP_DeleteProductByID
	@ProductID INT
AS
BEGIN
    Delete Products 
	where ProductID = @ProductID
END

create Procedure SP_GetAllProducts
as
begin
	select * from Products;
end

exec SP_GetAllProducts;

create Procedure SP_IsProductExist
@ProductID int
as
begin
	if Exists (select Found = 1 from Products where ProductID = @ProductID)
		return 1;
	else
		return 0;
end


--select * from Products;

create or alter Procedure SP_GetProductByID
@ProductID int
as
begin
	 select * from Products where ProductID = @ProductID
end
