--Like
select * from Staff_Master
--name starts with A
select * from Staff_Master where Staff_Name like 'A%'
--name ends with l
select * from staff_Master where Staff_Name like '%l'
--second char is a
select * from Staff_Master where Staff_Name like '_a%'
--first char is a or r
select * from Staff_Master where Staff_Name like '[AR]%'
select * from Staff_Master where Staff_Name not like '[AR]%'
--a is at any position
select * from Staff_Master where Staff_Name like '%a%'


