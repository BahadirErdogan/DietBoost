using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjeTaslak.Entities;

namespace DietBoost.DAL.Configurations
{
    public class MealConfiguration : EntityTypeConfiguration<Meal>
    {
        public MealConfiguration()
        {
            HasKey(a => a.MealID);
            Property(a=>a.Date).IsRequired();
        }
    }
}
