use C21_DB1;

--Common String Functions...

SELECT * FROM Contacts;
SELECT * FROM UserEmails;

SELECT STRING_AGG(Name , ',  ')as AllContactsNames from Contacts
WHERE ContactID BETWEEN 1 AND 3


🧠 That said, here's how the equivalent REGEX would look like:

If SQL Server had regex, you'd use something like:

--   ^[A-Za-z][A-Za-z0-9._-]*@leetcode\.com$

🔍 Regex Breakdown:

^ – Start of string

[A-Za-z] – First character must be a letter

[A-Za-z0-9._-]* – Followed by 0 or more allowed characters

@leetcode\.com – Must end exactly with @leetcode.com

$ – End of string



🔹 9. IIF() with LIKE, ISNUMERIC(), etc. -- short if 

Use inline conditions for string evaluation.

SELECT name, mail,
    IIF(mail LIKE '%@%.%', 'Valid Format', 'Possibly Invalid') AS EmailStatus
FROM UserEmails;

SELECT 
    mail,
    TRANSLATE(mail, '@#.-_', '     ') AS CleanedMail
FROM UserEmails;  


Extract values from a JSON-formatted string.

DECLARE @json NVARCHAR(MAX) = '{"name": "Winston", "email": "winston@leetcode.com"}';
SELECT JSON_VALUE(@json, '$.email') AS ExtractedEmail;

-- Using the LEN function to get the length of each employee's name
SELECT LEN(Name) AS NameLength FROM dbo.Employees2 where LEN(Name) > 10
GO

-- Converting employee names to uppercase using the UPPER function
SELECT UPPER(Name) AS UpperCaseName FROM dbo.Employees2
GO

-- Converting employee names to lowercase using the LOWER function
SELECT LOWER(Name) AS UpperCaseName FROM dbo.Employees2
GO

-- Extracting the first three characters of each name using SUBSTRING
SELECT SUBSTRING(Name, 1, 3) AS NameSubstring FROM dbo.Employees2
GO

-- Finding the position of '0' in each name using CHARINDEX
SELECT CHARINDEX('o', Name) AS CharPosition FROM dbo.Employees2
GO
SELECT CHARINDEX(' ','ELKHA sMAIL') AS NAMES
SELECT STUFF('ELKHA SMAIL',CHARINDEX(' ','ELKHA sMAIL') + 1 ,1,'S') AS FIXED_NAME

-- Replacing 'Sales' with 'Marketing' in department names using REPLACE
SELECT REPLACE(Department, 'Sales', 'Marketing') AS NewDepartment FROM dbo.Employees2
GO

-- Concatenating the name and department with a hyphen in between using CONCAT
SELECT CONCAT(Name, ' - ', Department) AS ConcatenatedString FROM dbo.Employees2
GO
	SELECT  ip, COUNT(*) AS 'invalid_count'
FROM logs
WHERE 
    CONCAT(' .', ip) LIKE '%.0%'
    OR
    LEN(ip) - LEN(REPLACE(ip, '.', '')) != 3
    OR
    (SELECT COUNT(*) FROM STRING_SPLIT(ip, '.') WHERE  value < 0 OR value > 255) > 0
GROUP BY ip
ORDER BY COUNT(*) DESC, ip DESC


SELECT *  FROM logs WHERE CONCAT(' .', ip) LIKE '%.0%'   -- ADD PREFIX TO ALL IPS AND COMPARED THEM.



-- Practice Exercise: Format Name and Department in a specific format using CONCAT, UPPER, and LOWER
-- Objective: Format the Name and Department columns as a single string, where names are in uppercase, and department names are in lowercase, separated by a colon (:)
SELECT CONCAT(UPPER(Name), ' : ', LOWER(Department)) AS FormattedOutput FROM dbo.Employees2
GO

-- Extracting the first 3 characters from the left side of the employee's name using LEFT
SELECT LEFT(Name, 3) AS LeftSubstring FROM dbo.Employees2
GO

-- Extracting the last 3 characters from the right side of the employee's name using RIGHT
SELECT RIGHT(Name, 3) AS RightSubstring FROM dbo.Employees2
GO

-- Removing leading spaces from the employee's name using LTRIM
SELECT LTRIM(Name) AS NameWithNoLeadingSpaces FROM dbo.Employees2
GO

