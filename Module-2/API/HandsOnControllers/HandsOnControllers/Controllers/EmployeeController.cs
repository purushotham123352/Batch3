﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnControllers.Models;
namespace HandsOnControllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeRepository repository;
        public EmployeeController()
        {
            repository = new EmployeeRepository();
        }
        //Get All Employees
        [HttpGet]
        [Route("GetEmployees")]
        public List<Employee> GetEmployees()
        {
            return repository.GetEmployees();
        }
        //Get Employee By Id
        [HttpGet]
        [Route("GetEmployeeById/{eid}")]
        public Employee GetEmployee(int eid)
        {
            return repository.GetEmployee(eid);
        }
       [Route("GetEmployeeByName/{name}")]
        public Employee GetEmployee(string name)
        {
            return repository.GetEmployee(name);
        }
        //Add New Employee
        [HttpPost]
        [Route("AddEmployee")]
        public string AddEmployee(Employee employee)
        {
           repository.AddEmployee(employee);
            return "Employee Added";
        }
        [HttpDelete("{eid}")]
        public string DeleteEmployee(int eid)
        {
            repository.DeleteEmployee(eid);
            return "Employee Deleted";
        }

    }
}
