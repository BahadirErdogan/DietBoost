using DietBoost.DAL.Repositories;
using ProjeTaslak.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.BLL.Services
{
    public class FoodService
    {
        FoodRepository foodRepository;
        public FoodService()
        {
            foodRepository = new FoodRepository();
        }
        /// <summary>
        /// FoodId kontrol eder. Eğer Id değeri uygun değilse hata mesajı gönderir.
        /// </summary>
        /// <param name="foodID"></param>
        void CheckFoodId(int foodID)
        {
            if (foodID <= 0) throw new Exception("Please select food.");
        }
        /// <summary>
        /// Bütün yiyecekleri içeren bir liste döndürür.
        /// </summary>
        /// <returns>List<Food></returns>
        public List<Food> GetFoods()
        {
            return foodRepository.GetFoods();
        }
        /// <summary>
        /// CategoryId'ye göre o kategoriye ait yiyecek listesi döndürür.
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        public List<Food> GetFoodsByCategoryID(int categoryID)
        {
            return foodRepository.GetFoodsByCategoryID(categoryID);
        }
        /// <summary>
        /// FoodId'ye göre o Id'ye ait yiyeceği döndürür.
        /// </summary>
        /// <param name="foodID"></param>
        /// <returns></returns>
        public Food GetByFoodId(int foodID)
        {
            CheckFoodId(foodID);
            return foodRepository.GetByFoodId(foodID);                        
        }
        /// <summary>
        /// Gerekli kontroller sağlanıp yeni bir yiyecek eklenir.
        /// </summary>
        /// <param name="food"></param>
        /// <returns>bool</returns>
        public bool Insert(Food food)
        {
            List<Food> foods = GetFoods();
            foreach (var item in foods)
            {
                if (item.Name == food.Name) throw new Exception("This food name already exists.");
               
            }
            if (string.IsNullOrWhiteSpace(food.Name)||string.IsNullOrWhiteSpace(food.Categories.Name))
            {
                throw new Exception("Please fill all requirements.");
            }
            return foodRepository.Insert(food);
        }
        /// <summary>
        /// Seçili yiyeceğin güncellemesi yapılır.
        /// </summary>
        /// <param name="food"></param>
        /// <returns>bool</returns>
        public bool Update(Food food)
        {
            List<Food> foods = GetFoods();
            CheckFoodId(food.ID);
            foreach (var item in foods)
            {
                if (item.Name == food.Name) throw new Exception("This food name already exists.");

            }
            if (string.IsNullOrWhiteSpace(food.Name) || string.IsNullOrWhiteSpace(food.Categories.Name))
            {
                throw new Exception("Please fill all requirements.");
            }           
            return foodRepository.Update(food);
        }
        /// <summary>
        /// Seçili yiyeceği Aktif'e alır.
        /// </summary>
        /// <param name="food"></param>
        /// <returns>bool</returns>
        public bool FoodActivated(Food food)
        {
            CheckFoodId(food.ID);
            return foodRepository.FoodActivated(food);
        }
        /// <summary>
        /// Seçili yiyeceği Pasif'e alır.
        /// </summary>
        /// <param name="food"></param>
        /// <returns>bool</returns>
        public bool FoodDeactivated(Food food)
        {
            CheckFoodId(food.ID);
            return foodRepository.FoodDeactivated(food);
        }
        /// <summary>
        /// Yazılan string ifadeye göre string ifadeyi içeren yiyecek listesi döndürür.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>List<Food></returns>
        public List<Food> GetFilteredFood(string text)
        {
            return foodRepository.GetFilteredFood(text);
        }

    }
    
}
