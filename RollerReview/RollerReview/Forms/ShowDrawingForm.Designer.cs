namespace RollerReview.Forms
{
    partial class ShowDrawingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pboxImage = new System.Windows.Forms.PictureBox();
            this.lbxImages = new System.Windows.Forms.ListBox();
            this.uploadImageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboxPicList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uploadImageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxImage
            // 
            this.pboxImage.Location = new System.Drawing.Point(374, 99);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.Size = new System.Drawing.Size(386, 214);
            this.pboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxImage.TabIndex = 0;
            this.pboxImage.TabStop = false;
            // 
            // lbxImages
            // 
            this.lbxImages.DataSource = this.uploadImageBindingSource;
            this.lbxImages.DisplayMember = "ImageName";
            this.lbxImages.FormattingEnabled = true;
            this.lbxImages.ItemHeight = 25;
            this.lbxImages.Location = new System.Drawing.Point(62, 99);
            this.lbxImages.Name = "lbxImages";
            this.lbxImages.Size = new System.Drawing.Size(230, 229);
            this.lbxImages.TabIndex = 1;
            this.lbxImages.ValueMember = "UploadImageId";
            this.lbxImages.SelectedIndexChanged += new System.EventHandler(this.lbxImages_SelectedIndexChanged);
            // 
            // uploadImageBindingSource
            // 
            this.uploadImageBindingSource.DataSource = typeof(RollerReview.Tables.UploadImage);
            // 
            // cboxPicList
            // 
            this.cboxPicList.DataSource = this.uploadImageBindingSource;
            this.cboxPicList.DisplayMember = "ImageName";
            this.cboxPicList.FormattingEnabled = true;
            this.cboxPicList.Location = new System.Drawing.Point(62, 351);
            this.cboxPicList.Name = "cboxPicList";
            this.cboxPicList.Size = new System.Drawing.Size(402, 33);
            this.cboxPicList.TabIndex = 2;
            this.cboxPicList.ValueMember = "UploadImageId";
            // 
            // ShowDrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxPicList);
            this.Controls.Add(this.lbxImages);
            this.Controls.Add(this.pboxImage);
            this.Name = "ShowDrawingForm";
            this.Text = "ShowDrawingForm";
            this.Load += new System.EventHandler(this.ShowDrawingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uploadImageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxImage;
        private System.Windows.Forms.ListBox lbxImages;
        private System.Windows.Forms.BindingSource uploadImageBindingSource;
        private System.Windows.Forms.ComboBox cboxPicList;
    }
}