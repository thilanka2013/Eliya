using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebSite.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.Name = User.Identity.Name;
            return View();
        }
    }
}