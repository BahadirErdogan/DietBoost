using DietBoost.BLL.Services;
using ProjeTaslak.Entities;
using ProjeTaslak.Enums;
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
        User user;
        Meal meal;
        MealDetail mealDetail;
        public FrmFoodSearch(User _user,Meal _meal)
        {
            InitializeComponent();
            btnAddFood.Text = "Add";
            mealService = new MealService();
            foodService = new FoodService();
            mealDetailService = new MealDetailService();
            categoryService = new CategoryService();
            user = _user;
            Reload();
            meal = _meal;
        }

        public FrmFoodSearch(User _user, MealDetail _mealDetail)
        {
            btnAddFood.Text = "Update";
            mealDetail = _mealDetail;
        }

        private void Reload()
        {

            FillFilteredListView();
            //FillListView();
            FillCategoryComboBox();
            FillPortionTypeComboBox();
        }

        public void FillCategoryComboBox()
        {
            List<Category> categories = categoryService.GetCategories();
            cbCategories.DataSource = categories;
            cbCategories.DisplayMember = "Name";
            cbCategories.ValueMember = "ID";
            Category category = new Category();//Bunu berke sor.
        }
        public void FillPortionTypeComboBox()
        {
            cbPortionType.Items.Clear();
            List<PortionType> portionTypes = mealDetailService.GetPortionTypes();
            foreach (var item in portionTypes)
            {
                cbPortionType.Items.Add(item.ToString());
            }
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


        private void btnAddFood_Click(object sender, EventArgs e)
        {
            MealDetail mealDetail = new MealDetail();
            //mealDetail.Food.Name=(lvFoods.SelectedItems[0].Text);
            mealDetail.FoodID = (int)lvFoods.SelectedItems[0].Tag;
            mealDetail.Quantity = (int)nudQuantity.Value;
            mealDetail.PortionType = GetPortionTypeFromComboBox();
            mealDetail.MealID = meal.ID;
            mealDetailService.Insert(mealDetail);
           
        }
        public PortionType GetPortionTypeFromComboBox()
        {
            PortionType portionType;

            switch (cbPortionType.SelectedIndex)
            {
                case 0:
                    portionType = PortionType.Gram;
                    break;
                case 1:
                    portionType = PortionType.Portion;
                    break;
                default:
                    portionType = PortionType.Piece;
                    break;
            }

            return portionType;

        }
    }
}
