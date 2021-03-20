namespace TimeTableManagmentSystem.Views.Tag
{
    partial class AddTagForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tagSaveBtn = new System.Windows.Forms.Button();
            this.tagClearBtn = new System.Windows.Forms.Button();
            this.relatedTagInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tagCodeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tagNameInput = new System.Windows.Forms.TextBox();
            this.buildingNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tagSaveBtn);
            this.panel1.Controls.Add(this.tagClearBtn);
            this.panel1.Controls.Add(this.relatedTagInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tagCodeInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tagNameInput);
            this.panel1.Controls.Add(this.buildingNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 575);
            this.panel1.TabIndex = 0;
            // 
            // tagSaveBtn
            // 
            this.tagSaveBtn.BackColor = System.Drawing.Color.Blue;
            this.tagSaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.tagSaveBtn.FlatAppearance.BorderSize = 0;
            this.tagSaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tagSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tagSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagSaveBtn.ForeColor = System.Drawing.Color.White;
            this.tagSaveBtn.Location = new System.Drawing.Point(368, 362);
            this.tagSaveBtn.Name = "tagSaveBtn";
            this.tagSaveBtn.Padding = new System.Windows.Forms.Padding(10);
            this.tagSaveBtn.Size = new System.Drawing.Size(131, 53);
            this.tagSaveBtn.TabIndex = 14;
            this.tagSaveBtn.Text = "Save";
            this.tagSaveBtn.UseVisualStyleBackColor = false;
            this.tagSaveBtn.Click += new System.EventHandler(this.tagSaveBtn_Click);
            // 
            // tagClearBtn
            // 
            this.tagClearBtn.BackColor = System.Drawing.Color.Red;
            this.tagClearBtn.FlatAppearance.BorderSize = 0;
            this.tagClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tagClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tagClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagClearBtn.ForeColor = System.Drawing.Color.White;
            this.tagClearBtn.Location = new System.Drawing.Point(129, 362);
            this.tagClearBtn.Name = "tagClearBtn";
            this.tagClearBtn.Padding = new System.Windows.Forms.Padding(10);
            this.tagClearBtn.Size = new System.Drawing.Size(131, 53);
            this.tagClearBtn.TabIndex = 13;
            this.tagClearBtn.Text = "Clear";
            this.tagClearBtn.UseVisualStyleBackColor = false;
            this.tagClearBtn.Click += new System.EventHandler(this.tagClearBtn_Click);
            // 
            // relatedTagInput
            // 
            this.relatedTagInput.AcceptsReturn = true;
            this.relatedTagInput.AcceptsTab = true;
            this.relatedTagInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.relatedTagInput.CausesValidation = false;
            this.relatedTagInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatedTagInput.Location = new System.Drawing.Point(232, 250);
            this.relatedTagInput.Name = "relatedTagInput";
            this.relatedTagInput.Size = new System.Drawing.Size(403, 30);
            this.relatedTagInput.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Related Tag";
            // 
            // tagCodeInput
            // 
            this.tagCodeInput.AcceptsReturn = true;
            this.tagCodeInput.AcceptsTab = true;
            this.tagCodeInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tagCodeInput.CausesValidation = false;
            this.tagCodeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagCodeInput.Location = new System.Drawing.Point(232, 151);
            this.tagCodeInput.Name = "tagCodeInput";
            this.tagCodeInput.Size = new System.Drawing.Size(403, 30);
            this.tagCodeInput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tag Code";
            // 
            // tagNameInput
            // 
            this.tagNameInput.AcceptsReturn = true;
            this.tagNameInput.AcceptsTab = true;
            this.tagNameInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tagNameInput.CausesValidation = false;
            this.tagNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagNameInput.Location = new System.Drawing.Point(232, 60);
            this.tagNameInput.Name = "tagNameInput";
            this.tagNameInput.Size = new System.Drawing.Size(403, 30);
            this.tagNameInput.TabIndex = 5;
            // 
            // buildingNameLabel
            // 
            this.buildingNameLabel.AutoSize = true;
            this.buildingNameLabel.BackColor = System.Drawing.Color.White;
            this.buildingNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingNameLabel.Location = new System.Drawing.Point(41, 59);
            this.buildingNameLabel.Name = "buildingNameLabel";
            this.buildingNameLabel.Size = new System.Drawing.Size(104, 25);
            this.buildingNameLabel.TabIndex = 4;
            this.buildingNameLabel.Text = "Tag Name";
            // 
            // AddTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 615);
            this.Controls.Add(this.panel1);
            this.Name = "AddTagForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "AddTagForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox relatedTagInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tagCodeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tagNameInput;
        private System.Windows.Forms.Label buildingNameLabel;
        private System.Windows.Forms.Button tagSaveBtn;
        private System.Windows.Forms.Button tagClearBtn;
    }
}