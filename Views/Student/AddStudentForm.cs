using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Controllers.Student;

namespace TimeTableManagmentSystem.Views.Student
{
    public partial class AddStudentForm : Form
    {
        string groupID, subGroupID = string.Empty;
        public AddStudentForm()
        {
            InitializeComponent();
            SetAcademicYearComboBoxValues();
            SetAcademicSemesterComboBoxValues();
            SetProgramComboBoxValues();
            yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            semesterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            programComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void SetAcademicYearComboBoxValues() {
            int[] year = new int[4];
            year[0] = 1;
            year[1] = 2;
            year[2] = 3;
            year[3] = 4;

            for (int i = 0; i < year.Length; i++) {
                yearComboBox.Items.Add(year[i]);
            }
        }
        void SetAcademicSemesterComboBoxValues() {
            int[] semester = new int[2];
            semester[0] = 1;
            semester[1] = 2;

            for (int i = 0; i < semester.Length; i++) {
                semesterComboBox.Items.Add(semester[i]);
            }
        }

        private void generateIDBtn_Click(object sender, EventArgs e)
        {
            groupID = "Y" + yearComboBox.SelectedItem + ".S" + semesterComboBox.SelectedItem + "." + programComboBox.SelectedItem + ".0" + groupNumberDropDown.Value;
            subGroupID = "Y" + yearComboBox.SelectedItem + ".S" + semesterComboBox.SelectedItem + "." + programComboBox.SelectedItem + ".0" + groupNumberDropDown.Value+"."+subGroupNumberDropDown.Value;
            groupIDInput.Text = groupID;
            subGroupIDInput.Text = subGroupID;
        }
        public void Clear()
        {
            yearComboBox.Text =
            semesterComboBox.Text =
            programComboBox.Text =
            groupNumberDropDown.Text =
            subGroupNumberDropDown.Text =
            groupIDInput.Text =
            subGroupIDInput.Text = string.Empty;
        }

        private void lecturerSaveBtn_Click(object sender, EventArgs e)
        {
            if (yearComboBox.Text == "")
            {
                MessageBox.Show("Select the academic year.", "ERROR");
                return;
            }

            if (semesterComboBox.Text == "")
            {
                MessageBox.Show("Select the academic semester.", "ERROR");
                return;
            }

            if (programComboBox.Text == "")
            {
                MessageBox.Show("Select the program.", "ERROR");
                return;
            }

            if (groupNumberDropDown.Text == "")
            {
                MessageBox.Show("Enter the group number.", "ERROR");
                return;
            }

            if (subGroupNumberDropDown.Text == "")
            {
                MessageBox.Show("Enter the sub-group number.", "ERROR");
                return;
            }

            if (groupIDInput.Text == "")
            {
                MessageBox.Show("Please click generate ids button.", "ERROR");
                return;
            }

            if (subGroupIDInput.Text == "")
            {
                MessageBox.Show("Please click generate ids button.", "ERROR");
                return;
            }

            if (studentSaveBtn.Text == "Save")
            {
                Models.Student student = new Models.Student(
                                                    Convert.ToInt16(yearComboBox.SelectedItem.ToString()),
                                                    Convert.ToInt16(semesterComboBox.SelectedItem),
                                                    programComboBox.SelectedItem.ToString(),
                                                    Convert.ToInt16(groupNumberDropDown.Value),
                                                    groupIDInput.Text.Trim(),
                                                    Convert.ToInt16(subGroupNumberDropDown.Value),
                                                    subGroupIDInput.Text.Trim()
                                                    );
                StudentController.Store(student);
                Clear();
            }
        }

        void SetProgramComboBoxValues() {
            string[] semester = new string[8];
            semester[0] = "IT";
            semester[1] = "SE";
            semester[2] = "CSSE";
            semester[3] = "CSE";
            semester[4] = "IM";
            semester[5] = "QS";
            semester[6] = "EN";
            semester[7] = "CS";

            for (int i = 0; i < semester.Length; i++) {
                programComboBox.Items.Add(semester[i]);
            }
        }
    }
}
