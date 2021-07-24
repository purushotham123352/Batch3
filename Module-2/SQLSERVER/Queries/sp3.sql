create procedure sp_AddStudent(
@Stud_Code numeric,
@Stud_Name varchar(30),
@Dept_Code numeric,
@Stud_DOb datetime,
@Address varchar(30))
as
begin
begin try
insert into Student_master values(@Stud_Code,@Stud_Name,@Dept_Code,@Stud_DOb,@Address)
end try
begin catch
print 'Error Occured'
end catch
end
exec sp_AddStudent 32334,'Rohan',10,'12.2.2010','Chennai'
exec sp_AddStudent 32335,'Karan',10,'12.2.2009','Bangalore'
exec sp_GetStudents
