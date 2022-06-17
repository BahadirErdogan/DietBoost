using DietBoost.BLL.Services;
using DietBoost.Model.Entities;
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
    public partial class FrmSignUp : Form
    {
        UserService userService;
        public FrmSignUp()
        {
            InitializeComponent();
            userService = new UserService();    
        }


        private void FrmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtPasswordRepeat.Text)
                {
                    MessageBox.Show("Passwords should be same to each other.");
                    return;
                }
                else if (!cbUserAgreement.Checked)
                {
                    MessageBox.Show("Please read and approve the user agreement. ");
                }

                User user = new User()
                {
                    FirstName = txtName.Text,
                    LastName = txtSurname.Text,
                    UserName = txtEmail.Text,
                    Phone=mtxtPhone.Text,
                    Gender=rbMale.Checked ? "Male":"Female",
                    BirthDate=dtpBirthDay.Value,
                    Height=nudHeight.Value,
                    Weight=nudWeight.Value,
                    WeightGoal=nudWeightGoal.Value
                    
                };
                user.Passwords.Add(new Password()
                {
                    Text = txtPassword.Text
                });

                bool check = userService.Insert(user);
                MessageBox.Show(check ? "Thank you for registering.You can login after admin's approval." : "Registeration failed.");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckStrength(txtPassword.Text);
            CheckPasswordMatch();
        }


        private void txtPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordMatch();
        }

        /// <summary>
        /// Belirlenen koşullara göre şifrenin gücünü bir label'a belirli renklerle yazdırır.
        /// </summary>
        /// <param name="password"></param>
        void CheckStrength(string password)
        {
            

            if (password.Length < 6 || password.All(Char.IsLetter) || password.All(Char.IsDigit) || !password.Any(Char.IsLetterOrDigit))
            {
                lblStrength.Text = "Low";
                lblStrength.ForeColor = Color.Red;
            }


            else if (password.Any(char.IsLetter) && password.Any(char.IsDigit) && !password.All(char.IsLetterOrDigit))
            {
                lblStrength.Text = "High";
                lblStrength.ForeColor = Color.Green;
            }
            else
            {
                lblStrength.Text = "Medium";
                lblStrength.ForeColor = Color.Blue;

            }

        }



        /// <summary>
        /// 2 Textboxdaki şifrelerin eşleşip eşleşmediğinin kontrol eder. Eşleşiyorsa yeşil tik işaretini visible yapar.
        /// </summary>
        void CheckPasswordMatch()
        {
            if(txtPassword.Text == txtPasswordRepeat.Text)
            {
                pbPasswordMatch1.Visible = true;
                pbPasswordMatch2.Visible = true;
            }
            else
            {
                pbPasswordMatch1.Visible = false;
                pbPasswordMatch2.Visible = false;
            }
        }
    }
}
