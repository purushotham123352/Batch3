Create table Project(ProjectId char(4) primary key,
ProjectName varchar(20) unique not null)
insert into Project values('P001','Processo')
insert into Project values('P002','Medykey')
select * from Project
Create table Employee(EmployeeId int primary key,
Ename varchar(20) not null,JoinDate Date check(JoinDate<=Getdate()),
Salary int check(Salary>0),
ProjectId char(4) foreign key references Project(ProjectId))
insert into Employee values(3244,'Tim','9/12/2020',23000,null)
insert into Employee(EmployeeId,Ename,JoinDate,Salary) 
values(3249,'Rohan','9/12/2020',23000)
select * from Employee
create table PrjectEmployee(RowId int identity primary key,
ProjectId char(4) foreign key references Project(ProjectId),
EmployeeId int foreign key references Employee(EmployeeId))
insert into PrjectEmployee values('P001',3244)