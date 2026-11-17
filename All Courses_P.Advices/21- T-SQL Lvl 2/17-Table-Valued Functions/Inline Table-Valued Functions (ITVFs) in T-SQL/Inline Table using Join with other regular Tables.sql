-- Example 1: Join Students and Teachers based on shared subject
SELECT s.StudentID, s.Name AS StudentName, t.Name AS TeacherName, s.Grade
FROM dbo.GetStudentsBySubject('Math') s
JOIN Teachers t ON s.Subject = t.Subject