namespace TimeTableManagmentSystem.Views.Session
{
    partial class ManageSessionRoomForm
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
            this.headerLable = new System.Windows.Forms.Label();
            this.headerBackgroundPanel = new System.Windows.Forms.Panel();
            this.selectSessionLabel = new System.Windows.Forms.Label();
            this.selectRSessionInput = new System.Windows.Forms.ComboBox();
            this.selectRoomInput = new System.Windows.Forms.ComboBox();
            this.selectRoomLable = new System.Windows.Forms.Label();
            this.selectedSessionLable = new System.Windows.Forms.Label();
            this.headerBackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLable
            // 
            this.headerLable.AllowDrop = true;
            this.headerLable.AutoSize = true;
            this.headerLable.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLable.ForeColor = System.Drawing.Color.White;
            this.headerLable.Location = new System.Drawing.Point(30, 26);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(345, 36);
            this.headerLable.TabIndex = 1;
            this.headerLable.Text = "Manage Session Rooms";
            // 
            // headerBackgroundPanel
            // 
            this.headerBackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.headerBackgroundPanel.Controls.Add(this.headerLable);
            this.headerBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.headerBackgroundPanel.Name = "headerBackgroundPanel";
            this.headerBackgroundPanel.Size = new System.Drawing.Size(742, 92);
            this.headerBackgroundPanel.TabIndex = 15;
            // 
            // selectSessionLabel
            // 
            this.selectSessionLabel.AutoSize = true;
            this.selectSessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSessionLabel.Location = new System.Drawing.Point(29, 181);
            this.selectSessionLabel.Name = "selectSessionLabel";
            this.selectSessionLabel.Size = new System.Drawing.Size(143, 25);
            this.selectSessionLabel.TabIndex = 16;
            this.selectSessionLabel.Text = "Select Session";
            // 
            // selectRSessionInput
            // 
            this.selectRSessionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRSessionInput.FormattingEnabled = true;
            this.selectRSessionInput.Location = new System.Drawing.Point(218, 178);
            this.selectRSessionInput.Name = "selectRSessionInput";
            this.selectRSessionInput.Size = new System.Drawing.Size(468, 33);
            this.selectRSessionInput.TabIndex = 18;
            // 
            // selectRoomInput
            // 
            this.selectRoomInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRoomInput.FormattingEnabled = true;
            this.selectRoomInput.Location = new System.Drawing.Point(220, 296);
            this.selectRoomInput.Name = "selectRoomInput";
            this.selectRoomInput.Size = new System.Drawing.Size(466, 33);
            this.selectRoomInput.TabIndex = 20;
            // 
            // selectRoomLable
            // 
            this.selectRoomLable.AutoSize = true;
            this.selectRoomLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRoomLable.Location = new System.Drawing.Point(31, 299);
            this.selectRoomLable.Name = "selectRoomLable";
            this.selectRoomLable.Size = new System.Drawing.Size(123, 25);
            this.selectRoomLable.TabIndex = 19;
            this.selectRoomLable.Text = "Select Room";
            // 
            // selectedSessionLable
            // 
            this.selectedSessionLable.AutoSize = true;
            this.selectedSessionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedSessionLable.Location = new System.Drawing.Point(31, 418);
            this.selectedSessionLable.Name = "selectedSessionLable";
            this.selectedSessionLable.Size = new System.Drawing.Size(165, 25);
            this.selectedSessionLable.TabIndex = 21;
            this.selectedSessionLable.Text = "Selected Session";
            // 
            // ManageSessionRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 751);
            this.Controls.Add(this.selectedSessionLable);
            this.Controls.Add(this.selectRoomInput);
            this.Controls.Add(this.selectRoomLable);
            this.Controls.Add(this.selectRSessionInput);
            this.Controls.Add(this.selectSessionLabel);
            this.Controls.Add(this.headerBackgroundPanel);
            this.Name = "ManageSessionRoomForm";
            this.Text = "ManageSessionRoomForm";
            this.headerBackgroundPanel.ResumeLayout(false);
            this.headerBackgroundPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLable;
        private System.Windows.Forms.Panel headerBackgroundPanel;
        private System.Windows.Forms.Label selectSessionLabel;
        private System.Windows.Forms.ComboBox selectRSessionInput;
        private System.Windows.Forms.ComboBox selectRoomInput;
        private System.Windows.Forms.Label selectRoomLable;
        private System.Windows.Forms.Label selectedSessionLable;
    }
}