namespace TimeTableManagmentSystem.Views.Session
{
    partial class AddNotAvailableSessionForm
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
            this.roomSaveBtn = new System.Windows.Forms.Button();
            this.selectLecturerLabel = new System.Windows.Forms.Label();
            this.selectLecturerCombobox = new System.Windows.Forms.ComboBox();
            this.selectGroupLable = new System.Windows.Forms.Label();
            this.selectGroupCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectSubGroupCombobox = new System.Windows.Forms.ComboBox();
            this.selectSessionIDLable = new System.Windows.Forms.Label();
            this.selectSessionIDCombobox = new System.Windows.Forms.ComboBox();
            this.setTimeLable = new System.Windows.Forms.Label();
            this.setTimeInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.setTimeInput);
            this.panel1.Controls.Add(this.setTimeLable);
            this.panel1.Controls.Add(this.selectSessionIDLable);
            this.panel1.Controls.Add(this.selectSessionIDCombobox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.selectSubGroupCombobox);
            this.panel1.Controls.Add(this.selectGroupLable);
            this.panel1.Controls.Add(this.selectGroupCombobox);
            this.panel1.Controls.Add(this.selectLecturerLabel);
            this.panel1.Controls.Add(this.selectLecturerCombobox);
            this.panel1.Controls.Add(this.roomSaveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 575);
            this.panel1.TabIndex = 23;
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
            this.roomSaveBtn.Location = new System.Drawing.Point(397, 472);
            this.roomSaveBtn.Name = "roomSaveBtn";
            this.roomSaveBtn.Padding = new System.Windows.Forms.Padding(10);
            this.roomSaveBtn.Size = new System.Drawing.Size(131, 53);
            this.roomSaveBtn.TabIndex = 23;
            this.roomSaveBtn.Text = "Save";
            this.roomSaveBtn.UseVisualStyleBackColor = false;
            // 
            // selectLecturerLabel
            // 
            this.selectLecturerLabel.AutoSize = true;
            this.selectLecturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLecturerLabel.Location = new System.Drawing.Point(46, 33);
            this.selectLecturerLabel.Name = "selectLecturerLabel";
            this.selectLecturerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectLecturerLabel.Size = new System.Drawing.Size(143, 25);
            this.selectLecturerLabel.TabIndex = 16;
            this.selectLecturerLabel.Text = "Select Lecturer";
            // 
            // selectLecturerCombobox
            // 
            this.selectLecturerCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLecturerCombobox.FormattingEnabled = true;
            this.selectLecturerCombobox.Location = new System.Drawing.Point(247, 30);
            this.selectLecturerCombobox.Name = "selectLecturerCombobox";
            this.selectLecturerCombobox.Size = new System.Drawing.Size(468, 33);
            this.selectLecturerCombobox.TabIndex = 18;
            // 
            // selectGroupLable
            // 
            this.selectGroupLable.AutoSize = true;
            this.selectGroupLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGroupLable.Location = new System.Drawing.Point(46, 124);
            this.selectGroupLable.Name = "selectGroupLable";
            this.selectGroupLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectGroupLable.Size = new System.Drawing.Size(126, 25);
            this.selectGroupLable.TabIndex = 24;
            this.selectGroupLable.Text = "Select Group";
            // 
            // selectGroupCombobox
            // 
            this.selectGroupCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGroupCombobox.FormattingEnabled = true;
            this.selectGroupCombobox.Location = new System.Drawing.Point(247, 121);
            this.selectGroupCombobox.Name = "selectGroupCombobox";
            this.selectGroupCombobox.Size = new System.Drawing.Size(468, 33);
            this.selectGroupCombobox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 219);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Select Sub Group";
            // 
            // selectSubGroupCombobox
            // 
            this.selectSubGroupCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSubGroupCombobox.FormattingEnabled = true;
            this.selectSubGroupCombobox.Location = new System.Drawing.Point(247, 216);
            this.selectSubGroupCombobox.Name = "selectSubGroupCombobox";
            this.selectSubGroupCombobox.Size = new System.Drawing.Size(468, 33);
            this.selectSubGroupCombobox.TabIndex = 27;
            // 
            // selectSessionIDLable
            // 
            this.selectSessionIDLable.AutoSize = true;
            this.selectSessionIDLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSessionIDLable.Location = new System.Drawing.Point(46, 312);
            this.selectSessionIDLable.Name = "selectSessionIDLable";
            this.selectSessionIDLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectSessionIDLable.Size = new System.Drawing.Size(167, 25);
            this.selectSessionIDLable.TabIndex = 28;
            this.selectSessionIDLable.Text = "Select Session ID";
            // 
            // selectSessionIDCombobox
            // 
            this.selectSessionIDCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSessionIDCombobox.FormattingEnabled = true;
            this.selectSessionIDCombobox.Location = new System.Drawing.Point(247, 309);
            this.selectSessionIDCombobox.Name = "selectSessionIDCombobox";
            this.selectSessionIDCombobox.Size = new System.Drawing.Size(468, 33);
            this.selectSessionIDCombobox.TabIndex = 29;
            // 
            // setTimeLable
            // 
            this.setTimeLable.AutoSize = true;
            this.setTimeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTimeLable.Location = new System.Drawing.Point(46, 403);
            this.setTimeLable.Name = "setTimeLable";
            this.setTimeLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.setTimeLable.Size = new System.Drawing.Size(91, 25);
            this.setTimeLable.TabIndex = 30;
            this.setTimeLable.Text = "Set Time";
            // 
            // setTimeInput
            // 
            this.setTimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTimeInput.Location = new System.Drawing.Point(247, 403);
            this.setTimeInput.Margin = new System.Windows.Forms.Padding(4);
            this.setTimeInput.Name = "setTimeInput";
            this.setTimeInput.Size = new System.Drawing.Size(468, 30);
            this.setTimeInput.TabIndex = 54;
            // 
            // AddNotAvailableSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 615);
            this.Controls.Add(this.panel1);
            this.Name = "AddNotAvailableSessionForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "AddNotAvailableSessionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox setTimeInput;
        private System.Windows.Forms.Label setTimeLable;
        private System.Windows.Forms.Label selectSessionIDLable;
        private System.Windows.Forms.ComboBox selectSessionIDCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectSubGroupCombobox;
        private System.Windows.Forms.Label selectGroupLable;
        private System.Windows.Forms.ComboBox selectGroupCombobox;
        private System.Windows.Forms.Label selectLecturerLabel;
        private System.Windows.Forms.ComboBox selectLecturerCombobox;
        private System.Windows.Forms.Button roomSaveBtn;
    }
}