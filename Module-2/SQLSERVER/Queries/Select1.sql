use Training
sp_tables
select 	* from Student_Master
select Stud_Name,Address from Student_master
select top 10 * from Student_master
select * from Student_master where Address='Bangalore'
select * from Student_master where Dept_Code=40
select * from Student_master where Stud_Code=1010
select * from Student_master where Address='Chennai' and Dept_Code=20
select * from Student_master where Address='Chennai' or Address='Bangalore'
select * from Student_Marks
select * from Student_Marks where Subject1<60
select * from Student_Master where Address <>'Chennai'

