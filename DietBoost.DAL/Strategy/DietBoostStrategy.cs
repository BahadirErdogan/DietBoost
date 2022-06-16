using DietBoost.DAL.Context;
using DietBoost.Model.Entities;
using ProjeTaslak.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.DAL.Strategy
{
    class DietBoostStrategy : CreateDatabaseIfNotExists<DietBoostDbContext>
    {


        protected override void Seed(DietBoostDbContext context)
        {
            User user = new User
            {
                FirstName = "Admin",
                LastName = "Admin",
                IsActive = true,
                CreationDate = DateTime.Now,
                UserName = "admin",
                UserType = ProjeTaslak.Enums.UserType.Admin, // İlk proje dosyasının adı kalmış!! DietBoost'u görmüyor..
            };
            user.Passwords.Add(new Password()
            {
                CreationDate = DateTime.Now,
                Text="admin1234"

            });
                
            context.Users.Add(user);
            context.SaveChanges();
        }




    }
}
