using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace KitchenForKiddosMVC.Models.WeekDefinition
{
    public class WeekListItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("startdate")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("enddate")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("notes")]
        [Display(Name = "Notes For The Week")]
        public string Notes { get; set; }
    }
}