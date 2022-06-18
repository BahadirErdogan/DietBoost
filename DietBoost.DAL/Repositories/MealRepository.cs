using DietBoost.DAL.Context;
using ProjeTaslak.Entities;
using ProjeTaslak.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.DAL.Repositories
{
    public class MealRepository
    {
        DietBoostDbContext context;
        public MealRepository()
        {
            context = new DietBoostDbContext();
        }
        public List<Meal> GetByUserId(int userID)
        {
            return context.Meals.Where(a => a.UserID == userID).ToList();
        }
        public Meal GetByNoteId(int noteID)
        {
            return context.Meals.Find(noteID);
        }
        public bool Insert(Meal meal)
        {
            context.Meals.Add(meal);
            return context.SaveChanges() > 0;
        }
        public bool Update(Meal meal)
        {
            Meal updatedMeal = context.Meals.Find(meal.ID);
            updatedMeal.MealType = meal.MealType;
            updatedMeal.MealDate = meal.MealDate;
            
            return context.SaveChanges() > 0;
        }






    }
}
