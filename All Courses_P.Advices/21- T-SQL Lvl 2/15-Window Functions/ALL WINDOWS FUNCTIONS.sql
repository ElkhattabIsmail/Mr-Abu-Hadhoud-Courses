Here’s a clean, single-page reference for **SQL Server Window (analytic) functions** (sometimes called “OVER / window functions”). I’ll list the main ones, explain their purpose, show syntax, and give a working example for each.

Window functions allow you to do calculations *over a set of rows* (“window”) relative to the current row, without collapsing rows (unlike aggregate + GROUP BY). ([dofactory.com][1])

---

## ✅ Window Functions in SQL Server – Reference & Examples

> **Syntax Template**
>
> ```sql
> <window_function>( [ expression ] )  
>   OVER (  
>     [ PARTITION BY column_list ]  
>     [ ORDER BY column_list [ ASC | DESC ] ]  
>     [ window_frame_clause ]  
>   )
> ```
>
> * `PARTITION BY` divides rows into groups
> * `ORDER BY` establishes order within each partition
> * Optional frame clause (e.g. `ROWS BETWEEN …`) refines which rows to include in the window. ([T-SQL Tutorial][2])

---

## 🔹 1. **Ranking Functions**

These assign ranks or numbers to rows within partitions.

| Function       | Purpose                                                                      | Example                                                                                                                           |
| -------------- | ---------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- |
| `ROW_NUMBER()` | Assigns a unique sequential integer to each row (ties get different numbers) | `sql SELECT EmployeeID, Salary, ROW_NUMBER() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC) AS RowNum FROM Employees; `    |
| `RANK()`       | Assigns ranks; ties get same rank but gaps appear after ties                 | `sql SELECT EmployeeID, Salary, RANK() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC) AS RankPos FROM Employees; `         |
| `DENSE_RANK()` | Similar to `RANK()`, but ranks are consecutive (no gaps)                     | `sql SELECT EmployeeID, Salary, DENSE_RANK() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC) AS DenseRank FROM Employees; ` |
| `NTILE(n)`     | Divides the partition into **n** approximately equal groups (“tiles”)        | `sql SELECT EmployeeID, Salary, NTILE(4) OVER (ORDER BY Salary DESC) AS Quartile FROM Employees; `                                |

---

## 🔹 2. **Value / Offset Functions**

These let you refer to “neighboring” rows’ values relative to the current row.

| Function                      | Purpose                                                          | Example                                                                                                                                                                             |
| ----------------------------- | ---------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `LAG(expr, offset, default)`  | Returns value from a preceding row (offset before current)       | `sql SELECT OrderDate, LAG(OrderDate,1) OVER (ORDER BY OrderDate) AS PrevDate FROM Orders; `                                                                                        |
| `LEAD(expr, offset, default)` | Returns value from a following row (offset ahead)                | `sql SELECT OrderDate, LEAD(OrderDate,1) OVER (ORDER BY OrderDate) AS NextDate FROM Orders; `                                                                                       |
| `FIRST_VALUE(expr)`           | Returns the first value in the window (based on ordering)        | `sql SELECT Salary, FIRST_VALUE(Salary) OVER (PARTITION BY Department ORDER BY Salary) AS MinSalaryInDept FROM Employees; `                                                         |
| `LAST_VALUE(expr)`            | Returns the last value in the window (based on ordering + frame) | `sql SELECT Salary, LAST_VALUE(Salary) OVER (PARTITION BY Department ORDER BY Salary ROWS BETWEEN UNBOUNDED PRECEDING AND UNBOUNDED FOLLOWING) AS MaxSalaryInDept FROM Employees; ` |
| `NTH_VALUE(expr, n)`          | Returns the n-th value in the window (if supported)              | (Note: availability depends on SQL version)                                                                                                                                         |

---

## 🔹 3. **Aggregate Functions as Window Functions**

Standard aggregate functions can be used with `OVER` to compute running totals, averages per group, etc., *while still returning a row for each input row*. ([learnsql.com][3])

