using ProjeTaslak.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.DAL.Configurations
{
    public class FoodConfiguration : EntityTypeConfiguration<Food>
    {
        public FoodConfiguration()
        {

            HasKey(a => a.FoodId);
            Property(a => a.Name).IsRequired().HasMaxLength(50);
                            
            HasRequired(a => a.Categories).WithMany(a => a.Foods).HasForeignKey(a => a.CategoryID);

        }
        
    }
}
