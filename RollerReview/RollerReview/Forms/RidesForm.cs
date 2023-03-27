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
    public partial class RidesForm : Form
    {
        private AppDbContext dbContext;

        public RidesForm()
        {
            InitializeComponent();
            

            lblWelcome.Text = $"Welcome, {Global.UserData.Username}";

            if (Global.UserData.RoleId == 1)
            {
                btnAddRide.Visible = true;
            }

            
            
        }
        private void RidesForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.Rollercoasters
                .Include(r => r.Park)
                .Load();

            this.dgvRollercoaster.DataSource = this.dbContext.Rollercoasters.Local.ToBindingList();
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

        private void dgvRollercoaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedReview = (Rollercoaster)this.dgvRollercoaster.CurrentRow?.DataBoundItem;

            if (selectedReview == null)
            {
                return;
            }

            Global.FormDirect(this, new ReviewPage(selectedReview));
        }

    }
}
