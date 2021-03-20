namespace TimeTableManagmentSystem.Views.Tag
{
    partial class ManageTagForm
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
            this.tagPanel = new System.Windows.Forms.Panel();
            this.tagDataGridView = new System.Windows.Forms.DataGridView();
            this.tagSearcheIcon = new System.Windows.Forms.PictureBox();
            this.tagSearchInput = new System.Windows.Forms.TextBox();
            this.addNewTagBtn = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelatedTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tagPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagSearcheIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tagPanel
            // 
            this.tagPanel.BackColor = System.Drawing.Color.White;
            this.tagPanel.Controls.Add(this.tagDataGridView);
            this.tagPanel.Controls.Add(this.tagSearcheIcon);
            this.tagPanel.Controls.Add(this.tagSearchInput);
            this.tagPanel.Controls.Add(this.addNewTagBtn);
            this.tagPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagPanel.Location = new System.Drawing.Point(20, 20);
            this.tagPanel.Name = "tagPanel";
            this.tagPanel.Size = new System.Drawing.Size(1126, 575);
            this.tagPanel.TabIndex = 0;
            // 
            // tagDataGridView
            // 
            this.tagDataGridView.AllowUserToAddRows = false;
            this.tagDataGridView.AllowUserToDeleteRows = false;
            this.tagDataGridView.AllowUserToOrderColumns = true;
            this.tagDataGridView.AllowUserToResizeColumns = false;
            this.tagDataGridView.AllowUserToResizeRows = false;
            this.tagDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tagDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TagName,
            this.Code,
            this.RelatedTag,
            this.Edit,
            this.Delete});
            this.tagDataGridView.GridColor = System.Drawing.Color.White;
            this.tagDataGridView.Location = new System.Drawing.Point(13, 71);
            this.tagDataGridView.MultiSelect = false;
            this.tagDataGridView.Name = "tagDataGridView";
            this.tagDataGridView.ReadOnly = true;
            this.tagDataGridView.RowHeadersWidth = 51;
            this.tagDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tagDataGridView.RowTemplate.Height = 24;
            this.tagDataGridView.ShowEditingIcon = false;
            this.tagDataGridView.Size = new System.Drawing.Size(1098, 491);
            this.tagDataGridView.TabIndex = 0;
            this.tagDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tagSearcheIcon
            // 
            this.tagSearcheIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagSearcheIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tagSearcheIcon.Image = global::TimeTableManagmentSystem.Properties.Resources.search;
            this.tagSearcheIcon.Location = new System.Drawing.Point(1072, 15);
            this.tagSearcheIcon.Name = "tagSearcheIcon";
            this.tagSearcheIcon.Size = new System.Drawing.Size(39, 38);
            this.tagSearcheIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tagSearcheIcon.TabIndex = 8;
            this.tagSearcheIcon.TabStop = false;
            // 
            // tagSearchInput
            // 
            this.tagSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagSearchInput.BackColor = System.Drawing.SystemColors.Control;
            this.tagSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagSearchInput.Location = new System.Drawing.Point(663, 15);
            this.tagSearchInput.Name = "tagSearchInput";
            this.tagSearchInput.Size = new System.Drawing.Size(409, 38);
            this.tagSearchInput.TabIndex = 7;
            this.tagSearchInput.TextChanged += new System.EventHandler(this.tagSearchInput_TextChanged);
            // 
            // addNewTagBtn
            // 
            this.addNewTagBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.addNewTagBtn.FlatAppearance.BorderSize = 0;
            this.addNewTagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewTagBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewTagBtn.ForeColor = System.Drawing.Color.White;
            this.addNewTagBtn.Location = new System.Drawing.Point(13, 13);
            this.addNewTagBtn.Name = "addNewTagBtn";
            this.addNewTagBtn.Size = new System.Drawing.Size(110, 40);
            this.addNewTagBtn.TabIndex = 6;
            this.addNewTagBtn.Text = "New";
            this.addNewTagBtn.UseVisualStyleBackColor = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TagName
            // 
            this.TagName.DataPropertyName = "Name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagName.DefaultCellStyle = dataGridViewCellStyle2;
            this.TagName.HeaderText = "Name";
            this.TagName.MinimumWidth = 6;
            this.TagName.Name = "TagName";
            this.TagName.ReadOnly = true;
            this.TagName.ToolTipText = "Name";
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Code.DefaultCellStyle = dataGridViewCellStyle3;
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.ToolTipText = "Code";
            // 
            // RelatedTag
            // 
            this.RelatedTag.DataPropertyName = "RelatedTag";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelatedTag.DefaultCellStyle = dataGridViewCellStyle4;
            this.RelatedTag.HeaderText = "Related Tag";
            this.RelatedTag.MinimumWidth = 6;
            this.RelatedTag.Name = "RelatedTag";
            this.RelatedTag.ReadOnly = true;
            this.RelatedTag.ToolTipText = "Related Tag";
            // 
            // Edit
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle6;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // ManageTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 615);
            this.Controls.Add(this.tagPanel);
            this.Name = "ManageTagForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "ManageTagForm";
            this.Shown += new System.EventHandler(this.ManageTagForm_Shown);
            this.tagPanel.ResumeLayout(false);
            this.tagPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagSearcheIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tagPanel;
        private System.Windows.Forms.DataGridView tagDataGridView;
        private System.Windows.Forms.PictureBox tagSearcheIcon;
        private System.Windows.Forms.TextBox tagSearchInput;
        private System.Windows.Forms.Button addNewTagBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelatedTag;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}