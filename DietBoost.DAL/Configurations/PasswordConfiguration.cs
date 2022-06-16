using DietBoost.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.DAL.Configurations
{
    public class PasswordConfiguration: EntityTypeConfiguration<Password>
    {
        public PasswordConfiguration()
        {
            Property(c => c.Text).IsRequired().HasMaxLength(24);
        }
    }
}
