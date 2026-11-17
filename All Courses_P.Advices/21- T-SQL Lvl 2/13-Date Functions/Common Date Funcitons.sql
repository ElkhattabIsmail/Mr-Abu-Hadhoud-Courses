use C21_DB1;

-- Common Date funcitons:

-- Getting the current system date and time
SELECT GETDATE() AS CurrentDateTime
GO

-- Getting the system date and time with fractional seconds and time zone offset
SELECT SYSDATETIME() AS SystemDateTime    -- high Precision .
GO

-- Adding 10 days to the current date
-- u can add Months or years  ,seconds munites millisecondes...
SELECT DATEADD(MILLISECOND, 60000, GETDATE()) AS DatePlus10Days
GO

-- Calculating the difference in days between two dates
SELECT DATEDIFF(day, '2023-01-01', GETDATE()) AS DaysSinceStartOfYear
GO

-- Extracting the year part from the current date
SELECT DATEPART(year, GETDATE()) AS CurrentYear
GO

-- Getting the name of the current month
SELECT DATENAME(month, GETDATE()) AS CurrentMonthName
GO

-- Extracting the day from the current date
SELECT DAY(GETDATE()) AS CurrentDay
GO

-- Extracting the month from the current date
SELECT MONTH(GETDATE()) AS CurrentMonth
GO

-- Extracting the year from the current date
SELECT YEAR(GETDATE()) AS CurrentYear
GO

-- Converting a datetime to a different format,The third argument, 103, specifies the style code for the conversion. 
--In SQL Server, style code 103 represents the date format as DD/MM/YYYY. 
--This means that the resulting string will have the day, then the month, and finally the year, separated by forward slashes.
SELECT CONVERT(varchar, GETDATE(), 103) AS DateInDDMMYYYY
GO

-- Casting a datetime to a different data type
SELECT CAST(GETDATE() AS date) AS DateOnly
GO

-- Getting the last day of the current month
SELECT EOMONTH(GETDATE()) AS LastDayOfCurrentMonth
GO


-- Thanks! Here's a well-organized, copy-friendly single-page reference for SQL Server date and time functions, including:

* Description
* Syntax
* A simple example

---

# ✅ SQL Server Date & Time Functions – Quick Reference

---

## 🔹 1. System Date and Time Functions (High Precision)

| Function              | Description                             | Example                       |
| --------------------- | --------------------------------------- | ----------------------------- |
| `SYSDATETIME()`       | Returns current date/time (no timezone) | `SELECT SYSDATETIME();`       |
| `SYSDATETIMEOFFSET()` | Returns current date/time with timezone | `SELECT SYSDATETIMEOFFSET();` |
| `SYSUTCDATETIME()`    | Returns current UTC date/time           | `SELECT SYSUTCDATETIME();`    |

---

## 🔹 2. System Date and Time Functions (Lower Precision)

| Function            | Description                       | Example                     |
| ------------------- | --------------------------------- | --------------------------- |
| `GETDATE()`         | Returns current date/time (local) | `SELECT GETDATE();`         |
| `GETUTCDATE()`      | Returns current UTC date/time     | `SELECT GETUTCDATE();`      |
| `CURRENT_TIMESTAMP` | ANSI equivalent of `GETDATE()`    | `SELECT CURRENT_TIMESTAMP;` |
| `CURRENT_DATE`      | Returns current date only         | `SELECT CURRENT_DATE;`      |

---

## 🔹 3. Extracting Parts of Date/Time

| Function                          | Description                             | Example                                       |
| --------------------------------- | --------------------------------------- | --------------------------------------------- |
| `YEAR(date)`                      | Gets the year                           | `SELECT YEAR('2025-09-30');`                  |
| `MONTH(date)`                     | Gets the month                          | `SELECT MONTH('2025-09-30');`                 |
| `DAY(date)`                       | Gets the day                            | `SELECT DAY('2025-09-30');`                   |
| `DATENAME(part, date)`            | Returns date part name (e.g., 'Monday') | `SELECT DATENAME(weekday, GETDATE());`        |
| `DATEPART(part, date)`            | Returns numeric date part               | `SELECT DATEPART(weekday, GETDATE());`        |
| `DATETRUNC(part, date)`           | Truncates to a date part                | `SELECT DATETRUNC(month, GETDATE());`         |
| `DATE_BUCKET(part, number, date)` | Buckets into intervals                  | `SELECT DATE_BUCKET(month, 2, '2025-09-30');` |

---

## 🔹 4. Building Dates from Parts

