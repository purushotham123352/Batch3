select * from Employee
insert into Employee values(1234,'John',Getdate(),12000,null)
insert into Employee(EmployeeId,Ename) values(1111,'Kim')
update Employee set ProjectId='P001' where EmployeeId=1234
update Employee set ProjectId='P002',Salary=12000 where EmployeeId=1111
update Employee set Salary=Salary+2000
Delete from Employee where EmployeeId=1111
Delete from Employee where ProjectId='P002'
Delete from Employee where ProjectId is null
												  