using RollerReview.MyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollerReview.Forms
{
    public partial class UserReviewForm : Form
    {
        public UserReviewForm()
        {
            InitializeComponent();
            
            lblWelcome.Text = $"Welcome, {Global.UserData.Username}";

            if (Global.UserData.RoleId == 1)
            {
                btnAddRide.Visible = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Global.Logout(this);
        }
    }
}
