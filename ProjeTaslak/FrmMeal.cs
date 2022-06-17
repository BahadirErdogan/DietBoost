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
    public partial class FrmMeal : Form
    {
        MealService mealService;
        FoodService foodService;
        MealDetailService mealDetailService;
        public FrmMeal()
        {
            InitializeComponent();
            mealService = new MealService();
            foodService = new FoodService();
            mealDetailService = new MealDetailService();
            Reload();
        }
        private void Reload()
        {
            
            FillListView();
            lblSelectedDailyCalorieInTake.Text = CalculateSelectedDailyCalorie().ToString();
            FillMealComboBox();

        }
        public void FillMealComboBox()
        {
            cbMeals.Items.Clear();
            List<MealType> mealTypes = mealService.GetMealTypes();
            foreach (var item in mealTypes)
            {
                cbMeals.Items.Add(item.ToString());
            }
        }

        private void FillListView()
        {

            lvMealDetails.Items.Clear();
            if (cbMeals.SelectedItem != null)
            {
                MealDetail meal = mealDetailService.GetMealDetailByMealDateAndMealType(dtpDate.Value, (MealType)cbMeals.SelectedItem);
                //List<MealDetail> meals = mealDetailService.GetMealDetailsByMealDateAndMealType(dtpDate.Value, (MealType)cbMeals.SelectedItem);
                //foreach (var item in meals)
                //{
                    string[] items = { meal.Quantity.ToString(), meal.Food.Name, (meal.Food.Calorie * meal.Quantity).ToString() };
                    ListViewItem lvi = new ListViewItem(items);
                    lvi.Tag = meal.Food.Calorie * meal.Quantity;
                    lvMealDetails.Items.Add(lvi);
                //}
            }
            else return;
        }
        public decimal CalculateSelectedDailyCalorie()
        {
            decimal totalDailyCalorie = 0;
            List<MealDetail> meals = mealDetailService.GetMealDetailsByDate(dtpDate.Value);
            foreach (var item in meals)
            {
                totalDailyCalorie += item.Food.Calorie * item.Quantity;
            }
            return totalDailyCalorie;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {


            FrmFoodSearch frmFoodSearch = new FrmFoodSearch();
            this.Hide();
            frmFoodSearch.ShowDialog();
            this.Show();
            
        }
    }
}
