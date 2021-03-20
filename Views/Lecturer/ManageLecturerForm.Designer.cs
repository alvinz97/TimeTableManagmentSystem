namespace TimeTableManagmentSystem.Views.Lecturer
{
    partial class ManageLecturerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLecturerForm));
            this.lecturerPanel = new System.Windows.Forms.Panel();
            this.lecturerDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LecturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Center = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LecturerLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addNewLecturerBtn = new System.Windows.Forms.Button();
            this.lecturerSearcheIcon = new System.Windows.Forms.PictureBox();
            this.lecturerSearchInput = new System.Windows.Forms.TextBox();
            this.lecturerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerSearcheIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lecturerPanel
            // 
            this.lecturerPanel.BackColor = System.Drawing.Color.White;
            this.lecturerPanel.Controls.Add(this.lecturerDataGridView);
            this.lecturerPanel.Controls.Add(this.addNewLecturerBtn);
            this.lecturerPanel.Controls.Add(this.lecturerSearcheIcon);
            this.lecturerPanel.Controls.Add(this.lecturerSearchInput);
            this.lecturerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lecturerPanel.Location = new System.Drawing.Point(20, 20);
            this.lecturerPanel.Name = "lecturerPanel";
            this.lecturerPanel.Size = new System.Drawing.Size(1126, 575);
            this.lecturerPanel.TabIndex = 0;
            // 
            // lecturerDataGridView
            // 
            this.lecturerDataGridView.AllowDrop = true;
            this.lecturerDataGridView.AllowUserToAddRows = false;
            this.lecturerDataGridView.AllowUserToDeleteRows = false;
            this.lecturerDataGridView.AllowUserToResizeColumns = false;
            this.lecturerDataGridView.AllowUserToResizeRows = false;
            this.lecturerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lecturerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lecturerDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.lecturerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lecturerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecturerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.LecturerName,
            this.Faculty,
            this.Department,
            this.Center,
            this.Building,
            this.LecturerLevel,
            this.Rank,
            this.Edit,
            this.Delete});
            this.lecturerDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.lecturerDataGridView.GridColor = System.Drawing.Color.White;
            this.lecturerDataGridView.Location = new System.Drawing.Point(12, 66);
            this.lecturerDataGridView.MultiSelect = false;
            this.lecturerDataGridView.Name = "lecturerDataGridView";
            this.lecturerDataGridView.ReadOnly = true;
            this.lecturerDataGridView.RowHeadersVisible = false;
            this.lecturerDataGridView.RowHeadersWidth = 51;
            this.lecturerDataGridView.RowTemplate.Height = 24;
            this.lecturerDataGridView.ShowEditingIcon = false;
            this.lecturerDataGridView.Size = new System.Drawing.Size(1103, 497);
            this.lecturerDataGridView.TabIndex = 0;
            this.lecturerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lecturerDataGridView_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // LecturerName
            // 
            this.LecturerName.DataPropertyName = "LecturerName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.LecturerName.DefaultCellStyle = dataGridViewCellStyle2;
            this.LecturerName.HeaderText = "Lecturer Name";
            this.LecturerName.MinimumWidth = 6;
            this.LecturerName.Name = "LecturerName";
            this.LecturerName.ReadOnly = true;
            this.LecturerName.ToolTipText = "Lecturer Name";
            // 
            // Faculty
            // 
            this.Faculty.DataPropertyName = "Faculty";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Faculty.DefaultCellStyle = dataGridViewCellStyle3;
            this.Faculty.HeaderText = "Faculty";
            this.Faculty.MinimumWidth = 6;
            this.Faculty.Name = "Faculty";
            this.Faculty.ReadOnly = true;
            this.Faculty.ToolTipText = "Faculty";
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Department.DefaultCellStyle = dataGridViewCellStyle4;
            this.Department.HeaderText = "Department";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.ToolTipText = "Department";
            // 
            // Center
            // 
            this.Center.DataPropertyName = "Center";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Center.DefaultCellStyle = dataGridViewCellStyle5;
            this.Center.HeaderText = "Center";
            this.Center.MinimumWidth = 6;
            this.Center.Name = "Center";
            this.Center.ReadOnly = true;
            this.Center.ToolTipText = "Center";
            // 
            // Building
            // 
            this.Building.DataPropertyName = "Building";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Building.DefaultCellStyle = dataGridViewCellStyle6;
            this.Building.HeaderText = "Building";
            this.Building.MinimumWidth = 6;
            this.Building.Name = "Building";
            this.Building.ReadOnly = true;
            this.Building.ToolTipText = "Building";
            // 
            // LecturerLevel
            // 
            this.LecturerLevel.DataPropertyName = "LecturerLevel";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.LecturerLevel.DefaultCellStyle = dataGridViewCellStyle7;
            this.LecturerLevel.HeaderText = "Level";
            this.LecturerLevel.MinimumWidth = 6;
            this.LecturerLevel.Name = "LecturerLevel";
            this.LecturerLevel.ReadOnly = true;
            this.LecturerLevel.ToolTipText = "Level";
            // 
            // Rank
            // 
            this.Rank.DataPropertyName = "Rank";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Rank.DefaultCellStyle = dataGridViewCellStyle8;
            this.Rank.HeaderText = "Rank";
            this.Rank.MinimumWidth = 6;
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            this.Rank.ToolTipText = "Rank";
            // 
            // Edit
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle9;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle10;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // addNewLecturerBtn
            // 
            this.addNewLecturerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.addNewLecturerBtn.FlatAppearance.BorderSize = 0;
            this.addNewLecturerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewLecturerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewLecturerBtn.ForeColor = System.Drawing.Color.White;
            this.addNewLecturerBtn.Location = new System.Drawing.Point(12, 10);
            this.addNewLecturerBtn.Name = "addNewLecturerBtn";
            this.addNewLecturerBtn.Size = new System.Drawing.Size(110, 40);
            this.addNewLecturerBtn.TabIndex = 8;
            this.addNewLecturerBtn.Text = "New";
            this.addNewLecturerBtn.UseVisualStyleBackColor = false;
            // 
            // lecturerSearcheIcon
            // 
            this.lecturerSearcheIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lecturerSearcheIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lecturerSearcheIcon.Image = global::TimeTableManagmentSystem.Properties.Resources.search;
            this.lecturerSearcheIcon.Location = new System.Drawing.Point(1076, 12);
            this.lecturerSearcheIcon.Name = "lecturerSearcheIcon";
            this.lecturerSearcheIcon.Size = new System.Drawing.Size(39, 38);
            this.lecturerSearcheIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lecturerSearcheIcon.TabIndex = 7;
            this.lecturerSearcheIcon.TabStop = false;
            // 
            // lecturerSearchInput
            // 
            this.lecturerSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lecturerSearchInput.BackColor = System.Drawing.SystemColors.Control;
            this.lecturerSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerSearchInput.Location = new System.Drawing.Point(667, 12);
            this.lecturerSearchInput.Name = "lecturerSearchInput";
            this.lecturerSearchInput.Size = new System.Drawing.Size(409, 38);
            this.lecturerSearchInput.TabIndex = 6;
            this.lecturerSearchInput.TextChanged += new System.EventHandler(this.lecturerSearchInput_TextChanged);
            // 
            // ManageLecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 615);
            this.Controls.Add(this.lecturerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageLecturerForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Manage Lecturers";
            this.Shown += new System.EventHandler(this.ManageLecturerForm_Shown);
            this.lecturerPanel.ResumeLayout(false);
            this.lecturerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerSearcheIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lecturerPanel;
        private System.Windows.Forms.PictureBox lecturerSearcheIcon;
        private System.Windows.Forms.TextBox lecturerSearchInput;
        private System.Windows.Forms.Button addNewLecturerBtn;
        private System.Windows.Forms.DataGridView lecturerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LecturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Center;
        private System.Windows.Forms.DataGridViewTextBoxColumn Building;
        private System.Windows.Forms.DataGridViewTextBoxColumn LecturerLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}