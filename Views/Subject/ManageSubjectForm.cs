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
    public partial class ManageSubjectForm : Form
    {
        Dashboard dashboard = new Dashboard();

        public ManageSubjectForm()
        {
            InitializeComponent();
        }
        public void Display()
        {
            string query = "SELECT id, Year, Semester, SubjectName, SubjectCode, LectureHours, TutorialHours, LabHours, EvaluationHours FROM subject";
            SubjectController.Index(query, subjectDataGridView);
        }

        private void ManageSubjectForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void subjectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {
            }
            if (e.ColumnIndex == 1) {
                if (MessageBox.Show("Are you sure? You want to delete this record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SubjectController.Delete(subjectDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void subjectSearchInput_TextChanged(object sender, EventArgs e)
        {
            string query =
                "SELECT id, Year, Semester, SubjectName, SubjectCode, LectureHours, TutorialHours, LabHours, EvaluationHours " +
                "FROM subject " +
                "WHERE Year " +
                "LIKE '%" + subjectSearchInput.Text + "%' " +
                "OR Semester " +
                "LIKE '%" + subjectSearchInput.Text + "%' " +
                "OR SubjectName " +
                "LIKE '%" + subjectSearchInput.Text + "%' " +
                "OR SubjectCode " +
                "LIKE '%" + subjectSearchInput.Text + "%' " +
                "OR LectureHours " +
                "LIKE '%" + subjectSearchInput.Text + "%' " +
                "OR TutorialHours " +
                "LIKE '%" + subjectSearchInput.Text + "%' " +
                "OR LabHours " +
                "LIKE '%" + subjectSearchInput.Text + "%' " +
                "OR EvaluationHours " +
                "LIKE '%" + subjectSearchInput.Text + "%' ";
            SubjectController.Index(query, subjectDataGridView);
        }

        private void addNewSubjectBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.OpenChildContainer(new AddSubjectForm());
            dashboard.ChangeHeaderText("Add Subjects");
            dashboard.HideSubmenu();
        }
    }
}
