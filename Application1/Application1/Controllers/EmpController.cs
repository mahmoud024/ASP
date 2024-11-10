using Microsoft.AspNetCore.Mvc;

namespace Application1.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form1()
        {
            return View();
        }

        public IActionResult Form2()
        {
            return View();
        }


        public string print() {
            return "Hello Mahmoud";
        }

        public int sum(int a , int b) { 
            return a + b;
        }
    }
}
