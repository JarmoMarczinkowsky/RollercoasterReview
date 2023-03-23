﻿using RollerReview.Tables;
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
    public partial class CreateRideForm : Form
    {
        private AppDbContext dbContext;

        public CreateRideForm()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newRide = new Rollercoaster()
            {
                Name = txbRideName.Text,
                ParkId = (int)cboxPark.SelectedValue,
                Build = dtpYearRide.Value
            };

            this.dbContext.Rollercoasters.Add(newRide);
            this.dbContext.SaveChanges();
        }
    }
}
