select * from Project
select * from Employee
insert into Project values('P003','HealthCare')
select E.EmployeeId,E.Ename,P.ProjectName from Employee E join Project P	on E.ProjectId=P.ProjectId
select E.EmployeeId,E.Ename,P.ProjectName from Employee E left outer join Project P	on E.ProjectId=P.ProjectId
select E.EmployeeId,E.Ename,P.ProjectName from Employee E right outer join Project P	on E.ProjectId=P.ProjectId
select E.EmployeeId,E.Ename,P.ProjectName from Employee E full outer join Project P	on E.ProjectId=P.ProjectId