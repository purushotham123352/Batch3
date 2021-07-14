--Create Views
Create view EmployeeView
as
Select Ename,JoinDate from Employee
select * from EmployeeView
select * from EmployeeView where Ename='Rohan'
delete from EmployeeView where Ename='Tim'
select * from Employee