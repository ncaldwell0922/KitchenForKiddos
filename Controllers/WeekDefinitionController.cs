using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KitchenForKiddosMVC.Controllers
{
    public class WeekDefinitionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}