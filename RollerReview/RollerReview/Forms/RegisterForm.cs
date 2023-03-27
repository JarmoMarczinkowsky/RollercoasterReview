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
    public partial class RegisterForm : Form
    {
        private AppDbContext dbContext;
        private User usernames;

        public RegisterForm()
        {
            InitializeComponent();

            lblError.Text = "";
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();

            //usernames = (User)this.dbContext.Users.Load();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbPassword.Text) || string.IsNullOrWhiteSpace(txbConfirmPass.Text))
            {
                lblError.Text = "Please fill in all fields";
                return;
            }

            var test = this.dbContext.Users.Where(u => u.Username == txbUsername.Text).FirstOrDefault();

            if (test != null)
            {
                lblError.Text = "Username already exists";
                return;
            }

            if (txbPassword.Text != txbConfirmPass.Text)
            {
                lblError.Text = "Passwords do not match";
                return;
            }

            var newUser = new User()
            {
                Email = txbEmail.Text,
                Username = txbUsername.Text,
                Password = Global.HashPassword(txbPassword.Text),
                RoleId = 2,
            };

            this.dbContext.Users.Add(newUser);
            this.dbContext.SaveChanges();
            this.Close();
        }

    }
}
