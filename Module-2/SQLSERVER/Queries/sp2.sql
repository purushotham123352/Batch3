create procedure sp_GetStudentsByDept(@DeptCode numeric)
as
begin
select * from Student_Master where Dept_Code=@DeptCode
end
exec sp_GetStudentsByDept 10
exec sp_GetStudentsByDept @DeptCode=20