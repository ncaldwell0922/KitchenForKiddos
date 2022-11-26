using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using KitchenForKiddosMVC.Services.WeekDefinition;

namespace KitchenForKiddosMVC.Controllers
{
    public class WeekDefinitionController : Controller
    {
        private readonly ILogger<WeekDefinitionController> _logger;
        private IWeekDefinitionService _service;

        public WeekDefinitionController(ILogger<WeekDefinitionController> logger, IWeekDefinitionService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var weekLists = await _service.GetAllWeeksAsync();
            return View(weekLists); 
        }
    }
}