


-- Merge Departments It And Engineering
select * from It_Emps
Union
select * from Engireenring_Emps
Order by FirstName ; 



select * from Active_Emps

select * from ResignedEmployees


select * from ActiveEmployees
Union
select * from ResignedEmployees

--this will remove the redundancy from the resultset (distinct results only)
select * from Departments
union 
select * from Departments;

--this will append data regardeless of any redundancy
select * from Departments
union ALL
select * from Departments;