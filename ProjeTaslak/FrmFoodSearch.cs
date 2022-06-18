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

            FillFilteredListView();
            //FillListView();
            FillCategoryComboBox();
        }

        public void FillCategoryComboBox()
        {
            List<Category> categories = categoryService.GetCategories();
            cbCategories.DataSource = categories;
            cbCategories.DisplayMember = "Name";
            cbCategories.ValueMember = "ID";
            Category category = new Category();
        }
        
        private void FillFilteredListView()
        {
            if (cbCategories.SelectedIndex > 0 && txtSearch.Text.Length <= 0) FillListViewByCategoryID();
            if (cbCategories.SelectedIndex > 0 && txtSearch.Text.Length > 0) FillListViewByCategoryIDAndSearchText();
            if (cbCategories.SelectedIndex <= 0 && txtSearch.Text.Length > 0) FillListViewBySearchText();
            if (cbCategories.SelectedIndex <= 0 && txtSearch.Text.Length <= 0) FillListView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillFilteredListView();
        }
        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillFilteredListView();
        }

        private void FillListView()
        {
            List<Food> foods = foodService.GetFoods();
            lvFoods.Items.Clear();
            foreach (var item in foods)
            {
                string[] items = { item.Name, item.Calorie.ToString(), item.Carbs.ToString(), item.Protein.ToString(), item.Fat.ToString() };
                ListViewItem lvi = new ListViewItem(items);
                lvi.Tag = item.ID;
                lvFoods.Items.Add(lvi);
            }

        }
        private void FillListViewByCategoryID()
        {
            int categoryID = 0;
            if(cbCategories.SelectedIndex >0 ) categoryID = (int)cbCategories.SelectedValue;
            List<Food> foods = foodService.GetFilteredFood(categoryID);
            lvFoods.Items.Clear();
            foreach (var item in foods)
            {
                string[] items = { item.Name, item.Calorie.ToString(), item.Carbs.ToString(), item.Protein.ToString(), item.Fat.ToString() };
                ListViewItem lvi = new ListViewItem(items);
                lvi.Tag = item.ID;
                lvFoods.Items.Add(lvi);
            }
        }
        private void FillListViewBySearchText()
        {
            string searchText = txtSearch.Text;
            List<Food> foods = foodService.GetFilteredFood(searchText);
            lvFoods.Items.Clear();
            foreach (var item in foods)
            {
                string[] items = { item.Name, item.Calorie.ToString(), item.Carbs.ToString(), item.Protein.ToString(), item.Fat.ToString() };
                ListViewItem lvi = new ListViewItem(items);
                lvi.Tag = item.ID;
                lvFoods.Items.Add(lvi);
            }
        }
        private void FillListViewByCategoryIDAndSearchText()
        {
            string searchText = txtSearch.Text;
            int categoryID = (int)cbCategories.SelectedValue;
            List<Food> foods = foodService.GetFilteredFood(searchText,categoryID);
            lvFoods.Items.Clear();
            foreach (var item in foods)
            {
                string[] items = { item.Name, item.Calorie.ToString(), item.Carbs.ToString(), item.Protein.ToString(), item.Fat.ToString() };
                ListViewItem lvi = new ListViewItem(items);
                lvi.Tag = item.ID;
                lvFoods.Items.Add(lvi);
            }
        }

        
    }
}
