﻿using DietBoost.DAL.Repositories;
using ProjeTaslak.Entities;
using ProjeTaslak.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.BLL.Services
{
    public class MealDetailService
    {
        MealDetailRepository mealDetailRepository;

        public MealDetailService()
        {
            mealDetailRepository = new MealDetailRepository();
        }
        /// <summary>
        /// Kullanıcı ana ekranında ; Seçilen tarihe göre meal details döndürür.(Tüm öğünler için)
        /// </summary>
        /// <param name="date"></param>
        /// <returns>List<MealDetail></returns>
        public List<MealDetail> GetMealDetailsByDate(DateTime date)
        {
            return mealDetailRepository.GetMealDetailsByDate(date);
        }
        /// <summary>
        /// Meal formunda; tarih ve öğün tipi seçimine göre meal details döndürür.
        /// </summary>
        /// <param name="mealDate"></param>
        /// <param name="mealType"></param>
        /// <returns>List<MealDetail></returns>
        public List<MealDetail> GetMealDetailsByMealDateAndMealType(DateTime mealDate, MealType mealType)
        {
            if (string.IsNullOrWhiteSpace(mealType.ToString()) || mealDate > DateTime.Now)
            {
                throw new Exception("Please select meal type or select correct date.");
            }
            return mealDetailRepository.GetMealDetailsByMealDateAndMealType(mealDate, mealType);
        }
        public MealDetail GetMealDetailByMealDateAndMealType(DateTime mealDate, MealType mealType)
        {
            if (string.IsNullOrWhiteSpace(mealType.ToString()) || mealDate > DateTime.Now)
            {
                throw new Exception("Please select meal type or select correct date.");
            }
            return mealDetailRepository.GetMealDetailByMealDateAndMealType(mealDate, mealType);
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
            if(string.IsNullOrWhiteSpace(mealId.ToString()) || string.IsNullOrWhiteSpace(foodId.ToString()))
            {
                throw new Exception("Please select meal or food.");
            }
            return mealDetailRepository.GetMealDetailByMealIdAndFoodId(mealId, foodId);
        }

        /// <summary>
        /// User Id ve Meal Date e göre meal içerisindeki foodların yağlarının değerlerini toplar ve double döner.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="date"></param>
        /// <returns>double</returns>
        public double GetTotalFatFromMealsByDate(int userID, DateTime date)
        {
            return mealDetailRepository.GetTotalFatFromMealsByDate(userID, date);
        }

        /// <summary>
        /// User Id ve Meal Date e göre meal içerisindeki foodların karbonhidrat değerlerini toplar ve double döner.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="date"></param>
        /// <returns>double</returns>
        public double GetTotalCarbsFromMealsByDate(int userID, DateTime date)
        {
            return mealDetailRepository.GetTotalCarbsFromMealsByDate(userID, date);
        }

        /// <summary>
        /// User Id ve Meal Date e göre meal içerisindeki foodların proteinlerinin değerlerini toplar ve double döner.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="date"></param>
        /// <returns>double</returns>
        public double GetTotalProteinFromMealsByDate(int userID, DateTime date)
        {
            return mealDetailRepository.GetTotalProteinFromMealsByDate(userID, date);
        }

    }

}
