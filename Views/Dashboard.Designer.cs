namespace TimeTableManagmentSystem.Views
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.topHeaderPanel = new System.Windows.Forms.Panel();
            this.headerDynamicLabel = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.locationSubMenuPanel = new System.Windows.Forms.Panel();
            this.addLocationSubMenuBtn = new System.Windows.Forms.Button();
            this.locationListSubMenuBtn = new System.Windows.Forms.Button();
            this.locationsMenuBtn = new System.Windows.Forms.Button();
            this.tagMenuBtn = new System.Windows.Forms.Button();
            this.subjectMenuBtn = new System.Windows.Forms.Button();
            this.studentsMenuBtn = new System.Windows.Forms.Button();
            this.lecturersMenuBtn = new System.Windows.Forms.Button();
            this.workingHDSubMenuPanel = new System.Windows.Forms.Panel();
            this.viewWeekdaysDetailsSubmenuBtn = new System.Windows.Forms.Button();
            this.weekdayDetailsSubmenuBtn = new System.Windows.Forms.Button();
            this.weekendDetailsSubmenuBtn = new System.Windows.Forms.Button();
            this.workingHDMenuBtn = new System.Windows.Forms.Button();
            this.dashboardMenuBtn = new System.Windows.Forms.Button();
            this.childContainerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.systemNameLable = new System.Windows.Forms.Label();
            this.subSystemNameLable = new System.Windows.Forms.Label();
            this.topHeaderPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.locationSubMenuPanel.SuspendLayout();
            this.workingHDSubMenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topHeaderPanel
            // 
            this.topHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.topHeaderPanel.Controls.Add(this.panel1);
            this.topHeaderPanel.Controls.Add(this.headerDynamicLabel);
            this.topHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.topHeaderPanel.Name = "topHeaderPanel";
            this.topHeaderPanel.Size = new System.Drawing.Size(1459, 86);
            this.topHeaderPanel.TabIndex = 0;
            this.topHeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topHeaderPanel_Paint);
            // 
            // headerDynamicLabel
            // 
            this.headerDynamicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.headerDynamicLabel.AutoSize = true;
            this.headerDynamicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerDynamicLabel.ForeColor = System.Drawing.Color.White;
            this.headerDynamicLabel.Location = new System.Drawing.Point(272, 22);
            this.headerDynamicLabel.Name = "headerDynamicLabel";
            this.headerDynamicLabel.Size = new System.Drawing.Size(0, 36);
            this.headerDynamicLabel.TabIndex = 0;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.AutoScroll = true;
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.sidebarPanel.Controls.Add(this.locationSubMenuPanel);
            this.sidebarPanel.Controls.Add(this.locationsMenuBtn);
            this.sidebarPanel.Controls.Add(this.tagMenuBtn);
            this.sidebarPanel.Controls.Add(this.subjectMenuBtn);
            this.sidebarPanel.Controls.Add(this.studentsMenuBtn);
            this.sidebarPanel.Controls.Add(this.lecturersMenuBtn);
            this.sidebarPanel.Controls.Add(this.workingHDSubMenuPanel);
            this.sidebarPanel.Controls.Add(this.workingHDMenuBtn);
            this.sidebarPanel.Controls.Add(this.dashboardMenuBtn);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 86);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(275, 662);
            this.sidebarPanel.TabIndex = 1;
            // 
            // locationSubMenuPanel
            // 
            this.locationSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.locationSubMenuPanel.Controls.Add(this.addLocationSubMenuBtn);
            this.locationSubMenuPanel.Controls.Add(this.locationListSubMenuBtn);
            this.locationSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.locationSubMenuPanel.Location = new System.Drawing.Point(0, 349);
            this.locationSubMenuPanel.Name = "locationSubMenuPanel";
            this.locationSubMenuPanel.Size = new System.Drawing.Size(275, 74);
            this.locationSubMenuPanel.TabIndex = 13;
            // 
            // addLocationSubMenuBtn
            // 
            this.addLocationSubMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.addLocationSubMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addLocationSubMenuBtn.FlatAppearance.BorderSize = 0;
            this.addLocationSubMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLocationSubMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLocationSubMenuBtn.ForeColor = System.Drawing.Color.White;
            this.addLocationSubMenuBtn.Location = new System.Drawing.Point(0, 35);
            this.addLocationSubMenuBtn.Name = "addLocationSubMenuBtn";
            this.addLocationSubMenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addLocationSubMenuBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addLocationSubMenuBtn.Size = new System.Drawing.Size(275, 35);
            this.addLocationSubMenuBtn.TabIndex = 1;
            this.addLocationSubMenuBtn.Text = "Add List";
            this.addLocationSubMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addLocationSubMenuBtn.UseVisualStyleBackColor = false;
            this.addLocationSubMenuBtn.Click += new System.EventHandler(this.addLocationSubMenuBtn_Click);
            // 
            // locationListSubMenuBtn
            // 
            this.locationListSubMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.locationListSubMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.locationListSubMenuBtn.FlatAppearance.BorderSize = 0;
            this.locationListSubMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationListSubMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationListSubMenuBtn.ForeColor = System.Drawing.Color.White;
            this.locationListSubMenuBtn.Location = new System.Drawing.Point(0, 0);
            this.locationListSubMenuBtn.Name = "locationListSubMenuBtn";
            this.locationListSubMenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.locationListSubMenuBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.locationListSubMenuBtn.Size = new System.Drawing.Size(275, 35);
            this.locationListSubMenuBtn.TabIndex = 0;
            this.locationListSubMenuBtn.Text = "Location List";
            this.locationListSubMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.locationListSubMenuBtn.UseVisualStyleBackColor = false;
            this.locationListSubMenuBtn.Click += new System.EventHandler(this.locationListSubMenuBtn_Click);
            // 
            // locationsMenuBtn
            // 
            this.locationsMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(138)))));
            this.locationsMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.locationsMenuBtn.FlatAppearance.BorderSize = 0;
            this.locationsMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationsMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationsMenuBtn.ForeColor = System.Drawing.Color.White;
            this.locationsMenuBtn.Location = new System.Drawing.Point(0, 314);
            this.locationsMenuBtn.Name = "locationsMenuBtn";
            this.locationsMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.locationsMenuBtn.Size = new System.Drawing.Size(275, 35);
            this.locationsMenuBtn.TabIndex = 11;
            this.locationsMenuBtn.Text = "Locations";
            this.locationsMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.locationsMenuBtn.UseVisualStyleBackColor = false;
            this.locationsMenuBtn.Click += new System.EventHandler(this.locationsMenuBtn_Click_1);
            // 
            // tagMenuBtn
            // 
            this.tagMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(138)))));
            this.tagMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tagMenuBtn.FlatAppearance.BorderSize = 0;
            this.tagMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tagMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagMenuBtn.ForeColor = System.Drawing.Color.White;
            this.tagMenuBtn.Location = new System.Drawing.Point(0, 279);
            this.tagMenuBtn.Name = "tagMenuBtn";
            this.tagMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.tagMenuBtn.Size = new System.Drawing.Size(275, 35);
            this.tagMenuBtn.TabIndex = 10;
            this.tagMenuBtn.Text = "Tags";
            this.tagMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tagMenuBtn.UseVisualStyleBackColor = false;
            // 
            // subjectMenuBtn
            // 
            this.subjectMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(138)))));
            this.subjectMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectMenuBtn.FlatAppearance.BorderSize = 0;
            this.subjectMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectMenuBtn.ForeColor = System.Drawing.Color.White;
            this.subjectMenuBtn.Location = new System.Drawing.Point(0, 244);
            this.subjectMenuBtn.Name = "subjectMenuBtn";
            this.subjectMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.subjectMenuBtn.Size = new System.Drawing.Size(275, 35);
            this.subjectMenuBtn.TabIndex = 9;
            this.subjectMenuBtn.Text = "Subjects";
            this.subjectMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectMenuBtn.UseVisualStyleBackColor = false;
            // 
            // studentsMenuBtn
            // 
            this.studentsMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(138)))));
            this.studentsMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentsMenuBtn.FlatAppearance.BorderSize = 0;
            this.studentsMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentsMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsMenuBtn.ForeColor = System.Drawing.Color.White;
            this.studentsMenuBtn.Location = new System.Drawing.Point(0, 209);
            this.studentsMenuBtn.Name = "studentsMenuBtn";
            this.studentsMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.studentsMenuBtn.Size = new System.Drawing.Size(275, 35);
            this.studentsMenuBtn.TabIndex = 8;
            this.studentsMenuBtn.Text = "Students";
            this.studentsMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentsMenuBtn.UseVisualStyleBackColor = false;
            // 
            // lecturersMenuBtn
            // 
            this.lecturersMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(138)))));
            this.lecturersMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lecturersMenuBtn.FlatAppearance.BorderSize = 0;
            this.lecturersMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lecturersMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturersMenuBtn.ForeColor = System.Drawing.Color.White;
            this.lecturersMenuBtn.Location = new System.Drawing.Point(0, 174);
            this.lecturersMenuBtn.Name = "lecturersMenuBtn";
            this.lecturersMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lecturersMenuBtn.Size = new System.Drawing.Size(275, 35);
            this.lecturersMenuBtn.TabIndex = 7;
            this.lecturersMenuBtn.Text = "Lecturers";
            this.lecturersMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lecturersMenuBtn.UseVisualStyleBackColor = false;
            // 
            // workingHDSubMenuPanel
            // 
            this.workingHDSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.workingHDSubMenuPanel.Controls.Add(this.viewWeekdaysDetailsSubmenuBtn);
            this.workingHDSubMenuPanel.Controls.Add(this.weekdayDetailsSubmenuBtn);
            this.workingHDSubMenuPanel.Controls.Add(this.weekendDetailsSubmenuBtn);
            this.workingHDSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.workingHDSubMenuPanel.Location = new System.Drawing.Point(0, 70);
            this.workingHDSubMenuPanel.Name = "workingHDSubMenuPanel";
            this.workingHDSubMenuPanel.Size = new System.Drawing.Size(275, 104);
            this.workingHDSubMenuPanel.TabIndex = 6;
            // 
            // viewWeekdaysDetailsSubmenuBtn
            // 
            this.viewWeekdaysDetailsSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.viewWeekdaysDetailsSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewWeekdaysDetailsSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.viewWeekdaysDetailsSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewWeekdaysDetailsSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewWeekdaysDetailsSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.viewWeekdaysDetailsSubmenuBtn.Location = new System.Drawing.Point(0, 70);
            this.viewWeekdaysDetailsSubmenuBtn.Name = "viewWeekdaysDetailsSubmenuBtn";
            this.viewWeekdaysDetailsSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.viewWeekdaysDetailsSubmenuBtn.Size = new System.Drawing.Size(275, 35);
            this.viewWeekdaysDetailsSubmenuBtn.TabIndex = 8;
            this.viewWeekdaysDetailsSubmenuBtn.Text = "View Details";
            this.viewWeekdaysDetailsSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewWeekdaysDetailsSubmenuBtn.UseVisualStyleBackColor = false;
            this.viewWeekdaysDetailsSubmenuBtn.Click += new System.EventHandler(this.viewWeekdaysDetailsSubmenuBtn_Click);
            // 
            // weekdayDetailsSubmenuBtn
            // 
            this.weekdayDetailsSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.weekdayDetailsSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.weekdayDetailsSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.weekdayDetailsSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weekdayDetailsSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekdayDetailsSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.weekdayDetailsSubmenuBtn.Location = new System.Drawing.Point(0, 35);
            this.weekdayDetailsSubmenuBtn.Name = "weekdayDetailsSubmenuBtn";
            this.weekdayDetailsSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.weekdayDetailsSubmenuBtn.Size = new System.Drawing.Size(275, 35);
            this.weekdayDetailsSubmenuBtn.TabIndex = 6;
            this.weekdayDetailsSubmenuBtn.Text = "Weekday Details";
            this.weekdayDetailsSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.weekdayDetailsSubmenuBtn.UseVisualStyleBackColor = false;
            this.weekdayDetailsSubmenuBtn.Click += new System.EventHandler(this.weekdayDetailsSubmenuBtn_Click);
            // 
            // weekendDetailsSubmenuBtn
            // 
            this.weekendDetailsSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.weekendDetailsSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.weekendDetailsSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.weekendDetailsSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weekendDetailsSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekendDetailsSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.weekendDetailsSubmenuBtn.Location = new System.Drawing.Point(0, 0);
            this.weekendDetailsSubmenuBtn.Name = "weekendDetailsSubmenuBtn";
            this.weekendDetailsSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.weekendDetailsSubmenuBtn.Size = new System.Drawing.Size(275, 35);
            this.weekendDetailsSubmenuBtn.TabIndex = 7;
            this.weekendDetailsSubmenuBtn.Text = "Weekend Details";
            this.weekendDetailsSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.weekendDetailsSubmenuBtn.UseVisualStyleBackColor = false;
            this.weekendDetailsSubmenuBtn.Click += new System.EventHandler(this.weekendDetailsSubmenuBtn_Click);
            // 
            // workingHDMenuBtn
            // 
            this.workingHDMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(138)))));
            this.workingHDMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.workingHDMenuBtn.FlatAppearance.BorderSize = 0;
            this.workingHDMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workingHDMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingHDMenuBtn.ForeColor = System.Drawing.Color.White;
            this.workingHDMenuBtn.Location = new System.Drawing.Point(0, 35);
            this.workingHDMenuBtn.Name = "workingHDMenuBtn";
            this.workingHDMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.workingHDMenuBtn.Size = new System.Drawing.Size(275, 35);
            this.workingHDMenuBtn.TabIndex = 5;
            this.workingHDMenuBtn.Text = "Working Hours and Days";
            this.workingHDMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.workingHDMenuBtn.UseVisualStyleBackColor = false;
            this.workingHDMenuBtn.Click += new System.EventHandler(this.workingHDMenuBtn_Click);
            // 
            // dashboardMenuBtn
            // 
            this.dashboardMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(138)))));
            this.dashboardMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardMenuBtn.FlatAppearance.BorderSize = 0;
            this.dashboardMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardMenuBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardMenuBtn.Location = new System.Drawing.Point(0, 0);
            this.dashboardMenuBtn.Name = "dashboardMenuBtn";
            this.dashboardMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.dashboardMenuBtn.Size = new System.Drawing.Size(275, 35);
            this.dashboardMenuBtn.TabIndex = 4;
            this.dashboardMenuBtn.Text = "Dashboard";
            this.dashboardMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardMenuBtn.UseVisualStyleBackColor = false;
            this.dashboardMenuBtn.Click += new System.EventHandler(this.dashboardMenuBtn_Click);
            // 
            // childContainerPanel
            // 
            this.childContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childContainerPanel.Location = new System.Drawing.Point(275, 86);
            this.childContainerPanel.Name = "childContainerPanel";
            this.childContainerPanel.Size = new System.Drawing.Size(1184, 662);
            this.childContainerPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.subSystemNameLable);
            this.panel1.Controls.Add(this.systemNameLable);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 86);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // systemNameLable
            // 
            this.systemNameLable.AutoSize = true;
            this.systemNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemNameLable.ForeColor = System.Drawing.Color.White;
            this.systemNameLable.Location = new System.Drawing.Point(129, 10);
            this.systemNameLable.Name = "systemNameLable";
            this.systemNameLable.Size = new System.Drawing.Size(110, 39);
            this.systemNameLable.TabIndex = 1;
            this.systemNameLable.Text = "TTMS";
            // 
            // subSystemNameLable
            // 
            this.subSystemNameLable.AutoSize = true;
            this.subSystemNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subSystemNameLable.ForeColor = System.Drawing.Color.White;
            this.subSystemNameLable.Location = new System.Drawing.Point(134, 50);
            this.subSystemNameLable.Name = "subSystemNameLable";
            this.subSystemNameLable.Size = new System.Drawing.Size(125, 24);
            this.subSystemNameLable.TabIndex = 2;
            this.subSystemNameLable.Text = "ITPM @ SLIIT";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1459, 748);
            this.Controls.Add(this.childContainerPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.topHeaderPanel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.topHeaderPanel.ResumeLayout(false);
            this.topHeaderPanel.PerformLayout();
            this.sidebarPanel.ResumeLayout(false);
            this.locationSubMenuPanel.ResumeLayout(false);
            this.workingHDSubMenuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topHeaderPanel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button workingHDMenuBtn;
        private System.Windows.Forms.Button dashboardMenuBtn;
        private System.Windows.Forms.Button weekendDetailsSubmenuBtn;
        private System.Windows.Forms.Button weekdayDetailsSubmenuBtn;
        private System.Windows.Forms.Panel locationSubMenuPanel;
        private System.Windows.Forms.Button addLocationSubMenuBtn;
        private System.Windows.Forms.Button locationListSubMenuBtn;
        private System.Windows.Forms.Panel childContainerPanel;
        private System.Windows.Forms.Label headerDynamicLabel;
        private System.Windows.Forms.Button viewWeekdaysDetailsSubmenuBtn;
        private System.Windows.Forms.Panel workingHDSubMenuPanel;
        private System.Windows.Forms.Button lecturersMenuBtn;
        private System.Windows.Forms.Button studentsMenuBtn;
        private System.Windows.Forms.Button locationsMenuBtn;
        private System.Windows.Forms.Button tagMenuBtn;
        private System.Windows.Forms.Button subjectMenuBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label subSystemNameLable;
        private System.Windows.Forms.Label systemNameLable;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}