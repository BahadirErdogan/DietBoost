using ProjeTaslak.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.DAL.Configurations
{
    public class UserConfigurations: EntityTypeConfiguration<User>
    {
        public UserConfigurations()
        {
            HasMany(a => a.Meals).WithRequired(b => b.User).HasForeignKey(c => c.UserID);
            HasKey(a => a.UserName);
            Property(a => a.Phone).IsOptional();
            Property(b=> b.Password).IsRequired().HasMaxLength(32);
            Property(c=> c.FirstName).IsRequired().HasMaxLength(50);
            Property(c => c.LastName).IsRequired().HasMaxLength(50);
            Ignore(c => c.Age);   

        }
    }
}
