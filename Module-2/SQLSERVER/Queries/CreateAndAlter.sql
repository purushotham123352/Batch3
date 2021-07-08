use Batch3DB
CREATE TABLE Employee
( 
Employee_Code int NOT NULL,
Employee_Name varchar(40) NOT NULL,
Employee_DOB datetime NOT NULL,
Employee_EmailID varchar(20) NULL
)
alter table Employee add Employee_Salary money null
alter table Employee add Employee_Desig varchar(20)
alter table Employee drop column Employee_Desig
alter table Employee alter column Employee_Name varchar(80) not null