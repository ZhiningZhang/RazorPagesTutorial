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
    public class DetailsModel : PageModel
    {
        public string message { get; set; }
        public Employee Employee { get; private set; }

        private IEmployeeRepository _employeeRepository;

        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult OnGet(int id = 1)
        {
            message = id.ToString();

            Employee = _employeeRepository.GetEmployee(id);

            if(Employee == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}
