create table Person(Pid int not null,Pname varchar(20),Address varchar(50))
--Clustered Index
create clustered index Pid_Clustered on Person(Pid)
sp_help Person
insert into Person values(1,'Robers','Chennai')
select * from Person
--NonClustered Index
create nonclustered index Pname_nonClustured on Person(Pname)
create nonclustered index Add_nonClustured on Person(Address)
sp_helpIndex Person		 --return the indexes on a table

--Drop Index
drop index Person.Add_nonClustured
select * from Employee