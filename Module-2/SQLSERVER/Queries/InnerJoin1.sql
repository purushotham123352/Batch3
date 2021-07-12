sp_tables
select * from Student_master
select * from Student_Marks
select S1.Stud_Code,S1.Stud_Name,S2.Subject1,S2.Subject2,S2.Subject3,
(S2.Subject1+S2.Subject2+S2.Subject3) as 'Total Marks'
from Student_master S1 join Student_Marks S2 
on S1.Stud_Code=S2.Stud_Code
select S1.Stud_Code,S1.Stud_Name,S2.Subject1,S2.Subject2,S2.Subject3,
(S2.Subject1+S2.Subject2+S2.Subject3) as 'Total Marks'
from Student_master S1 join Student_Marks S2 
on S1.Stud_Code=S2.Stud_Code where S1.Address='Bangalore'
select S1.Stud_Code,S1.Stud_Name,S2.Subject1,S2.Subject2,S2.Subject3,
(S2.Subject1+S2.Subject2+S2.Subject3) as 'Total Marks'
from Student_master S1 join Student_Marks S2 
on S1.Stud_Code=S2.Stud_Code where S1.Address='Bangalore' order by Stud_Name