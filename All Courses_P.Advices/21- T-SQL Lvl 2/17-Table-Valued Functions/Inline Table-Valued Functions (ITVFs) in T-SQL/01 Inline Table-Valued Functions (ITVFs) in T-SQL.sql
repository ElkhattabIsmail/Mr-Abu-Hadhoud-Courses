
ALTER FUNCTION dbo.GetStudentsBySubject
(
    @Subject NVARCHAR(50) -- As A Parameter.
)
RETURNS TABLE -- Return Type as a Table. Generic Table OR Fixed Table
AS
RETURN  -- Any Select Statement.
(
	-- Support Single Select Statement the ITVFs.
    SELECT *
    FROM Students
    WHERE Subject = @Subject
	-- Like a parameterized view.
)