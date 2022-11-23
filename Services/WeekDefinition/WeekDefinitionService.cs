using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitchenForKiddosMVC.Data;
using KitchenForKiddosMVC.Models.WeekDefinition;
using Microsoft.EntityFrameworkCore;

namespace KitchenForKiddosMVC.Services.WeekDefinition
{
    public class WeekDefinitionService : IWeekDefinitionService
    {
        private KitchenDbContext _context;

        public WeekDefinitionService(KitchenDbContext context)
        {
            _context = context;
        }

        public async Task<List<WeekListItem>> GetAllWeeksAsync()
        {
            List<WeekListItem> weekLists = await _context.WeekDefinitions
                .Select(w => new WeekListItem()
                {
                    Id = w.Id,
                    StartDate = w.StartDate,
                    EndDate = w.EndDate,
                    Notes = w.Notes
                }).ToListAsync();

            return weekLists;
        }
    }
}