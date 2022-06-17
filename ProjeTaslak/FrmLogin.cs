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
    public partial class FrmLogin : Form
    {
        UserService userService;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtEmail.Text;
            string password = txtPassword.Text;

            try
            {
                userService = new UserService();
                User user = userService.CheckLogIn(userName, password);
                if (user != null)
                {
                    if (!user.IsActive)
                    {
                        MessageBox.Show("Your account is still not confirmed yet.");
                        return;
                    }

                    switch (user.UserType)
                    {
                        case UserType.Admin:
                            FrmAdminPanel frmAdminPanel = new FrmAdminPanel();
                            this.Hide();
                            frmAdminPanel.ShowDialog();
                            this.Show();
                            break;
                        case UserType.Standard:
                            FrmMainScreen frmMainScreen = new FrmMainScreen(user);
                            this.Hide();
                            frmMainScreen.ShowDialog();
                            this.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Please Check Your Information or Sign Up. ");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
                FrmSignUp frmSignUp = new FrmSignUp();
                this.Hide();
                frmSignUp.ShowDialog();
                this.Show();
            
        }
    }
}
