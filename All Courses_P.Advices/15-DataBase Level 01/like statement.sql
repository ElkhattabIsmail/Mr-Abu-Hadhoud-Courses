



select * from Employees;

--Finds any values that start with "a"
select * from Employees
where Name like 'a%';


--Finds any values that end with "a"
select ID, FirstName from Employees
where FirstName like '%a';


--Finds any values that have "tell" in any position
select Name from Employees
where Name like '%tell%';

--	Finds any values that start with "a" and ends with "a"
select ID, FirstName from Employees
where FirstName like 'a%a';

--Finds any values that have "a" in the second position
select Name from Employees
where Name like '_a%' or Name like '_o%';

--Finds any values that have "a" in the third position
select Name from Employees
where Name like '__a%';


--Finds any values that start with "a" and are at least 3 characters in length
select ID, FirstName from Employees
where FirstName like 'a__%';

--Finds any values that start with "a" and are at least 4 characters in length
select ID, FirstName from Employees
where FirstName like 'a___%'
order by FirstName;



--Finds any values that start with "a"
select ID, FirstName from Employees
where FirstName like 'a%' or FirstName like 'b%' 
order by FirstName;