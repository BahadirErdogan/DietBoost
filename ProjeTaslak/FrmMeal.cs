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
            MealType mealType = GetMealTypeFromComboBox();

            if (cbMeals.SelectedIndex > 0)
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


            #region Berk'in ilk kodu
            //lvMealDetails.Items.Clear();
            //if (cbMeals.SelectedItem != null)
            //{
            //    MealDetail meal = mealDetailService.GetMealDetailByMealDateAndMealType(dtpDate.Value, (MealType)cbMeals.SelectedItem);
            //    //List<MealDetail> meals = mealDetailService.GetMealDetailsByMealDateAndMealType(dtpDate.Value, (MealType)cbMeals.SelectedItem);

            //   // foreach (var item in meals)
            //    {


            //        string[] items = { meal.Quantity.ToString(), meal.Food.Name, (meal.Food.Calorie * meal.Quantity).ToString() };
            //        ListViewItem lvi = new ListViewItem(items);
            //        lvi.Tag = meal.Food.Calorie * meal.Quantity;
            //        lvMealDetails.Items.Add(lvi);
            //    }
            //}
            //else return;
            #endregion
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
                
            foreach (var item in meals)
            {
                totalDailyCalorie += item.TotalCalorie;
            }
            return totalDailyCalorie;
        }


        /// <summary>
        /// Combobox'da seçilen öğüne göre MealType tipinde mealtype döner. (FillListView içeriisndeki servisde kullanıldı.)
        /// </summary>
        /// <returns></returns>
        public MealType GetMealTypeFromComboBox()
        {
            MealType mealType;

            switch (cbMeals.SelectedIndex)
            {
                case 0:
                    mealType = MealType.Breakfast;
                    break;
                case 1:
                    mealType = MealType.Elevenses;
                    break;
                case 2:
                    mealType = MealType.Lunch;
                    break;
                case 3:
                    mealType = MealType.Snack;
                    break;
                default:
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
            MealDetail mealDetail=new MealDetail();
           
            FrmFoodSearch frmFoodSearch = new FrmFoodSearch(user, mealDetail);
            this.Hide();
            frmFoodSearch.ShowDialog();
            this.Show();

        }

    
    }
}
