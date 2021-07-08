CREATE SEQUENCE mySeq
START WITH 10
INCREMENT BY 5
Go
create table myTable
(sid int, Sname varchar(15))INSERT INTO myTable(sid, sname)
VALUES (NEXT VALUE FOR mySeq, 'Tom');
INSERT INTO myTable(sid, sname)
VALUES (NEXT VALUE FOR mySeq, 'Moody');
INSERT INTO myTable(sid, sname)
VALUES (120, 'Moody');
select * from myTable