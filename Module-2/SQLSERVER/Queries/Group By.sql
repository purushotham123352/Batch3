use Training
select * from student_Master
--Group by
select Address as City,COUNT(Stud_Code) from Student_master group by Address
select Address as City,COUNT(Stud_Code) 'Students' from Student_master where Address is not null group by Address
select Address as City,COUNT(Stud_Code)  as 'Students' from Student_master where Address is not null group by Address having COUNT(Stud_Code) >1
select Address as City,COUNT(Stud_Code)  as 'Students' from Student_master where Address is not null group by Address having COUNT(Stud_Code) =1
select * from staff_Master
select Salary,COUNT(Staff_Code) as 'Staff Count' from Staff_Master group by Salary
select Dept_Code,Sum(Salary) as 'Total Salary' from Staff_Master group by Dept_Code
select Dept_Code,COUNT(Staff_code) as 'Staff Count' from staff_Master group by Dept_Code   order by 'Staff Count'
