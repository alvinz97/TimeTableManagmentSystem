using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Controllers.Lecturer;

namespace TimeTableManagmentSystem.Views.Lecturer
{
    public partial class ManageLecturerForm : Form
    {
        public ManageLecturerForm()
        {
            InitializeComponent();
        }

        public void Display()
        {
            string query = "SELECT id, LecturerName, Faculty, Department, Center, Building, LecturerLevel, Rank FROM lecturer";
            LecturerController.Index(query, lecturerDataGridView);
        }

        private void ManageLecturerForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void lecturerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure? You want to delete this record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    LecturerController.Delete(lecturerDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void lecturerSearchInput_TextChanged(object sender, EventArgs e)
        {
            string query =
                "SELECT id, LecturerName, Faculty, Department, Center, Building, LecturerLevel, Rank " +
                "FROM lecturer " +
                "WHERE LecturerName " +
                "LIKE '%" + lecturerSearchInput.Text + "%' " +
                "OR Faculty " +
                "LIKE '%" + lecturerSearchInput.Text + "%' " +
                "OR Department " +
                "LIKE '%" + lecturerSearchInput.Text + "%' " +
                "OR Center " +
                "LIKE '%" + lecturerSearchInput.Text + "%' " +
                "OR Building " +
                "LIKE '%" + lecturerSearchInput.Text + "%' " +
                "OR LecturerLevel " +
                "LIKE '%" + lecturerSearchInput.Text + "%' " +
                "OR Rank " +
                "LIKE '%" + lecturerSearchInput.Text + "%' ";
            LecturerController.Index(query, lecturerDataGridView);
        }
    }
}
