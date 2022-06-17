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
    public partial class FrmAdminPanel : Form
    {
        UserService userService;
        FoodService foodService;
        CategoryService categoryService;
        public FrmAdminPanel()
        {
            InitializeComponent();
            userService = new UserService();
            foodService = new FoodService();
            categoryService = new CategoryService();
        }


        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            ListUsers();
            ListFoods();
            FillCategoryComboBox();
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                Food food = new Food();
                food.Name = txtFoodName.Text;
                food.Calorie = nudCalorie.Value;
                food.Fat = nudFat.Value;
                food.Carbs = nudCarbs.Value;
                food.Protein = nudProtein.Value;
                food.PieceGram = nudGramPiece.Value;
                food.PortionGram = nudGramPortion.Value;
                food.Categories.Name = cbCategory.SelectedItem.ToString();
                food.Image = txtImagePath.Text;
                foodService.Insert(food);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            try
            {
                Food food = new Food();
                food.Name = txtFoodName.Text;
                food.Calorie = nudCalorie.Value;
                food.Fat = nudFat.Value;
                food.Carbs = nudCarbs.Value;
                food.Protein = nudProtein.Value;
                food.PieceGram = nudGramPiece.Value;
                food.PortionGram = nudGramPortion.Value;
                food.Categories.Name = cbCategory.SelectedItem.ToString();
                food.Image = txtImagePath.Text;
                foodService.Update(food);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ListUsers()
        {

            lvUsers.Items.Clear();
            List<User> users = userService.GetAllUsers();

            foreach (var item in users)
            {
                string status = string.Empty;
                status = item.IsActive ? "Active" : "Passive";
                string[] items = { item.FirstName, item.LastName, item.UserName, status };
                ListViewItem lvi = new ListViewItem(items);
                lvi.Tag = item.ID;
                lvUsers.Items.Add(lvi);
            }
        }
        private void lvUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int userID = (int)lvUsers.SelectedItems[0].Tag;
            try
            {
                User user = userService.GetUserById(userID);
                if (user.IsActive == false)
                {
                    userService.UserActivated(userID);
                }
                else userService.UserDeactivated(userID);

                ListUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = txtCategoryName.Text;
            categoryService.Insert(category);
        }
        public void FillCategoryComboBox()
        {
            List<Category> categories = GetCategoryList();
            foreach (var item in categories)
            {
                cbCategory.Items.Add(item);
            }
        }

        public List<Category> GetCategoryList()
        {
            List<Category> categories = new List<Category>();
            categories = categoryService.GetCategories();
            return categories;
        }


        private void ListFoods()
        {

            lvFoods.Items.Clear();
            List<Food> foods = foodService.GetFoods();

            foreach (var item in foods)
            {
                string status = string.Empty;
                status = item.IsActive ? "Active" : "Passive";
                string[] items = { item.Name, status };
                ListViewItem lvi = new ListViewItem(items);
                lvi.Tag = item.ID;
                lvUsers.Items.Add(lvi);
            }
        }
        private void lvFoods_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int foodID = (int)lvFoods.SelectedItems[0].Tag;
            try
            {
                Food food = foodService.GetByFoodId(foodID);
                if (food.IsActive == false)
                {
                    foodService.FoodActivated(food);
                }
                else foodService.FoodDeactivated(food);

                ListFoods();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
