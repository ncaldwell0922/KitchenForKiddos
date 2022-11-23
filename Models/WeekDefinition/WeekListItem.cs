using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KitchenForKiddosMVC.Models.WeekDefinition
{
    public class WeekListItem
    {
        public int Id { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        [Display(Name = "Notes For The Week")]
        public string Notes { get; set; }
    }
}