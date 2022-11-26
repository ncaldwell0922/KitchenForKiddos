using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitchenForKiddosMVC.Data;
using KitchenForKiddosMVC.Models.Meals;
using Microsoft.EntityFrameworkCore;

namespace KitchenForKiddosMVC.Services.Meals
{
    public class MealsService : IMealsService
    {
        private KitchenDbContext _context;

        public MealsService(KitchenDbContext context)
    {
        _context = context;
    }

    public async Task<List<MealsViewModel>> SeeAllMealsAsync()
    {
        List<MealsViewModel> mealLists = await _context.Meals
            .Select(m => new MealsViewModel()
            {
                Id = m.Id,
                Name = m.Name
            }).ToListAsync();

        return mealLists;
    }
    }
}