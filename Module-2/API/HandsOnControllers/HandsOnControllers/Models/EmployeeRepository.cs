using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnControllers.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private static List<Employee> employees = new List<Employee>()
            {
                new Employee(){Eid=1,Ename="Rohan",Salary=12000},
                new Employee(){Eid=2,Ename="Suren",Salary=23000}
            };
       
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void DeleteEmployee(int eid)
        {
            Employee employee = employees.SingleOrDefault(i => i.Eid == eid);
            employees.Remove(employee); //remove employee object from the list.
        }

        public Employee GetEmployee(int eid)
        {
            Employee employee = employees.SingleOrDefault(i => i.Eid == eid);
            return employee;
        }

        public Employee GetEmployee(string name)
        {
            Employee employee = employees.SingleOrDefault(i => i.Ename == name);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
