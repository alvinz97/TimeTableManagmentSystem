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
using TimeTableManagmentSystem.Helpers;

namespace TimeTableManagmentSystem.Views.Student
{
    public partial class ManageStudentForm : Form
    {
        Helper helper = new Helper();
        Dashboard dashboard = new Dashboard();
        public ManageStudentForm()
        {
            InitializeComponent();
        }
        public void Display() {
            string query = "SELECT id, Year, Semester, Program, GroupNo, SubGroupNo, GroupID, SubGroupID FROM student";
            StudentController.Index(query, studentDataGridView);
        }

        private void ManageStudentForm_Shown(object sender, EventArgs e) {
            Display();
        }

        private void studentDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {
            }
            if (e.ColumnIndex == 1) {
                if (MessageBox.Show("Are you sure? You want to delete this record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes) {
                    StudentController.Delete(studentDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void studentSearchInput_TextChanged(object sender, EventArgs e)
        {
            string query =
                "SELECT id, Year, Semester, Program, GroupNo, SubGroupNo, GroupID, SubGroupID " +
                "FROM student " +
                "WHERE Year " +
                "LIKE '%" + studentSearchInput.Text + "%' " +
                "OR Semester " +
                "LIKE '%" + studentSearchInput.Text + "%' " +
                "OR Program " +
                "LIKE '%" + studentSearchInput.Text + "%' " +
                "OR GroupNo " +
                "LIKE '%" + studentSearchInput.Text + "%' " +
                "OR SubGroupID " +
                "LIKE '%" + studentSearchInput.Text + "%' ";
            StudentController.Index(query, studentDataGridView);
        }

        private void addNewLocationBtn_Click(object sender, EventArgs e)
        {
            //helper.OpenChildContainer(new AddStudentForm(), ((Dashboard)this.Owner).childContainerPanel);
            dashboard.OpenChildContainer(new AddStudentForm());
            dashboard.ChangeHeaderText("Add Lecturer");
            dashboard.ChangeTitleText("Add Lecturer");
            dashboard.HideSubmenu();
            this.Close();
        }
    }
}
