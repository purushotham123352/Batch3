create table customer(Region varchar(20),Phone varchar(20))
CREATE DEFAULT phone_no_default
AS '00-000-0000' 
GO
EXEC sp_bindefault phone_no_default,
'Customer.Phone' 
insert into customer(Region) values('Inida')
select * from customer