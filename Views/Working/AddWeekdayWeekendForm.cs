using System;
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

        private void AddWeekdayWeekendForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void thursdayCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (thursdayCheckbox.Checked) {
                thursday = 1;
            } else {
                thursday = 0;
            }
        }

        private void weekendWeekdayDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure? You want to delete this record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    WorkingdayController.Delete(weekendWeekdayDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
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

            if (noOfWorkingDaysInput.Text == "0") { 
                MessageBox.Show("Please select number of days.", "ERROR");
                return;
            }

            if (workingTimeHoursInput.Text == "0") {
                MessageBox.Show("Working hour is required.", "ERROR");
                return;
            }

            if (workingTimeMinutesInput.Text == "0") {
                MessageBox.Show("Working minute is required.", "ERROR");
                return;
            }

            if (weekendNweekdaySaveBtn.Text == "Update") {
                int noOfWorkingDays = Int16.Parse(noOfWorkingDaysInput.Text.Trim());
                int hours = Int16.Parse(workingTimeHoursInput.Text.Trim());
                int minutes = Int16.Parse(workingTimeMinutesInput.Text.Trim());
                Workingday workingday= new Workingday(noOfWorkingDays, monday, tuesday, wednesday, thursday, friday, saturday, sunday, hours, minutes);
                WorkingdayController.Update(workingday, 1002);
                Clear();
                Display();
            }
        }
        public void Display()
        {
            string query = "SELECT id, NoOfWorkingDay, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Hour, Minute FROM workingday WHERE id=1002";
            WorkingdayController.Index(query, weekendWeekdayDataGridView);
        }
    }
}
