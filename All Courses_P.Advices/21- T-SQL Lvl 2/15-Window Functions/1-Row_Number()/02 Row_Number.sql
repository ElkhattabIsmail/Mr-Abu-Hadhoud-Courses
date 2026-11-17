use C21_DB1;

select * from students order by grade desc;

--Assigns a unique integer to each row within the result set.

SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    ROW_NUMBER() OVER (ORDER BY grade desc) AS RowNum  --   Arrange Data Depends On  Grades asc/desc
FROM 
    Students order by grade desc;


	SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    ROW_NUMBER() OVER (partition by Subject ORDER BY grade desc) AS RowNum  --   Arrange Data Depends On  Grades asc/desc
FROM 
    Students order by Subject desc;








	SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    ROW_NUMBER() OVER (ORDER BY grade desc) AS RowNum   --   Arrange Data Depends On  Grades asc/desc
FROM 
    (select * from students where Subject = 'Math') as m

	select sum(Grade) from students where Subject = 'Math'



	SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    ROW_NUMBER() OVER (ORDER BY grade desc) AS RowNum  --   Arrange Data Depends On  Grades asc/desc
FROM 
    (select * from students where Subject = 'Science') as m


	SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    ROW_NUMBER() OVER (ORDER BY Grade DESC) AS RowNum,  -- Arrange Data Depends On Grades DESC
    SUM(Grade) OVER () AS TotalGradeSum  -- Add the sum of grades as a column
FROM 
    (SELECT * FROM students WHERE Subject = 'Science') AS m;



	SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    ROW_NUMBER() OVER (ORDER BY Grade DESC) AS RowNum,  -- Arrange Data Depends On Grades DESC
    SUM(Grade) OVER (PARTITION BY Subject) AS SubjectGradeSum  -- Sum of grades per subject
FROM 
    (SELECT * FROM students ) as S
	order by RowNum



	-- Arrange Each Subject .
	SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    ROW_NUMBER() OVER (PARTITION BY Subject ORDER BY Grade DESC) AS RowNum
FROM Students;



WITH PaginatedData AS (
    SELECT 
        StudentID, 
        Name, 
        Grade,
        ROW_NUMBER() OVER (ORDER BY Grade DESC) AS RowNum
    FROM Students
)
SELECT 
    StudentID, 
    Name, 
    Grade
FROM PaginatedData
WHERE RowNum BETWEEN 7 AND 9;  -- Fetch rows from 1 to 3




-- no duplicate in out table.
WITH DeduplicatedData AS (
    SELECT 
        StudentID, 
        Name, 
        Grade,
        ROW_NUMBER() OVER (PARTITION BY StudentID ORDER BY Grade DESC) AS RowNum
    FROM Students
)
SELECT 
    StudentID, 
    Name, 
    Grade
FROM DeduplicatedData
WHERE RowNum = 1;  -- Keep only the first occurrence of each StudentID






WITH TopNPerGroup AS (
    SELECT 
        StudentID, 
        Name, 
        Subject, 
        Grade,
        ROW_NUMBER() OVER (PARTITION BY Subject ORDER BY Grade DESC) AS RowNum
    FROM Students
)
SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade
FROM TopNPerGroup
WHERE RowNum <= 2;  -- Get top 2 students per subject









SELECT 
    StudentID, 
    Name, 
    Grade,subject,
    --ROW_NUMBER() OVER (ORDER BY Grade DESC) AS RowNum,
    RANK() OVER (ORDER BY Grade DESC) AS Rank,
    DENSE_RANK() OVER (ORDER BY Grade DESC) AS DenseRank
FROM Students;




















-- 9. Handling NULLs
Use ROW_NUMBER() to handle NULL values in the ordering.

Example:
sql
Copy
SELECT 
    StudentID, 
    Name, 
    Grade,
    ROW_NUMBER() OVER (ORDER BY Grade DESC NULLS LAST) AS RowNum
FROM Students;
-- Output: NULL values are placed last.





10. Dynamic Sorting
Use ROW_NUMBER() with dynamic sorting based on user input.


DECLARE @SortColumn NVARCHAR(50) = 'Name';
DECLARE @SortOrder NVARCHAR(4) = 'desc';

DECLARE @SQL NVARCHAR(MAX);
SET @SQL = N'
SELECT 
    StudentID, 
    Name, 
    Grade,
    ROW_NUMBER() OVER (ORDER BY ' + @SortColumn + ' ' + @SortOrder + ') AS RowNum
FROM Students;';
EXEC sp_executesql @SQL;
-- Output: Dynamically sorts based on the column and order specified.




-- 15. Use in Updates
-- Use ROW_NUMBER() in UPDATE statements to update specific rows.

WITH RankedData AS (
    SELECT 
        StudentID, 
        Grade,
        ROW_NUMBER() OVER (ORDER BY Grade DESC) AS RowNum
    FROM Students
)
UPDATE RankedData
SET Grade = Grade + 1
WHERE RowNum = 1;  -- Update the top student's grade

-- Output: Adds 5 to the top student's grade.












