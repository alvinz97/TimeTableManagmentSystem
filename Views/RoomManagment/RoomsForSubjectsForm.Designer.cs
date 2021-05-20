namespace TimeTableManagmentSystem.Views.RoomManagment
{
    partial class RoomsForSubjectsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.roomSelectCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectForTagDataGridView = new System.Windows.Forms.DataGridView();
            this.subjectForTagSaveBtn = new System.Windows.Forms.Button();
            this.subjectSelectCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tagSelectCombobox = new System.Windows.Forms.ComboBox();
            this.buildingNameLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectForTagDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.roomSelectCombobox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.subjectForTagDataGridView);
            this.panel1.Controls.Add(this.subjectForTagSaveBtn);
            this.panel1.Controls.Add(this.subjectSelectCombobox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tagSelectCombobox);
            this.panel1.Controls.Add(this.buildingNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 575);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Subject Name";
            // 
            // roomSelectCombobox
            // 
            this.roomSelectCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomSelectCombobox.FormattingEnabled = true;
            this.roomSelectCombobox.Location = new System.Drawing.Point(214, 148);
            this.roomSelectCombobox.Name = "roomSelectCombobox";
            this.roomSelectCombobox.Size = new System.Drawing.Size(345, 33);
            this.roomSelectCombobox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Room Name";
            // 
            // subjectForTagDataGridView
            // 
            this.subjectForTagDataGridView.AllowUserToAddRows = false;
            this.subjectForTagDataGridView.AllowUserToDeleteRows = false;
            this.subjectForTagDataGridView.AllowUserToResizeColumns = false;
            this.subjectForTagDataGridView.AllowUserToResizeRows = false;
            this.subjectForTagDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectForTagDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subjectForTagDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.subjectForTagDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectForTagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectForTagDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TagName,
            this.SubjectName,
            this.RoomName,
            this.Delete});
            this.subjectForTagDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.subjectForTagDataGridView.GridColor = System.Drawing.Color.White;
            this.subjectForTagDataGridView.Location = new System.Drawing.Point(12, 271);
            this.subjectForTagDataGridView.Name = "subjectForTagDataGridView";
            this.subjectForTagDataGridView.ReadOnly = true;
            this.subjectForTagDataGridView.RowHeadersWidth = 51;
            this.subjectForTagDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.subjectForTagDataGridView.RowTemplate.Height = 24;
            this.subjectForTagDataGridView.ShowEditingIcon = false;
            this.subjectForTagDataGridView.Size = new System.Drawing.Size(1102, 301);
            this.subjectForTagDataGridView.TabIndex = 0;
            this.subjectForTagDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectForTagDataGridView_CellClick);
            this.subjectForTagDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectForTagDataGridView_CellContentClick);
            // 
            // subjectForTagSaveBtn
            // 
            this.subjectForTagSaveBtn.BackColor = System.Drawing.Color.Blue;
            this.subjectForTagSaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.subjectForTagSaveBtn.FlatAppearance.BorderSize = 0;
            this.subjectForTagSaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.subjectForTagSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectForTagSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectForTagSaveBtn.ForeColor = System.Drawing.Color.White;
            this.subjectForTagSaveBtn.Location = new System.Drawing.Point(214, 202);
            this.subjectForTagSaveBtn.Name = "subjectForTagSaveBtn";
            this.subjectForTagSaveBtn.Padding = new System.Windows.Forms.Padding(10);
            this.subjectForTagSaveBtn.Size = new System.Drawing.Size(131, 53);
            this.subjectForTagSaveBtn.TabIndex = 33;
            this.subjectForTagSaveBtn.Text = "Save";
            this.subjectForTagSaveBtn.UseVisualStyleBackColor = false;
            this.subjectForTagSaveBtn.Click += new System.EventHandler(this.subjectForTagSaveBtn_Click);
            // 
            // subjectSelectCombobox
            // 
            this.subjectSelectCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectSelectCombobox.FormattingEnabled = true;
            this.subjectSelectCombobox.Location = new System.Drawing.Point(214, 85);
            this.subjectSelectCombobox.Name = "subjectSelectCombobox";
            this.subjectSelectCombobox.Size = new System.Drawing.Size(345, 33);
            this.subjectSelectCombobox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 31;
            // 
            // tagSelectCombobox
            // 
            this.tagSelectCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagSelectCombobox.FormattingEnabled = true;
            this.tagSelectCombobox.Location = new System.Drawing.Point(214, 25);
            this.tagSelectCombobox.Name = "tagSelectCombobox";
            this.tagSelectCombobox.Size = new System.Drawing.Size(345, 33);
            this.tagSelectCombobox.TabIndex = 30;
            // 
            // buildingNameLabel
            // 
            this.buildingNameLabel.AutoSize = true;
            this.buildingNameLabel.BackColor = System.Drawing.Color.White;
            this.buildingNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingNameLabel.Location = new System.Drawing.Point(41, 29);
            this.buildingNameLabel.Name = "buildingNameLabel";
            this.buildingNameLabel.Size = new System.Drawing.Size(104, 25);
            this.buildingNameLabel.TabIndex = 4;
            this.buildingNameLabel.Text = "Tag Name";
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
            // TagName
            // 
            this.TagName.DataPropertyName = "TagName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.TagName.DefaultCellStyle = dataGridViewCellStyle2;
            this.TagName.HeaderText = "Tag Name";
            this.TagName.MinimumWidth = 6;
            this.TagName.Name = "TagName";
            this.TagName.ReadOnly = true;
            this.TagName.ToolTipText = "Tag Name";
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.SubjectName.DefaultCellStyle = dataGridViewCellStyle3;
            this.SubjectName.HeaderText = "Subject Name";
            this.SubjectName.MinimumWidth = 6;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            this.SubjectName.ToolTipText = "Subject Name";
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.RoomName.DefaultCellStyle = dataGridViewCellStyle4;
            this.RoomName.HeaderText = "Room Name";
            this.RoomName.MinimumWidth = 6;
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            this.RoomName.ToolTipText = "Room Name";
            // 
            // Delete
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle5;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // RoomsForSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 615);
            this.Controls.Add(this.panel1);
            this.Name = "RoomsForSubjectsForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "RoomsForSubjectsForm";
            this.Shown += new System.EventHandler(this.RoomsForSubjectsForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectForTagDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView subjectForTagDataGridView;
        private System.Windows.Forms.Button subjectForTagSaveBtn;
        private System.Windows.Forms.ComboBox subjectSelectCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tagSelectCombobox;
        private System.Windows.Forms.Label buildingNameLabel;
        private System.Windows.Forms.ComboBox roomSelectCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}