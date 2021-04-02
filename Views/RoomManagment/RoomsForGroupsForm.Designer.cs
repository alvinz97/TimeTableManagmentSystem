namespace TimeTableManagmentSystem.Views.RoomManagment
{
    partial class RoomsForGroupsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomSelectCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomForGroupDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LecturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.roomForTagSaveBtn = new System.Windows.Forms.Button();
            this.subGroupSelectCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupSelectCombobox = new System.Windows.Forms.ComboBox();
            this.buildingNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomForGroupDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.roomSelectCombobox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.roomForGroupDataGridView);
            this.panel1.Controls.Add(this.roomForTagSaveBtn);
            this.panel1.Controls.Add(this.subGroupSelectCombobox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupSelectCombobox);
            this.panel1.Controls.Add(this.buildingNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 575);
            this.panel1.TabIndex = 16;
            // 
            // roomSelectCombobox
            // 
            this.roomSelectCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomSelectCombobox.FormattingEnabled = true;
            this.roomSelectCombobox.Location = new System.Drawing.Point(214, 126);
            this.roomSelectCombobox.Name = "roomSelectCombobox";
            this.roomSelectCombobox.Size = new System.Drawing.Size(345, 33);
            this.roomSelectCombobox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Room Name";
            // 
            // roomForGroupDataGridView
            // 
            this.roomForGroupDataGridView.AllowUserToAddRows = false;
            this.roomForGroupDataGridView.AllowUserToDeleteRows = false;
            this.roomForGroupDataGridView.AllowUserToResizeColumns = false;
            this.roomForGroupDataGridView.AllowUserToResizeRows = false;
            this.roomForGroupDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomForGroupDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomForGroupDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.roomForGroupDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomForGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomForGroupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.LecturerName,
            this.RoomName,
            this.Delete});
            this.roomForGroupDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.roomForGroupDataGridView.GridColor = System.Drawing.Color.White;
            this.roomForGroupDataGridView.Location = new System.Drawing.Point(12, 249);
            this.roomForGroupDataGridView.Name = "roomForGroupDataGridView";
            this.roomForGroupDataGridView.ReadOnly = true;
            this.roomForGroupDataGridView.RowHeadersWidth = 51;
            this.roomForGroupDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.roomForGroupDataGridView.RowTemplate.Height = 24;
            this.roomForGroupDataGridView.ShowEditingIcon = false;
            this.roomForGroupDataGridView.Size = new System.Drawing.Size(1102, 323);
            this.roomForGroupDataGridView.TabIndex = 0;
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
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.RoomName.DefaultCellStyle = dataGridViewCellStyle3;
            this.RoomName.HeaderText = "Room Name";
            this.RoomName.MinimumWidth = 6;
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            this.RoomName.ToolTipText = "Room Name";
            // 
            // Delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // roomForTagSaveBtn
            // 
            this.roomForTagSaveBtn.BackColor = System.Drawing.Color.Blue;
            this.roomForTagSaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.roomForTagSaveBtn.FlatAppearance.BorderSize = 0;
            this.roomForTagSaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roomForTagSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomForTagSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomForTagSaveBtn.ForeColor = System.Drawing.Color.White;
            this.roomForTagSaveBtn.Location = new System.Drawing.Point(214, 182);
            this.roomForTagSaveBtn.Name = "roomForTagSaveBtn";
            this.roomForTagSaveBtn.Padding = new System.Windows.Forms.Padding(10);
            this.roomForTagSaveBtn.Size = new System.Drawing.Size(131, 53);
            this.roomForTagSaveBtn.TabIndex = 33;
            this.roomForTagSaveBtn.Text = "Save";
            this.roomForTagSaveBtn.UseVisualStyleBackColor = false;
            // 
            // subGroupSelectCombobox
            // 
            this.subGroupSelectCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGroupSelectCombobox.FormattingEnabled = true;
            this.subGroupSelectCombobox.Location = new System.Drawing.Point(214, 70);
            this.subGroupSelectCombobox.Name = "subGroupSelectCombobox";
            this.subGroupSelectCombobox.Size = new System.Drawing.Size(345, 33);
            this.subGroupSelectCombobox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Sub Group ID";
            // 
            // groupSelectCombobox
            // 
            this.groupSelectCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSelectCombobox.FormattingEnabled = true;
            this.groupSelectCombobox.Location = new System.Drawing.Point(214, 17);
            this.groupSelectCombobox.Name = "groupSelectCombobox";
            this.groupSelectCombobox.Size = new System.Drawing.Size(345, 33);
            this.groupSelectCombobox.TabIndex = 30;
            // 
            // buildingNameLabel
            // 
            this.buildingNameLabel.AutoSize = true;
            this.buildingNameLabel.BackColor = System.Drawing.Color.White;
            this.buildingNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingNameLabel.Location = new System.Drawing.Point(41, 21);
            this.buildingNameLabel.Name = "buildingNameLabel";
            this.buildingNameLabel.Size = new System.Drawing.Size(90, 25);
            this.buildingNameLabel.TabIndex = 4;
            this.buildingNameLabel.Text = "Group ID";
            // 
            // RoomsForGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 615);
            this.Controls.Add(this.panel1);
            this.Name = "RoomsForGroupsForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "RoomsForGroupsForm";
            this.Shown += new System.EventHandler(this.RoomsForGroupsForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomForGroupDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView roomForGroupDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LecturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button roomForTagSaveBtn;
        private System.Windows.Forms.ComboBox subGroupSelectCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox groupSelectCombobox;
        private System.Windows.Forms.Label buildingNameLabel;
        private System.Windows.Forms.ComboBox roomSelectCombobox;
        private System.Windows.Forms.Label label2;
    }
}