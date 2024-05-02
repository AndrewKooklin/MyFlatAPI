using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFlatAPI.Controllers
{
    public class HomePageEditAPIController : Controller
    {
        public IActionResult EditTopMenuLinks()
        {
            return View();
        }
    }
}