-- Removing trailing spaces from the employee's name using RTRIM
SELECT RTRIM(Name) AS NameWithNoTrailingSpaces FROM dbo.Employees2
GO


-- Removing spaces from the start and end of each name using LTRIM and RTRIM
SELECT LTRIM(RTRIM(Name)) AS TrimmedName FROM dbo.Employees2
GO

-- Removing both leading and trailing spaces from the employee's name using TRIM
SELECT TRIM(Name) AS NameWithNoSpaces FROM dbo.Employees2
GO


SELECT ASCII('A') AS A, ASCII('B') AS B,   
ASCII('a') AS a, ASCII('b') AS b,  
ASCII(1) AS [1], ASCII(2) AS [2];



SET TEXTSIZE 0; -- Setting it to 0 resets the limit to the maximum size (2 GB).
-- Create variables for the character string and for the current
-- position in the string.
DECLARE @position INT, @string CHAR(8);
-- Initialize the current position and the string variables.
SET @position = 1;
SET @string = 'New Moon';
WHILE @position <= DATALENGTH(@string)
   BEGIN
   SELECT ASCII(SUBSTRING(@string, @position, 1)),
      CHAR(ASCII(SUBSTRING(@string, @position, 1)))

   SET @position = @position + 1
   END;
GO



SELECT name, 'was created on ',
    create_date,
    CHAR(13),
    name,
    'is currently ',
    state_desc
FROM sys.databases;
GO



select DIFFERENCE ( 'Smail' , '0lSeekmawilff' )  -- Difference Level 




-- MORE :

-- Absolutely! Here's a clean, organized, single-page reference for SQL Server string functions – including:

* ✅ Purpose
* 🧾 Syntax
* 🧪 Simple Example

It’s formatted for easy copy/paste or printing.

---

# ✅ SQL Server String Functions – Quick Reference

---

## 🔹 1. `ASCII`

Purpose: Returns ASCII code of the first character.
Syntax: `ASCII(character_expression)`
Example:

sql
SELECT ASCII('A'); -- Returns 65


---

## 🔹 2. `CHAR`

Purpose: Converts ASCII code to character.
Syntax: `CHAR(integer_expression)`
Example:

sql
SELECT CHAR(65); -- Returns 'A'


---

## 🔹 3. `CHARINDEX`

Purpose: Finds the starting position of a substring.
Syntax: `CHARINDEX(substring, string [, start_location])`
Example:

sql
SELECT CHARINDEX('world', 'Hello world'); -- Returns 7
SELECT CHARINDEX('@letcod.com', 'Hello world'); -- Returns 0


---

## 🔹 4. `CONCAT`

Purpose: Concatenates two or more strings.
Syntax: `CONCAT(string1, string2, ...)`
Example:

sql
SELECT CONCAT('Hello', ' ', 'world'); -- Returns 'Hello world'


---

## 🔹 5. `CONCAT_WS`

Purpose: Concatenates strings with a separator.
Syntax: `CONCAT_WS(separator, string1, string2, ...)`
Example:

sql
SELECT CONCAT_WS('-', '2023', '10', '05'); -- Returns '2023-10-05'


---

## 🔹 6. `DIFFERENCE`

Purpose: Compares strings using SOUNDEX.
Syntax: `DIFFERENCE(string1, string2)`
Example:

sql
SELECT DIFFERENCE('Smith', 'Smyth'); -- Returns 4


---

## 🔹 7. `FORMAT`

Purpose: Formats a value (locale-aware).
Syntax: `FORMAT(value, format [, culture])`
Example:

sql
SELECT FORMAT(123456789, '##-##-#####'); -- Returns '12-34-56789'


---

## 🔹 8. `LEFT`

Purpose: Gets the left part of a string.
Syntax: `LEFT(string, length)`
Example:

sql
SELECT LEFT('Hello world', 5); -- Returns 'Hello'


---

## 🔹 9. `LEN`

Purpose: Returns length of a string (excluding trailing spaces).
Syntax: `LEN(string)`
Example:

sql
SELECT LEN('Hello world'); -- Returns 11


---

## 🔹 10. `LOWER`

Purpose: Converts to lowercase.
Syntax: `LOWER(string)`
Example:

