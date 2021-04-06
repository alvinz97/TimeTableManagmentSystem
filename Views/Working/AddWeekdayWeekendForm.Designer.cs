namespace TimeTableManagmentSystem.Views.Working
{
    partial class AddWeekdayWeekendForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWeekdayWeekendForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.weekendNweekdaySaveBtn = new System.Windows.Forms.Button();
            this.minutesLable = new System.Windows.Forms.Label();
            this.hoursLable = new System.Windows.Forms.Label();
            this.workingTimeMinutesInput = new System.Windows.Forms.NumericUpDown();
            this.workingTimeHoursInput = new System.Windows.Forms.NumericUpDown();
            this.workingTimePerDayLable = new System.Windows.Forms.Label();
            this.sundayCheckbox = new System.Windows.Forms.CheckBox();
            this.saturdayCheckbox = new System.Windows.Forms.CheckBox();
            this.fridayCheckbox = new System.Windows.Forms.CheckBox();
            this.thursdayCheckbox = new System.Windows.Forms.CheckBox();
            this.wednesdayCheckbox = new System.Windows.Forms.CheckBox();
            this.tuesdayCheckbox = new System.Windows.Forms.CheckBox();
            this.mondayCheckBox = new System.Windows.Forms.CheckBox();
            this.workingDaysLable = new System.Windows.Forms.Label();
            this.noOfWorkingDaysInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workingTimeMinutesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingTimeHoursInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOfWorkingDaysInput)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.weekendNweekdaySaveBtn);
            this.panel1.Controls.Add(this.minutesLable);
            this.panel1.Controls.Add(this.hoursLable);
            this.panel1.Controls.Add(this.workingTimeMinutesInput);
            this.panel1.Controls.Add(this.workingTimeHoursInput);
            this.panel1.Controls.Add(this.workingTimePerDayLable);
            this.panel1.Controls.Add(this.sundayCheckbox);
            this.panel1.Controls.Add(this.saturdayCheckbox);
            this.panel1.Controls.Add(this.fridayCheckbox);
            this.panel1.Controls.Add(this.thursdayCheckbox);
            this.panel1.Controls.Add(this.wednesdayCheckbox);
            this.panel1.Controls.Add(this.tuesdayCheckbox);
            this.panel1.Controls.Add(this.mondayCheckBox);
            this.panel1.Controls.Add(this.workingDaysLable);
            this.panel1.Controls.Add(this.noOfWorkingDaysInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 575);
            this.panel1.TabIndex = 23;
            // 
            // weekendNweekdaySaveBtn
            // 
            this.weekendNweekdaySaveBtn.BackColor = System.Drawing.Color.Blue;
            this.weekendNweekdaySaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.weekendNweekdaySaveBtn.FlatAppearance.BorderSize = 0;
            this.weekendNweekdaySaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.weekendNweekdaySaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weekendNweekdaySaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekendNweekdaySaveBtn.ForeColor = System.Drawing.Color.White;
            this.weekendNweekdaySaveBtn.Location = new System.Drawing.Point(419, 421);
            this.weekendNweekdaySaveBtn.Name = "weekendNweekdaySaveBtn";
            this.weekendNweekdaySaveBtn.Padding = new System.Windows.Forms.Padding(10);
            this.weekendNweekdaySaveBtn.Size = new System.Drawing.Size(131, 53);
            this.weekendNweekdaySaveBtn.TabIndex = 36;
            this.weekendNweekdaySaveBtn.Text = "Save";
            this.weekendNweekdaySaveBtn.UseVisualStyleBackColor = false;
            this.weekendNweekdaySaveBtn.Click += new System.EventHandler(this.weekendNweekdaySaveBtn_Click);
            // 
            // minutesLable
            // 
            this.minutesLable.AutoSize = true;
            this.minutesLable.BackColor = System.Drawing.Color.White;
            this.minutesLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLable.Location = new System.Drawing.Point(697, 333);
            this.minutesLable.Name = "minutesLable";
            this.minutesLable.Size = new System.Drawing.Size(81, 25);
            this.minutesLable.TabIndex = 35;
            this.minutesLable.Text = "Minutes";
            // 
            // hoursLable
            // 
            this.hoursLable.AutoSize = true;
            this.hoursLable.BackColor = System.Drawing.Color.White;
            this.hoursLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLable.Location = new System.Drawing.Point(398, 336);
            this.hoursLable.Name = "hoursLable";
            this.hoursLable.Size = new System.Drawing.Size(64, 25);
            this.hoursLable.TabIndex = 34;
            this.hoursLable.Text = "Hours";
            // 
            // workingTimeMinutesInput
            // 
            this.workingTimeMinutesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingTimeMinutesInput.Location = new System.Drawing.Point(571, 331);
            this.workingTimeMinutesInput.Name = "workingTimeMinutesInput";
            this.workingTimeMinutesInput.Size = new System.Drawing.Size(120, 30);
            this.workingTimeMinutesInput.TabIndex = 33;
            // 
            // workingTimeHoursInput
            // 
            this.workingTimeHoursInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingTimeHoursInput.Location = new System.Drawing.Point(272, 334);
            this.workingTimeHoursInput.Name = "workingTimeHoursInput";
            this.workingTimeHoursInput.Size = new System.Drawing.Size(120, 30);
            this.workingTimeHoursInput.TabIndex = 32;
            // 
            // workingTimePerDayLable
            // 
            this.workingTimePerDayLable.AutoSize = true;
            this.workingTimePerDayLable.BackColor = System.Drawing.Color.White;
            this.workingTimePerDayLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingTimePerDayLable.Location = new System.Drawing.Point(28, 336);
            this.workingTimePerDayLable.Name = "workingTimePerDayLable";
            this.workingTimePerDayLable.Size = new System.Drawing.Size(209, 25);
            this.workingTimePerDayLable.TabIndex = 31;
            this.workingTimePerDayLable.Text = "Working Time Per Day";
            // 
            // sundayCheckbox
            // 
            this.sundayCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sundayCheckbox.AutoSize = true;
            this.sundayCheckbox.BackColor = System.Drawing.Color.White;
            this.sundayCheckbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundayCheckbox.ForeColor = System.Drawing.Color.Gray;
            this.sundayCheckbox.Location = new System.Drawing.Point(396, 253);
            this.sundayCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.sundayCheckbox.Name = "sundayCheckbox";
            this.sundayCheckbox.Size = new System.Drawing.Size(82, 24);
            this.sundayCheckbox.TabIndex = 30;
            this.sundayCheckbox.Text = "Sunday";
            this.sundayCheckbox.UseVisualStyleBackColor = false;
            this.sundayCheckbox.CheckedChanged += new System.EventHandler(this.sundayCheckbox_CheckedChanged);
            // 
            // saturdayCheckbox
            // 
            this.saturdayCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saturdayCheckbox.AutoSize = true;
            this.saturdayCheckbox.BackColor = System.Drawing.Color.White;
            this.saturdayCheckbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturdayCheckbox.ForeColor = System.Drawing.Color.Gray;
            this.saturdayCheckbox.Location = new System.Drawing.Point(272, 253);
            this.saturdayCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.saturdayCheckbox.Name = "saturdayCheckbox";
            this.saturdayCheckbox.Size = new System.Drawing.Size(92, 24);
            this.saturdayCheckbox.TabIndex = 29;
            this.saturdayCheckbox.Text = "Saturday";
            this.saturdayCheckbox.UseVisualStyleBackColor = false;
            this.saturdayCheckbox.CheckedChanged += new System.EventHandler(this.saturdayCheckbox_CheckedChanged);
            // 
            // fridayCheckbox
            // 
            this.fridayCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fridayCheckbox.AutoSize = true;
            this.fridayCheckbox.BackColor = System.Drawing.Color.White;
            this.fridayCheckbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridayCheckbox.ForeColor = System.Drawing.Color.Gray;
            this.fridayCheckbox.Location = new System.Drawing.Point(772, 175);
            this.fridayCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.fridayCheckbox.Name = "fridayCheckbox";
            this.fridayCheckbox.Size = new System.Drawing.Size(74, 24);
            this.fridayCheckbox.TabIndex = 28;
            this.fridayCheckbox.Text = "Friday";
            this.fridayCheckbox.UseVisualStyleBackColor = false;
            this.fridayCheckbox.CheckedChanged += new System.EventHandler(this.fridayCheckbox_CheckedChanged);
            // 
            // thursdayCheckbox
            // 
            this.thursdayCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thursdayCheckbox.AutoSize = true;
            this.thursdayCheckbox.BackColor = System.Drawing.Color.White;
            this.thursdayCheckbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursdayCheckbox.ForeColor = System.Drawing.Color.Gray;
            this.thursdayCheckbox.Location = new System.Drawing.Point(654, 175);
            this.thursdayCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.thursdayCheckbox.Name = "thursdayCheckbox";
            this.thursdayCheckbox.Size = new System.Drawing.Size(94, 24);
            this.thursdayCheckbox.TabIndex = 27;
            this.thursdayCheckbox.Text = "Thursday";
            this.thursdayCheckbox.UseVisualStyleBackColor = false;
            this.thursdayCheckbox.CheckedChanged += new System.EventHandler(this.thursdayCheckbox_CheckedChanged);
            // 
            // wednesdayCheckbox
            // 
            this.wednesdayCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wednesdayCheckbox.AutoSize = true;
            this.wednesdayCheckbox.BackColor = System.Drawing.Color.White;
            this.wednesdayCheckbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesdayCheckbox.ForeColor = System.Drawing.Color.Gray;
            this.wednesdayCheckbox.Location = new System.Drawing.Point(510, 177);
            this.wednesdayCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.wednesdayCheckbox.Name = "wednesdayCheckbox";
            this.wednesdayCheckbox.Size = new System.Drawing.Size(110, 24);
            this.wednesdayCheckbox.TabIndex = 26;
            this.wednesdayCheckbox.Text = "Wednesday";
            this.wednesdayCheckbox.UseVisualStyleBackColor = false;
            this.wednesdayCheckbox.CheckedChanged += new System.EventHandler(this.wednesdayCheckbox_CheckedChanged);
            // 
            // tuesdayCheckbox
            // 
            this.tuesdayCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tuesdayCheckbox.AutoSize = true;
            this.tuesdayCheckbox.BackColor = System.Drawing.Color.White;
            this.tuesdayCheckbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesdayCheckbox.ForeColor = System.Drawing.Color.Gray;
            this.tuesdayCheckbox.Location = new System.Drawing.Point(396, 177);
            this.tuesdayCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.tuesdayCheckbox.Name = "tuesdayCheckbox";
            this.tuesdayCheckbox.Size = new System.Drawing.Size(86, 24);
            this.tuesdayCheckbox.TabIndex = 25;
            this.tuesdayCheckbox.Text = "Tuesday";
            this.tuesdayCheckbox.UseVisualStyleBackColor = false;
            this.tuesdayCheckbox.CheckedChanged += new System.EventHandler(this.tuesdayCheckbox_CheckedChanged);
            // 
            // mondayCheckBox
            // 
            this.mondayCheckBox.AutoSize = true;
            this.mondayCheckBox.BackColor = System.Drawing.Color.White;
            this.mondayCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mondayCheckBox.ForeColor = System.Drawing.Color.Gray;
            this.mondayCheckBox.Location = new System.Drawing.Point(272, 177);
            this.mondayCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.mondayCheckBox.Name = "mondayCheckBox";
            this.mondayCheckBox.Size = new System.Drawing.Size(88, 24);
            this.mondayCheckBox.TabIndex = 24;
            this.mondayCheckBox.Text = "Monday";
            this.mondayCheckBox.UseVisualStyleBackColor = false;
            this.mondayCheckBox.CheckedChanged += new System.EventHandler(this.mondayCheckBox_CheckedChanged);
            // 
            // workingDaysLable
            // 
            this.workingDaysLable.AutoSize = true;
            this.workingDaysLable.BackColor = System.Drawing.Color.White;
            this.workingDaysLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingDaysLable.Location = new System.Drawing.Point(28, 174);
            this.workingDaysLable.Name = "workingDaysLable";
            this.workingDaysLable.Size = new System.Drawing.Size(135, 25);
            this.workingDaysLable.TabIndex = 23;
            this.workingDaysLable.Text = "Working Days";
            // 
            // noOfWorkingDaysInput
            // 
            this.noOfWorkingDaysInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfWorkingDaysInput.Location = new System.Drawing.Point(272, 85);
            this.noOfWorkingDaysInput.Name = "noOfWorkingDaysInput";
            this.noOfWorkingDaysInput.Size = new System.Drawing.Size(120, 30);
            this.noOfWorkingDaysInput.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "No Of Working Days";
            // 
            // AddWeekdayWeekendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 615);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddWeekdayWeekendForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Add Weekday Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workingTimeMinutesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingTimeHoursInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOfWorkingDaysInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minutesLable;
        private System.Windows.Forms.Label hoursLable;
        private System.Windows.Forms.NumericUpDown workingTimeMinutesInput;
        private System.Windows.Forms.NumericUpDown workingTimeHoursInput;
        private System.Windows.Forms.Label workingTimePerDayLable;
        private System.Windows.Forms.CheckBox sundayCheckbox;
        private System.Windows.Forms.CheckBox saturdayCheckbox;
        private System.Windows.Forms.CheckBox fridayCheckbox;
        private System.Windows.Forms.CheckBox thursdayCheckbox;
        private System.Windows.Forms.CheckBox wednesdayCheckbox;
        private System.Windows.Forms.CheckBox tuesdayCheckbox;
        private System.Windows.Forms.CheckBox mondayCheckBox;
        private System.Windows.Forms.Label workingDaysLable;
        private System.Windows.Forms.NumericUpDown noOfWorkingDaysInput;
        private System.Windows.Forms.Button weekendNweekdaySaveBtn;
    }
}