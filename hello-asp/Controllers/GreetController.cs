using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hello_asp.Controllers
{
    public class GreetController : Controller
    {
        public IActionResult Index(string name)
        {
            ViewData["name"] = name;
            return View();
        }
    }
}