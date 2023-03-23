using Microsoft.EntityFrameworkCore;
using RollerReview.MyClasses;
using RollerReview.Tables;
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
        private AppDbContext dbContext;

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

        private void btnAddRide_Click(object sender, EventArgs e)
        {
            CreateRideForm createRideForm = new CreateRideForm();
            createRideForm.ShowDialog();
        }
    }
}
