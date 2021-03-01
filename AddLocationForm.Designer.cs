﻿namespace TimeTableManagmentSystem
{
    partial class AddLocationForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerLable = new System.Windows.Forms.Label();
            this.buildingNameLabel = new System.Windows.Forms.Label();
            this.buildingNameInput = new System.Windows.Forms.TextBox();
            this.roomNameInput = new System.Windows.Forms.TextBox();
            this.roomNameLable = new System.Windows.Forms.Label();
            this.roomTypeLable = new System.Windows.Forms.Label();
            this.lectureTypeRadio = new System.Windows.Forms.RadioButton();
            this.labTypeRadio = new System.Windows.Forms.RadioButton();
            this.roomCapacityInput = new System.Windows.Forms.TextBox();
            this.roomCapacityLable = new System.Windows.Forms.Label();
            this.roomClearBtn = new System.Windows.Forms.Button();
            this.roomSaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-345, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // headerLable
            // 
            this.headerLable.AllowDrop = true;
            this.headerLable.AutoSize = true;
            this.headerLable.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLable.Location = new System.Drawing.Point(30, 30);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(202, 36);
            this.headerLable.TabIndex = 1;
            this.headerLable.Text = "Add Location";
            this.headerLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // buildingNameLabel
            // 
            this.buildingNameLabel.AutoSize = true;
            this.buildingNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingNameLabel.Location = new System.Drawing.Point(31, 140);
            this.buildingNameLabel.Name = "buildingNameLabel";
            this.buildingNameLabel.Size = new System.Drawing.Size(138, 25);
            this.buildingNameLabel.TabIndex = 2;
            this.buildingNameLabel.Text = "Building Name";
            this.buildingNameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buildingNameInput
            // 
            this.buildingNameInput.AcceptsReturn = true;
            this.buildingNameInput.AcceptsTab = true;
            this.buildingNameInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.buildingNameInput.CausesValidation = false;
            this.buildingNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingNameInput.Location = new System.Drawing.Point(242, 135);
            this.buildingNameInput.Name = "buildingNameInput";
            this.buildingNameInput.Size = new System.Drawing.Size(403, 30);
            this.buildingNameInput.TabIndex = 3;
            this.buildingNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // roomNameInput
            // 
            this.roomNameInput.AcceptsReturn = true;
            this.roomNameInput.AcceptsTab = true;
            this.roomNameInput.CausesValidation = false;
            this.roomNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameInput.Location = new System.Drawing.Point(242, 229);
            this.roomNameInput.Name = "roomNameInput";
            this.roomNameInput.Size = new System.Drawing.Size(403, 30);
            this.roomNameInput.TabIndex = 5;
            this.roomNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // roomNameLable
            // 
            this.roomNameLable.AutoSize = true;
            this.roomNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameLable.Location = new System.Drawing.Point(31, 234);
            this.roomNameLable.Name = "roomNameLable";
            this.roomNameLable.Size = new System.Drawing.Size(120, 25);
            this.roomNameLable.TabIndex = 4;
            this.roomNameLable.Text = "Room Name";
            this.roomNameLable.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // roomTypeLable
            // 
            this.roomTypeLable.AutoSize = true;
            this.roomTypeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeLable.Location = new System.Drawing.Point(31, 329);
            this.roomTypeLable.Name = "roomTypeLable";
            this.roomTypeLable.Size = new System.Drawing.Size(113, 25);
            this.roomTypeLable.TabIndex = 6;
            this.roomTypeLable.Text = "Room Type";
            // 
            // lectureTypeRadio
            // 
            this.lectureTypeRadio.AutoSize = true;
            this.lectureTypeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lectureTypeRadio.Location = new System.Drawing.Point(242, 332);
            this.lectureTypeRadio.Name = "lectureTypeRadio";
            this.lectureTypeRadio.Size = new System.Drawing.Size(122, 24);
            this.lectureTypeRadio.TabIndex = 7;
            this.lectureTypeRadio.TabStop = true;
            this.lectureTypeRadio.Text = "Lecture Hall";
            this.lectureTypeRadio.UseVisualStyleBackColor = true;
            this.lectureTypeRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labTypeRadio
            // 
            this.labTypeRadio.AutoSize = true;
            this.labTypeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTypeRadio.Location = new System.Drawing.Point(419, 332);
            this.labTypeRadio.Name = "labTypeRadio";
            this.labTypeRadio.Size = new System.Drawing.Size(110, 24);
            this.labTypeRadio.TabIndex = 8;
            this.labTypeRadio.TabStop = true;
            this.labTypeRadio.Text = "Laboratory";
            this.labTypeRadio.UseVisualStyleBackColor = true;
            // 
            // roomCapacityInput
            // 
            this.roomCapacityInput.AcceptsReturn = true;
            this.roomCapacityInput.AcceptsTab = true;
            this.roomCapacityInput.CausesValidation = false;
            this.roomCapacityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCapacityInput.Location = new System.Drawing.Point(242, 415);
            this.roomCapacityInput.Name = "roomCapacityInput";
            this.roomCapacityInput.Size = new System.Drawing.Size(403, 30);
            this.roomCapacityInput.TabIndex = 10;
            // 
            // roomCapacityLable
            // 
            this.roomCapacityLable.AutoSize = true;
            this.roomCapacityLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCapacityLable.Location = new System.Drawing.Point(31, 420);
            this.roomCapacityLable.Name = "roomCapacityLable";
            this.roomCapacityLable.Size = new System.Drawing.Size(145, 25);
            this.roomCapacityLable.TabIndex = 9;
            this.roomCapacityLable.Text = "Room Capacity";
            // 
            // roomClearBtn
            // 
            this.roomClearBtn.BackColor = System.Drawing.Color.Red;
            this.roomClearBtn.FlatAppearance.BorderSize = 0;
            this.roomClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.roomClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomClearBtn.ForeColor = System.Drawing.Color.White;
            this.roomClearBtn.Location = new System.Drawing.Point(242, 517);
            this.roomClearBtn.Name = "roomClearBtn";
            this.roomClearBtn.Padding = new System.Windows.Forms.Padding(10);
            this.roomClearBtn.Size = new System.Drawing.Size(131, 53);
            this.roomClearBtn.TabIndex = 11;
            this.roomClearBtn.Text = "Clear";
            this.roomClearBtn.UseVisualStyleBackColor = false;
            // 
            // roomSaveBtn
            // 
            this.roomSaveBtn.BackColor = System.Drawing.Color.Blue;
            this.roomSaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.roomSaveBtn.FlatAppearance.BorderSize = 0;
            this.roomSaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roomSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomSaveBtn.ForeColor = System.Drawing.Color.White;
            this.roomSaveBtn.Location = new System.Drawing.Point(481, 517);
            this.roomSaveBtn.Name = "roomSaveBtn";
            this.roomSaveBtn.Padding = new System.Windows.Forms.Padding(10);
            this.roomSaveBtn.Size = new System.Drawing.Size(131, 53);
            this.roomSaveBtn.TabIndex = 12;
            this.roomSaveBtn.Text = "Save";
            this.roomSaveBtn.UseVisualStyleBackColor = false;
            // 
            // AddLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 631);
            this.Controls.Add(this.roomSaveBtn);
            this.Controls.Add(this.roomClearBtn);
            this.Controls.Add(this.roomCapacityInput);
            this.Controls.Add(this.roomCapacityLable);
            this.Controls.Add(this.labTypeRadio);
            this.Controls.Add(this.lectureTypeRadio);
            this.Controls.Add(this.roomTypeLable);
            this.Controls.Add(this.roomNameInput);
            this.Controls.Add(this.roomNameLable);
            this.Controls.Add(this.buildingNameInput);
            this.Controls.Add(this.buildingNameLabel);
            this.Controls.Add(this.headerLable);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddLocationForm";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headerLable;
        private System.Windows.Forms.Label buildingNameLabel;
        private System.Windows.Forms.TextBox buildingNameInput;
        private System.Windows.Forms.TextBox roomNameInput;
        private System.Windows.Forms.Label roomNameLable;
        private System.Windows.Forms.Label roomTypeLable;
        private System.Windows.Forms.RadioButton lectureTypeRadio;
        private System.Windows.Forms.RadioButton labTypeRadio;
        private System.Windows.Forms.TextBox roomCapacityInput;
        private System.Windows.Forms.Label roomCapacityLable;
        private System.Windows.Forms.Button roomClearBtn;
        private System.Windows.Forms.Button roomSaveBtn;
    }
}

