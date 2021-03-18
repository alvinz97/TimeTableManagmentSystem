﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Controllers.Workingday;
using TimeTableManagmentSystem.Models;

namespace TimeTableManagmentSystem.Views.Working
{
    public partial class AddWeekdayWeekendForm : Form
    {
        public int monday, tuesday, wednesday, thursday, friday, saturday, sunday;

        public AddWeekdayWeekendForm()
        {
            InitializeComponent();
        }

        private void mondayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mondayCheckBox.Checked) {
                monday = 1;
            } else {
                monday = 0;
            }
        }

        private void tuesdayCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (tuesdayCheckbox.Checked) {
                tuesday = 1;
            } else {
                tuesday = 0;
            }
        }

        private void wednesdayCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (wednesdayCheckbox.Checked) {
                wednesday = 1;
            } else {
                wednesday = 0;
            }
        }

        private void thursdayCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (thursdayCheckbox.Checked) {
                thursday = 1;
            } else {
                thursday = 0;
            }
        }

        private void fridayCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (fridayCheckbox.Checked) {
                friday = 1;
            } else {
                friday = 0;
            }
        }

        private void saturdayCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (saturdayCheckbox.Checked) {
                saturday = 1;
            } else {
                saturday = 0;
            }
        }

        private void sundayCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (sundayCheckbox.Checked) {
                sunday = 1;
            } else {
                sunday = 0;
            }
        }
        public void Clear()
        {
            noOfWorkingDaysInput.Text = workingTimeHoursInput.Text = workingTimeMinutesInput.Text = string.Empty;
            mondayCheckBox.Checked = tuesdayCheckbox.Checked = wednesdayCheckbox.Checked = thursdayCheckbox.Checked = fridayCheckbox.Checked = saturdayCheckbox.Checked = sundayCheckbox.Checked = false;
        }

        private void weekendNweekdaySaveBtn_Click(object sender, EventArgs e)
        {

            if (noOfWorkingDaysInput.Text == "")
            {
                MessageBox.Show("No of workingdays is required.", "ERROR");
                return;
            }

            if (workingTimeHoursInput.Text == "")
            {
                MessageBox.Show("Working hour is required.", "ERROR");
                return;
            }

            if (workingTimeMinutesInput.Text == "")
            {
                MessageBox.Show("Working minute is required.", "ERROR");
                return;
            }

            if (weekendNweekdaySaveBtn.Text == "Save")
            {
                int noOfWorkingDays = Int16.Parse(noOfWorkingDaysInput.Text.Trim());
                int hours = Int16.Parse(workingTimeHoursInput.Text.Trim());
                int minutes = Int16.Parse(workingTimeMinutesInput.Text.Trim());
                Workingday workingday= new Workingday(noOfWorkingDays, monday, tuesday, wednesday, thursday, friday, saturday, sunday, hours, minutes);
                WorkingdayController.Store(workingday);
                Clear();
            }
        }
    }
}