using DietBoost.BLL.Services;
using ProjeTaslak.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeTaslak
{
    public partial class FrmFoodSearch : Form
    {
        MealService mealService;
        FoodService foodService;
        MealDetailService mealDetailService;
        CategoryService categoryService;
        public FrmFoodSearch()
        {
            InitializeComponent();
            
            mealService = new MealService();
            foodService = new FoodService();
            mealDetailService = new MealDetailService();
            categoryService = new CategoryService();
            Reload();
        }
        private void Reload()
        {

            FillListView();
            FillCategoryComboBox();
        }

        public void FillCategoryComboBox()
        {
            cbCategories.Items.Clear();
            cbCategories.DataSource = categoryService.GetCategories();
            cbCategories.DisplayMember = "Name";
            cbCategories.ValueMember = "ID";
        }
        private void FillListView()
        {
      
        }

    }
}
