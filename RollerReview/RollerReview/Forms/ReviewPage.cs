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
    public partial class ReviewPage : Form
    {
        private AppDbContext dbContext;
        public static Rollercoaster _chosencoaster;

        public ReviewPage(Rollercoaster chosenCoaster)
        {
            InitializeComponent();

            this.dbContext = new AppDbContext();
            _chosencoaster = chosenCoaster;

            lblRollercoaster.Text = _chosencoaster.Name;
            lblPark.Text = _chosencoaster.Park.Name;
            lblYearBuilt.Text = _chosencoaster.Build.ToString("dd-MMMM-yyyy");

            lblWelcome.Text = $"Welcome, {Global.UserData.Username}";

            if (Global.UserData.RoleId == 1)
            {
                btnEdit.Visible = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Global.Logout(this);
        }

        private void ReviewPage_Load(object sender, EventArgs e)
        {
            this.dbContext.Reviews.Where(r => r.UserId == Global.UserData.UserId && r.RollercoasterId == _chosencoaster.RollercoasterId).OrderByDescending(d => d.ReviewDate).Load();
            this.reviewBindingSource.DataSource = this.dbContext.Reviews.Local.ToBindingList();

            pboxRide.ImageLocation = _chosencoaster.RollercoasterImage;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Global.FormDirect(this, new RidesForm());
        }

        private void lblAppName_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void lblAppName_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnRideAgain_Click(object sender, EventArgs e)
        {
            //Global.FormDirect(this, new RegisterRidingRideForm());
            RegisterRidingRideForm registerRidingRideForm = new RegisterRidingRideForm();
            registerRidingRideForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.dbContext.Reviews.Where(r => r.UserId == Global.UserData.UserId && r.RollercoasterId == _chosencoaster.RollercoasterId).OrderByDescending(d => d.ReviewDate).Load();
            this.reviewBindingSource.DataSource = this.dbContext.Reviews.Local.ToBindingList();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Global.FormDirect(this, new RidesForm());
        }
    }
}