| Function                       | Description             | Example                                                       |
| ------------------------------ | ----------------------- | ------------------------------------------------------------- |
| `DATEFROMPARTS(y, m, d)`       | Builds a date           | `SELECT DATEFROMPARTS(2025, 9, 30);`                          |
| `DATETIMEFROMPARTS(...)`       | Builds `datetime`       | `SELECT DATETIMEFROMPARTS(2025, 9, 30, 14, 30, 45, 123);`     |
| `DATETIME2FROMPARTS(...)`      | Builds `datetime2`      | `SELECT DATETIME2FROMPARTS(2025,9,30,14,30,45,1234567,7);`    |
| `DATETIMEOFFSETFROMPARTS(...)` | Builds `datetimeoffset` | `SELECT DATETIMEOFFSETFROMPARTS(2025,9,30,14,30,45,0,2,0,7);` |
| `SMALLDATETIMEFROMPARTS(...)`  | Builds `smalldatetime`  | `SELECT SMALLDATETIMEFROMPARTS(2025, 9, 30, 14, 30);`         |
| `TIMEFROMPARTS(...)`           | Builds a `time` value   | `SELECT TIMEFROMPARTS(14, 30, 45, 0, 0);`                     |

---

## 🔹 5. Date Arithmetic and Modification

| Function                     | Description                     | Example                                                      |
| ---------------------------- | ------------------------------- | ------------------------------------------------------------ |
| `DATEDIFF(part, start, end)` | Diff in datepart units          | `SELECT DATEDIFF(day, '2025-09-01', '2025-09-30');`          |
| `DATEDIFF_BIG(...)`          | Like above but returns `BIGINT` | `SELECT DATEDIFF_BIG(millisecond, '2020-01-01', GETDATE());` |
| `DATEADD(part, value, date)` | Adds to a date                  | `SELECT DATEADD(day, 5, '2025-09-30');`                      |
| `EOMONTH(date)`              | Last day of month               | `SELECT EOMONTH('2025-09-15');`                              |
| `EOMONTH(date, offset)`      | Last day with offset months     | `SELECT EOMONTH('2025-09-15', 1);`                           |

---

## 🔹 6. Time Zone Conversion

| Function                               | Description                    | Example                                               |
| -------------------------------------- | ------------------------------ | ----------------------------------------------------- |
| `SWITCHOFFSET(datetimeoffset, offset)` | Changes timezone               | `SELECT SWITCHOFFSET(SYSDATETIMEOFFSET(), '-05:00');` |
| `TODATETIMEOFFSET(datetime2, offset)`  | Converts datetime2 → offset    | `SELECT TODATETIMEOFFSET(SYSDATETIME(), '+02:00');`   |
| `AT TIME ZONE`                         | Converts using named time zone | `SELECT SYSDATETIMEOFFSET() AT TIME ZONE 'UTC';`      |

---

## 🔹 7. Date Formatting and Conversion

| Function                      | Description                    | Example                                                  |
| ----------------------------- | ------------------------------ | -------------------------------------------------------- |
| `FORMAT(value, format)`       | Formats date/time as string    | `SELECT FORMAT(GETDATE(), 'yyyy-MM-dd');`                |
| `CAST(value AS type)`         | Converts between types         | `SELECT CAST(GETDATE() AS date);`                        |
| `CONVERT(type, value, style)` | Converts with style formatting | `SELECT CONVERT(varchar, GETDATE(), 103); -- dd/mm/yyyy` |

---

## 🔹 8. Session Date Format Settings

| Function / Command          | Description                    | Example                      |
| --------------------------- | ------------------------------ | ---------------------------- |
| `@@DATEFIRST`               | First weekday setting          | `SELECT @@DATEFIRST;`        |
| `SET DATEFIRST n`           | Set first weekday (1 = Monday) | `SET DATEFIRST 1;`           |
| `SET DATEFORMAT mdy`        | Set input date format          | `SET DATEFORMAT dmy;`        |
| `@@LANGUAGE`                | Current session language       | `SELECT @@LANGUAGE;`         |
| `SET LANGUAGE 'us_english'` | Change session language        | `SET LANGUAGE 'us_english';` |
| `sp_helplanguage`           | View all language settings     | `EXEC sp_helplanguage;`      |

---

## 🔹 9. Validation

| Function             | Description                     | Example                        |
| -------------------- | ------------------------------- | ------------------------------ |
| `ISDATE(expression)` | Returns 1 if valid date, else 0 | `SELECT ISDATE('2025-09-30');` |




















| Function             | Description                     | Example                        |
| -------------------- | ------------------------------- | ------------------------------ |
| `ISDATE(expression)` | Returns 1 if valid date, else 0 | `SELECT ISDATE('2025-09-30');` |
