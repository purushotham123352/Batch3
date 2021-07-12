sp_tables
select * from Book_Master
select * from Book_Transaction
Select B.Book_Name,S.Stud_Code,S.Stud_Name,BT.Issue_Date from 
Book_Master B join Book_Transaction BT
on B.Book_code=BT.Book_Code
join Student_master S on S.Stud_Code=BT.Stud_Code