using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using hello_asp.Models;

namespace hello_asp.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            HelloModel model = new HelloModel();
            model.Name = "名無しさん";

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(HelloModel helloModel)
        {
            return View(helloModel);
        }
    }
}