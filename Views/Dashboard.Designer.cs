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
            this.panel1 = new System.Windows.Forms.Panel();
            this.subSystemNameLable = new System.Windows.Forms.Label();
            this.systemNameLable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerDynamicLabel = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.timtableGenerateMenuBtn = new System.Windows.Forms.Button();
            this.roomManagmentSubmenuPanel = new System.Windows.Forms.Panel();
            this.roomsForConsecutiveSessionsSubmenuBtn = new System.Windows.Forms.Button();
            this.roomsForSessionsSubmenuBtn = new System.Windows.Forms.Button();
            this.roomsForGroupsSubmenuBtn = new System.Windows.Forms.Button();
            this.roomsForLecturersSubmenuBtn = new System.Windows.Forms.Button();
            this.roomsForSubjectsSubmenuBtn = new System.Windows.Forms.Button();
            this.roomsForTagsSubmenuBtn = new System.Windows.Forms.Button();
            this.roomManagmentMenuBtn = new System.Windows.Forms.Button();
            this.sessionManagemntSubmenuPanel = new System.Windows.Forms.Panel();
            this.addSessionRoomSubmenuBtn = new System.Windows.Forms.Button();
            this.paralleSessionSubmenuBtn = new System.Windows.Forms.Button();
            this.allocateNotAvailableSubmenuBtn = new System.Windows.Forms.Button();
            this.notOverlappingSessionSubmenuBtn = new System.Windows.Forms.Button();
            this.consecutiveSessionSubmenuBtn = new System.Windows.Forms.Button();
            this.sessionManagemntMenuBtn = new System.Windows.Forms.Button();
            this.locationSubMenuPanel = new System.Windows.Forms.Panel();
            this.addLocationSubMenuBtn = new System.Windows.Forms.Button();
            this.locationListSubMenuBtn = new System.Windows.Forms.Button();
            this.locationsMenuBtn = new System.Windows.Forms.Button();
            this.subjectSubMenuPanel = new System.Windows.Forms.Panel();
            this.addSubjectSubMenuBtn = new System.Windows.Forms.Button();
            this.subjectListSubMenuBtn = new System.Windows.Forms.Button();
            this.subjectMenuBtn = new System.Windows.Forms.Button();
            this.studentSubMenuPanel = new System.Windows.Forms.Panel();
            this.listStudentGroupSubMenuBtn = new System.Windows.Forms.Button();
            this.addStudentGroupSubMenuBtn = new System.Windows.Forms.Button();
            this.studentsMenuBtn = new System.Windows.Forms.Button();
            this.tagSubMenuPanel = new System.Windows.Forms.Panel();
            this.tagListSubMenuBtn = new System.Windows.Forms.Button();
            this.addTagSubMenuBtn = new System.Windows.Forms.Button();
            this.tagMenuBtn = new System.Windows.Forms.Button();
            this.lecturerSubMenuPanel = new System.Windows.Forms.Panel();
            this.lecturerListSubMenuBtn = new System.Windows.Forms.Button();
            this.addLecturerSubMenuBtn = new System.Windows.Forms.Button();
            this.lecturersMenuBtn = new System.Windows.Forms.Button();
            this.workingHDSubMenuPanel = new System.Windows.Forms.Panel();
            this.weekendDayDetailsSubmenuBtn = new System.Windows.Forms.Button();
            this.workingHDMenuBtn = new System.Windows.Forms.Button();
            this.dashboardMenuBtn = new System.Windows.Forms.Button();
            this.childContainerPanel = new System.Windows.Forms.Panel();
            this.addSessionSubmenuBtn = new System.Windows.Forms.Button();
            this.topHeaderPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebarPanel.SuspendLayout();
            this.roomManagmentSubmenuPanel.SuspendLayout();
            this.sessionManagemntSubmenuPanel.SuspendLayout();
            this.locationSubMenuPanel.SuspendLayout();
            this.subjectSubMenuPanel.SuspendLayout();
            this.studentSubMenuPanel.SuspendLayout();
            this.tagSubMenuPanel.SuspendLayout();
            this.lecturerSubMenuPanel.SuspendLayout();
            this.workingHDSubMenuPanel.SuspendLayout();
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
            this.topHeaderPanel.Size = new System.Drawing.Size(1427, 86);
            this.topHeaderPanel.TabIndex = 0;
            this.topHeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topHeaderPanel_Paint);
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
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::TimeTableManagmentSystem.Properties.Resources.logo;
            this.pictureBox1.Image = global::TimeTableManagmentSystem.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::TimeTableManagmentSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
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
            this.sidebarPanel.Controls.Add(this.timtableGenerateMenuBtn);
            this.sidebarPanel.Controls.Add(this.roomManagmentSubmenuPanel);
            this.sidebarPanel.Controls.Add(this.roomManagmentMenuBtn);
            this.sidebarPanel.Controls.Add(this.sessionManagemntSubmenuPanel);
            this.sidebarPanel.Controls.Add(this.sessionManagemntMenuBtn);
            this.sidebarPanel.Controls.Add(this.locationSubMenuPanel);
            this.sidebarPanel.Controls.Add(this.locationsMenuBtn);
            this.sidebarPanel.Controls.Add(this.subjectSubMenuPanel);
            this.sidebarPanel.Controls.Add(this.subjectMenuBtn);
            this.sidebarPanel.Controls.Add(this.studentSubMenuPanel);
            this.sidebarPanel.Controls.Add(this.studentsMenuBtn);
            this.sidebarPanel.Controls.Add(this.tagSubMenuPanel);
            this.sidebarPanel.Controls.Add(this.tagMenuBtn);
            this.sidebarPanel.Controls.Add(this.lecturerSubMenuPanel);
            this.sidebarPanel.Controls.Add(this.lecturersMenuBtn);
            this.sidebarPanel.Controls.Add(this.workingHDSubMenuPanel);
            this.sidebarPanel.Controls.Add(this.workingHDMenuBtn);
            this.sidebarPanel.Controls.Add(this.dashboardMenuBtn);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 86);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(275, 670);
            this.sidebarPanel.TabIndex = 1;
            // 
            // timtableGenerateMenuBtn
            // 
            this.timtableGenerateMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(138)))));
            this.timtableGenerateMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.timtableGenerateMenuBtn.FlatAppearance.BorderSize = 0;
            this.timtableGenerateMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timtableGenerateMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timtableGenerateMenuBtn.ForeColor = System.Drawing.Color.White;
            this.timtableGenerateMenuBtn.Location = new System.Drawing.Point(0, 1087);
            this.timtableGenerateMenuBtn.Name = "timtableGenerateMenuBtn";
            this.timtableGenerateMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.timtableGenerateMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.timtableGenerateMenuBtn.TabIndex = 18;
            this.timtableGenerateMenuBtn.Text = "Generate Timetable";
            this.timtableGenerateMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timtableGenerateMenuBtn.UseVisualStyleBackColor = false;
            // 
            // roomManagmentSubmenuPanel
            // 
            this.roomManagmentSubmenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.roomManagmentSubmenuPanel.Controls.Add(this.roomsForConsecutiveSessionsSubmenuBtn);
            this.roomManagmentSubmenuPanel.Controls.Add(this.roomsForSessionsSubmenuBtn);
            this.roomManagmentSubmenuPanel.Controls.Add(this.roomsForGroupsSubmenuBtn);
            this.roomManagmentSubmenuPanel.Controls.Add(this.roomsForLecturersSubmenuBtn);
            this.roomManagmentSubmenuPanel.Controls.Add(this.roomsForSubjectsSubmenuBtn);
            this.roomManagmentSubmenuPanel.Controls.Add(this.roomsForTagsSubmenuBtn);
            this.roomManagmentSubmenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomManagmentSubmenuPanel.Location = new System.Drawing.Point(0, 882);
            this.roomManagmentSubmenuPanel.Name = "roomManagmentSubmenuPanel";
            this.roomManagmentSubmenuPanel.Size = new System.Drawing.Size(254, 205);
            this.roomManagmentSubmenuPanel.TabIndex = 17;
            // 
            // roomsForConsecutiveSessionsSubmenuBtn
            // 
            this.roomsForConsecutiveSessionsSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.roomsForConsecutiveSessionsSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomsForConsecutiveSessionsSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.roomsForConsecutiveSessionsSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomsForConsecutiveSessionsSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsForConsecutiveSessionsSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.roomsForConsecutiveSessionsSubmenuBtn.Location = new System.Drawing.Point(0, 175);
            this.roomsForConsecutiveSessionsSubmenuBtn.Name = "roomsForConsecutiveSessionsSubmenuBtn";
            this.roomsForConsecutiveSessionsSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.roomsForConsecutiveSessionsSubmenuBtn.Size = new System.Drawing.Size(254, 35);
            this.roomsForConsecutiveSessionsSubmenuBtn.TabIndex = 10;
            this.roomsForConsecutiveSessionsSubmenuBtn.Text = "Consecutive Sessions";
            this.roomsForConsecutiveSessionsSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomsForConsecutiveSessionsSubmenuBtn.UseVisualStyleBackColor = false;
            // 
            // roomsForSessionsSubmenuBtn
            // 
            this.roomsForSessionsSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.roomsForSessionsSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomsForSessionsSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.roomsForSessionsSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomsForSessionsSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsForSessionsSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.roomsForSessionsSubmenuBtn.Location = new System.Drawing.Point(0, 140);
            this.roomsForSessionsSubmenuBtn.Name = "roomsForSessionsSubmenuBtn";
            this.roomsForSessionsSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.roomsForSessionsSubmenuBtn.Size = new System.Drawing.Size(254, 35);
            this.roomsForSessionsSubmenuBtn.TabIndex = 9;
            this.roomsForSessionsSubmenuBtn.Text = "Rooms For Sessions";
            this.roomsForSessionsSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomsForSessionsSubmenuBtn.UseVisualStyleBackColor = false;
            // 
            // roomsForGroupsSubmenuBtn
            // 
            this.roomsForGroupsSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.roomsForGroupsSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomsForGroupsSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.roomsForGroupsSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomsForGroupsSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsForGroupsSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.roomsForGroupsSubmenuBtn.Location = new System.Drawing.Point(0, 105);
            this.roomsForGroupsSubmenuBtn.Name = "roomsForGroupsSubmenuBtn";
            this.roomsForGroupsSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.roomsForGroupsSubmenuBtn.Size = new System.Drawing.Size(254, 35);
            this.roomsForGroupsSubmenuBtn.TabIndex = 8;
            this.roomsForGroupsSubmenuBtn.Text = "Rooms For Groups";
            this.roomsForGroupsSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomsForGroupsSubmenuBtn.UseVisualStyleBackColor = false;
            this.roomsForGroupsSubmenuBtn.Click += new System.EventHandler(this.roomsForGroupsSubmenuBtn_Click);
            // 
            // roomsForLecturersSubmenuBtn
            // 
            this.roomsForLecturersSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.roomsForLecturersSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomsForLecturersSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.roomsForLecturersSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomsForLecturersSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsForLecturersSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.roomsForLecturersSubmenuBtn.Location = new System.Drawing.Point(0, 70);
            this.roomsForLecturersSubmenuBtn.Name = "roomsForLecturersSubmenuBtn";
            this.roomsForLecturersSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.roomsForLecturersSubmenuBtn.Size = new System.Drawing.Size(254, 35);
            this.roomsForLecturersSubmenuBtn.TabIndex = 7;
            this.roomsForLecturersSubmenuBtn.Text = "Rooms For Lecturers";
            this.roomsForLecturersSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomsForLecturersSubmenuBtn.UseVisualStyleBackColor = false;
            this.roomsForLecturersSubmenuBtn.Click += new System.EventHandler(this.roomsForLecturersSubmenuBtn_Click);
            // 
            // roomsForSubjectsSubmenuBtn
            // 
            this.roomsForSubjectsSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.roomsForSubjectsSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomsForSubjectsSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.roomsForSubjectsSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomsForSubjectsSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsForSubjectsSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.roomsForSubjectsSubmenuBtn.Location = new System.Drawing.Point(0, 35);
            this.roomsForSubjectsSubmenuBtn.Name = "roomsForSubjectsSubmenuBtn";
            this.roomsForSubjectsSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.roomsForSubjectsSubmenuBtn.Size = new System.Drawing.Size(254, 35);
            this.roomsForSubjectsSubmenuBtn.TabIndex = 6;
            this.roomsForSubjectsSubmenuBtn.Text = "Rooms For Subjects";
            this.roomsForSubjectsSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomsForSubjectsSubmenuBtn.UseVisualStyleBackColor = false;
            this.roomsForSubjectsSubmenuBtn.Click += new System.EventHandler(this.roomsForSubjectsSubmenuBtn_Click);
            // 
            // roomsForTagsSubmenuBtn
            // 
            this.roomsForTagsSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.roomsForTagsSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomsForTagsSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.roomsForTagsSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomsForTagsSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsForTagsSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.roomsForTagsSubmenuBtn.Location = new System.Drawing.Point(0, 0);
            this.roomsForTagsSubmenuBtn.Name = "roomsForTagsSubmenuBtn";
            this.roomsForTagsSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.roomsForTagsSubmenuBtn.Size = new System.Drawing.Size(254, 35);
            this.roomsForTagsSubmenuBtn.TabIndex = 5;
            this.roomsForTagsSubmenuBtn.Text = "Rooms For Tags";
            this.roomsForTagsSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomsForTagsSubmenuBtn.UseVisualStyleBackColor = false;
            this.roomsForTagsSubmenuBtn.Click += new System.EventHandler(this.roomsForTagsSubmenuBtn_Click);
            // 
            // roomManagmentMenuBtn
            // 
            this.roomManagmentMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(138)))));
            this.roomManagmentMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomManagmentMenuBtn.FlatAppearance.BorderSize = 0;
            this.roomManagmentMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomManagmentMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomManagmentMenuBtn.ForeColor = System.Drawing.Color.White;
            this.roomManagmentMenuBtn.Location = new System.Drawing.Point(0, 847);
            this.roomManagmentMenuBtn.Name = "roomManagmentMenuBtn";
            this.roomManagmentMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.roomManagmentMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.roomManagmentMenuBtn.TabIndex = 17;
            this.roomManagmentMenuBtn.Text = "Room Managment";
            this.roomManagmentMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomManagmentMenuBtn.UseVisualStyleBackColor = false;
            this.roomManagmentMenuBtn.Click += new System.EventHandler(this.roomManagmentMenuBtn_Click);
            // 
            // sessionManagemntSubmenuPanel
            // 
            this.sessionManagemntSubmenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.sessionManagemntSubmenuPanel.Controls.Add(this.addSessionSubmenuBtn);
            this.sessionManagemntSubmenuPanel.Controls.Add(this.addSessionRoomSubmenuBtn);
            this.sessionManagemntSubmenuPanel.Controls.Add(this.paralleSessionSubmenuBtn);
            this.sessionManagemntSubmenuPanel.Controls.Add(this.allocateNotAvailableSubmenuBtn);
            this.sessionManagemntSubmenuPanel.Controls.Add(this.notOverlappingSessionSubmenuBtn);
            this.sessionManagemntSubmenuPanel.Controls.Add(this.consecutiveSessionSubmenuBtn);
            this.sessionManagemntSubmenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sessionManagemntSubmenuPanel.Location = new System.Drawing.Point(0, 642);
            this.sessionManagemntSubmenuPanel.Name = "sessionManagemntSubmenuPanel";
            this.sessionManagemntSubmenuPanel.Size = new System.Drawing.Size(254, 205);
            this.sessionManagemntSubmenuPanel.TabIndex = 16;
            // 
            // addSessionRoomSubmenuBtn
            // 
            this.addSessionRoomSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.addSessionRoomSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addSessionRoomSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.addSessionRoomSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSessionRoomSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSessionRoomSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.addSessionRoomSubmenuBtn.Location = new System.Drawing.Point(0, 140);
            this.addSessionRoomSubmenuBtn.Name = "addSessionRoomSubmenuBtn";
            this.addSessionRoomSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addSessionRoomSubmenuBtn.Size = new System.Drawing.Size(254, 35);
            this.addSessionRoomSubmenuBtn.TabIndex = 0;
            this.addSessionRoomSubmenuBtn.Text = "Add Session Room";
            this.addSessionRoomSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSessionRoomSubmenuBtn.UseVisualStyleBackColor = false;
            this.addSessionRoomSubmenuBtn.Click += new System.EventHandler(this.addSessionSubmenuBtn_Click);
            // 
            // paralleSessionSubmenuBtn
            // 
            this.paralleSessionSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.paralleSessionSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.paralleSessionSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.paralleSessionSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paralleSessionSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paralleSessionSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.paralleSessionSubmenuBtn.Location = new System.Drawing.Point(0, 105);
            this.paralleSessionSubmenuBtn.Name = "paralleSessionSubmenuBtn";
            this.paralleSessionSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.paralleSessionSubmenuBtn.Size = new System.Drawing.Size(254, 35);
            this.paralleSessionSubmenuBtn.TabIndex = 3;
            this.paralleSessionSubmenuBtn.Text = "Paralle Session";
            this.paralleSessionSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paralleSessionSubmenuBtn.UseVisualStyleBackColor = false;
            // 
            // allocateNotAvailableSubmenuBtn
            // 
            this.allocateNotAvailableSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.allocateNotAvailableSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.allocateNotAvailableSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.allocateNotAvailableSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allocateNotAvailableSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allocateNotAvailableSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.allocateNotAvailableSubmenuBtn.Location = new System.Drawing.Point(0, 70);
            this.allocateNotAvailableSubmenuBtn.Name = "allocateNotAvailableSubmenuBtn";
            this.allocateNotAvailableSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.allocateNotAvailableSubmenuBtn.Size = new System.Drawing.Size(254, 35);
            this.allocateNotAvailableSubmenuBtn.TabIndex = 1;
            this.allocateNotAvailableSubmenuBtn.Text = "Allocate Not Available";
            this.allocateNotAvailableSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allocateNotAvailableSubmenuBtn.UseVisualStyleBackColor = false;
            this.allocateNotAvailableSubmenuBtn.Click += new System.EventHandler(this.allocateNotAvailableSubmenuBtn_Click);
            // 
            // notOverlappingSessionSubmenuBtn
            // 
            this.notOverlappingSessionSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.notOverlappingSessionSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.notOverlappingSessionSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.notOverlappingSessionSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notOverlappingSessionSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notOverlappingSessionSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.notOverlappingSessionSubmenuBtn.Location = new System.Drawing.Point(0, 35);
            this.notOverlappingSessionSubmenuBtn.Name = "notOverlappingSessionSubmenuBtn";
            this.notOverlappingSessionSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.notOverlappingSessionSubmenuBtn.Size = new System.Drawing.Size(254, 35);
            this.notOverlappingSessionSubmenuBtn.TabIndex = 4;
            this.notOverlappingSessionSubmenuBtn.Text = "Not Overlapping Sessions";
            this.notOverlappingSessionSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notOverlappingSessionSubmenuBtn.UseVisualStyleBackColor = false;
            // 
            // consecutiveSessionSubmenuBtn
            // 
            this.consecutiveSessionSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.consecutiveSessionSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.consecutiveSessionSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.consecutiveSessionSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consecutiveSessionSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consecutiveSessionSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.consecutiveSessionSubmenuBtn.Location = new System.Drawing.Point(0, 0);
            this.consecutiveSessionSubmenuBtn.Name = "consecutiveSessionSubmenuBtn";
            this.consecutiveSessionSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.consecutiveSessionSubmenuBtn.Size = new System.Drawing.Size(254, 35);
            this.consecutiveSessionSubmenuBtn.TabIndex = 2;
            this.consecutiveSessionSubmenuBtn.Text = "Consecutive Session";
            this.consecutiveSessionSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consecutiveSessionSubmenuBtn.UseVisualStyleBackColor = false;
            // 
            // sessionManagemntMenuBtn
            // 
            this.sessionManagemntMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(138)))));
            this.sessionManagemntMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sessionManagemntMenuBtn.FlatAppearance.BorderSize = 0;
            this.sessionManagemntMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sessionManagemntMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionManagemntMenuBtn.ForeColor = System.Drawing.Color.White;
            this.sessionManagemntMenuBtn.Location = new System.Drawing.Point(0, 607);
            this.sessionManagemntMenuBtn.Name = "sessionManagemntMenuBtn";
            this.sessionManagemntMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sessionManagemntMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.sessionManagemntMenuBtn.TabIndex = 15;
            this.sessionManagemntMenuBtn.Text = "Session Managment";
            this.sessionManagemntMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sessionManagemntMenuBtn.UseVisualStyleBackColor = false;
            this.sessionManagemntMenuBtn.Click += new System.EventHandler(this.sessionManagemntMenuBtn_Click_1);
            // 
            // locationSubMenuPanel
            // 
            this.locationSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.locationSubMenuPanel.Controls.Add(this.addLocationSubMenuBtn);
            this.locationSubMenuPanel.Controls.Add(this.locationListSubMenuBtn);
            this.locationSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.locationSubMenuPanel.Location = new System.Drawing.Point(0, 542);
            this.locationSubMenuPanel.Name = "locationSubMenuPanel";
            this.locationSubMenuPanel.Size = new System.Drawing.Size(254, 65);
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
            this.addLocationSubMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.addLocationSubMenuBtn.TabIndex = 1;
            this.addLocationSubMenuBtn.Text = "Add Location";
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
            this.locationListSubMenuBtn.Size = new System.Drawing.Size(254, 35);
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
            this.locationsMenuBtn.Location = new System.Drawing.Point(0, 507);
            this.locationsMenuBtn.Name = "locationsMenuBtn";
            this.locationsMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.locationsMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.locationsMenuBtn.TabIndex = 14;
            this.locationsMenuBtn.Text = "Locations";
            this.locationsMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.locationsMenuBtn.UseVisualStyleBackColor = false;
            this.locationsMenuBtn.Click += new System.EventHandler(this.locationsMenuBtn_Click_2);
            // 
            // subjectSubMenuPanel
            // 
            this.subjectSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.subjectSubMenuPanel.Controls.Add(this.addSubjectSubMenuBtn);
            this.subjectSubMenuPanel.Controls.Add(this.subjectListSubMenuBtn);
            this.subjectSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectSubMenuPanel.Location = new System.Drawing.Point(0, 442);
            this.subjectSubMenuPanel.Name = "subjectSubMenuPanel";
            this.subjectSubMenuPanel.Size = new System.Drawing.Size(254, 65);
            this.subjectSubMenuPanel.TabIndex = 13;
            // 
            // addSubjectSubMenuBtn
            // 
            this.addSubjectSubMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.addSubjectSubMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addSubjectSubMenuBtn.FlatAppearance.BorderSize = 0;
            this.addSubjectSubMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSubjectSubMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSubjectSubMenuBtn.ForeColor = System.Drawing.Color.White;
            this.addSubjectSubMenuBtn.Location = new System.Drawing.Point(0, 35);
            this.addSubjectSubMenuBtn.Name = "addSubjectSubMenuBtn";
            this.addSubjectSubMenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addSubjectSubMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.addSubjectSubMenuBtn.TabIndex = 1;
            this.addSubjectSubMenuBtn.Text = "Add Subject";
            this.addSubjectSubMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSubjectSubMenuBtn.UseVisualStyleBackColor = false;
            this.addSubjectSubMenuBtn.Click += new System.EventHandler(this.addSubjectSubMenuBtn_Click);
            // 
            // subjectListSubMenuBtn
            // 
            this.subjectListSubMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.subjectListSubMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectListSubMenuBtn.FlatAppearance.BorderSize = 0;
            this.subjectListSubMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectListSubMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectListSubMenuBtn.ForeColor = System.Drawing.Color.White;
            this.subjectListSubMenuBtn.Location = new System.Drawing.Point(0, 0);
            this.subjectListSubMenuBtn.Name = "subjectListSubMenuBtn";
            this.subjectListSubMenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.subjectListSubMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.subjectListSubMenuBtn.TabIndex = 2;
            this.subjectListSubMenuBtn.Text = "Subject List";
            this.subjectListSubMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectListSubMenuBtn.UseVisualStyleBackColor = false;
            this.subjectListSubMenuBtn.Click += new System.EventHandler(this.subjectListSubMenuBtn_Click);
            // 
            // subjectMenuBtn
            // 
            this.subjectMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(138)))));
            this.subjectMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectMenuBtn.FlatAppearance.BorderSize = 0;
            this.subjectMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectMenuBtn.ForeColor = System.Drawing.Color.White;
            this.subjectMenuBtn.Location = new System.Drawing.Point(0, 407);
            this.subjectMenuBtn.Name = "subjectMenuBtn";
            this.subjectMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.subjectMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.subjectMenuBtn.TabIndex = 9;
            this.subjectMenuBtn.Text = "Subjects";
            this.subjectMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectMenuBtn.UseVisualStyleBackColor = false;
            this.subjectMenuBtn.Click += new System.EventHandler(this.subjectMenuBtn_Click);
            // 
            // studentSubMenuPanel
            // 
            this.studentSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.studentSubMenuPanel.Controls.Add(this.listStudentGroupSubMenuBtn);
            this.studentSubMenuPanel.Controls.Add(this.addStudentGroupSubMenuBtn);
            this.studentSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentSubMenuPanel.Location = new System.Drawing.Point(0, 342);
            this.studentSubMenuPanel.Name = "studentSubMenuPanel";
            this.studentSubMenuPanel.Size = new System.Drawing.Size(254, 65);
            this.studentSubMenuPanel.TabIndex = 12;
            // 
            // listStudentGroupSubMenuBtn
            // 
            this.listStudentGroupSubMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.listStudentGroupSubMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.listStudentGroupSubMenuBtn.FlatAppearance.BorderSize = 0;
            this.listStudentGroupSubMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listStudentGroupSubMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listStudentGroupSubMenuBtn.ForeColor = System.Drawing.Color.White;
            this.listStudentGroupSubMenuBtn.Location = new System.Drawing.Point(0, 35);
            this.listStudentGroupSubMenuBtn.Name = "listStudentGroupSubMenuBtn";
            this.listStudentGroupSubMenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.listStudentGroupSubMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.listStudentGroupSubMenuBtn.TabIndex = 3;
            this.listStudentGroupSubMenuBtn.Text = "Student Group List";
            this.listStudentGroupSubMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listStudentGroupSubMenuBtn.UseVisualStyleBackColor = false;
            this.listStudentGroupSubMenuBtn.Click += new System.EventHandler(this.listStudentGroupSubMenuBtn_Click);
            // 
            // addStudentGroupSubMenuBtn
            // 
            this.addStudentGroupSubMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.addStudentGroupSubMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addStudentGroupSubMenuBtn.FlatAppearance.BorderSize = 0;
            this.addStudentGroupSubMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentGroupSubMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentGroupSubMenuBtn.ForeColor = System.Drawing.Color.White;
            this.addStudentGroupSubMenuBtn.Location = new System.Drawing.Point(0, 0);
            this.addStudentGroupSubMenuBtn.Name = "addStudentGroupSubMenuBtn";
            this.addStudentGroupSubMenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addStudentGroupSubMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.addStudentGroupSubMenuBtn.TabIndex = 2;
            this.addStudentGroupSubMenuBtn.Text = "Add Student Group";
            this.addStudentGroupSubMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStudentGroupSubMenuBtn.UseVisualStyleBackColor = false;
            this.addStudentGroupSubMenuBtn.Click += new System.EventHandler(this.addStudentGroupSubMenuBtn_Click);
            // 
            // studentsMenuBtn
            // 
            this.studentsMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(138)))));
            this.studentsMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentsMenuBtn.FlatAppearance.BorderSize = 0;
            this.studentsMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentsMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsMenuBtn.ForeColor = System.Drawing.Color.White;
            this.studentsMenuBtn.Location = new System.Drawing.Point(0, 307);
            this.studentsMenuBtn.Name = "studentsMenuBtn";
            this.studentsMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.studentsMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.studentsMenuBtn.TabIndex = 11;
            this.studentsMenuBtn.Text = "Students";
            this.studentsMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentsMenuBtn.UseVisualStyleBackColor = false;
            this.studentsMenuBtn.Click += new System.EventHandler(this.studentsMenuBtn_Click_1);
            // 
            // tagSubMenuPanel
            // 
            this.tagSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tagSubMenuPanel.Controls.Add(this.tagListSubMenuBtn);
            this.tagSubMenuPanel.Controls.Add(this.addTagSubMenuBtn);
            this.tagSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tagSubMenuPanel.Location = new System.Drawing.Point(0, 242);
            this.tagSubMenuPanel.Name = "tagSubMenuPanel";
            this.tagSubMenuPanel.Size = new System.Drawing.Size(254, 65);
            this.tagSubMenuPanel.TabIndex = 10;
            // 
            // tagListSubMenuBtn
            // 
            this.tagListSubMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.tagListSubMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tagListSubMenuBtn.FlatAppearance.BorderSize = 0;
            this.tagListSubMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tagListSubMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagListSubMenuBtn.ForeColor = System.Drawing.Color.White;
            this.tagListSubMenuBtn.Location = new System.Drawing.Point(0, 35);
            this.tagListSubMenuBtn.Name = "tagListSubMenuBtn";
            this.tagListSubMenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.tagListSubMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.tagListSubMenuBtn.TabIndex = 19;
            this.tagListSubMenuBtn.Text = "Tag List";
            this.tagListSubMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tagListSubMenuBtn.UseVisualStyleBackColor = false;
            this.tagListSubMenuBtn.Click += new System.EventHandler(this.tagListSubMenuBtn_Click);
            // 
            // addTagSubMenuBtn
            // 
            this.addTagSubMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.addTagSubMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addTagSubMenuBtn.FlatAppearance.BorderSize = 0;
            this.addTagSubMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTagSubMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTagSubMenuBtn.ForeColor = System.Drawing.Color.White;
            this.addTagSubMenuBtn.Location = new System.Drawing.Point(0, 0);
            this.addTagSubMenuBtn.Name = "addTagSubMenuBtn";
            this.addTagSubMenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addTagSubMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.addTagSubMenuBtn.TabIndex = 18;
            this.addTagSubMenuBtn.Text = "Add Tag";
            this.addTagSubMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTagSubMenuBtn.UseVisualStyleBackColor = false;
            this.addTagSubMenuBtn.Click += new System.EventHandler(this.addTagSubMenuBtn_Click);
            // 
            // tagMenuBtn
            // 
            this.tagMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(138)))));
            this.tagMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tagMenuBtn.FlatAppearance.BorderSize = 0;
            this.tagMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tagMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagMenuBtn.ForeColor = System.Drawing.Color.White;
            this.tagMenuBtn.Location = new System.Drawing.Point(0, 207);
            this.tagMenuBtn.Name = "tagMenuBtn";
            this.tagMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.tagMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.tagMenuBtn.TabIndex = 9;
            this.tagMenuBtn.Text = "Tags";
            this.tagMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tagMenuBtn.UseVisualStyleBackColor = false;
            this.tagMenuBtn.Click += new System.EventHandler(this.tagMenuBtn_Click);
            // 
            // lecturerSubMenuPanel
            // 
            this.lecturerSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.lecturerSubMenuPanel.Controls.Add(this.lecturerListSubMenuBtn);
            this.lecturerSubMenuPanel.Controls.Add(this.addLecturerSubMenuBtn);
            this.lecturerSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lecturerSubMenuPanel.Location = new System.Drawing.Point(0, 142);
            this.lecturerSubMenuPanel.Name = "lecturerSubMenuPanel";
            this.lecturerSubMenuPanel.Size = new System.Drawing.Size(254, 65);
            this.lecturerSubMenuPanel.TabIndex = 8;
            // 
            // lecturerListSubMenuBtn
            // 
            this.lecturerListSubMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.lecturerListSubMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lecturerListSubMenuBtn.FlatAppearance.BorderSize = 0;
            this.lecturerListSubMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lecturerListSubMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerListSubMenuBtn.ForeColor = System.Drawing.Color.White;
            this.lecturerListSubMenuBtn.Location = new System.Drawing.Point(0, 35);
            this.lecturerListSubMenuBtn.Name = "lecturerListSubMenuBtn";
            this.lecturerListSubMenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.lecturerListSubMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.lecturerListSubMenuBtn.TabIndex = 2;
            this.lecturerListSubMenuBtn.Text = "Lecturer List";
            this.lecturerListSubMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lecturerListSubMenuBtn.UseVisualStyleBackColor = false;
            this.lecturerListSubMenuBtn.Click += new System.EventHandler(this.lecturerListSubMenuBtn_Click);
            // 
            // addLecturerSubMenuBtn
            // 
            this.addLecturerSubMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.addLecturerSubMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addLecturerSubMenuBtn.FlatAppearance.BorderSize = 0;
            this.addLecturerSubMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLecturerSubMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLecturerSubMenuBtn.ForeColor = System.Drawing.Color.White;
            this.addLecturerSubMenuBtn.Location = new System.Drawing.Point(0, 0);
            this.addLecturerSubMenuBtn.Name = "addLecturerSubMenuBtn";
            this.addLecturerSubMenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addLecturerSubMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.addLecturerSubMenuBtn.TabIndex = 1;
            this.addLecturerSubMenuBtn.Text = "Add Lecturer";
            this.addLecturerSubMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addLecturerSubMenuBtn.UseVisualStyleBackColor = false;
            this.addLecturerSubMenuBtn.Click += new System.EventHandler(this.addLecturerSubMenuBtn_Click);
            // 
            // lecturersMenuBtn
            // 
            this.lecturersMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(138)))));
            this.lecturersMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lecturersMenuBtn.FlatAppearance.BorderSize = 0;
            this.lecturersMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lecturersMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturersMenuBtn.ForeColor = System.Drawing.Color.White;
            this.lecturersMenuBtn.Location = new System.Drawing.Point(0, 107);
            this.lecturersMenuBtn.Name = "lecturersMenuBtn";
            this.lecturersMenuBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lecturersMenuBtn.Size = new System.Drawing.Size(254, 35);
            this.lecturersMenuBtn.TabIndex = 7;
            this.lecturersMenuBtn.Text = "Lecturers";
            this.lecturersMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lecturersMenuBtn.UseVisualStyleBackColor = false;
            this.lecturersMenuBtn.Click += new System.EventHandler(this.lecturersMenuBtn_Click);
            // 
            // workingHDSubMenuPanel
            // 
            this.workingHDSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.workingHDSubMenuPanel.Controls.Add(this.weekendDayDetailsSubmenuBtn);
            this.workingHDSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.workingHDSubMenuPanel.Location = new System.Drawing.Point(0, 70);
            this.workingHDSubMenuPanel.Name = "workingHDSubMenuPanel";
            this.workingHDSubMenuPanel.Size = new System.Drawing.Size(254, 37);
            this.workingHDSubMenuPanel.TabIndex = 6;
            // 
            // weekendDayDetailsSubmenuBtn
            // 
            this.weekendDayDetailsSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.weekendDayDetailsSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.weekendDayDetailsSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.weekendDayDetailsSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weekendDayDetailsSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekendDayDetailsSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.weekendDayDetailsSubmenuBtn.Location = new System.Drawing.Point(0, 0);
            this.weekendDayDetailsSubmenuBtn.Name = "weekendDayDetailsSubmenuBtn";
            this.weekendDayDetailsSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.weekendDayDetailsSubmenuBtn.Size = new System.Drawing.Size(254, 37);
            this.weekendDayDetailsSubmenuBtn.TabIndex = 7;
            this.weekendDayDetailsSubmenuBtn.Text = "Add Details";
            this.weekendDayDetailsSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.weekendDayDetailsSubmenuBtn.UseVisualStyleBackColor = false;
            this.weekendDayDetailsSubmenuBtn.Click += new System.EventHandler(this.weekendDetailsSubmenuBtn_Click);
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
            this.workingHDMenuBtn.Size = new System.Drawing.Size(254, 35);
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
            this.dashboardMenuBtn.Size = new System.Drawing.Size(254, 35);
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
            this.childContainerPanel.Size = new System.Drawing.Size(1152, 670);
            this.childContainerPanel.TabIndex = 2;
            // 
            // addSessionSubmenuBtn
            // 
            this.addSessionSubmenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(100)))));
            this.addSessionSubmenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addSessionSubmenuBtn.FlatAppearance.BorderSize = 0;
            this.addSessionSubmenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSessionSubmenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSessionSubmenuBtn.ForeColor = System.Drawing.Color.White;
            this.addSessionSubmenuBtn.Location = new System.Drawing.Point(0, 175);
            this.addSessionSubmenuBtn.Name = "addSessionSubmenuBtn";
            this.addSessionSubmenuBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.addSessionSubmenuBtn.Size = new System.Drawing.Size(254, 35);
            this.addSessionSubmenuBtn.TabIndex = 5;
            this.addSessionSubmenuBtn.Text = "Add Session";
            this.addSessionSubmenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSessionSubmenuBtn.UseVisualStyleBackColor = false;
            this.addSessionSubmenuBtn.Click += new System.EventHandler(this.addSessionSubmenuBtn_Click_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1427, 756);
            this.Controls.Add(this.childContainerPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.topHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.topHeaderPanel.ResumeLayout(false);
            this.topHeaderPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebarPanel.ResumeLayout(false);
            this.roomManagmentSubmenuPanel.ResumeLayout(false);
            this.sessionManagemntSubmenuPanel.ResumeLayout(false);
            this.locationSubMenuPanel.ResumeLayout(false);
            this.subjectSubMenuPanel.ResumeLayout(false);
            this.studentSubMenuPanel.ResumeLayout(false);
            this.tagSubMenuPanel.ResumeLayout(false);
            this.lecturerSubMenuPanel.ResumeLayout(false);
            this.workingHDSubMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topHeaderPanel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button workingHDMenuBtn;
        private System.Windows.Forms.Button dashboardMenuBtn;
        private System.Windows.Forms.Button weekendDayDetailsSubmenuBtn;
        private System.Windows.Forms.Panel locationSubMenuPanel;
        private System.Windows.Forms.Button addLocationSubMenuBtn;
        private System.Windows.Forms.Button locationListSubMenuBtn;
        private System.Windows.Forms.Panel childContainerPanel;
        private System.Windows.Forms.Label headerDynamicLabel;
        private System.Windows.Forms.Panel workingHDSubMenuPanel;
        private System.Windows.Forms.Button lecturersMenuBtn;
        private System.Windows.Forms.Button subjectMenuBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label subSystemNameLable;
        private System.Windows.Forms.Label systemNameLable;
        private System.Windows.Forms.Button notOverlappingSessionSubmenuBtn;
        private System.Windows.Forms.Button paralleSessionSubmenuBtn;
        private System.Windows.Forms.Button consecutiveSessionSubmenuBtn;
        private System.Windows.Forms.Button allocateNotAvailableSubmenuBtn;
        private System.Windows.Forms.Button addSessionRoomSubmenuBtn;
        private System.Windows.Forms.Panel roomManagmentSubmenuPanel;
        private System.Windows.Forms.Button roomsForTagsSubmenuBtn;
        private System.Windows.Forms.Panel lecturerSubMenuPanel;
        private System.Windows.Forms.Button addLecturerSubMenuBtn;
        private System.Windows.Forms.Button lecturerListSubMenuBtn;
        private System.Windows.Forms.Button tagMenuBtn;
        private System.Windows.Forms.Button studentsMenuBtn;
        private System.Windows.Forms.Panel tagSubMenuPanel;
        private System.Windows.Forms.Button tagListSubMenuBtn;
        private System.Windows.Forms.Button addTagSubMenuBtn;
        private System.Windows.Forms.Panel studentSubMenuPanel;
        private System.Windows.Forms.Panel subjectSubMenuPanel;
        private System.Windows.Forms.Button subjectListSubMenuBtn;
        private System.Windows.Forms.Button addSubjectSubMenuBtn;
        private System.Windows.Forms.Button sessionManagemntMenuBtn;
        private System.Windows.Forms.Button locationsMenuBtn;
        private System.Windows.Forms.Button listStudentGroupSubMenuBtn;
        private System.Windows.Forms.Button addStudentGroupSubMenuBtn;
        private System.Windows.Forms.Panel sessionManagemntSubmenuPanel;
        private System.Windows.Forms.Button roomManagmentMenuBtn;
        private System.Windows.Forms.Button roomsForConsecutiveSessionsSubmenuBtn;
        private System.Windows.Forms.Button roomsForSessionsSubmenuBtn;
        private System.Windows.Forms.Button roomsForGroupsSubmenuBtn;
        private System.Windows.Forms.Button roomsForLecturersSubmenuBtn;
        private System.Windows.Forms.Button roomsForSubjectsSubmenuBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button timtableGenerateMenuBtn;
        private System.Windows.Forms.Button addSessionSubmenuBtn;
    }
}