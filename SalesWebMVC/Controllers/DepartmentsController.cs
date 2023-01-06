using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "MakeUp" });
            list.Add(new Department { Id = 2, Name = "Nails" });

            return View(list);
        }
    }
}
