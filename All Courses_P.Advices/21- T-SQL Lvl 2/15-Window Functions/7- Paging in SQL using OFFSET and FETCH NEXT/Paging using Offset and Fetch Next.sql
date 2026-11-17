
use C21_DB1;
go

select * from Students order by Name ;

-- Declare variables for paging
DECLARE @PageNumber AS INT, @RowsPerPage AS INT;

-- Set the page number to 2 (to retrieve the second page of results)
SET @PageNumber = 1;
-- Set the number of rows per page to 3
SET @RowsPerPage = 3;

-- Query to retrieve data with paging
SELECT StudentID, Name, Subject, Grade
FROM Students
-- Order the results by StudentID (or another column as desired)
ORDER BY StudentID
-- Calculate the number of rows to skip (offset) based on the current page
OFFSET (@PageNumber - 1) * @RowsPerPage ROWS   -- OFFSET MEANS omit THE ROWS (3 ROWS IN THIS EX) 
-- Specify the number of rows to fetch after the offset
FETCH NEXT @RowsPerPage ROWS ONLY;  -- THATS MEAN GET THE NEXT 3 ROWS AFTER THE IGNORED ROWS      الثلاثة ريكورد لي بعد الرووز لي تعمل لهم أوفسيت

-- Explanation:
-- 1. @PageNumber is set to 2, indicating the second page is to be retrieved.
-- 2. @RowsPerPage is set to 3, meaning each page will display 3 records.
-- 3. The OFFSET clause skips (2-1)*3 = 3 rows (as this is page 2).
-- 4. The FETCH NEXT clause then fetches the next 3 rows after the offset.
-- 5. The result is records 4, 5, and 6 from the Students table, assuming
--    sequential ordering by StudentID.

--------------------------------------------------

DECLARE @Skip INT=0;
DECLARE @Fetch INT=3;
DECLARE @LoopCnt INT;

select @LoopCnt = Count(*) /  @Fetch from Students

while @LoopCnt > 0
BEGIN 

Set @LoopCnt = @LoopCnt-1;

-- Query to retrieve data with paging
SELECT StudentID, Name, Subject, Grade
FROM Students
-- Order the results by StudentID (or another column as desired)
ORDER BY StudentID

OFFSET @Skip rows fetch next @Fetch rows only

set @Skip = @Skip + @Fetch
END