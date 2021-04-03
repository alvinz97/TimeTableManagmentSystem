using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Controllers.Subject;

namespace TimeTableManagmentSystem.Views.Subject
{
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
            SetAcademicYearComboBoxValues();
            SetAcademicSemesterComboBoxValues();
            yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            semesterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void SetAcademicYearComboBoxValues()
        {
            int[] year = new int[4];
            year[0] = 1;
            year[1] = 2;
            year[2] = 3;
            year[3] = 4;

            for (int i = 0; i < year.Length; i++)
            {
                yearComboBox.Items.Add(year[i]);
            }
        }
        void SetAcademicSemesterComboBoxValues()
        {
            int[] semester = new int[2];
            semester[0] = 1;
            semester[1] = 2;

            for (int i = 0; i < semester.Length; i++)
            {
                semesterComboBox.Items.Add(semester[i]);
            }
        }
        public void Clear()
        {
            yearComboBox.Text =
            semesterComboBox.Text =
            subjectNameTextbox.Text =
            subjectCodeTextbox.Text =
            lectturHourNumberDropDown.Text =
            tutorialHourNumberDropDown.Text =
            evaluationHourNumberDropDown.Text =
            labHourNumberDropDown.Text = string.Empty;
        }

        private void studentSaveBtn_Click(object sender, EventArgs e)
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

            if (subjectNameTextbox.Text == "")
            {
                MessageBox.Show("Subject Name is Required.", "ERROR");
                return;
            }

            if (subjectCodeTextbox.Text == "")
            {
                MessageBox.Show("Subject Code is Required.", "ERROR");
                return;
            }

            if (subjectSaveBtn.Text == "Save")
            {
                Models.Subject subject = new Models.Subject(
                                                    Convert.ToInt16(yearComboBox.SelectedItem.ToString()),
                                                    Convert.ToInt16(semesterComboBox.SelectedItem),
                                                    subjectNameTextbox.Text.Trim(),
                                                    subjectCodeTextbox.Text.Trim(),
                                                    Convert.ToInt16(lectturHourNumberDropDown.Value),
                                                    Convert.ToInt16(tutorialHourNumberDropDown.Value),
                                                    Convert.ToInt16(labHourNumberDropDown.Value),
                                                    Convert.ToInt16(evaluationHourNumberDropDown.Value)
                                                    );
                SubjectController.Store(subject);
                Clear();
            }
        }
    }
}
