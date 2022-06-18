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
    
    public partial class FrmAccount : Form
    {
        UserService userService;
        PasswordService passwordService;
        User user;
        public FrmAccount(User _user)
        {
            
            InitializeComponent();
            userService = new UserService();
            passwordService = new PasswordService();
            user = _user;
            
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtPhone.Text = user.Phone;
            dtpBirthDate.Value = user.BirthDate;
            if(user.Gender=="Male")rbMale.Checked = true;
            else rbFemale.Checked = true;
            nudHeight.Value = user.Height;
            nudWeight.Value = user.Weight;
            nudWeightGoal.Value = user.WeightGoal;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.Phone = txtPhone.Text;
                user.BirthDate = dtpBirthDate.Value;
                user.Gender = rbMale.Checked ? "Male" : "Female";
                user.Weight = nudWeight.Value;
                user.WeightGoal = nudWeightGoal.Value;
                user.Height = nudHeight.Value;
                userService.Update(user);
                MessageBox.Show("User Account informations updated.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Password activePassword=passwordService.GetActivePassword(user.ID);
            if(txtOldPassword.Text != activePassword.Text)
            {
                MessageBox.Show("Your Current Password is wrong!");
                return;
            }
            if (txtNewPassword.Text != txtRepeatPassword.Text)
            {
                MessageBox.Show("Your Passwords don't match");
                return;
            }
            bool check = passwordService.Insert(new Password()
            {
                Text = txtNewPassword.Text,
                UserID = user.ID
            });
            MessageBox.Show(check ? "Password updated" : "Failed");

        }
    }
}
