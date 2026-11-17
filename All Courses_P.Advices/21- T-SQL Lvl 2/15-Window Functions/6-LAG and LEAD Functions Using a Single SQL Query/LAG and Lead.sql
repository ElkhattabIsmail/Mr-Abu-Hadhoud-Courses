use C21_DB1;

select * from Students order by grade desc;


SELECT 
    StudentID, 
    Name, 
	LAG(Grade, 1) OVER (ORDER BY Grade DESC) AS PreviousGrade,  
    Grade,
    Lead(Grade, 1) OVER (ORDER BY Grade DESC) AS NextGrade
FROM 
    Students order by grade desc;   -- comprehensive comparison within the dataset



	select * from Students order by grade desc;



WITH RankedStudents AS (
    SELECT 
        StudentID, 
        Name, 
        Grade,
        ROW_NUMBER() OVER (ORDER BY Grade DESC) AS RowNum
    FROM Students
)
SELECT 
    D1.StudentID, 
    D1.Name,D1.RowNum RN_1, D2.RowNum RN_2,
	--D3.RowNum RN_3,
    D1.Grade,
    D2.Grade AS PreviousGrade  -- Grade of the previous row
    --D3.Grade AS NextGrade       -- Grade of the next row
FROM RankedStudents D1

LEFT JOIN RankedStudents D2
    ON D1.RowNum = D2.RowNum + 1  -- Join with the previous row

LEFT JOIN RankedStudents D3
    ON D1.RowNum = D3.RowNum - 1  -- Join with the next row

ORDER BY D1.Grade DESC;






-- Self Join

SELECT 
    D1.StudentID, 
    D1.Name, 
    D2.Grade AS PreviousGrade,  -- Grade of the previous row
	D1.Grade,
    D3.Grade AS NextGrade       -- Grade of the next row
FROM Students D1
LEFT JOIN Students D2
    ON D2.Grade > D1.Grade  -- Join with the previous row (higher grade)
    AND NOT EXISTS (
        SELECT 1
        FROM Students D4
        WHERE D4.Grade > D1.Grade AND D4.Grade < D2.Grade
    )
LEFT JOIN Students D3
    ON D3.Grade < D1.Grade  -- Join with the next row (lower grade)
    AND NOT EXISTS (
        SELECT 1
        FROM Students D5
        WHERE D5.Grade < D1.Grade AND D5.Grade > D3.Grade
    )
ORDER BY D1.Grade DESC;

