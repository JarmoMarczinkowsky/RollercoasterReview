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
    public partial class RegisterRidingRideForm : Form
    {
        private AppDbContext dbContext;

        public RegisterRidingRideForm()
        {
            InitializeComponent();

            lblWelcome.Text = $"Welcome, {Global.UserData.Username}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Global.Logout(this);
        }

        private void RegisterRidingRideForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var NewRide = new Review()
            {
                UserId = Global.UserData.UserId,
                RollercoasterId = ReviewPage._chosencoaster.RollercoasterId,
                ReviewDate = dtpRideDate.Value,
                Partner = txbPartner.Text
            };

            this.dbContext.Reviews.Add(NewRide);
            this.dbContext.SaveChanges();
            this.Close();
        }
    }
}