sql
SELECT LOWER('Hello World'); -- Returns 'hello world'


---

## 🔹 11. `LTRIM`

Purpose: Removes leading spaces.
Syntax: `LTRIM(string)`
Example:

sql
SELECT LTRIM('   Hello'); -- Returns 'Hello'


---

## 🔹 12. `PATINDEX`

Purpose: Finds pattern position using wildcards.
Syntax: `PATINDEX('%pattern%', string)`
Example:

sql
SELECT PATINDEX('%world%', 'Helloworld'); -- Returns 7
SELECT PATINDEX('%smail%', 'Hello world'); -- Returns 0
SELECT PATINDEX('%.%', 'Hello.wor.ld'); -- Returns 6
SELECT PATINDEX('%.%', 'Hello.wor.ld'); -- Returns 6



---

## 🔹 13. `REPLACE`

Purpose: Replaces substring occurrences.
Syntax: `REPLACE(string, old, new)`
Example:

sql
SELECT REPLACE('Hello world', 'world', ''); -- Returns 'Hello '


---

## 🔹 14. `RIGHT`

Purpose: Gets the right part of a string.
Syntax: `RIGHT(string, length)`
Example:

sql
SELECT RIGHT('Hello world', 5); -- Returns 'world'


---

## 🔹 15. `RTRIM`

Purpose: Removes trailing spaces.
Syntax: `RTRIM(string)`
Example:

sql
SELECT RTRIM('Hello   '); -- Returns 'Hello'


---

## 🔹 16. `SOUNDEX`

Purpose: Returns SOUNDEX code.
Syntax: `SOUNDEX(string)`
Example:

sql
SELECT SOUNDEX('Smith'); -- Returns 'S530'
SELECT SOUNDEX('smail');
SELECT SOUNDEX('Elkhattab');


---

## 🔹 17. `SPACE`

Purpose: Returns a string of spaces.
Syntax: `SPACE(number)`
Example:

sql
SELECT 'Hello' + SPACE(2) + 'world'; -- Returns 'Hello  world'


---

## 🔹 18. `STR`

--Purpose: Converts number to string.
--Syntax: `STR(number [, length [, decimal]])`

SELECT STR(123.456, 6, 2); -- Returns '123.46'


---

## 🔹 19. `STRING_AGG` ✅ Very Useful

Purpose: Aggregates strings with separator (GROUP BY compatible).
Syntax: `STRING_AGG(expression, separator)`
Example:

SELECT * FROM Employees;
SELECT STRING_AGG(Name, ', ') FROM Employees;
-- Returns: 'John, Jane, Alice'


---

## 🔹 20. `STRING_SPLIT` ✅ Very Useful

Purpose: Splits string into table rows.
Syntax: `STRING_SPLIT(string, separator)`
Example:

sql
SELECT value FROM STRING_SPLIT('apple,banana,orange', ',' , 1)
-- Returns: apple, banana, orange
SELECT value FROM STRING_SPLIT('1,2,3', ',',1) as Ids ,

---

## 🔹 21. `STUFF` ✅ Very Useful

Purpose: Replaces part of a string.
Syntax: `STUFF(string, start, length, new_substring)`
Example:

sql
SELECT STUFF('Hello world', 7, 1, 'N'); -- Returns 'Hello '


---

## 🔹 22. `SUBSTRING`

Purpose: Extracts substring from a string.
Syntax: `SUBSTRING(string, start, length)`
Example:

sql
SELECT SUBSTRING('Hello world', 7, 5); -- Returns 'world'


---

## 🔹 23. `TRANSLATE`

Purpose: Replaces characters using a map.
Syntax: `TRANSLATE(string, from_chars, to_chars)`
Example:

sql
SELECT TRANSLATE('2*[3+4]/{7-2}', '[]{}', '()()'); -- Returns '2*(3+4)/(7-2)'


---

 🔹 24. `TRIM`

Purpose: Removes leading/trailing characters (default: spaces).
Syntax: `TRIM([characters FROM] string)`
Example:

sql
SELECT TRIM('   Hello   '); -- Returns 'Hello'


---

## 🔹 25. `UPPER`

Purpose: Converts to uppercase.
Syntax: `UPPER(string)`
Example:

sql
SELECT UPPER('Hello world'); -- Returns 'HELLO WORLD'
