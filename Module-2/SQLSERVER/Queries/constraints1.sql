Create table student(studentId int primary key,
studentName varchar(20) not null,age int check(age>2 and age<17),
studentAddress varchar(20) default 'Unknown')
insert into student values(102,'Bheem',10,'Banglore')
select * from student
insert into student(studentId,studentName) values(103,'Charan')