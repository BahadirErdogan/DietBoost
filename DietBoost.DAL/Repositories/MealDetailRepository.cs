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
            return context.MealDetails.Where(a => a.MealID==a.Meal.ID).ToList();
        }

        /// <summary>
        /// Meal formunda; tarih ve öğün tipi seçimine göre meal details döndürür.
        /// </summary>
        /// <param name="mealDate"></param>
        /// <param name="mealType"></param>
        /// <returns>List<MealDetail></returns>
        public List<MealDetail> GetMealDetails()
        {
            List<MealDetail> mealDetails = context.MealDetails.Where(a => a.MealID == a.Meal.ID).ToList();
            return mealDetails;
            

        }
        public List<MealDetail> GetFoodDetails()
        {
            List<MealDetail> mealDetails = context.MealDetails.Where(a => a.FoodID== a.Food.ID).ToList();
            return mealDetails;
          
        }

        public MealDetail GetMealDetailByMealDateAndMealType(DateTime mealDate, MealType mealType)
        {
            return context.MealDetails.Where(a => a.Meal.MealDate == mealDate && a.Meal.MealType == mealType).FirstOrDefault();
        }

        /// <summary>
        /// Meal formunda güncelleme butonuna basıldığında foodId ve MealId'ye göre 
        /// Meal Details döndürüp Food formunda bu meal detailsin bilgilerini kullanmak için kullanacağız. 
        /// Food.Name, Quantity vb.
        /// </summary>
        /// <param name="mealId"></param>
        /// <param name="foodId"></param>
        /// <returns></returns>
        public MealDetail GetMealDetailByMealIdAndFoodId(int mealId, int foodId)
        {
            MealDetail mealDetail = new MealDetail();
            mealDetail = context.MealDetails.Where(a => a.MealID == mealId && a.FoodID == foodId).SingleOrDefault();
            return mealDetail;
        }


        /// <summary>
        /// User Id ve Meal Date e göre meal içerisindeki foodların yağlarının değerlerini toplar ve double döner.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="date"></param>
        /// <returns>double</returns>
        public double GetTotalFatFromMealsByDate(int userID, DateTime date)
        {
            double total;

            total = Convert.ToDouble((from md in context.MealDetails
                                      join m in context.Meals on md.MealID equals m.ID
                                      join f in context.Foods on md.FoodID equals f.ID
                                      where m.MealDate == date && m.UserID == userID
                                      group md by md.MealID into g
                                      select new
                                      {

                                          Sum = g.Sum(a => a.Food.Fat)
                                      }).FirstOrDefault());

            return total;

        }

        /// <summary>
        /// User Id ve Meal Date e göre meal içerisindeki foodların karbonhidrat değerlerini toplar ve double döner.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="date"></param>
        /// <returns>double</returns>
        public double GetTotalCarbsFromMealsByDate(int userID, DateTime date)
        {
            double total;

            total = Convert.ToDouble((from md in context.MealDetails
                                      join m in context.Meals on md.MealID equals m.ID
                                      join f in context.Foods on md.FoodID equals f.ID
                                      where m.MealDate == date && m.UserID == userID
                                      group md by md.MealID into g
                                      select new
                                      {

                                          Sum = g.Sum(a => a.Food.Carbs)
                                      }).FirstOrDefault());

            return total;

        }

        /// <summary>
        /// User Id ve Meal Date e göre meal içerisindeki foodların proteinlerinin değerlerini toplar ve double döner.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="date"></param>
        /// <returns>double</returns>
        public double GetTotalProteinFromMealsByDate(int userID, DateTime date)
        {
            double total;

            total = Convert.ToDouble((from md in context.MealDetails
                                      join m in context.Meals on md.MealID equals m.ID
                                      join f in context.Foods on md.FoodID equals f.ID
                                      where m.MealDate == date && m.UserID == userID
                                      group md by md.MealID into g
                                      select new
                                      {

                                          Sum = g.Sum(a => a.Food.Protein)
                                      }).FirstOrDefault());

            return total;

        }
        public bool Insert(MealDetail mealDetail)
        {
            context.MealDetails.Add(mealDetail);
            return context.SaveChanges() > 0;
        }

      
      

    }
}

