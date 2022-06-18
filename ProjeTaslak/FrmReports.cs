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
        CategoryService categoryService;
        DietBoostDbContext context;
        public FrmReports()
        {
            InitializeComponent();
            categoryService = new CategoryService();
            context = new DietBoostDbContext();
        }

        private void cbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbReports.Text)) MessageBox.Show("Failed.");
            else
            {
                List<string> raporlar = new List<string> { "Gün Sonu  Raporu", "Kıyas Raporları", "Yemek Çeşidi Raporu" };
                cbReports.DataSource=raporlar;
                

                if (cbReports.SelectedIndex == 0)
                {
                    dataGridView1.DataSource = context.MealDetails.GroupBy(G => G.MealID).Select(a => new
                    {
                        
                        Sum = a.Sum(T => T.Food.PortionCalorie*T.Quantity),
                        
                    }).ToList();
                }
                else if(cbReports.SelectedIndex == 1)
                {
                    //dataGridView1.DataSource=(from F in context.Foods join Md in context.MealDetails on F.ID equals Md.FoodID 
                    //                          join M in context.Meals on Md.MealID equals M.ID
                    //                          select new
                    //                          {
                    //                              F.Name,
                    //                              M.MealType
                    //                          }).ToList();

                    
                }
            }
        }
    }
}
