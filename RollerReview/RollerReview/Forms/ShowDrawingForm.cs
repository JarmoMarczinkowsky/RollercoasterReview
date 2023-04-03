using Microsoft.EntityFrameworkCore;
using RollerReview.Tables;
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
    public partial class ShowDrawingForm : Form
    {
        private AppDbContext dbContext;

        public ShowDrawingForm()
        {
            InitializeComponent();
        }

        private void ShowDrawingForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new AppDbContext();
            this.dbContext.UploadImages.Load();

            this.uploadImageBindingSource.DataSource = this.dbContext.UploadImages.Local.ToBindingList();
        }

        private void lbxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] convertImg = null;

            var getSelectedImage = this.dbContext.UploadImages.Where(ui => ui.UploadImageId == (int)lbxImages.SelectedValue).FirstOrDefault();
            convertImg = getSelectedImage.Image;

            if (getSelectedImage != null)
            {
                Image createImage = Image.FromStream(new MemoryStream(convertImg));
                pboxImage.Image = createImage;
            }
        }
    }
}
