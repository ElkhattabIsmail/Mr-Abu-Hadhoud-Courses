use C21_DB1;
SELECT * FROM Students;
--You can apply aggregate functions over a window of rows specified by the PARTITION BY clause.
SELECT StudentID, Name, Subject, Grade,
       AVG(Grade) OVER (PARTITION BY Subject) AS SubjectAvgGrade,
       SUM(Grade) OVER (PARTITION BY Subject) AS SubjectTotalGrade,
	   Max(Grade) OVER (PARTITION BY Subject) AS MaxGradePerSubject 
FROM Students 
order by subject ;

-- p2
SELECT * FROM
(
SELECT StudentID, Name, Subject, Grade,
       AVG(Grade) OVER (PARTITION BY Subject) AS SubjectAvgGrade,
       SUM(Grade) OVER (PARTITION BY Subject) AS SubjectTotalGrade,
	   Max(Grade) OVER (PARTITION BY Subject) AS MaxGradePerSubject 
FROM Students 
) T1 WHERE Grade > SubjectAvgGrade 

-- OVER () fOR NO NEEDS FOR DIVIDED DATA

-- Practice :

--, Top 1 Grade as StudentName

select * from
(
SELECT StudentID, Name, Subject, Grade,
       AVG(Grade) OVER (PARTITION BY Subject) AS SubjectAvgGrade,
       SUM(Grade) OVER (PARTITION BY Subject) AS SubjectTotalGrade,
	   Max(Grade) OVER (PARTITION BY Subject) AS MaxGradePerSubject 
FROM Students 
-- order by subject 
--Msg 1033, Level 15, State 1, Line 36
--The ORDER BY clause is invalid 
-- in views, inline functions, derived tables, subqueries, and common table expressions, unless TOP, OFFSET or FOR XML
--is also specified.
) as D1 WHERE Grade = MaxGradePerSubject 

-- P3
SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    AVG(Grade) OVER (PARTITION BY Subject) AS SubjectAvgGrade,
    SUM(Grade) OVER (PARTITION BY Subject) AS SubjectTotalGrade,
    MAX(Grade) OVER (PARTITION BY Subject) AS MaxGradePerSubject,
    FIRST_VALUE(Name) OVER (PARTITION BY Subject ORDER BY Grade DESC) AS TopStudentName
FROM Students
ORDER BY Subject;







-- FROM DEEP
SELECT 
    D1.StudentID, 
    D1.Name, 
    D1.Subject, 
    D1.Grade,
    AVG(D1.Grade) OVER (PARTITION BY D1.Subject) AS SubjectAvgGrade,
    SUM(D1.Grade) OVER (PARTITION BY D1.Subject) AS SubjectTotalGrade,
    MAX(D1.Grade) OVER (PARTITION BY D1.Subject) AS MaxGradePerSubject,
    (
        SELECT TOP 1 D2.Name
        FROM Students D2
        WHERE D2.Subject = D1.Subject
        ORDER BY D2.Grade DESC
    ) AS TopStudentName
FROM Students D1
ORDER BY D1.Subject;

--Explanation:
--Subquery:

--The subquery (SELECT TOP 1 D2.Name ...) fetches the name of the top student for each subject.

--It correlates with the outer query using D2.Subject = D1.Subject.

--Window Functions:

--AVG(), SUM(), and MAX() are used to calculate the average, total, and maximum grade for each subject.

--Ordering:

--The final result is ordered by Subject.