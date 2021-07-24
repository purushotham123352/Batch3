create procedure sp_DeleteBook(@Book_Code numeric)
as
begin
begin try
delete from Book_Master where Book_code=@Book_Code
end try
begin catch
print 'Error Occured'
end catch
end
exec sp_DeleteBook 10000001