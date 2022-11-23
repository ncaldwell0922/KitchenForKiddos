using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KitchenForKiddosMVC.Data
{
    public class WeeklyCalendarEntity
    {
        [Key]
        public int DefinitionId { get; set; }

        [Required]
        public Day_Of_Week Day_Of_Week { get; set; }

        [Required]
        public int BreakfastId { get; set; }

        [Required]
        public int LunchId { get; set; }

        [Required]
        public int SnackId { get; set; }
        
        [Required]
        public int DinnerId { get; set; }
        [Required]
        [ForeignKey(nameof(ShoppingListEntity))]
        public int ShoppingListId { get; set; }

        

    }

    public enum Day_Of_Week {Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday}
}