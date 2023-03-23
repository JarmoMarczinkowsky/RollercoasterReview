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
            
            lblWelcome.Text = $"Welcome, {Global.Username}";
        }
    }
}
