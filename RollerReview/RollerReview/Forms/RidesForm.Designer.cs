namespace RollerReview.Forms
{
    partial class RidesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dgvRollercoaster = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollercoasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddRide = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRollercoaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollercoasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(526, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "MyRides";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogout.Location = new System.Drawing.Point(1128, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(134, 46);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(532, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(456, 35);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome, ....";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvRollercoaster
            // 
            this.dgvRollercoaster.AllowUserToAddRows = false;
            this.dgvRollercoaster.AllowUserToDeleteRows = false;
            this.dgvRollercoaster.AutoGenerateColumns = false;
            this.dgvRollercoaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRollercoaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRollercoaster.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRollercoaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRollercoaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRollercoaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRollercoaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.parkDataGridViewTextBoxColumn,
            this.buildDataGridViewTextBoxColumn});
            this.dgvRollercoaster.DataSource = this.rollercoasterBindingSource;
            this.dgvRollercoaster.EnableHeadersVisualStyles = false;
            this.dgvRollercoaster.Location = new System.Drawing.Point(131, 189);
            this.dgvRollercoaster.Name = "dgvRollercoaster";
            this.dgvRollercoaster.ReadOnly = true;
            this.dgvRollercoaster.RowHeadersWidth = 25;
            this.dgvRollercoaster.RowTemplate.Height = 33;
            this.dgvRollercoaster.Size = new System.Drawing.Size(1015, 583);
            this.dgvRollercoaster.TabIndex = 3;
            this.dgvRollercoaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRollercoaster_CellDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 113;
            // 
            // parkDataGridViewTextBoxColumn
            // 
            this.parkDataGridViewTextBoxColumn.DataPropertyName = "Park";
            this.parkDataGridViewTextBoxColumn.HeaderText = "Park";
            this.parkDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.parkDataGridViewTextBoxColumn.Name = "parkDataGridViewTextBoxColumn";
            this.parkDataGridViewTextBoxColumn.ReadOnly = true;
            this.parkDataGridViewTextBoxColumn.Width = 101;
            // 
            // buildDataGridViewTextBoxColumn
            // 
            this.buildDataGridViewTextBoxColumn.DataPropertyName = "Build";
            this.buildDataGridViewTextBoxColumn.HeaderText = "Build";
            this.buildDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.buildDataGridViewTextBoxColumn.Name = "buildDataGridViewTextBoxColumn";
            this.buildDataGridViewTextBoxColumn.ReadOnly = true;
            this.buildDataGridViewTextBoxColumn.Width = 105;
            // 
            // rollercoasterBindingSource
            // 
            this.rollercoasterBindingSource.DataSource = typeof(RollerReview.Tables.Rollercoaster);
            // 
            // btnAddRide
            // 
            this.btnAddRide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddRide.Location = new System.Drawing.Point(131, 778);
            this.btnAddRide.Name = "btnAddRide";
            this.btnAddRide.Size = new System.Drawing.Size(1015, 73);
            this.btnAddRide.TabIndex = 4;
            this.btnAddRide.Text = "Add new ride";
            this.btnAddRide.UseVisualStyleBackColor = false;
            this.btnAddRide.Visible = false;
            this.btnAddRide.Click += new System.EventHandler(this.btnAddRide_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReturn.Location = new System.Drawing.Point(988, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(134, 46);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // RidesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 879);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddRide);
            this.Controls.Add(this.dgvRollercoaster);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Name = "RidesForm";
            this.Text = "UserReviewForm";
            this.Load += new System.EventHandler(this.RidesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRollercoaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollercoasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dgvRollercoaster;
        private System.Windows.Forms.Button btnAddRide;
        private System.Windows.Forms.BindingSource rollercoasterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReturn;
    }
}