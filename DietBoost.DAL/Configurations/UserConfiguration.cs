using ProjeTaslak.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.DAL.Configurations
{
    public class UserConfiguration: EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            
            Property(a => a.UserName).HasMaxLength(40);
            HasIndex(a => a.UserName);

            //İlişki
            HasMany(a => a.Meals).WithRequired(b => b.User).HasForeignKey(c => c.UserID);  
            
            //Kısıtlamalar
            Property(a => a.Phone).IsOptional();
            Property(b=> b.Password).IsRequired().HasMaxLength(32);
            Property(c=> c.FirstName).IsRequired().HasMaxLength(50);
            Property(c => c.LastName).IsRequired().HasMaxLength(50);
            Ignore(c => c.Age);

        }
    }
}
