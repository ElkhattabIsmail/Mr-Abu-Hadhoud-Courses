-- Top statement

select distinct top 3 MonthlySalary from Employees
order by MonthlySalary desc;


--get top 3 Salary descinding 
select ID,FirstName,MonthlySalary from Employees where MonthlySalary in 
(
select distinct top 3 MonthlySalary from Employees
order by MonthlySalary desc
)
order by MonthlySalary desc; -- back and organize data

--get top 3 Salary ascinding
select  ID,FirstName,MonthlySalary from Employees where MonthlySalary in 
(
   select distinct top 3 MonthlySalary from Employees
   order by MonthlySalary asc
)
order by  MonthlySalary asc; -- back and organize data
