namespace RollerReview.Forms
{
    partial class RegisterRidingRideForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.dtpRideDate = new System.Windows.Forms.DateTimePicker();
            this.txbPartner = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(271, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(456, 35);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "Welcome, ....";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogout.Location = new System.Drawing.Point(733, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(134, 46);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(2, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1079, 1);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblAppName.Location = new System.Drawing.Point(6, 9);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(248, 63);
            this.lblAppName.TabIndex = 8;
            this.lblAppName.Text = "MyRides";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpRideDate
            // 
            this.dtpRideDate.Location = new System.Drawing.Point(200, 133);
            this.dtpRideDate.Name = "dtpRideDate";
            this.dtpRideDate.Size = new System.Drawing.Size(489, 31);
            this.dtpRideDate.TabIndex = 12;
            // 
            // txbPartner
            // 
            this.txbPartner.Location = new System.Drawing.Point(200, 170);
            this.txbPartner.Multiline = true;
            this.txbPartner.Name = "txbPartner";
            this.txbPartner.Size = new System.Drawing.Size(489, 119);
            this.txbPartner.TabIndex = 13;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(113, 138);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 25);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Date";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(200, 295);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(489, 43);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "With:";
            // 
            // RegisterRidingRideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txbPartner);
            this.Controls.Add(this.dtpRideDate);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAppName);
            this.Name = "RegisterRidingRideForm";
            this.Text = "RegisterRidingRideForm";
            this.Load += new System.EventHandler(this.RegisterRidingRideForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.DateTimePicker dtpRideDate;
        private System.Windows.Forms.TextBox txbPartner;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
    }
}