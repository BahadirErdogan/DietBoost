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
        MealDetailService mealDetailService;
        User user;
        Meal meal;

        public FrmMeal(User _user)
        {
            InitializeComponent();
            user = _user;
            mealService = new MealService();
            mealDetailService = new MealDetailService();
        }

        private void FrmMeal_Load(object sender, EventArgs e)
        {
            FillMealComboBox();
            FillListView();
            lblSelectedMealTotalCalorie.Text = CalculateSelectedDailyCalorie().ToString();

        }

        private void cbMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListView();
            lblSelectedMealTotalCalorie.Text = CalculateSelectedDailyCalorie().ToString();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            FillListView();
            lblSelectedMealTotalCalorie.Text = CalculateSelectedDailyCalorie().ToString();
        }


        /// <summary>
        /// Meal comboxına mealtype enum'ı içindeki öğünleri doldurur.
        /// </summary>
        public void FillMealComboBox()
        {
            cbMeals.Items.Clear();
            List<MealType> mealTypes = mealService.GetMealTypes();
            foreach (var item in mealTypes)
            {
                cbMeals.Items.Add(item.ToString());
            }
        }

        /// <summary>
        /// ListView'i doldurur.
        /// </summary>
        private void FillListView()
        {
            
            lvMealDetails.Items.Clear();
            MealType mealType = GetMealTypeFromComboBox();


            if (cbMeals.SelectedIndex >0)
            {

                List<MealDetail> mealDetails = mealDetailService.GetMealDetailsByMealDateAndMealType(dtpDate.Value, mealType);

                ListViewItem lvi;
                

                foreach (var item in mealDetails)
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.Quantity.ToString();
                    lvi.SubItems.Add(item.Food.Name);
                    lvi.SubItems.Add(item.TotalCalorie.ToString());
                    lvMealDetails.Items.Add(lvi);
                }
            }
            
        }

        /// <summary>
        /// Seçili tarih ve öğündeki alınan toplam kaloriyi döndürür.
        /// </summary>
        /// <returns>decimal</returns>
        public decimal CalculateSelectedDailyCalorie()
        {
            MealType mealType = GetMealTypeFromComboBox();
            decimal totalDailyCalorie = 0;
            List<MealDetail> meals = mealDetailService.GetMealDetailsByMealDateAndMealType(dtpDate.Value, mealType);
            if(cbMeals.SelectedIndex > 0)
            {
               foreach (var item in meals)
                {
                totalDailyCalorie += item.TotalCalorie;
                }
            
            }
            return totalDailyCalorie;

        }


        /// <summary>
        /// Combobox'da seçilen öğüne göre MealType tipinde mealtype döner. (FillListView içeriisndeki serviste kullanıldı.)
        /// </summary>
        /// <returns></returns>
        public MealType GetMealTypeFromComboBox()
        {
            MealType mealType=new MealType();

            switch (cbMeals.SelectedIndex)
            {
                case 1:
                    mealType = MealType.Breakfast;
                    break;
                case 2:
                    mealType = MealType.Elevenses;
                    break;
                case 3:
                    mealType = MealType.Lunch;
                    break;
                case 4:
                    mealType = MealType.Snack;
                    break;
                case 5:
                    mealType = MealType.Dinner;
                    break;
                    
            }
            return mealType;


        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Meal meal= new Meal();
            meal.MealDate=dtpDate.Value;
            meal.MealType=GetMealTypeFromComboBox();
            meal.UserID = user.ID;
            meal.CreationDate=DateTime.Now;




            mealService.Insert(meal);
            FrmFoodSearch frmFoodSearch = new FrmFoodSearch(user,meal);
            this.Hide();
            frmFoodSearch.ShowDialog();
            this.Show();

        }

        private void btnUpdateMeal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Maintenance..:/");
            //MealDetail mealDetail=new MealDetail();

            //FrmFoodSearch frmFoodSearch = new FrmFoodSearch(user, mealDetail);
            //this.Hide();
            //frmFoodSearch.ShowDialog();
            //this.Show();

        }

    
    }
}
