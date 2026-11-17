
-- Assuming there is a student with StudentID = 110 in the Students table

 select * from students;

-- Deleting a student
DELETE FROM Students WHERE StudentID = 7;

-- Note : the after delete Trigger behavior do not work correctly when we use the instead delete ! 

-- Checking the delete log table
SELECT * FROM StudentDeleteLog;