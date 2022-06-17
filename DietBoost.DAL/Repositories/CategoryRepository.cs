using DietBoost.DAL.Context;
using ProjeTaslak.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.DAL.Repositories
{
    public class CategoryRepository
    {
        DietBoostDbContext context;
        public CategoryRepository()
        {
            context = new DietBoostDbContext();
        }

        /// <summary>
        /// Kategorileri getirir
        /// </summary>
        /// <returns></returns>
        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }
        public bool Insert(Category category)
        {
            context.Categories.Add(category);
            return context.SaveChanges() > 0;
        }

     


    }
}
