--Date Functions
select GetDate()
select Year(GetDate())
select Year('12.2.2000')
select Month('12.2.2000')
select Day('12.2.2000')
select DatePart(yy,'12.2.2000')
select DATEPART(mm,'12.2.2000')
select DatePart(dd,'12.2.2000')
select DatePart(dw,GetDate())
select DatePart(hh,Getdate())
create table Tabl1(col1 date,col2 datetime)
insert into Tabl1 values(Getdate(),getdate())
select * from Tabl1
select * from Staff_Master where Year(HireDate)=2001
select Staff_Name,year(HireDate) as 'JoinedYear' from Staff_Master
select DATEDIFF(yy,'12.2.1990',GetDate())
select DATEDIFF(mm,'12.2.1990',GetDate())
select DATEDIFF(dd,'12.2.1990',GetDate())
select Staff_Name,DATEDIFF(yy,HireDate,GetDate()) as 'Exp' from Staff_Master
select DATENAME(dw,GetDate())
select DATENAME(mm,GetDate())
select DATENAME(dw,'12.2.1989')
select ISDATE('sdd')
select ISDATE('12.2.2000')