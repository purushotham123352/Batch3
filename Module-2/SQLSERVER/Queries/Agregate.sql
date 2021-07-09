--Agrigate Functions
--return no of recors
select * from Staff_Master
select count(*) as 'Total Staff'  from Staff_Master
select count(*) from Staff_Master where Salary=12000 
select count(Staff_Code) from staff_Master
--Sum
Select SUM(Salary) as 'Total Salary' from Staff_Master where Dept_Code=10
Select SUM(Salary) as 'Total Salary' from Staff_Master where Dept_Code in(10,20)
--Max
Select Max(Salary) from Staff_Master
select Max(Salary) from Staff_Master where Dept_Code=10
select Max(Hiredate) as 'Min exp' from Staff_Master
--Min
Select Min(Salary) from Staff_Master
select Min(Salary) from Staff_Master where Dept_Code=10
select Min(Hiredate) as 'Max Exp' from Staff_Master
select * from Staff_Master where Hiredate=(Select Min(Hiredate)	 from Staff_Master)
--Avg
Select Avg(Salary) from Staff_Master
select Avg(Salary) from Staff_Master where Dept_Code=10