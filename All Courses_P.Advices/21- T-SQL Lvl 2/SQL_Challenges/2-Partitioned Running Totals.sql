--Question:

--The cats must be ordered first by breed and second by name.
--They are about to enter an elevator one by one. When all the cats of the same breed have entered they leave.

--We would like to know what the running total weight of the cats is.

--Return: name, breed, running total weight
--Order by: breed, name

-- Step 1: Create the table
CREATE TABLE Cats (
    Name NVARCHAR(50) PRIMARY KEY,
    Breed NVARCHAR(50),
    Weight DECIMAL(5, 2),
    Color NVARCHAR(50),
    Age INT
);

-- Step 2: Insert the data
INSERT INTO Cats (Name, Breed, Weight, Color, Age)
VALUES
    ('Ashes', 'Persian', 4.5, 'Black', 5),
    ('Molly', 'Persian', 4.2, 'Black', 1),
    ('Felix', 'Persian', 5.0, 'Tortoiseshell', 2),
    ('Smudge', 'British Shorthair', 4.9, 'Black', 4),
    ('Tigger', 'British Shorthair', 3.8, 'Tortoiseshell', 2),
    ('Alfie', 'Siamese', 5.5, 'Brown', 5),
    ('Oscar', 'Siamese', 6.1, 'Black', 1),
    ('Millie', 'Maine Coon', 5.4, 'Tortoiseshell', 5),
    ('Misty', 'Maine Coon', 5.7, 'Brown', 2),
    ('Puss', 'Maine Coon', 5.1, 'Tortoiseshell', 2),
    ('Smokey', 'Maine Coon', 6.1, 'Brown', 4),
    ('Charlie', 'British Shorthair', 4.8, 'Black', 4);

-- Step 3: Verify the data
SELECT * FROM Cats;

-- Solution:
select 
name, breed ,Weight,
sum(weight) over (partition by breed order by name ) as running_total_weight
 from cats 

