using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesTutorial.Models;
using RazorPagesTutorial.Services;

namespace RazorPagesTutorial.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;

        public EditModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public Employee Employee { get; private set; }

        public IActionResult OnGet(int id)
        {
            Employee = employeeRepository.GetEmployee(id);

            if (Employee == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }

        public IActionResult OnPost(Employee employee)
        {
            Employee = employeeRepository.Update(employee);
            return RedirectToPage("Index");
        }
    }
}
