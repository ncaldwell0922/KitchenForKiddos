using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitchenForKiddosMVC.Models.Meals;

namespace KitchenForKiddosMVC.Services.Meals
{
    public interface IMealsService
    {
        Task<List<MealsViewModel>> SeeAllMealsAsync();
    }
}