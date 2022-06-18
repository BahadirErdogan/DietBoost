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
    public partial class FrmMainScreen : Form
    {
        User user;
        MealDetailService mealDetailService;
        public FrmMainScreen(User _user)
        {
            InitializeComponent();
            user = _user;
            mealDetailService = new MealDetailService();
            lblUserName.Text = user.FullName.ToUpper();
            lblRecommendedCalorie.Text = CalculateRecomendedDailyCalorie(user).ToString();
            lblSelectedDailyCalorieInTake.Text = CalculateDailyCalorie(dtpMeals.Value).ToString();
            lblTodaysCalorieIntake.Text = CalculateDailyCalorie().ToString();
        }
        private void FrmMainScreen_Load(object sender, EventArgs e)
        {
            dtpMeals.Value = DateTime.Now;
            FillListView();
            lblTodaysCalorieIntake.Text = CalculateDailyCalorie().ToString();

        }
        

        private void FillListView()
        {

            lvMeals.Items.Clear();
            List<MealDetail> meals = mealDetailService.GetMealDetailsByDate(dtpMeals.Value);

            foreach (var item in meals)
            {
                string[] items = { item.Meal.MealType.ToString(),item.Quantity.ToString(), item.Food.Name };
                ListViewItem lvi = new ListViewItem(items);
                lvi.Tag = item.Food.Calorie * item.Quantity;
                lvMeals.Items.Add(lvi);
            }
        }

 

        /// <summary>
        /// Bugüne ait öğünlerdeki toplam kaloriyi hesaplar ve decimal döner.
        /// </summary>
        /// <returns>decimal</returns>
        public decimal CalculateDailyCalorie()
        {
            DateTime dt = DateTime.Today;
            decimal dailyCalorie = 0;
            List<MealDetail> meals = mealDetailService.GetMealDetailsByDate(dt);
            foreach (var item in meals)
            {
                dailyCalorie += item.TotalCalorie;
            }
            return dailyCalorie;
        }


        /// <summary>
        /// Seçili tarihe ait öğünlerdeki toplam kaloriyi hesaplar. Decimal döner.
        /// </summary>
        /// <param name="date"></param>
        /// <returns>decimal</returns>
        public decimal CalculateDailyCalorie(DateTime date)
        {
            DateTime dt = date;
            decimal dailyCalorie = 0;
            List<MealDetail> meals = mealDetailService.GetMealDetailsByDate(dt);
            foreach (var item in meals)
            {
                dailyCalorie += item.TotalCalorie;
            }
            return dailyCalorie;
        }



        /// <summary>
        /// HARRİS- BENEDİCT DENKLEMİ(kkal/gün) ne göre kcal hesapları yapıp günlük alınması gereken kalori limitini hesaplar.
        /// BMH(erkek) =66.5+13.75A+5.0B-6.77Y , BMH(kadın)=655.1+9.56A+1.85B-4.67Y
        /// </summary>
        /// <param name="user"></param>
        /// <returns>double</returns>
        public double CalculateRecomendedDailyCalorie(User user)
        {
            double calorieLimit;
            if (user.Gender == "Male")
            {
                if (user.Weight == user.WeightGoal)
                {
                    calorieLimit = 66.5 + (Convert.ToDouble(user.Weight) * 13.75) + (Convert.ToDouble(user.Height) * 5) - (Convert.ToDouble(user.Age) * 6.77);
                }
                 else if (user.Weight > user.WeightGoal)
                {
                    calorieLimit = 66.5 + (Convert.ToDouble(user.Weight - 10) * 13.75) + (Convert.ToDouble(user.Height) * 5) - (Convert.ToDouble(user.Age) * 6.77);
                }
                else
                {
                    calorieLimit = 66.5 + (Convert.ToDouble(user.Weight + 10) * 13.75) + (Convert.ToDouble(user.Height) * 5) - (Convert.ToDouble(user.Age) * 6.77);
                }
            }
            else
            {
                if (user.Weight == user.WeightGoal)
                {
                    calorieLimit = 655.1 + (Convert.ToDouble(user.Weight) * 9.56) + (Convert.ToDouble(user.Height) * 1.85) - (Convert.ToDouble(user.Age) * 4.67);
                }
                else if (user.Weight > user.WeightGoal)
                {
                    calorieLimit = 655.1 + (Convert.ToDouble(user.Weight - 10) * 9.56) + (Convert.ToDouble(user.Height) * 1.85) - (Convert.ToDouble(user.Age) * 4.67);
                }
                else
                {
                    calorieLimit = 655.1 + (Convert.ToDouble(user.Weight + 10) * 9.56) + (Convert.ToDouble(user.Height) * 1.85) - (Convert.ToDouble(user.Age) * 4.67);
                }
            }
            return calorieLimit;
        }
        
        private void btnMeals_Click(object sender, EventArgs e)
        {
            FrmMeal frmMeal = new FrmMeal(user);
            this.Hide();
            frmMeal.ShowDialog();
            this.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FrmReports frmReports = new FrmReports(user);
            this.Hide();
            frmReports.ShowDialog();
            this.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your version is up to date.");
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project was developed by\n\nBahadır Erdoğan,\nBerk Başdemir,\nEnes Cihan,\nSinem Pamık\n\nas part of the BilgeAdam-Boost Program.\n\nContact Information:\n\nbahadirerdogan@outlook.com.tr\nbasdemirberk@gmail.com\nens.chn35@gmail.com\nsnmpmk93@gmail.com");
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount(user);
            this.Hide();
            frmAccount.ShowDialog();
            this.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void dtpMeals_ValueChanged(object sender, EventArgs e)
        {

            foreach (var series in chartDailyPerMacros.Series)
            {
                series.Points.Clear();
            }

            double fatTotal = mealDetailService.GetTotalFatFromMealsByDate(user.ID, dtpMeals.Value);
            double carbsTotal = mealDetailService.GetTotalCarbsFromMealsByDate(user.ID, dtpMeals.Value);
            double proteinTotal = mealDetailService.GetTotalProteinFromMealsByDate(user.ID, dtpMeals.Value);

            chartDailyPerMacros.Series["Macronutrients"].Points.AddXY("Fat", fatTotal);
            chartDailyPerMacros.Series["Macronutrients"].Points.AddXY("Protein", carbsTotal);
            chartDailyPerMacros.Series["Macronutrients"].Points.AddXY("Carbs", proteinTotal);

            lblSelectedDailyCalorieInTake.Text = CalculateDailyCalorie(dtpMeals.Value).ToString();
            
        }
    }
}

