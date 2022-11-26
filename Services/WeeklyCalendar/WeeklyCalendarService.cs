using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitchenForKiddosMVC.Data;

namespace KitchenForKiddosMVC.Services.WeeklyCalendar
{
    public class WeeklyCalendarService : IWeeklyCalendarService
    {
        private KitchenDbContext _context;

        public WeeklyCalendarService(KitchenDbContext context)
        {
            _context = context;
        }

        
    }
}