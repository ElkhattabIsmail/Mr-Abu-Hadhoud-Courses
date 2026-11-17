
use C21_DB1;
SELECT * FROM Students;
-- Inserting a new student
INSERT INTO Students (StudentID, Name, Subject, Grade)
VALUES (10, 'ALi Doe', 'Mathematics', 75);
-- every insert in students , there is an event added a records on StudentInsertLog too.
-- Checking the log table
SELECT * FROM StudentInsertLog;