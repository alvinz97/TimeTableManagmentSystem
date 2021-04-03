namespace TimeTableManagmentSystem.Views.Subject
{
    partial class ManageSubjectForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSubjectForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.subjectDataGridView = new System.Windows.Forms.DataGridView();
            this.subjectSearcheIcon = new System.Windows.Forms.PictureBox();
            this.subjectSearchInput = new System.Windows.Forms.TextBox();
            this.addNewSubjectBtn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LectureHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorialHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvaluationHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectSearcheIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.subjectDataGridView);
            this.panel1.Controls.Add(this.subjectSearcheIcon);
            this.panel1.Controls.Add(this.subjectSearchInput);
            this.panel1.Controls.Add(this.addNewSubjectBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 575);
            this.panel1.TabIndex = 18;
            // 
            // subjectDataGridView
            // 
            this.subjectDataGridView.AllowUserToAddRows = false;
            this.subjectDataGridView.AllowUserToDeleteRows = false;
            this.subjectDataGridView.AllowUserToResizeRows = false;
            this.subjectDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subjectDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.subjectDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Year,
            this.Semester,
            this.SubjectName,
            this.SubjectCode,
            this.LectureHours,
            this.TutorialHours,
            this.LabHours,
            this.EvaluationHours,
            this.Column1,
            this.Column2});
            this.subjectDataGridView.Location = new System.Drawing.Point(0, 75);
            this.subjectDataGridView.MultiSelect = false;
            this.subjectDataGridView.Name = "subjectDataGridView";
            this.subjectDataGridView.ReadOnly = true;
            this.subjectDataGridView.RowHeadersVisible = false;
            this.subjectDataGridView.RowHeadersWidth = 51;
            this.subjectDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.subjectDataGridView.RowTemplate.Height = 24;
            this.subjectDataGridView.ShowEditingIcon = false;
            this.subjectDataGridView.Size = new System.Drawing.Size(1123, 497);
            this.subjectDataGridView.TabIndex = 0;
            this.subjectDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectDataGridView_CellContentClick);
            // 
            // subjectSearcheIcon
            // 
            this.subjectSearcheIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectSearcheIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subjectSearcheIcon.Image = global::TimeTableManagmentSystem.Properties.Resources.search;
            this.subjectSearcheIcon.Location = new System.Drawing.Point(1072, 17);
            this.subjectSearcheIcon.Name = "subjectSearcheIcon";
            this.subjectSearcheIcon.Size = new System.Drawing.Size(39, 38);
            this.subjectSearcheIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.subjectSearcheIcon.TabIndex = 5;
            this.subjectSearcheIcon.TabStop = false;
            // 
            // subjectSearchInput
            // 
            this.subjectSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectSearchInput.BackColor = System.Drawing.SystemColors.Control;
            this.subjectSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectSearchInput.Location = new System.Drawing.Point(663, 17);
            this.subjectSearchInput.Name = "subjectSearchInput";
            this.subjectSearchInput.Size = new System.Drawing.Size(409, 38);
            this.subjectSearchInput.TabIndex = 4;
            this.subjectSearchInput.TextChanged += new System.EventHandler(this.subjectSearchInput_TextChanged);
            // 
            // addNewSubjectBtn
            // 
            this.addNewSubjectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.addNewSubjectBtn.FlatAppearance.BorderSize = 0;
            this.addNewSubjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewSubjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewSubjectBtn.ForeColor = System.Drawing.Color.White;
            this.addNewSubjectBtn.Location = new System.Drawing.Point(13, 15);
            this.addNewSubjectBtn.Name = "addNewSubjectBtn";
            this.addNewSubjectBtn.Size = new System.Drawing.Size(110, 40);
            this.addNewSubjectBtn.TabIndex = 3;
            this.addNewSubjectBtn.Text = "New";
            this.addNewSubjectBtn.UseVisualStyleBackColor = false;
            this.addNewSubjectBtn.Click += new System.EventHandler(this.addNewSubjectBtn_Click);
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
            this.id.ToolTipText = "ID";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Year.DefaultCellStyle = dataGridViewCellStyle2;
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.ToolTipText = "Year";
            // 
            // Semester
            // 
            this.Semester.DataPropertyName = "Semester";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Semester.DefaultCellStyle = dataGridViewCellStyle3;
            this.Semester.HeaderText = "Semester";
            this.Semester.MinimumWidth = 6;
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            this.Semester.ToolTipText = "Semester";
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.SubjectName.DefaultCellStyle = dataGridViewCellStyle4;
            this.SubjectName.HeaderText = "Subject Name";
            this.SubjectName.MinimumWidth = 6;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            this.SubjectName.ToolTipText = "Subject Name";
            // 
            // SubjectCode
            // 
            this.SubjectCode.DataPropertyName = "SubjectCode";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.SubjectCode.DefaultCellStyle = dataGridViewCellStyle5;
            this.SubjectCode.HeaderText = "Subject Code";
            this.SubjectCode.MinimumWidth = 6;
            this.SubjectCode.Name = "SubjectCode";
            this.SubjectCode.ReadOnly = true;
            this.SubjectCode.ToolTipText = "Subject Code";
            // 
            // LectureHours
            // 
            this.LectureHours.DataPropertyName = "LectureHours";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.LectureHours.DefaultCellStyle = dataGridViewCellStyle6;
            this.LectureHours.HeaderText = "Lecture Hours";
            this.LectureHours.MinimumWidth = 6;
            this.LectureHours.Name = "LectureHours";
            this.LectureHours.ReadOnly = true;
            this.LectureHours.ToolTipText = "Lecture Hours";
            // 
            // TutorialHours
            // 
            this.TutorialHours.DataPropertyName = "TutorialHours";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.TutorialHours.DefaultCellStyle = dataGridViewCellStyle7;
            this.TutorialHours.HeaderText = "Tutorial Hours";
            this.TutorialHours.MinimumWidth = 6;
            this.TutorialHours.Name = "TutorialHours";
            this.TutorialHours.ReadOnly = true;
            this.TutorialHours.ToolTipText = "Tutorial Hours";
            // 
            // LabHours
            // 
            this.LabHours.DataPropertyName = "LabHours";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.LabHours.DefaultCellStyle = dataGridViewCellStyle8;
            this.LabHours.HeaderText = "Lab Hours";
            this.LabHours.MinimumWidth = 6;
            this.LabHours.Name = "LabHours";
            this.LabHours.ReadOnly = true;
            this.LabHours.ToolTipText = "Lab Hours";
            // 
            // EvaluationHours
            // 
            this.EvaluationHours.DataPropertyName = "EvaluationHours";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.EvaluationHours.DefaultCellStyle = dataGridViewCellStyle9;
            this.EvaluationHours.HeaderText = "Evaluation Hours";
            this.EvaluationHours.MinimumWidth = 6;
            this.EvaluationHours.Name = "EvaluationHours";
            this.EvaluationHours.ReadOnly = true;
            this.EvaluationHours.ToolTipText = "Evaluation Hours";
            // 
            // Column1
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "Delete";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Delete";
            this.Column2.ToolTipText = "Delete";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // ManageSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 615);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageSubjectForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Manage Subject";
            this.Shown += new System.EventHandler(this.ManageSubjectForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectSearcheIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView subjectDataGridView;
        private System.Windows.Forms.PictureBox subjectSearcheIcon;
        private System.Windows.Forms.TextBox subjectSearchInput;
        private System.Windows.Forms.Button addNewSubjectBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LectureHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorialHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvaluationHours;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}