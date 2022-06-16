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
    public class MealDetailRepository
    {
        DietBoostDbContext context;
        public MealDetailRepository()
        {
            context = new DietBoostDbContext();
        }
        public Meal GetFoodsByMealID(DateTime mealDate, MealType mealType)
        {
            return context.Meals.Where(a => a.MealDate == mealDate && a.MealType == mealType).FirstOrDefault();
        }

        public List<Food> InsertFoodsToMeal(Meal meal, List<MealDetail>)
        {
            
        }

    }
}

