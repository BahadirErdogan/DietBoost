using DietBoost.DAL.Repositories;
using DietBoost.Model.Entities;
using ProjeTaslak.Entities;
using ProjeTaslak.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.BLL.Services
{
    public class UserService
    {
        UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }

        public bool Insert(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName)) throw new Exception("First name and Last name informations are required.");

            Password firstPassword = user.Passwords.FirstOrDefault();
            if (firstPassword == null) throw new Exception("Please enter your password.");

            user.CreationDate = DateTime.Now;
            user.Passwords.FirstOrDefault().CreationDate = DateTime.Now;
            user.IsActive = false;
            user.UserType = UserType.Standard;
            return userRepository.Insert(user);
        }
        public bool Update(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName)) throw new Exception("First Name and Last Name informations are required.");

            return userRepository.Update(user);
        }

        public User CheckLogIn(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password)) throw new Exception("Please enter your E-mail and password.");
            return userRepository.CheckLogin(userName, password);
        }

        public void UserActivated(User user)
        {
            CheckUserId(user);
            userRepository.UserActivated(user);
        }

        void CheckUserId(User user)
        {
            if (user.ID <= 0) throw new Exception("User ID invalid.");
        }


        public void UserActivated(int id)
        {
            User user = userRepository.GetUserById(id);
            CheckUserId(user);
            userRepository.UserActivated(user);
        }
        public void UserDeactivated(int id)
        {
            User user = userRepository.GetUserById(id);
            CheckUserId(user);
            userRepository.UserDeactivated(user);
        }

        public List<User> GetAllUsers()
        {
            return userRepository.GetAllUsers();
        }
        public User GetUserById(int userID)
        {
            return userRepository.GetUserById(userID);
        }
    }
}
