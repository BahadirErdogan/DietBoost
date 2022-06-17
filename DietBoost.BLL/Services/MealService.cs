using DietBoost.DAL.Repositories;
using ProjeTaslak.Entities;
using ProjeTaslak.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.BLL.Services
{
    public class MealService
    {
        MealRepository mealRepository;
        public MealService()
        {
            mealRepository = new MealRepository();
        }
        public List<Meal> GetByUserId(int userID)
        {
            return mealRepository.GetByUserId(userID);
        }
        public bool Insert(Meal meal)
        {
            if (string.IsNullOrWhiteSpace(meal.MealType.ToString()) || string.IsNullOrWhiteSpace(meal.MealDate.ToString())) throw new Exception("Meal Type and Meal Date are required.");
            return mealRepository.Insert(meal);
        }
        public bool Update(Meal meal)
        {
            if (string.IsNullOrWhiteSpace(meal.MealType.ToString()) || string.IsNullOrWhiteSpace(meal.MealDate.ToString())) throw new Exception("Meal Type and Meal Date are required.");
            return mealRepository.Update(meal);
        }
        public List<MealType> GetMealTypes()
        {
            List<MealType> mealTypes = new List<MealType>();
            mealTypes = Enum.GetValues(typeof(MealType)).Cast<MealType>().ToList();
            return mealTypes;
        }
    }
}
