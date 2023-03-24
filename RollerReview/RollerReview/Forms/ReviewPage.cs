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
        private Rollercoaster _chosencoaster;

        public ReviewPage(Rollercoaster chosenCoaster)
        {
            InitializeComponent();

            this.dbContext = new AppDbContext();
            _chosencoaster = chosenCoaster;

            lblRollercoaster.Text = _chosencoaster.Name;
            lblPark.Text = _chosencoaster.Park.Name;
            lblYearBuilt.Text = _chosencoaster.Build.ToString("dd-MMMM-yyyy");

            lblWelcome.Text = $"Welcome, {Global.UserData.Username}";
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
    }
}
