
use PointOfSales_DB

select * from SaleDetails_View
--select * from Customers
alter view SaleDetails_View as
SELECT  
Products.ProductName,Products.Price, Products.ProductQuantity as Quantity,Products.ProductQuantityInstock,
People.FirstName +  People.LastName as CustomerName, People.Phone,
Categories.CategoyName as Category, Payments.PaymentMethod,
SaleDetails.SaleDate, Users.UserName as CreatedByUserName, Users.IsActive
FROM     People INNER JOIN
               Customers ON People.PersonID = Customers.PersonID INNER JOIN
               SaleDetails ON Customers.CustomerID = SaleDetails.CustomerID INNER JOIN
               Products INNER JOIN
               Categories ON Products.FK_CategoryID = Categories.CategoryID 
			   ON SaleDetails.FK_ProductID = Products.ProductID INNER JOIN
               Payments ON SaleDetails.SaleID = Payments.SaleID INNER JOIN
               Users 
			   ON People.PersonID = Users.PersonID AND SaleDetails.FK_UserID = Users.UserID
--select * from SaleDetails





			   select * from People

create Table Categories
(
	CategoryID int ,
	CategoyName nvarchar(100),
	PRIMARY KEY (CategoryID)
)
create Table People
(
	PersonID int ,
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	Phone nvarchar(100),
	Email nvarchar(100),
	Address nvarchar(200),
	PRIMARY KEY (PersonID)
)
create Table Users
(
	UserID int ,
	UserName nvarchar(50) not null,
	Password nvarchar(50) not null,
	Permission int not null,
	IsActive bit not null,
	PersonID int References People(PersonID),
	Address nvarchar(200),
	PRIMARY KEY (UserID)
) 
create Table Customers
(
	CustomerID int ,
	PersonID int References People(PersonID),
	PRIMARY KEY (CustomerID)
) 
create Table Payments
(
	PaymentID int ,
	PaymentMethod nvarchar(50),
	PRIMARY KEY (PaymentID)
) 
create Table SaleDetails
(
	SaleID int ,
	CustomerID int references Customers(CustomerID),
	FK_ProductID int references Products(ProductID),
	FK_UserID int references Users(UserID),
	PaimentMethodID int references Payments(PaymentID),
	ProductQuantity int not null,
	SaleDate date not null,
	PRIMARY KEY (SaleID)
) 




















-- after insert
create view as
SELECT  Products.Price * SaleDetails.ProductQuantity AS TotalAmount,
SaleDetails.ProductQuantity, SaleDetails.SaleDate, People.FirstName,
People.LastName, Payments.PaymentMethod, Products.Name, Products.Price,
Categories.CategoryName, Products.Description, Users.Username
FROM     SaleDetails INNER JOIN
               Products ON SaleDetails.ProductID = Products.ProductID INNER JOIN
               Users ON SaleDetails.UserID = Users.UserID INNER JOIN
               Categories ON Products.CategoryID = Categories.CategoryID CROSS JOIN
               People CROSS JOIN
               Payments

			   
ALTER TABLE SaleDetails
ADD FOREIGN KEY (PaimentMethodID) REFERENCES Payments(PaymentID);





-- Create Database
CREATE DATABASE POS_DB;
GO

-- Use the Database
USE POS_DB;
GO

-- Create People Table
CREATE TABLE People (
    PersonID INT IDENTITY(1,1) PRIMARY KEY, -- Auto-incrementing primary key
    FirstName NVARCHAR(50) NOT NULL,        -- First name
    LastName NVARCHAR(50) NOT NULL,         -- Last name
    Phone NVARCHAR(15),                     -- Phone number
    Email NVARCHAR(100),                    -- Email address
    Address NVARCHAR(200)                   -- Address
);
GO

-- Create Products Table
CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY, -- Auto-incrementing primary key
    Name NVARCHAR(100) NOT NULL,            -- Product name
    Price DECIMAL(18, 2) NOT NULL,          -- Product price
    Quantity INT NOT NULL,                  -- Product quantity in stock
    Category NVARCHAR(50),                  -- Product category (e.g., Electronics, Clothing)
    Description NVARCHAR(255)               -- Product description
);

select * from Products
CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY, -- Auto-incrementing primary key
    PersonID INT NOT NULL,                   -- Foreign key to People table
    CONSTRAINT PersonID FOREIGN KEY (PersonID) REFERENCES People(PersonID)
);
GO

select * from People
CREATE TABLE Payments (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY, -- Auto-incrementing primary key
);
-- Create Users Table
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,    -- Auto-incrementing primary key
    PersonID INT NOT NULL,                   -- Foreign key to People table
    Username NVARCHAR(50) NOT NULL,         -- Username for login
    Password NVARCHAR(100) NOT NULL,        -- Password for login (store hashed passwords)
    Permission INT NOT NULL,                -- User role (e.g., 1 = Cashier, 2 = Manager)
    IsActive BIT NOT NULL,                  -- Indicates if the user
	)

	-- Create SaleDetails Table
CREATE TABLE SaleDetails (
    SaleID INT IDENTITY(1,1) PRIMARY KEY,   -- Auto-incrementing primary key
	ProductID INT NOT NULL,                    -- Foreign key to Products table
	Quantity INT NOT NULL,                     -- Quantity of the product sold
	CONSTRAINT CustomerID FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    SaleDate DATETIME NOT NULL,             -- Date and time of the sale
    TotalAmount DECIMAL(18, 2) NOT NULL,    -- Total amount of the sale
    PaymentMethod NVARCHAR(50) NOT NULL,    -- Payment method (e.g., Cash, Credit Card)
    CONSTRAINT UserID  FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
GO

-- Create SaleDetails Table
CREATE TABLE SaleDetails (
    SaleDetailID INT IDENTITY(1,1) PRIMARY KEY, -- Auto-incrementing primary key
    SaleID INT NOT NULL,                       -- Foreign key to Sales table
    ProductID INT NOT NULL,                    -- Foreign key to Products table
    Price DECIMAL(18, 2) NOT NULL,             -- Price of the product at the time of sale
    CONSTRAINT FK_SaleDetails_Sales FOREIGN KEY (SaleID) REFERENCES Sales(SaleID),
    CONSTRAINT FK_SaleDetails_Products FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);