using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KitchenForKiddosMVC.Data
{
    public class ShoppingListEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Food_Items Food_Items { get; set; }
        public int Quantity { get; set; }
    }

    public enum Food_Items {eggs, milk, onions, garlic, strawberries, blueberries, pineapple, flour, bakingsoda, bakingpowder, apples, bananas, oranges, greenbeans, broccoli, spinach, sweetpotatoes, potatoes, yellowpotatoes, chicken, carrots, celery, peanutbutter, almondbutter, panko, onionpowder, garlicpowder, italianseasoning, salt, pepper, groundbeef, beef, sausage, bacon, lemon, lime, avacado, whitebread, wheatbread, cinnamon, pumpkinfilling, spaghetti, corn, penne, cheddarcheese, sourcream, creamcheese, zucchini, cauliflower, tomatoes, beets, cucumbers, butternutsquash}
}