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
        public FrmMainScreen(User _user)
        {
            InitializeComponent();
            user = _user;
            lblUserName.Text = user.FirstName;
            lblRecommendedCalorie.Text = CalculateCalorieLimit(user).ToString();
        }



        private void FrmMainScreen_Load(object sender, EventArgs e)
        {
            
           








        }





        /// <summary>
        /// HARRİS- BENEDİCT DENKLEMİ(kkal/gün) ne göre kcal hesapları yapıp günlük alınması gereken kalori limitini hesaplar.
        /// BMH(erkek) =66.5+13.75A+5.0B-6.77Y , BMH(kadın)=655.1+9.56A+1.85B-4.67Y
        /// </summary>
        /// <param name="user"></param>
        /// <returns>double</returns>
        public double CalculateCalorieLimit(User user)
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



    }
}

