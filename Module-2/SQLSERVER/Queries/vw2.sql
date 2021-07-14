Create view EmployeeProjectView
as
select E.EmployeeId,E.Ename,E.Salary,P.ProjectId,P.ProjectName from Employee E join
Project P on E.ProjectId=P.ProjectId
select * from EmployeeProjectView
select * from EmployeeProjectView where ProjectName='PayPal'
insert into EmployeeView values(4567,'Jo',getdate(),12000)
select * from Employee