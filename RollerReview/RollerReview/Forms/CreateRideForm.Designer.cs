namespace RollerReview.Forms
{
    partial class CreateRideForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbRideName = new System.Windows.Forms.TextBox();
            this.cboxPark = new System.Windows.Forms.ComboBox();
            this.parkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dtpYearRide = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(140, 392);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(469, 67);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ride name:";
            // 
            // txbRideName
            // 
            this.txbRideName.Location = new System.Drawing.Point(262, 231);
            this.txbRideName.Name = "txbRideName";
            this.txbRideName.Size = new System.Drawing.Size(347, 31);
            this.txbRideName.TabIndex = 2;
            // 
            // cboxPark
            // 
            this.cboxPark.DataSource = this.parkBindingSource;
            this.cboxPark.DisplayMember = "Name";
            this.cboxPark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPark.FormattingEnabled = true;
            this.cboxPark.Location = new System.Drawing.Point(262, 155);
            this.cboxPark.Name = "cboxPark";
            this.cboxPark.Size = new System.Drawing.Size(347, 33);
            this.cboxPark.TabIndex = 3;
            this.cboxPark.ValueMember = "ParkId";
            // 
            // parkBindingSource
            // 
            this.parkBindingSource.DataSource = typeof(RollerReview.Tables.Park);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Park:";
            // 
            // dtpYearRide
            // 
            this.dtpYearRide.Location = new System.Drawing.Point(262, 194);
            this.dtpYearRide.Name = "dtpYearRide";
            this.dtpYearRide.Size = new System.Drawing.Size(347, 31);
            this.dtpYearRide.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year built";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(244, 62);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "MyRides";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(291, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(305, 35);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome...";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(602, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(134, 46);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(262, 267);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(347, 121);
            this.txbDescription.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            // 
            // CreateRideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 493);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpYearRide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxPark);
            this.Controls.Add(this.txbRideName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "CreateRideForm";
            this.Text = "CreateRideForm";
            ((System.ComponentModel.ISupportInitialize)(this.parkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbRideName;
        private System.Windows.Forms.ComboBox cboxPark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpYearRide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.BindingSource parkBindingSource;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label label5;
    }
}