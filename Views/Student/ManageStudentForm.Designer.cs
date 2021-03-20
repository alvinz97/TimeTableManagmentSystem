namespace TimeTableManagmentSystem.Views.Student
{
    partial class ManageStudentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.locationSearcheIcon = new System.Windows.Forms.PictureBox();
            this.studentSearchInput = new System.Windows.Forms.TextBox();
            this.addNewLocationBtn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubGroupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationSearcheIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.studentDataGridView);
            this.panel1.Controls.Add(this.locationSearcheIcon);
            this.panel1.Controls.Add(this.studentSearchInput);
            this.panel1.Controls.Add(this.addNewLocationBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 575);
            this.panel1.TabIndex = 17;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToAddRows = false;
            this.studentDataGridView.AllowUserToDeleteRows = false;
            this.studentDataGridView.AllowUserToResizeRows = false;
            this.studentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.studentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Year,
            this.Semester,
            this.Program,
            this.GroupNo,
            this.SubGroupNo,
            this.GroupID,
            this.SubGroupID,
            this.Column1,
            this.Column2});
            this.studentDataGridView.Location = new System.Drawing.Point(0, 75);
            this.studentDataGridView.MultiSelect = false;
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.ReadOnly = true;
            this.studentDataGridView.RowHeadersVisible = false;
            this.studentDataGridView.RowHeadersWidth = 51;
            this.studentDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.studentDataGridView.RowTemplate.Height = 24;
            this.studentDataGridView.ShowEditingIcon = false;
            this.studentDataGridView.Size = new System.Drawing.Size(1123, 497);
            this.studentDataGridView.TabIndex = 0;
            this.studentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_CellClick_1);
            this.studentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_CellContentClick_1);
            // 
            // locationSearcheIcon
            // 
            this.locationSearcheIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locationSearcheIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.locationSearcheIcon.Image = global::TimeTableManagmentSystem.Properties.Resources.search;
            this.locationSearcheIcon.Location = new System.Drawing.Point(1072, 17);
            this.locationSearcheIcon.Name = "locationSearcheIcon";
            this.locationSearcheIcon.Size = new System.Drawing.Size(39, 38);
            this.locationSearcheIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.locationSearcheIcon.TabIndex = 5;
            this.locationSearcheIcon.TabStop = false;
            // 
            // studentSearchInput
            // 
            this.studentSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studentSearchInput.BackColor = System.Drawing.SystemColors.Control;
            this.studentSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentSearchInput.Location = new System.Drawing.Point(663, 17);
            this.studentSearchInput.Name = "studentSearchInput";
            this.studentSearchInput.Size = new System.Drawing.Size(409, 38);
            this.studentSearchInput.TabIndex = 4;
            // 
            // addNewLocationBtn
            // 
            this.addNewLocationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.addNewLocationBtn.FlatAppearance.BorderSize = 0;
            this.addNewLocationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewLocationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewLocationBtn.ForeColor = System.Drawing.Color.White;
            this.addNewLocationBtn.Location = new System.Drawing.Point(13, 15);
            this.addNewLocationBtn.Name = "addNewLocationBtn";
            this.addNewLocationBtn.Size = new System.Drawing.Size(110, 40);
            this.addNewLocationBtn.TabIndex = 3;
            this.addNewLocationBtn.Text = "New";
            this.addNewLocationBtn.UseVisualStyleBackColor = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.DefaultCellStyle = dataGridViewCellStyle61;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.ToolTipText = "ID";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Year.DefaultCellStyle = dataGridViewCellStyle62;
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.ToolTipText = "Year";
            // 
            // Semester
            // 
            this.Semester.DataPropertyName = "Semester";
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Semester.DefaultCellStyle = dataGridViewCellStyle63;
            this.Semester.HeaderText = "Semester";
            this.Semester.MinimumWidth = 6;
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            this.Semester.ToolTipText = "Semester";
            // 
            // Program
            // 
            this.Program.DataPropertyName = "Program";
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Program.DefaultCellStyle = dataGridViewCellStyle64;
            this.Program.HeaderText = "Program";
            this.Program.MinimumWidth = 6;
            this.Program.Name = "Program";
            this.Program.ReadOnly = true;
            this.Program.ToolTipText = "Program";
            // 
            // GroupNo
            // 
            this.GroupNo.DataPropertyName = "GroupNo";
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.GroupNo.DefaultCellStyle = dataGridViewCellStyle65;
            this.GroupNo.HeaderText = "GroupNo";
            this.GroupNo.MinimumWidth = 6;
            this.GroupNo.Name = "GroupNo";
            this.GroupNo.ReadOnly = true;
            this.GroupNo.ToolTipText = "GroupNo";
            // 
            // SubGroupNo
            // 
            this.SubGroupNo.DataPropertyName = "SubGroupNo";
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.SubGroupNo.DefaultCellStyle = dataGridViewCellStyle66;
            this.SubGroupNo.HeaderText = "SubGroupNo";
            this.SubGroupNo.MinimumWidth = 6;
            this.SubGroupNo.Name = "SubGroupNo";
            this.SubGroupNo.ReadOnly = true;
            this.SubGroupNo.ToolTipText = "SubGroupNo";
            // 
            // GroupID
            // 
            this.GroupID.DataPropertyName = "GroupID";
            dataGridViewCellStyle67.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.GroupID.DefaultCellStyle = dataGridViewCellStyle67;
            this.GroupID.HeaderText = "GroupID";
            this.GroupID.MinimumWidth = 6;
            this.GroupID.Name = "GroupID";
            this.GroupID.ReadOnly = true;
            this.GroupID.ToolTipText = "GroupID";
            // 
            // SubGroupID
            // 
            this.SubGroupID.DataPropertyName = "SubGroupID";
            dataGridViewCellStyle68.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.SubGroupID.DefaultCellStyle = dataGridViewCellStyle68;
            this.SubGroupID.HeaderText = "SubGroupID";
            this.SubGroupID.MinimumWidth = 6;
            this.SubGroupID.Name = "SubGroupID";
            this.SubGroupID.ReadOnly = true;
            this.SubGroupID.ToolTipText = "SubGroupID";
            // 
            // Column1
            // 
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle69.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle69.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            dataGridViewCellStyle69.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle69;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "Edit";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Edit";
            this.Column1.ToolTipText = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle70.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle70.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            dataGridViewCellStyle70.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle70;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "Delete";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Delete";
            this.Column2.ToolTipText = "Delete";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 615);
            this.Controls.Add(this.panel1);
            this.Name = "ManageStudentForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "ManageStudentForm";
            this.Shown += new System.EventHandler(this.ManageStudentForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationSearcheIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox locationSearcheIcon;
        private System.Windows.Forms.TextBox studentSearchInput;
        private System.Windows.Forms.Button addNewLocationBtn;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubGroupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubGroupID;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}