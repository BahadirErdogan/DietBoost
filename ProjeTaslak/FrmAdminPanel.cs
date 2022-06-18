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
            //Reload();
            ListUsers();
            ListFoods();
            FillCategoryComboBox();
        }
        private void Reload()
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
                food.CategoryID = (int)cbCategory.SelectedValue;
                food.Image = txtImagePath.Text;
                food.CreationDate = DateTime.Now.Date;
                foodService.Insert(food);
                MessageBox.Show("Food added successfully.");
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
                food.Category.Name = cbCategory.SelectedValue.ToString();
                food.Image = txtImagePath.Text;
                foodService.Update(food);
                MessageBox.Show("Food updated successfully.");
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

                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text)) MessageBox.Show("Failed.");
            else
            {
                Category category = new Category();
                category.Name = txtCategoryName.Text;
                category.CreationDate = DateTime.Now.Date;

                categoryService.Insert(category);
                FillCategoryComboBox();
                MessageBox.Show("Category is successfully added to the list.");
            }
            
            
        }
        public void FillCategoryComboBox()
        {
            List<Category> categories = categoryService.GetCategories();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "ID";
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
                lvFoods.Items.Add(lvi);
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

                Reload();
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

        private void btnReloadFoodList_Click(object sender, EventArgs e)
        {
            ListFoods();
        }
    }
}
