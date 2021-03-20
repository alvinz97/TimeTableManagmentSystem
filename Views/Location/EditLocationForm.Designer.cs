namespace TimeTableManagmentSystem.Views.Location
{
    partial class EditLocationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLocationForm));
            this.roomUpdateBtn = new System.Windows.Forms.Button();
            this.roomCapacityInput = new System.Windows.Forms.TextBox();
            this.roomCapacityLable = new System.Windows.Forms.Label();
            this.labTypeRadio = new System.Windows.Forms.RadioButton();
            this.lectureTypeRadio = new System.Windows.Forms.RadioButton();
            this.roomTypeLable = new System.Windows.Forms.Label();
            this.roomNameInput = new System.Windows.Forms.TextBox();
            this.roomNameLable = new System.Windows.Forms.Label();
            this.buildingNameInput = new System.Windows.Forms.TextBox();
            this.buildingNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomUpdateBtn
            // 
            this.roomUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(211)))), ((int)(((byte)(0)))));
            this.roomUpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.roomUpdateBtn.FlatAppearance.BorderSize = 0;
            this.roomUpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roomUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.roomUpdateBtn.Location = new System.Drawing.Point(279, 449);
            this.roomUpdateBtn.Name = "roomUpdateBtn";
            this.roomUpdateBtn.Padding = new System.Windows.Forms.Padding(10);
            this.roomUpdateBtn.Size = new System.Drawing.Size(131, 53);
            this.roomUpdateBtn.TabIndex = 25;
            this.roomUpdateBtn.Text = "Update";
            this.roomUpdateBtn.UseVisualStyleBackColor = false;
            this.roomUpdateBtn.Click += new System.EventHandler(this.roomSaveBtn_Click);
            // 
            // roomCapacityInput
            // 
            this.roomCapacityInput.AcceptsReturn = true;
            this.roomCapacityInput.AcceptsTab = true;
            this.roomCapacityInput.CausesValidation = false;
            this.roomCapacityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCapacityInput.Location = new System.Drawing.Point(242, 377);
            this.roomCapacityInput.Name = "roomCapacityInput";
            this.roomCapacityInput.Size = new System.Drawing.Size(403, 30);
            this.roomCapacityInput.TabIndex = 23;
            // 
            // roomCapacityLable
            // 
            this.roomCapacityLable.AutoSize = true;
            this.roomCapacityLable.BackColor = System.Drawing.Color.White;
            this.roomCapacityLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCapacityLable.Location = new System.Drawing.Point(51, 380);
            this.roomCapacityLable.Name = "roomCapacityLable";
            this.roomCapacityLable.Size = new System.Drawing.Size(145, 25);
            this.roomCapacityLable.TabIndex = 22;
            this.roomCapacityLable.Text = "Room Capacity";
            // 
            // labTypeRadio
            // 
            this.labTypeRadio.AutoSize = true;
            this.labTypeRadio.BackColor = System.Drawing.Color.White;
            this.labTypeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTypeRadio.Location = new System.Drawing.Point(423, 292);
            this.labTypeRadio.Name = "labTypeRadio";
            this.labTypeRadio.Size = new System.Drawing.Size(110, 24);
            this.labTypeRadio.TabIndex = 21;
            this.labTypeRadio.TabStop = true;
            this.labTypeRadio.Text = "Laboratory";
            this.labTypeRadio.UseVisualStyleBackColor = false;
            // 
            // lectureTypeRadio
            // 
            this.lectureTypeRadio.AutoSize = true;
            this.lectureTypeRadio.BackColor = System.Drawing.Color.White;
            this.lectureTypeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lectureTypeRadio.Location = new System.Drawing.Point(246, 292);
            this.lectureTypeRadio.Name = "lectureTypeRadio";
            this.lectureTypeRadio.Size = new System.Drawing.Size(122, 24);
            this.lectureTypeRadio.TabIndex = 20;
            this.lectureTypeRadio.TabStop = true;
            this.lectureTypeRadio.Text = "Lecture Hall";
            this.lectureTypeRadio.UseVisualStyleBackColor = false;
            // 
            // roomTypeLable
            // 
            this.roomTypeLable.AutoSize = true;
            this.roomTypeLable.BackColor = System.Drawing.Color.White;
            this.roomTypeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeLable.Location = new System.Drawing.Point(51, 289);
            this.roomTypeLable.Name = "roomTypeLable";
            this.roomTypeLable.Size = new System.Drawing.Size(113, 25);
            this.roomTypeLable.TabIndex = 19;
            this.roomTypeLable.Text = "Room Type";
            // 
            // roomNameInput
            // 
            this.roomNameInput.AcceptsReturn = true;
            this.roomNameInput.AcceptsTab = true;
            this.roomNameInput.CausesValidation = false;
            this.roomNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameInput.Location = new System.Drawing.Point(242, 194);
            this.roomNameInput.Name = "roomNameInput";
            this.roomNameInput.Size = new System.Drawing.Size(403, 30);
            this.roomNameInput.TabIndex = 18;
            // 
            // roomNameLable
            // 
            this.roomNameLable.AutoSize = true;
            this.roomNameLable.BackColor = System.Drawing.Color.White;
            this.roomNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameLable.Location = new System.Drawing.Point(51, 194);
            this.roomNameLable.Name = "roomNameLable";
            this.roomNameLable.Size = new System.Drawing.Size(120, 25);
            this.roomNameLable.TabIndex = 17;
            this.roomNameLable.Text = "Room Name";
            // 
            // buildingNameInput
            // 
            this.buildingNameInput.AcceptsReturn = true;
            this.buildingNameInput.AcceptsTab = true;
            this.buildingNameInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.buildingNameInput.CausesValidation = false;
            this.buildingNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingNameInput.Location = new System.Drawing.Point(242, 100);
            this.buildingNameInput.Name = "buildingNameInput";
            this.buildingNameInput.Size = new System.Drawing.Size(403, 30);
            this.buildingNameInput.TabIndex = 16;
            // 
            // buildingNameLabel
            // 
            this.buildingNameLabel.AutoSize = true;
            this.buildingNameLabel.BackColor = System.Drawing.Color.White;
            this.buildingNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingNameLabel.Location = new System.Drawing.Point(51, 100);
            this.buildingNameLabel.Name = "buildingNameLabel";
            this.buildingNameLabel.Size = new System.Drawing.Size(138, 25);
            this.buildingNameLabel.TabIndex = 15;
            this.buildingNameLabel.Text = "Building Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.roomUpdateBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 575);
            this.panel1.TabIndex = 26;
            // 
            // EditLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 615);
            this.Controls.Add(this.roomCapacityInput);
            this.Controls.Add(this.roomCapacityLable);
            this.Controls.Add(this.labTypeRadio);
            this.Controls.Add(this.lectureTypeRadio);
            this.Controls.Add(this.roomTypeLable);
            this.Controls.Add(this.roomNameInput);
            this.Controls.Add(this.roomNameLable);
            this.Controls.Add(this.buildingNameInput);
            this.Controls.Add(this.buildingNameLabel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditLocationForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Edit Location";
            this.Load += new System.EventHandler(this.EditLocationForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button roomUpdateBtn;
        private System.Windows.Forms.TextBox roomCapacityInput;
        private System.Windows.Forms.Label roomCapacityLable;
        private System.Windows.Forms.RadioButton labTypeRadio;
        private System.Windows.Forms.RadioButton lectureTypeRadio;
        private System.Windows.Forms.Label roomTypeLable;
        private System.Windows.Forms.TextBox roomNameInput;
        private System.Windows.Forms.Label roomNameLable;
        private System.Windows.Forms.TextBox buildingNameInput;
        private System.Windows.Forms.Label buildingNameLabel;
        private System.Windows.Forms.Panel panel1;
    }
}