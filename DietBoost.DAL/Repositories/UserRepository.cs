using DietBoost.DAL.Context;
using DietBoost.Model.Entities;
using ProjeTaslak.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.DAL.Repositories
{
    public class UserRepository
    {
        DietBoostDbContext context;
        PasswordRepository passwordRepository;
        public UserRepository()
        {
            context = new DietBoostDbContext();
            passwordRepository = new PasswordRepository();
        }

        public bool Insert(User user)
        {
            context.Users.Add(user);
            return context.SaveChanges() > 0;
        }

        public bool Update(User user)
        {
            User updatedUser = context.Users.Find(user.ID);
            updatedUser.Weight = user.Weight;
            updatedUser.WeightGoal = user.WeightGoal;
            updatedUser.BirthDate = user.BirthDate;
            updatedUser.FirstName = user.FirstName;
            updatedUser.LastName = user.LastName;
            updatedUser.Gender = user.Gender;
            updatedUser.Height = user.Height;
            updatedUser.Phone = user.Phone;

            return context.SaveChanges() > 0;

        }

        public User CheckLogin(string userName, string password)
        {
            User user = context.Users.Where(a => a.UserName == userName).SingleOrDefault();
            if (user != null)
            {
                Password userPassword = passwordRepository.GetActivePassword(user.ID);
                if (userPassword != null && userPassword.Text == password)
                {
                    return user;
                }
            }
            return null;
        }

        public void UserActivated(User user)
        {
            User activatedUser = context.Users.Find(user.ID);
            activatedUser.IsActive = true;
            context.SaveChanges();
        }

        public void UserDeactivated(User user)
        {
            User deactivatedUser = context.Users.Find(user.ID);
            deactivatedUser.IsActive = false;
            context.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return context.Users.ToList();
        }

        public User GetUserById(int userID)
        {
            return context.Users.Find(userID);
        }        

    }
}
