sp_tables
select * from Book_Transaction
select * from Student_master
select * from Book_Transaction where Stud_code=(Select Stud_Code from Student_master where 
Stud_Name='Rajesh')
select * from Staff_Master
select Max(Salary) from Staff_Master
select * from Staff_Master where Salary=(Select Max(Salary) from Staff_Master)
select * from Student_master
select * from Staff_Master
select * from Student_Master where Dept_Code in
(Select Dept_Code from Staff_Master where Staff_Name in('Arvind','Shyam'))
select Salary from Staff_Master where Dept_Code=10
select * from Staff_Master where Salary>All(select Salary from Staff_Master where Dept_Code=10)
select * from Staff_Master where Salary>(select Max(Salary) from Staff_Master where Dept_Code=10)
select Salary from Staff_Master where Dept_Code=20
select * from Staff_Master where Salary>Any(select Salary from Staff_Master where Dept_Code=20) and Dept_Code<>20
select * from Staff_Master
select * from Staff_Master where Hiredate=(select Min(HireDate) from Staff_Master)

