CREATE RULE country_rule
AS @country IN ('Inida', 'US', 'UK', 'Japan')
GOCreate table Table1(country varchar(20))EXEC sp_bindrule country_rule,
'Table1.country' insert into Table1 values('UK')CREATE RULE age_rule
AS @age>3 and @age<20
GO