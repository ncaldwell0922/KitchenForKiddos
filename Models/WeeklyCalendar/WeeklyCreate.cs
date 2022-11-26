using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace KitchenForKiddosMVC.Models.WeeklyCalendar
{
    public class WeeklyCreate
    {
        [JsonPropertyName("id")]
        public int DefinitionId { get; set; }

        [JsonPropertyName("dayofweek")]
        public Day_Of_Week Day_Of_Week { get; set; }

        [JsonPropertyName("breakfast")]
        public int BreakfastId { get; set; }

        [JsonPropertyName("lunch")]
        public int LunchId { get; set; }

        [JsonPropertyName("snack")]
        public int SnackId { get; set; }

        [JsonPropertyName("dinner")]
        public int DinnerId { get; set; }

    }

    public enum Day_Of_Week {Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday}
}