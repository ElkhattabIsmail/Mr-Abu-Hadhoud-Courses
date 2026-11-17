use C21_DB1;

SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    RANK() OVER ( ORDER BY Grade DESC) AS GradeRank
FROM 
    Students;


SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    RANK() OVER (PARTITION BY Subject ORDER BY Grade DESC) AS GradeRank  -- جزئ لي حسب المواد ورتب الداتا حسب العلامات وفي الآخر يعمل رانك للداتا
FROM 
    Students;
	--expanation :
	-- First SQL Partition Data into 3 groups by Using 'PARTITION BY Subject' .
	-- second ORDER BY Grade DESC each partition.
	-- third Rank this Data partition by partition;  SEPERATE DATA

