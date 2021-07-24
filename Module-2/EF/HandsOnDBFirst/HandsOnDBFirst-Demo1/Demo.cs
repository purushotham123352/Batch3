using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnDBFirst_Demo1.Models;
using Microsoft.EntityFrameworkCore;
namespace HandsOnDBFirst_Demo1
{
    class Demo
    {
        static void Main()
        {
            using(TrainingContext db=new TrainingContext())
            {
               // List<StudentMaster> students = db.StudentMasters.FromSqlRaw("sp_GetStudents").ToList();
                List<StudentMaster> students = db.StudentMasters.FromSqlRaw("sp_GetStudentsByDept 10").ToList();
                foreach (var item in students)
                {
                    Console.WriteLine("{0} {1}",item.StudCode,item.StudName);
                }
            }
        }
    }
}
