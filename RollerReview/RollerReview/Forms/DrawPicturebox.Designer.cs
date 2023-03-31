namespace RollerReview.Forms
{
    partial class DrawPicturebox
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
            this.MyArt = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyArt)).BeginInit();
            this.SuspendLayout();
            // 
            // MyArt
            // 
            this.MyArt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MyArt.Location = new System.Drawing.Point(100, 53);
            this.MyArt.Name = "MyArt";
            this.MyArt.Size = new System.Drawing.Size(578, 307);
            this.MyArt.TabIndex = 0;
            this.MyArt.TabStop = false;
            this.MyArt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.MyArt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.MyArt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(591, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 60);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DrawPicturebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.MyArt);
            this.Name = "DrawPicturebox";
            this.Text = "DrawPicturebox";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MyArt;
        private System.Windows.Forms.Button btnSave;
    }
}