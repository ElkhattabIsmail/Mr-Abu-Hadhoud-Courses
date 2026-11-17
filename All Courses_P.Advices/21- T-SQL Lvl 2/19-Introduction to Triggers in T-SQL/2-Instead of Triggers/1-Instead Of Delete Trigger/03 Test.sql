-- Assuming there is a student with StudentID = 4

select * from students;
update students set IsActive = 1

-- Attempting to delete a student
DELETE FROM Students WHERE  StudentID > 7;

-- Checking the status of the student record
SELECT StudentID, Name, IsActive FROM Students WHERE StudentID = 7;
