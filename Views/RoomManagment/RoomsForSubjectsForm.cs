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
using TimeTableManagmentSystem.Controllers.RoomManagment;

namespace TimeTableManagmentSystem.Views.RoomManagment
{
    public partial class RoomsForSubjectsForm : Form
    {
        string tag = string.Empty;
        string room = string.Empty;
        string subject = string.Empty;
        public RoomsForSubjectsForm()
        {
            InitializeComponent();
            SetTagsComboBoxValues();
            SetRoomsComboBoxValues();
            SetSubjectsComboBoxValues();
            tagSelectCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomSelectCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            subjectSelectCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void SetSubjectsComboBoxValues()
        {
            string query = "SELECT * FROM subject";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                using (SqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        subject = read["SubjectName"].ToString();
                        subjectSelectCombobox.Items.Add(subject);
                    }
                }
            }
            finally
            {
                connection.Close();
            }
        }
        void SetTagsComboBoxValues()
        {
            string query = "SELECT * FROM tag";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                using (SqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        tag = read["Name"].ToString();
                        tagSelectCombobox.Items.Add(tag);
                    }
                }
            }
            finally
            {
                connection.Close();
            }
        }
        void SetRoomsComboBoxValues()
        {
            string query = "SELECT * FROM location";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                using (SqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        room = read["RoomName"].ToString();
                        roomSelectCombobox.Items.Add(room);
                    }
                }
            }
            finally
            {
                connection.Close();
            }
        }
        public void Clear()
        {
            tagSelectCombobox.Text =
            subjectSelectCombobox.Text =
            roomSelectCombobox.Text = string.Empty;
        }

        public void Display()
        {
            string query = "SELECT id, TagName, SubjectName, RoomName FROM roomSubject";
            RoomForSubjectController.Index(query, subjectForTagDataGridView);
        }

        private void subjectForTagSaveBtn_Click(object sender, EventArgs e)
        {
            if (tagSelectCombobox.Text == "")
            {
                MessageBox.Show("Tag Name is required.", "ERROR");
                return;
            }

            if (subjectSelectCombobox.Text == "")
            {
                MessageBox.Show("Select the subject.", "ERROR");
            }


            if (roomSelectCombobox.Text == "")
            {
                MessageBox.Show("Room Name is required.", "ERROR");
                return;
            }

            if (subjectForTagSaveBtn.Text == "Save")
            {
                Models.RoomSubject roomSubject = new Models.RoomSubject(
                                                    tagSelectCombobox.Text.Trim(),
                                                    subjectSelectCombobox.Text.Trim(),
                                                    roomSelectCombobox.Text.Trim());
                RoomForSubjectController.Store(roomSubject);
                Clear();
                Display();
            }
        }

        private void subjectForTagDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void subjectForTagDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Are you sure? You want to delete this record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    RoomForSubjectController.Delete(subjectForTagDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void RoomsForSubjectsForm_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
