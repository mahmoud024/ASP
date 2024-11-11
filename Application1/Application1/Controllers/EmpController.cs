using Microsoft.AspNetCore.Mvc;

namespace Application1.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form1(int n1, int n2)
        {
            int sum = n1 + n2;
            ViewBag.n1 = n1;
            ViewBag.n2 = n2;
            ViewBag.Sum = sum;
            return View();
        }

        public IActionResult Form2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form2(String tname,string gender , int age, string status , string note )
        {
            return View();
        }
    }
}
