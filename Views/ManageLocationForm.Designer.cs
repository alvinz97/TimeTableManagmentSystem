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
            this.headerLable = new System.Windows.Forms.Label();
            this.addNewLocationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLable
            // 
            this.headerLable.AllowDrop = true;
            this.headerLable.AutoSize = true;
            this.headerLable.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLable.Location = new System.Drawing.Point(31, 32);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(257, 36);
            this.headerLable.TabIndex = 2;
            this.headerLable.Text = "Manage Location";
            this.headerLable.Click += new System.EventHandler(this.headerLable_Click);
            // 
            // addNewLocationBtn
            // 
            this.addNewLocationBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNewLocationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewLocationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewLocationBtn.ForeColor = System.Drawing.Color.White;
            this.addNewLocationBtn.Location = new System.Drawing.Point(37, 93);
            this.addNewLocationBtn.Name = "addNewLocationBtn";
            this.addNewLocationBtn.Size = new System.Drawing.Size(110, 40);
            this.addNewLocationBtn.TabIndex = 3;
            this.addNewLocationBtn.Text = "New";
            this.addNewLocationBtn.UseVisualStyleBackColor = false;
            this.addNewLocationBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 703);
            this.Controls.Add(this.addNewLocationBtn);
            this.Controls.Add(this.headerLable);
            this.Name = "ManageLocation";
            this.Text = "ManageLocation";
            this.Load += new System.EventHandler(this.ManageLocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLable;
        private System.Windows.Forms.Button addNewLocationBtn;
    }
}