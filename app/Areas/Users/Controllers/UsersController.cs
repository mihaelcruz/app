using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Areas.Users.Controllers
{
    [Area("Users")]
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string n)
        { // 3!= 1*2*3=6
            int num = Int16.Parse(n);
            int fact=1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            ViewBag.resultado = fact;
            return View();
        }
    }
}
