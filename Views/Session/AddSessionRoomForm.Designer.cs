namespace TimeTableManagmentSystem.Views.Session
{
    partial class AddSessionRoomForm
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
            this.selectSessionLabel = new System.Windows.Forms.Label();
            this.selectSessionInput = new System.Windows.Forms.ComboBox();
            this.selectRoomInput = new System.Windows.Forms.ComboBox();
            this.selectRoomLable = new System.Windows.Forms.Label();
            this.selectedSessionLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectedSessionTextBox = new System.Windows.Forms.RichTextBox();
            this.roomSaveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectSessionLabel
            // 
            this.selectSessionLabel.AutoSize = true;
            this.selectSessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSessionLabel.Location = new System.Drawing.Point(31, 78);
            this.selectSessionLabel.Name = "selectSessionLabel";
            this.selectSessionLabel.Size = new System.Drawing.Size(143, 25);
            this.selectSessionLabel.TabIndex = 16;
            this.selectSessionLabel.Text = "Select Session";
            // 
            // selectSessionInput
            // 
            this.selectSessionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSessionInput.FormattingEnabled = true;
            this.selectSessionInput.Location = new System.Drawing.Point(232, 75);
            this.selectSessionInput.Name = "selectSessionInput";
            this.selectSessionInput.Size = new System.Drawing.Size(468, 33);
            this.selectSessionInput.TabIndex = 18;
            // 
            // selectRoomInput
            // 
            this.selectRoomInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRoomInput.FormattingEnabled = true;
            this.selectRoomInput.Location = new System.Drawing.Point(232, 159);
            this.selectRoomInput.Name = "selectRoomInput";
            this.selectRoomInput.Size = new System.Drawing.Size(466, 33);
            this.selectRoomInput.TabIndex = 20;
            // 
            // selectRoomLable
            // 
            this.selectRoomLable.AutoSize = true;
            this.selectRoomLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRoomLable.Location = new System.Drawing.Point(31, 167);
            this.selectRoomLable.Name = "selectRoomLable";
            this.selectRoomLable.Size = new System.Drawing.Size(123, 25);
            this.selectRoomLable.TabIndex = 19;
            this.selectRoomLable.Text = "Select Room";
            // 
            // selectedSessionLable
            // 
            this.selectedSessionLable.AutoSize = true;
            this.selectedSessionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedSessionLable.Location = new System.Drawing.Point(31, 268);
            this.selectedSessionLable.Name = "selectedSessionLable";
            this.selectedSessionLable.Size = new System.Drawing.Size(165, 25);
            this.selectedSessionLable.TabIndex = 21;
            this.selectedSessionLable.Text = "Selected Session";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.roomSaveBtn);
            this.panel1.Controls.Add(this.selectedSessionTextBox);
            this.panel1.Controls.Add(this.selectedSessionLable);
            this.panel1.Controls.Add(this.selectSessionLabel);
            this.panel1.Controls.Add(this.selectRoomInput);
            this.panel1.Controls.Add(this.selectSessionInput);
            this.panel1.Controls.Add(this.selectRoomLable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 575);
            this.panel1.TabIndex = 22;
            // 
            // selectedSessionTextBox
            // 
            this.selectedSessionTextBox.Location = new System.Drawing.Point(232, 272);
            this.selectedSessionTextBox.Name = "selectedSessionTextBox";
            this.selectedSessionTextBox.Size = new System.Drawing.Size(473, 164);
            this.selectedSessionTextBox.TabIndex = 22;
            this.selectedSessionTextBox.Text = "";
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
            // ManageSessionRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 615);
            this.Controls.Add(this.panel1);
            this.Name = "ManageSessionRoomForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "ManageSessionRoomForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label selectSessionLabel;
        private System.Windows.Forms.ComboBox selectRoomInput;
        private System.Windows.Forms.Label selectRoomLable;
        private System.Windows.Forms.Label selectedSessionLable;
        private System.Windows.Forms.ComboBox selectSessionInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox selectedSessionTextBox;
        private System.Windows.Forms.Button roomSaveBtn;
    }
}