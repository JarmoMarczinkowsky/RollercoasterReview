namespace RollerReview.Forms
{
    partial class ReviewPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReview = new System.Windows.Forms.DataGridView();
            this.reviewDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRideAgain = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pboxRide = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPark = new System.Windows.Forms.Label();
            this.lblYearBuilt = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblRollercoaster = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRide)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReview
            // 
            this.dgvReview.AutoGenerateColumns = false;
            this.dgvReview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reviewDateDataGridViewTextBoxColumn,
            this.Partner});
            this.dgvReview.DataSource = this.reviewBindingSource;
            this.dgvReview.EnableHeadersVisualStyles = false;
            this.dgvReview.Location = new System.Drawing.Point(272, 298);
            this.dgvReview.Name = "dgvReview";
            this.dgvReview.RowHeadersWidth = 25;
            this.dgvReview.RowTemplate.Height = 33;
            this.dgvReview.Size = new System.Drawing.Size(718, 346);
            this.dgvReview.TabIndex = 1;
            // 
            // reviewDateDataGridViewTextBoxColumn
            // 
            this.reviewDateDataGridViewTextBoxColumn.DataPropertyName = "ReviewDate";
            this.reviewDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.reviewDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.reviewDateDataGridViewTextBoxColumn.Name = "reviewDateDataGridViewTextBoxColumn";
            this.reviewDateDataGridViewTextBoxColumn.Width = 102;
            // 
            // Partner
            // 
            this.Partner.DataPropertyName = "Partner";
            this.Partner.HeaderText = "Partner";
            this.Partner.MinimumWidth = 10;
            this.Partner.Name = "Partner";
            this.Partner.Width = 127;
            // 
            // reviewBindingSource
            // 
            this.reviewBindingSource.DataSource = typeof(RollerReview.Tables.Review);
            // 
            // btnRideAgain
            // 
            this.btnRideAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRideAgain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRideAgain.Location = new System.Drawing.Point(272, 670);
            this.btnRideAgain.Name = "btnRideAgain";
            this.btnRideAgain.Size = new System.Drawing.Size(718, 62);
            this.btnRideAgain.TabIndex = 2;
            this.btnRideAgain.Text = "I rode this ride again";
            this.btnRideAgain.UseVisualStyleBackColor = false;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblAppName.Location = new System.Drawing.Point(12, 9);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(248, 63);
            this.lblAppName.TabIndex = 3;
            this.lblAppName.Text = "MyRides";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAppName.Click += new System.EventHandler(this.label2_Click);
            this.lblAppName.MouseEnter += new System.EventHandler(this.lblAppName_MouseEnter);
            this.lblAppName.MouseLeave += new System.EventHandler(this.lblAppName_MouseLeave);
            // 
            // pboxRide
            // 
            this.pboxRide.Location = new System.Drawing.Point(23, 87);
            this.pboxRide.Name = "pboxRide";
            this.pboxRide.Size = new System.Drawing.Size(223, 208);
            this.pboxRide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxRide.TabIndex = 4;
            this.pboxRide.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1079, 1);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(478, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(456, 35);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Welcome, ....";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(940, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(134, 46);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblPark
            // 
            this.lblPark.AutoSize = true;
            this.lblPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPark.Location = new System.Drawing.Point(267, 186);
            this.lblPark.Name = "lblPark";
            this.lblPark.Size = new System.Drawing.Size(67, 25);
            this.lblPark.TabIndex = 9;
            this.lblPark.Text = "Park:";
            // 
            // lblYearBuilt
            // 
            this.lblYearBuilt.AutoSize = true;
            this.lblYearBuilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearBuilt.Location = new System.Drawing.Point(267, 211);
            this.lblYearBuilt.Name = "lblYearBuilt";
            this.lblYearBuilt.Size = new System.Drawing.Size(128, 25);
            this.lblYearBuilt.TabIndex = 10;
            this.lblYearBuilt.Text = "Year built: ";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Location = new System.Drawing.Point(932, 87);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 46);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblRollercoaster
            // 
            this.lblRollercoaster.AutoSize = true;
            this.lblRollercoaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollercoaster.Location = new System.Drawing.Point(267, 161);
            this.lblRollercoaster.Name = "lblRollercoaster";
            this.lblRollercoaster.Size = new System.Drawing.Size(152, 25);
            this.lblRollercoaster.TabIndex = 12;
            this.lblRollercoaster.Text = "Rollercoaster";
            // 
            // ReviewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 763);
            this.Controls.Add(this.lblRollercoaster);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblYearBuilt);
            this.Controls.Add(this.lblPark);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pboxRide);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.btnRideAgain);
            this.Controls.Add(this.dgvReview);
            this.Name = "ReviewPage";
            this.Text = "ReviewPage";
            this.Load += new System.EventHandler(this.ReviewPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvReview;
        private System.Windows.Forms.BindingSource reviewBindingSource;
        private System.Windows.Forms.Button btnRideAgain;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partner;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.PictureBox pboxRide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPark;
        private System.Windows.Forms.Label lblYearBuilt;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblRollercoaster;
    }
}