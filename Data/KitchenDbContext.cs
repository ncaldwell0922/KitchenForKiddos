using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KitchenForKiddosMVC.Data
{
    public class KitchenDbContext : DbContext
    {
        public KitchenDbContext(DbContextOptions<KitchenDbContext> options) : base(options) {}

        public DbSet<MealsEntity> Meals { get; set; }
        public DbSet<RecipeEntity> Recipes { get; set; }
        public DbSet<ShoppingListEntity> ShoppingLists { get; set; }
        public DbSet<WeekDefinitionEntity> WeekDefinitions { get; set; }
        public DbSet<WeeklyCalendarEntity> WeeklyCalendars { get; set; }
    }
}