using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Configurations;
using TimeTableManagmentSystem.Controllers.SessionManagement;

namespace TimeTableManagmentSystem.Views.Session
{
    public partial class AddSessionForm : Form
    {
        string lecturer = string.Empty;
        string subGroup = string.Empty;
        string group = string.Empty;
        string tag = string.Empty;

        public AddSessionForm()
        {
            InitializeComponent();
            SetLecturerComboBoxValues();
            SetSubGroupsComboBoxValues();
            SetGroupsComboBoxValues();
            SetTagsComboBoxValues();
            selectLecturerCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectGroupcombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectSubGroupCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectTagCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SetTagsComboBoxValues()
        {
            string query = "SELECT * FROM tag";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try {
                using (SqlDataReader read = command.ExecuteReader()) {
                    while (read.Read()) {
                        tag = read["Name"].ToString();
                        selectTagCombobox.Items.Add(tag);
                    }
                }
            } finally {
                connection.Close();
            }
        }

        private void SetGroupsComboBoxValues()
        {
            string query = "SELECT * FROM student";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try {
                using (SqlDataReader read = command.ExecuteReader()) {
                    while (read.Read()) {
                        group = read["GroupID"].ToString();
                        selectGroupcombobox.Items.Add(group);
                    }
                }
            }  finally {
                connection.Close();
            }
        }

        private void SetSubGroupsComboBoxValues()
        {
            string query = "SELECT * FROM student";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try {
                using (SqlDataReader read = command.ExecuteReader()) {
                    while (read.Read()) {
                        subGroup = read["SubGroupID"].ToString();
                        selectSubGroupCombobox.Items.Add(subGroup);
                    }
                }
            } finally {
                connection.Close();
            }
        }

        private void SetLecturerComboBoxValues()
        {
            string query = "SELECT * FROM lecturer";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try {
                using (SqlDataReader read = command.ExecuteReader()) {
                    while (read.Read()) {
                        lecturer = read["LecturerName"].ToString();
                        selectLecturerCombobox.Items.Add(lecturer);
                    }
                }
            } finally {
                connection.Close();
            }
        }

        private void sessionSaveBtn_Click(object sender, EventArgs e)
        {
            if (selectLecturerCombobox.Text == "")
            {
                MessageBox.Show("Select Lecturer.", "ERROR");
                return;
            }

            if (selectGroupcombobox.Text == "")
            {
                MessageBox.Show("Select Group.", "ERROR");
                return;
            }

            if (selectTagCombobox.Text == "")
            {
                MessageBox.Show("Select Tag.", "ERROR");
                return;
            }

            if (selectSubGroupCombobox.Text == "")
            {
                MessageBox.Show("Select Sub Group.", "ERROR");
                return;
            }

            if (sessionSaveBtn.Text == "Save")
            {
                int hours = Int16.Parse(hoursUpAndDown.Text.Trim());
                int minutes = Int16.Parse(minutesUpAndDown.Text.Trim());
                Models.Session session = new Models.Session(
                                                    selectLecturerCombobox.Text.Trim(),
                                                    selectTagCombobox.Text.Trim(),
                                                    selectGroupcombobox.Text.Trim(),
                                                    selectSubGroupCombobox.Text.Trim(),
                                                    noOfStudentUpAndDown.Text.Trim(),
                                                    hours,
                                                    minutes);
                SessionController.Store(session);
                Clear();
                Display();
            }
        }

        public void Display()
        {
            string query = "SELECT id, Lecturer, Tag, GroupID, SubGroupID, NoOfStudents, Hours, Minutes FROM session";
            SessionController.Index(query, sessionDataGridView);
        }
        public void Clear()
        {
            selectLecturerCombobox.Text =
            selectGroupcombobox.Text =
            selectTagCombobox.Text =
            selectSubGroupCombobox.Text = string.Empty;
        }

        private void AddSessionForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void sessionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure? You want to delete this record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SessionController.Delete(sessionDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void sessionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
