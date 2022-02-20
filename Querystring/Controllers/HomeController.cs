using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Querystring.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Querystring.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult querystring(string firstname ,string lastname)
        {
            ViewBag.fname = firstname;
            ViewBag.lname = lastname;
            return View();
        }
    }
}
