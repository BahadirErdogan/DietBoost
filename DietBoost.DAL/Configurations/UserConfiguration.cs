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
            
            Property(a => a.UserName).HasMaxLength(50);
            HasIndex(a => a.UserName).IsUnique();

            //İlişki
            HasMany(a => a.Meals).WithRequired(b => b.User).HasForeignKey(c => c.UserID);  
            HasMany(b=>b.Passwords).WithRequired(c=>c.User).HasForeignKey(c => c.UserID);

            //Kısıtlamalar
            Property(a => a.Phone).IsOptional();
           
            Property(c=> c.FirstName).IsRequired().HasMaxLength(50);
            Property(c => c.LastName).IsRequired().HasMaxLength(50);

            Ignore(c => c.Age);

        }
    }
}
