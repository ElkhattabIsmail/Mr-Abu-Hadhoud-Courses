

alter FUNCTION dbo.GetTopPerformingStudents(@Subject NVARCHAR(50) 

RETURNS @Result TABLE 
    StudentID INT,
    Name NVARCHAR(50),
    Subject NVARCHAR(50),
    Grade INT
)
AS
BEGIN

	INSERT INTO @Result (StudentID, Name, Subject, Grade)
    select * from dbo.GetTheTopStudentsBySubject(@Subject);

    RETURN;
END;

