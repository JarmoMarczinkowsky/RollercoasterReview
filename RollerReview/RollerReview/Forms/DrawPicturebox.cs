﻿using RollerReview.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollerReview.Forms
{
    public partial class DrawPicturebox : Form
    {
        private AppDbContext dbContext;

        private Point? _prevPoint;
        private Bitmap _bitmap;
        public DrawPicturebox()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _prevPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_prevPoint.HasValue && e.Button == MouseButtons.Left)
            {
                using (var g = Graphics.FromImage(_bitmap))
                {
                    g.DrawLine(Pens.Black, _prevPoint.Value, e.Location);
                }
                _prevPoint = e.Location;
                MyArt.Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(MyArt.Width, MyArt.Height);
            MyArt.Image = _bitmap;

            this.dbContext = new AppDbContext();

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _prevPoint = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] myImg;

            // Get the bitmap of the picture box
            Bitmap bmp = new Bitmap(MyArt.Width, MyArt.Height);
            MyArt.DrawToBitmap(bmp, new Rectangle(0, 0, MyArt.Width, MyArt.Height));

            using(MemoryStream ms = new MemoryStream()) 
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                myImg = ms.ToArray();
            }

            var newImage = new UploadImage()
            {
                ImageName = txbName.Text,
                Image = myImg
            };

            this.dbContext.UploadImages.Add(newImage);
            this.dbContext.SaveChanges();

            // Save the bitmap as a PNG file
            //using (var dialog = new SaveFileDialog())
            //{
            //    dialog.Filter = "PNG Image|*.png";
            //    if (dialog.ShowDialog() == DialogResult.OK)
            //    {
            //        bmp.Save(dialog.FileName);
            //    }
            //}
        }

        
    }
}
