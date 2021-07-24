create procedure sp_UpdateBook(@Book_Code numeric,
@pub_year int,@Author varchar(30))
as
begin
update Book_Master set pub_year=@pub_year,Author=@Author where Book_code=@Book_Code
end
exec sp_UpdateBook 10000001,2020,'Microsoft'