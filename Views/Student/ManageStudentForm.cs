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
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }
        public void Display()
        {
            string query = "SELECT id, Year, Semester, Program, GroupNo, SubGroupNo, GroupID, SubGroupID FROM student";
            StudentController.Index(query, subjectDataGridView);
        }

        private void ManageStudentForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void studentDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentSearchInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
