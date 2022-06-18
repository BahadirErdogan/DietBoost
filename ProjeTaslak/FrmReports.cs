using DietBoost.BLL.Services;
using DietBoost.DAL.Context;
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
    public partial class FrmReports : Form
    {
        User user;
        CategoryService categoryService;
        DietBoostDbContext context;
        public FrmReports(User _user)
        {
            InitializeComponent();
            categoryService = new CategoryService();
            context = new DietBoostDbContext();
            user = _user;
            lblFullName.Text =user.FullName.ToUpper();
           
        }
        private void FrmReports_Load(object sender, EventArgs e)
        {
            
            dgvReports.DataSource = null;
           
            List<string> raporlar = new List<string>();
            raporlar.Add("Reports");
            raporlar.Add("Meal Based Daily Report");
            raporlar.Add("Total Calories Intake Report");
            raporlar.Add("Comparison Report");
            raporlar.Add("Number Of Foods Eaten Per Meal ");
            raporlar.Add("Most Eaten Food(Top3)");
            cbReports.DataSource = raporlar;
            

        }

        private void cbReports_SelectedIndexChanged(object sender, EventArgs e)
        {



            //Öğün Bazlı Günlük Rapor
            if (cbReports.SelectedIndex == 1)
                {
                    dgvReports.DataSource = context.MealDetails.Where(a=>a.Meal.MealDate==DateTime.Today 
                    && user.ID== a.Meal.UserID).GroupBy(g => g.MealID).Select(b => new
                    {

                        Username = user.FullName,
                        MealId = b.Key,
                        MealType = b.Select(a => a.Meal.MealType),
                        TotalCalorie=b.Sum(a=>a.TotalCalorie)

                    }).ToList();
                                               
                }
                //Günlük alınan toplam kalori
                else if (cbReports.SelectedIndex == 2)
                {
                    dgvReports.DataSource = context.MealDetails.Where(a => a.Meal.MealDate == DateTime.Today
                    && user.ID == a.Meal.UserID).GroupBy(g => g.Meal.MealDate).Select(b => new
                    {

                        Username = user.FullName,
                        mealDate= b.Key,
                        TotalCalorie = b.Sum(a => a.TotalCalorie)

                    }).ToList();

                }
                //karşılaştırma Raporu
                else if(cbReports.SelectedIndex == 3)
                {
                dgvReports.DataSource = context.MealDetails.GroupBy(a => a.Meal.MealType).Select(a => new
                {
                    ToBeCompared = user.FullName,
                    Mealtype = a.Key,
                    CategoryName = a.Select(b => b.Food.Category.Name)
                 
                }).ToList();
                }
                //Öğünlerde hangi Yemeklerin ne kadar yendiği
                else if (cbReports.SelectedIndex == 4)
                {
                    dgvReports.DataSource = context.MealDetails.Where(a => a.Meal.UserID == user.ID).GroupBy(a => a.FoodID).Select(b => new
                    {
                        FoodId = b.Key,
                        FoodName = b.Select(a => a.Food.Name),
                        MealName = b.Select(a => a.Meal.MealType),
                        Quantity = b.Sum(a => a.Quantity)

                    }).OrderByDescending(T => T.Quantity).ToList();
                }
                //En  çok yenen 3 yemek 
                else if(cbReports.SelectedIndex == 5)
                {
                    dgvReports.DataSource = context.MealDetails.Where(a => a.Meal.UserID == user.ID).GroupBy(a => a.FoodID).Select(b => new
                    {
                        FoodId = b.Key,
                        FoodName = b.Select(a => a.Food.Name),
                        Quantity = b.Sum(a => a.Quantity)
                    }).OrderByDescending(c => c.Quantity).Take(3).ToList();
                }
                else
                {
                    dgvReports.DataSource = null;
                }

        }


    }
}

