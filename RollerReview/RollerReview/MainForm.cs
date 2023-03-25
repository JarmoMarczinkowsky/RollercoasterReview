using Microsoft.EntityFrameworkCore;
using RollerReview.Forms;
using RollerReview.MyClasses;
using RollerReview.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollerReview
{
    public partial class MainForm : Form
    {
        private AppDbContext dbContext;
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();

            //this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Users.Load();
            this.dbContext.Roles.Load();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var getUser = this.dbContext.Users.FirstOrDefault(u => u.Username == txbUsername.Text);

            if (getUser == null)
            {
                return;
            }

            if(Global.CheckPassword(txbPassword.Text, getUser.Password))
            {
                Global.UserData = (User)getUser;
                Global.FormDirect(this, new RidesForm());
            }
        }
    }
}
