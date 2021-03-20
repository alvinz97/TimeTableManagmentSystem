namespace TimeTableManagmentSystem
{
    partial class ManageLocation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLocation));
            this.addNewLocationBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.locationSearcheIcon = new System.Windows.Forms.PictureBox();
            this.locationSearchInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationSearcheIcon)).BeginInit();
            this.SuspendLayout();
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
            this.addNewLocationBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.locationSearcheIcon);
            this.panel1.Controls.Add(this.locationSearchInput);
            this.panel1.Controls.Add(this.addNewLocationBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 575);
            this.panel1.TabIndex = 15;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView.Location = new System.Drawing.Point(13, 77);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(1098, 481);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BuildingName";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column2.HeaderText = "Building Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "RoomName";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column3.HeaderText = "Room Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "RoomType";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Column4.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column4.HeaderText = "Room Type";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "RoomCapacity";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Column5.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column5.HeaderText = "Room Capacity";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(106)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(106)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle20;
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
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle21;
            this.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column7.HeaderText = "Delete";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Delete";
            this.Column7.UseColumnTextForButtonValue = true;
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
            this.locationSearcheIcon.Click += new System.EventHandler(this.locationSearcheIcon_Click);
            // 
            // locationSearchInput
            // 
            this.locationSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locationSearchInput.BackColor = System.Drawing.SystemColors.Control;
            this.locationSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationSearchInput.Location = new System.Drawing.Point(663, 17);
            this.locationSearchInput.Name = "locationSearchInput";
            this.locationSearchInput.Size = new System.Drawing.Size(409, 38);
            this.locationSearchInput.TabIndex = 4;
            this.locationSearchInput.TextChanged += new System.EventHandler(this.locationSearchInput_TextChanged);
            // 
            // ManageLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 615);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageLocation";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Manage Locations";
            this.Load += new System.EventHandler(this.ManageLocation_Load);
            this.Shown += new System.EventHandler(this.ManageLocation_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationSearcheIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addNewLocationBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox locationSearcheIcon;
        private System.Windows.Forms.TextBox locationSearchInput;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
    }
}