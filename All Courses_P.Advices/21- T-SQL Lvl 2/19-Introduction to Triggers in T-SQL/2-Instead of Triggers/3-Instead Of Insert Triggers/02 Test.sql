
INSERT INTO StudentView (StudentID, Name, Address, Course, Grade)
VALUES (3, 'abbas', '789 Pine Rd', 'Physics', 50);


SELECT * FROM PersonalInfo WHERE StudentID = 3;
SELECT * FROM AcademicInfo WHERE StudentID = 3;
