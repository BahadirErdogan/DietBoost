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

        /// <summary>
        /// Kullanıcı ana ekranında ; Seçilen tarihe göre meal details döndürür.(Tüm öğünler için)
        /// </summary>
        /// <param name="date"></param>
        /// <returns>List<MealDetail></returns>
        public List<MealDetail> GetMealDetailsByDate(DateTime date)
        {
            return context.MealDetails.Where(a => a.Meal.MealDate == date).ToList();
        }

       /// <summary>
       /// Yedek repo
       /// </summary>
       /// <param name="meal"></param>
       /// <returns></returns>
        public List<MealDetail> GetMealDetailsByMeal(Meal meal)
        {
            return context.MealDetails.Where(a => a.MealID == meal.ID).ToList();
        }


        /// <summary>
        /// Meal formunda; tarih ve öğün tipi seçimine göre meal details döndürür.
        /// </summary>
        /// <param name="mealDate"></param>
        /// <param name="mealType"></param>
        /// <returns>List<MealDetail></returns>
        public List<MealDetail> GetMealDetailsByMealDateAndMealType(DateTime mealDate, MealType mealType)
        {
            return context.MealDetails.Where(a => a.Meal.MealDate == mealDate && a.Meal.MealType == mealType).ToList();
        }


        /// <summary>
        /// Meal formunda güncelleme butonuna basıldığında foodId ve MealId'ye göre Meal Details döndürüp Food formunda bu meal detailsin bilgilerini kullanmak için kullanacağız. Food.Name, Quantity vb.
        /// </summary>
        /// <param name="mealId"></param>
        /// <param name="foodId"></param>
        /// <returns></returns>
        public List<MealDetail> GetMealDetailByMealIdAndFoodId(int mealId, int foodId)
        {
            List<MealDetail> mealDetails = new List<MealDetail>();
            mealDetails = context.MealDetails.Where(a => a.MealID == mealId && a.FoodID == foodId).ToList();
            return mealDetails;
        }

    }
}

