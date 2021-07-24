create procedure sp_GetStudents
as
begin
--Sql statemets
select * from Student_master
end
Go
--run the procedure
exec sp_GetStudents