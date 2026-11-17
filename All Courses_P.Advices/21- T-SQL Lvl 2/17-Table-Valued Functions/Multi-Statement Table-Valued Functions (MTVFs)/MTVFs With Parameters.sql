
alter function dbo.GetTheTopStudentsBySubject
( 
	@Subject NVARCHAR(50) -- As A Parameter.
) 
RETURNS TABLE -- Return Type as a Table. Generic Table OR Fixed Table
AS
RETURN
(
    SELECT TOP 1 StudentID, Name, Subject, Grade
    FROM Students
	WHERE Subject = @Subject
	order by Grade desc
)
