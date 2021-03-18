namespace TimeTableManagmentSystem.Views.Working
{
    partial class ManageWeekendNWeekdayFrom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.weekendWeekdayDataGridView = new System.Windows.Forms.DataGridView();
            this.weekendWeekdaySearcheIcon = new System.Windows.Forms.PictureBox();
            this.weekendWeekdaySearchInput = new System.Windows.Forms.TextBox();
            this.addNewWeekdayNWeekendBtn = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekendWeekdayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekendWeekdaySearcheIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.weekendWeekdayDataGridView);
            this.panel1.Controls.Add(this.weekendWeekdaySearcheIcon);
            this.panel1.Controls.Add(this.weekendWeekdaySearchInput);
            this.panel1.Controls.Add(this.addNewWeekdayNWeekendBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 575);
            this.panel1.TabIndex = 24;
            // 
            // weekendWeekdayDataGridView
            // 
            this.weekendWeekdayDataGridView.AllowUserToAddRows = false;
            this.weekendWeekdayDataGridView.AllowUserToDeleteRows = false;
            this.weekendWeekdayDataGridView.AllowUserToResizeColumns = false;
            this.weekendWeekdayDataGridView.AllowUserToResizeRows = false;
            this.weekendWeekdayDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weekendWeekdayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.weekendWeekdayDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.weekendWeekdayDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weekendWeekdayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weekendWeekdayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.weekendWeekdayDataGridView.Location = new System.Drawing.Point(14, 78);
            this.weekendWeekdayDataGridView.Name = "weekendWeekdayDataGridView";
            this.weekendWeekdayDataGridView.ReadOnly = true;
            this.weekendWeekdayDataGridView.RowHeadersWidth = 51;
            this.weekendWeekdayDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.weekendWeekdayDataGridView.RowTemplate.Height = 24;
            this.weekendWeekdayDataGridView.ShowEditingIcon = false;
            this.weekendWeekdayDataGridView.Size = new System.Drawing.Size(1098, 481);
            this.weekendWeekdayDataGridView.TabIndex = 6;
            this.weekendWeekdayDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.weekendWeekdayDataGridView_CellContentClick);
            // 
            // weekendWeekdaySearcheIcon
            // 
            this.weekendWeekdaySearcheIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weekendWeekdaySearcheIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weekendWeekdaySearcheIcon.Image = global::TimeTableManagmentSystem.Properties.Resources.search;
            this.weekendWeekdaySearcheIcon.Location = new System.Drawing.Point(1073, 18);
            this.weekendWeekdaySearcheIcon.Name = "weekendWeekdaySearcheIcon";
            this.weekendWeekdaySearcheIcon.Size = new System.Drawing.Size(39, 38);
            this.weekendWeekdaySearcheIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weekendWeekdaySearcheIcon.TabIndex = 9;
            this.weekendWeekdaySearcheIcon.TabStop = false;
            // 
            // weekendWeekdaySearchInput
            // 
            this.weekendWeekdaySearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.weekendWeekdaySearchInput.BackColor = System.Drawing.SystemColors.Control;
            this.weekendWeekdaySearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekendWeekdaySearchInput.Location = new System.Drawing.Point(664, 18);
            this.weekendWeekdaySearchInput.Name = "weekendWeekdaySearchInput";
            this.weekendWeekdaySearchInput.Size = new System.Drawing.Size(409, 38);
            this.weekendWeekdaySearchInput.TabIndex = 8;
            this.weekendWeekdaySearchInput.TextChanged += new System.EventHandler(this.weekendWeekdaySearchInput_TextChanged);
            // 
            // addNewWeekdayNWeekendBtn
            // 
            this.addNewWeekdayNWeekendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.addNewWeekdayNWeekendBtn.FlatAppearance.BorderSize = 0;
            this.addNewWeekdayNWeekendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewWeekdayNWeekendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewWeekdayNWeekendBtn.ForeColor = System.Drawing.Color.White;
            this.addNewWeekdayNWeekendBtn.Location = new System.Drawing.Point(14, 16);
            this.addNewWeekdayNWeekendBtn.Name = "addNewWeekdayNWeekendBtn";
            this.addNewWeekdayNWeekendBtn.Size = new System.Drawing.Size(110, 40);
            this.addNewWeekdayNWeekendBtn.TabIndex = 7;
            this.addNewWeekdayNWeekendBtn.Text = "New";
            this.addNewWeekdayNWeekendBtn.UseVisualStyleBackColor = false;
            this.addNewWeekdayNWeekendBtn.Click += new System.EventHandler(this.addNewWeekdayNWeekendBtn_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 4;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LecturerName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Lecturer Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NoOfWorkingDay";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "No Of Working Days Per Week";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "WorkingDays";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Working Days";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TimePerDay";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Time Per Day (H)";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(106)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(106)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column6.HeaderText = "Edit";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Text = "Edit";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column7.HeaderText = "Delete";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Delete";
            this.Column7.UseColumnTextForButtonValue = true;
            // 
            // ManageWeekendNWeekdayFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 615);
            this.Controls.Add(this.panel1);
            this.Name = "ManageWeekendNWeekdayFrom";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "ViewDetailsFrom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekendWeekdayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekendWeekdaySearcheIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView weekendWeekdayDataGridView;
        private System.Windows.Forms.PictureBox weekendWeekdaySearcheIcon;
        private System.Windows.Forms.TextBox weekendWeekdaySearchInput;
        private System.Windows.Forms.Button addNewWeekdayNWeekendBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
    }
}