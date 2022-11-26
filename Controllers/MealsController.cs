using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitchenForKiddosMVC.Services.Meals;
using Microsoft.AspNetCore.Mvc;

namespace KitchenForKiddosMVC.Controllers
{
    public class MealsController :Controller
    {
        private readonly ILogger<MealsController> _logger;
        private IMealsService _service;

        public MealsController(ILogger<MealsController> logger, IMealsService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var mealLists = await _service.SeeAllMealsAsync();
            return View(mealLists);
        }
    }
}