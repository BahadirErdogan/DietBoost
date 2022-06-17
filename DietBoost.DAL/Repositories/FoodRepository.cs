using DietBoost.DAL.Context;
using ProjeTaslak.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.DAL.Repositories
{
    public class FoodRepository
    {
        DietBoostDbContext context;
        public FoodRepository()
        {
            context = new DietBoostDbContext();
        }
        public List<Food> GetFoods()
        {
            return context.Foods.ToList();
        }

        public List<Food> GetFoodsByCategoryID(int categoryID)
        {
            return context.Foods.Where(a=>a.CategoryID == categoryID).ToList();
        }
        public Food GetByFoodId(int foodID)
        {
            return context.Foods.Find(foodID);
        }
        public bool Insert(Food food)
        {
            context.Foods.Add(food);
            return context.SaveChanges() > 0;
        }

        public bool Update(Food food)
        {
            Food updatedFood = context.Foods.Find(food.ID);
            updatedFood.Name = food.Name;
            updatedFood.Calorie = food.Calorie;
            updatedFood.Fat = food.Fat;
            updatedFood.Carbs = food.Carbs;
            updatedFood.Protein = food.Protein;
            updatedFood.PieceCalorie = food.PieceCalorie;
            updatedFood.PortionCalorie = food.PortionCalorie;
            updatedFood.Image = food.Image;

            return context.SaveChanges() > 0;
        }
        public bool FoodActivated(Food food)
        {
            Food activatedFood = context.Foods.Find(food.ID);
            activatedFood.IsActive = true;
            return context.SaveChanges() > 0;
            
        }
        public bool FoodDeactivated(Food food)
        {
            Food deactivatedFood = context.Foods.Find(food.ID);
            deactivatedFood.IsActive = false;
            return context.SaveChanges() > 0;
        }

        public List<Food> GetFilteredFood(string text)
        {
            return context.Foods.Where(a => a.Name.ToLower().Contains(text.ToLower())).ToList();
        }
    }
}
