using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Interfaces.Infrastructure;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    //[Route("users/[action]")]
    [Route("users")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeesService _employeesService;

        public EmployeeController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        [Route("all")]
        public IActionResult Employees()
        {
            return View(_employeesService.GetAll());
        }

        [Route("{id}")]
        public IActionResult EmployeeDetails(int id)
        {
            //Получаем сотрудника по Id
            var employee = _employeesService.GetById(id);
            
            //Если такого не существует
            if (employee == null)
                return NotFound(); // возвращаем результат 404 Not Found
 
            //Иначе возвращаем сотрудника
            return View(employee);
        }
    }
}
