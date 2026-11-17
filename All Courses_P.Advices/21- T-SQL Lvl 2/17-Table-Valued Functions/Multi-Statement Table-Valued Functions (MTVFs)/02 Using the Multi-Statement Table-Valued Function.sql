SELECT *
FROM dbo.GetTopPerformingStudents('math'); -- top 3


-- Example: Join Teachers with the result of the Multi-Statement Table-Valued Function
SELECT t.Name AS TeacherName, s.Name AS StudentName, s.Grade , s.subject
FROM Teachers t
JOIN 
dbo.GetTopPerformingStudents() s ON t.Subject = s.Subject