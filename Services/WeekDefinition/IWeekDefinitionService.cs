using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitchenForKiddosMVC.Models.WeekDefinition;

namespace KitchenForKiddosMVC.Services.WeekDefinition
{
    public interface IWeekDefinitionService
    {
        Task<List<WeekListItem>> GetAllWeeksAsync();
        
    }
}