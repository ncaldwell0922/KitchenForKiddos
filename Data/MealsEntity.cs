using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KitchenForKiddosMVC.Data
{
    public class MealsEntity
    {
        [Key]
        [Required]
        public int MealsId { get; set; }
        [Required]
        public float PrepTime { get; set; }
        [Required]
        public float TotalTime { get; set; }
        [Required]
        public int Yield { get; set; }
        [Required]
        public Ingredients Ingredients { get; set; }
        [Required]
        public string Directions { get; set; }
    }

    public enum Ingredients {eggs, milk, onions, garlic, strawberries, blueberries, pineapple, flour, bakingsoda, bakingpowder, apples, bananas, oranges, greenbeans, broccoli, spinach, sweetpotatoes, potatoes, yellowpotatoes, chicken, carrots, celery, peanutbutter, almondbutter, panko, onionpowder, garlicpowder, italianseasoning, salt, pepper, groundbeef, beef, sausage, bacon, lemon, lime, avacado, whitebread, wheatbread, cinnamon, pumpkinfilling, spaghetti, corn, penne, cheddarcheese, sourcream, creamcheese, zucchini, cauliflower, tomatoes, beets, cucumbers, butternutsquash}
}