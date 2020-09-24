using RazorPagesTutorial.Models;
using System;
using System.Collections.Generic;

namespace RazorPagesTutorial.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
    }
}
