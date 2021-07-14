sp_helptext EmployeeView
create view Student_View
with encryption
as
select StudentId,StudentName from Student
sp_helptext Student_View
sp_depends EmployeeView
