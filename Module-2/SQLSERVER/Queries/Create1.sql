CREATE TABLE Marks
( Test1 int, Test2 int, 
TestAvg AS (Test1 + Test2)/2 )
insert into Marks values(80,67)
select * from Marks
CREATE TABLE Printer
(PrinterId int IDENTITY (1, 1) NOT NULL,PrinterName varchar(20))
insert into Printer values('Intex')
insert into Printer values('Samsung')

select * from Printer

CREATE TABLE Customer ( CustomerID uniqueidentifier NOT 
NULL)
INSERT INTO Customer Values (NewID()) 
INSERT INTO Customer Values (NewID()) 
INSERT INTO Customer Values (NewID()) 
INSERT INTO Customer Values (NewID()) 
select * from Customer
delete Customer where CustomerID='A294131C-CDC6-427A-9EE8-DE10882ED23B'