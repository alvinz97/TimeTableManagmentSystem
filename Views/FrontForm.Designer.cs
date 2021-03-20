namespace TimeTableManagmentSystem.Views
{
    partial class FrontForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lecturersPanel = new System.Windows.Forms.Panel();
            this.lecturerCount = new System.Windows.Forms.Label();
            this.studentsPanel = new System.Windows.Forms.Panel();
            this.studentCount = new System.Windows.Forms.Label();
            this.subjectsPanel = new System.Windows.Forms.Panel();
            this.subjectCount = new System.Windows.Forms.Label();
            this.roomsPanel = new System.Windows.Forms.Panel();
            this.roomCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.latestSubjectDisplay = new System.Windows.Forms.Label();
            this.latestGroupDisplay = new System.Windows.Forms.Label();
            this.latestLectDisplay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.lecturersPanel.SuspendLayout();
            this.studentsPanel.SuspendLayout();
            this.subjectsPanel.SuspendLayout();
            this.roomsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lecturersPanel);
            this.panel1.Controls.Add(this.studentsPanel);
            this.panel1.Controls.Add(this.subjectsPanel);
            this.panel1.Controls.Add(this.roomsPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 583);
            this.panel1.TabIndex = 0;
            // 
            // lecturersPanel
            // 
            this.lecturersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.lecturersPanel.Controls.Add(this.lecturerCount);
            this.lecturersPanel.Location = new System.Drawing.Point(3, 3);
            this.lecturersPanel.Name = "lecturersPanel";
            this.lecturersPanel.Size = new System.Drawing.Size(200, 200);
            this.lecturersPanel.TabIndex = 5;
            // 
            // lecturerCount
            // 
            this.lecturerCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lecturerCount.AutoSize = true;
            this.lecturerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerCount.ForeColor = System.Drawing.Color.White;
            this.lecturerCount.Location = new System.Drawing.Point(49, 64);
            this.lecturerCount.Name = "lecturerCount";
            this.lecturerCount.Size = new System.Drawing.Size(95, 67);
            this.lecturerCount.TabIndex = 0;
            this.lecturerCount.Text = "25";
            // 
            // studentsPanel
            // 
            this.studentsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.studentsPanel.Controls.Add(this.studentCount);
            this.studentsPanel.Location = new System.Drawing.Point(299, 3);
            this.studentsPanel.Name = "studentsPanel";
            this.studentsPanel.Size = new System.Drawing.Size(200, 200);
            this.studentsPanel.TabIndex = 6;
            // 
            // studentCount
            // 
            this.studentCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentCount.AutoSize = true;
            this.studentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentCount.ForeColor = System.Drawing.Color.White;
            this.studentCount.Location = new System.Drawing.Point(53, 64);
            this.studentCount.Name = "studentCount";
            this.studentCount.Size = new System.Drawing.Size(95, 67);
            this.studentCount.TabIndex = 1;
            this.studentCount.Text = "25";
            // 
            // subjectsPanel
            // 
            this.subjectsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.subjectsPanel.Controls.Add(this.subjectCount);
            this.subjectsPanel.Location = new System.Drawing.Point(596, 4);
            this.subjectsPanel.Name = "subjectsPanel";
            this.subjectsPanel.Size = new System.Drawing.Size(200, 200);
            this.subjectsPanel.TabIndex = 7;
            // 
            // subjectCount
            // 
            this.subjectCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectCount.AutoSize = true;
            this.subjectCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectCount.ForeColor = System.Drawing.Color.White;
            this.subjectCount.Location = new System.Drawing.Point(55, 62);
            this.subjectCount.Name = "subjectCount";
            this.subjectCount.Size = new System.Drawing.Size(95, 67);
            this.subjectCount.TabIndex = 2;
            this.subjectCount.Text = "25";
            // 
            // roomsPanel
            // 
            this.roomsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.roomsPanel.Controls.Add(this.roomCount);
            this.roomsPanel.Location = new System.Drawing.Point(887, 3);
            this.roomsPanel.Name = "roomsPanel";
            this.roomsPanel.Size = new System.Drawing.Size(200, 200);
            this.roomsPanel.TabIndex = 8;
            // 
            // roomCount
            // 
            this.roomCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomCount.AutoSize = true;
            this.roomCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCount.ForeColor = System.Drawing.Color.White;
            this.roomCount.Location = new System.Drawing.Point(56, 64);
            this.roomCount.Name = "roomCount";
            this.roomCount.Size = new System.Drawing.Size(95, 67);
            this.roomCount.TabIndex = 3;
            this.roomCount.Text = "25";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.latestSubjectDisplay);
            this.panel2.Controls.Add(this.latestGroupDisplay);
            this.panel2.Controls.Add(this.latestLectDisplay);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(495, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 356);
            this.panel2.TabIndex = 9;
            // 
            // latestSubjectDisplay
            // 
            this.latestSubjectDisplay.AutoSize = true;
            this.latestSubjectDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latestSubjectDisplay.ForeColor = System.Drawing.Color.White;
            this.latestSubjectDisplay.Location = new System.Drawing.Point(236, 280);
            this.latestSubjectDisplay.Name = "latestSubjectDisplay";
            this.latestSubjectDisplay.Size = new System.Drawing.Size(81, 29);
            this.latestSubjectDisplay.TabIndex = 5;
            this.latestSubjectDisplay.Text = "Name";
            this.latestSubjectDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // latestGroupDisplay
            // 
            this.latestGroupDisplay.AutoSize = true;
            this.latestGroupDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latestGroupDisplay.ForeColor = System.Drawing.Color.White;
            this.latestGroupDisplay.Location = new System.Drawing.Point(234, 167);
            this.latestGroupDisplay.Name = "latestGroupDisplay";
            this.latestGroupDisplay.Size = new System.Drawing.Size(81, 29);
            this.latestGroupDisplay.TabIndex = 4;
            this.latestGroupDisplay.Text = "Name";
            this.latestGroupDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // latestLectDisplay
            // 
            this.latestLectDisplay.AutoSize = true;
            this.latestLectDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latestLectDisplay.ForeColor = System.Drawing.Color.White;
            this.latestLectDisplay.Location = new System.Drawing.Point(232, 50);
            this.latestLectDisplay.Name = "latestLectDisplay";
            this.latestLectDisplay.Size = new System.Drawing.Size(81, 29);
            this.latestLectDisplay.TabIndex = 3;
            this.latestLectDisplay.Text = "Name";
            this.latestLectDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Latest Subject :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Latest Group :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latest Lecturer :";
            // 
            // FrontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 623);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrontForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Front Form";
            this.panel1.ResumeLayout(false);
            this.lecturersPanel.ResumeLayout(false);
            this.lecturersPanel.PerformLayout();
            this.studentsPanel.ResumeLayout(false);
            this.studentsPanel.PerformLayout();
            this.subjectsPanel.ResumeLayout(false);
            this.subjectsPanel.PerformLayout();
            this.roomsPanel.ResumeLayout(false);
            this.roomsPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel lecturersPanel;
        private System.Windows.Forms.Label lecturerCount;
        private System.Windows.Forms.Panel studentsPanel;
        private System.Windows.Forms.Label studentCount;
        private System.Windows.Forms.Panel subjectsPanel;
        private System.Windows.Forms.Label subjectCount;
        private System.Windows.Forms.Panel roomsPanel;
        private System.Windows.Forms.Label roomCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label latestSubjectDisplay;
        private System.Windows.Forms.Label latestGroupDisplay;
        private System.Windows.Forms.Label latestLectDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}