using ProjeTaslak.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.DAL.Configurations
{
    public class MealDetailCofiguration : EntityTypeConfiguration<MealDetail>
    {
        public MealDetailCofiguration()
        {
            HasKey(a => new { a.MealID, a.FoodID });
            HasRequired(a=> a.Meal).WithMany(b=>b.MealDetails).HasForeignKey(c => c.MealID);
            HasRequired(a=> a.Food).WithMany(b=>b.MealDetails).HasForeignKey(c => c.FoodID);
        }
    }
}
