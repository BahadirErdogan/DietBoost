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
        }
    }
}
