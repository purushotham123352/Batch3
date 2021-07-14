--Global variables
select @@VERSION
select @@SERVERNAME
--Local variable
--variable declaration
declare @a int
--assign value
set @a=1
declare @ename varchar(20)
set @ename='John'
declare @sid int
declare @sname varchar(20)
declare @age int
--set value to multiple variables
select @sid=1,@sname='Charan',@age=10
declare @m int,@n int
select @m=10,@n=20
select @m,@n
print @m
print @n