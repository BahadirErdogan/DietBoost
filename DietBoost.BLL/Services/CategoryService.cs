using DietBoost.DAL.Repositories;
using ProjeTaslak.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietBoost.BLL.Services
{
    public class CategoryService
    {
        CategoryRepository categoryRepository;
        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }
        public List<Category> GetCategories()
        {
            return categoryRepository.GetCategories();
        }
        public bool Insert(Category category)
        {
            List<Category> categories = GetCategories();
            foreach (var item in categories)
            {
                if (item.Name == category.Name) throw new Exception("This category name already exists.");
            }
            return categoryRepository.Insert(category);
        }

    }
}
