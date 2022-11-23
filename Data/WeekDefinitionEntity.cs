using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KitchenForKiddosMVC.Data
{
    public class WeekDefinitionEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateOnly StartDate { get; set; }

        [Required]
        public DateOnly EndDate { get; set; }

        [Required]
        [MaxLength(500)]
        public string Notes { get; set; }

        public virtual List<WeeklyCalendarEntity> WeeklyCalendars { get; set; } = new List<WeeklyCalendarEntity>();
    }
}