use Training
select * from Student_master
select * from Staff_Master
sp_tables
--In
select * from Staff_Master where Staff_Name in('Arvind','John','Ram')
select * from Staff_Master where Salary in(12000,22000,42000)
select * from Staff_Master where Salary not in(12000,22000,42000)
--Between
select * from staff_Master where Salary between 12000 and 30000
select * from staff_Master where Hiredate between '01.01.2001' and '12.31.2001'
select * from staff_Master where Salary not between 12000 and 30000	order by Salary