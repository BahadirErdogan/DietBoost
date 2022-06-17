using DietBoost.DAL.Repositories;
using DietBoost.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.BLL.Services
{
    public class PasswordService
    {
        PasswordRepository passwordRepository;
        public PasswordService()
        {
            passwordRepository = new PasswordRepository();
        }

        bool CheckLastThreePasswords(Password password)
        {
            List<Password> lastThreePasswords = passwordRepository.GetLastThreePasswords(password.UserID);
            foreach (var item in lastThreePasswords)
            {
                if (item.Text == password.Text) throw new Exception("New password shouldn't be similar with your last three passwords.");
            }
            return true;
        }

        public bool Insert(Password password)
        {
            if (CheckLastThreePasswords(password))
            {
                password.CreationDate = DateTime.Now;
                return passwordRepository.Insert(password);
            }
            return false;
        }

        public Password GetActivePassword(int userID)
        {
            if (userID <= 0) throw new Exception("User is invalid.");
            return passwordRepository.GetActivePassword(userID);
        }
    }
}