| Function                    | Purpose                    | Example                                                                                                                                        |
| --------------------------- | -------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- |
| `SUM(expr)`                 | Running or partitioned sum | `sql SELECT SalesPerson, Sales, SUM(Sales) OVER (PARTITION BY Region ORDER BY SaleDate ROWS UNBOUNDED PRECEDING) AS RunningTotal FROM Sales; ` |
| `AVG(expr)`                 | Average over window        | `sql SELECT Department, Salary, AVG(Salary) OVER (PARTITION BY Department) AS AvgDeptSalary FROM Employees; `                                  |
| `COUNT(expr)` or `COUNT(*)` | Count rows in window       | `sql SELECT Department, EmployeeID, COUNT(*) OVER (PARTITION BY Department) AS DeptCount FROM Employees; `                                     |
| `MIN(expr)`                 | Minimum over window        | `sql SELECT Department, Salary, MIN(Salary) OVER (PARTITION BY Department) AS MinSalaryDept FROM Employees; `                                  |
| `MAX(expr)`                 | Maximum over window        | `sql SELECT Department, Salary, MAX(Salary) OVER (PARTITION BY Department) AS MaxSalaryDept FROM Employees; `                                  |

---

## 🔹 4. **Distribution / Relative Position Functions**

These help you understand relative standing.

| Function                                                   | Purpose                                                     | Example                                                                                                                                               |
| ---------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| `PERCENT_RANK()`                                           | (Rank - 1) / (total rows in partition - 1)                  | `sql SELECT Salary, PERCENT_RANK() OVER (PARTITION BY Department ORDER BY Salary DESC) AS Prank FROM Employees; `                                     |
| `CUME_DIST()`                                              | Cumulative distribution: proportion of rows ≤ current value | `sql SELECT Salary, CUME_DIST() OVER (PARTITION BY Department ORDER BY Salary) AS CumDist FROM Employees; `                                           |
| `PERCENTILE_CONT(percentile) WITHIN GROUP (ORDER BY expr)` | Continuous percentile (interpolated)                        | `sql SELECT DISTINCT Department, PERCENTILE_CONT(0.5) WITHIN GROUP (ORDER BY Salary) OVER (PARTITION BY Department) AS MedianSalary FROM Employees; ` |
| `PERCENTILE_DISC(percentile)`                              | Discrete percentile (chooses actual value)                  | `sql SELECT DISTINCT Department, PERCENTILE_DISC(0.5) WITHIN GROUP (ORDER BY Salary) OVER (PARTITION BY Department) AS MedianSalary FROM Employees; ` |

---

## 🔹 5. **Window Frame Clauses**

You can refine **which rows** in the partition are considered for each row’s window via `ROWS`, `RANGE`, or `GROUPS`:

* `UNBOUNDED PRECEDING`
* `CURRENT ROW`
* `n PRECEDING` / `n FOLLOWING`
* `BETWEEN ... AND ...`

Example:

```sql
SELECT
  OrderDate,
  Sales,
  SUM(Sales) OVER (
    ORDER BY OrderDate  
    ROWS BETWEEN 2 PRECEDING AND CURRENT ROW
  ) AS MovingSum_3Days
FROM Sales;
```

---

## ✅ Combined Cheat-Sheet Example

Here’s a sample query that uses several window functions together:

```sql
SELECT
  EmployeeID,
  Department,
  Salary,
  ROW_NUMBER() OVER (PARTITION BY Department ORDER BY Salary DESC) AS RowNumInDept,
  DENSE_RANK() OVER (PARTITION BY Department ORDER BY Salary DESC) AS DenseRankInDept,
  LAG(Salary, 1) OVER (PARTITION BY Department ORDER BY Salary) AS PrevSalary,
  LEAD(Salary, 1) OVER (PARTITION BY Department ORDER BY Salary) AS NextSalary,
  AVG(Salary) OVER (PARTITION BY Department) AS AvgDeptSalary,
  SUM(Salary) OVER (PARTITION BY Department ORDER BY Salary
                    ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW)
      AS RunningSumSalary
FROM Employees;
```

This single SELECT returns for each employee:

* Their rank and dense rank within department
* The previous and next salary in order
* The average salary for the department
* A running sum of salaries in the department up to that employee’s salary

