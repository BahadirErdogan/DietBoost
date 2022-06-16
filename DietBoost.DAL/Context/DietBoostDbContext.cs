using DietBoost.DAL.Configurations;
using DietBoost.DAL.Strategy;
using DietBoost.Model.Entities;
using ProjeTaslak.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.DAL.Context
{
    public class DietBoostDbContext : DbContext
    {
        public DietBoostDbContext() : base("conStr")
        {
            Database.SetInitializer(new DietBoostStrategy());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealDetail> MealDetails { get; set; }
        public DbSet<Password> Passwords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            
            modelbuilder.Configurations.Add(new CategoryConfiguration());
            modelbuilder.Configurations.Add(new FoodConfiguration());
            modelbuilder.Configurations.Add(new UserConfiguration());
            modelbuilder.Configurations.Add(new MealConfiguration());
            modelbuilder.Configurations.Add(new MealDetailCofiguration());
        }
    }
}
