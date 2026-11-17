use C21_DB1;

-- Example 1: Select all students studying Math
SELECT *
FROM dbo.GetStudentsBySubject('Math')
-- or
where Grade >= 90;

SELECT *
FROM dbo.GetStudentsBySubject('engLish')

-- Example 2: Get the average grade of students studying Science
SELECT AVG(Grade) as Average
FROM dbo.GetStudentsBySubject('Science')
SELECT AVG(Grade) as Average
FROM dbo.GetStudentsBySubject('engLish')


-- dbo.GetStudentsBySubject Like a physical table, you can interact with it like a regular table in the database.
--dbo.GetStudentsBySubject مثل الجدول الفعلي، يمكنك التعامل معه مثل أي جدول عادي في قاعدة البيانات.
--dbo.GetStudentsBySubject Like a physical table, you can treat it like a regular table in the database.