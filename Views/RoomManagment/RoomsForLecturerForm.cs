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
    public partial class RoomsForLecturerForm : Form
    {
        string lecturer = string.Empty;
        string room = string.Empty;

        public RoomsForLecturerForm()
        {
            InitializeComponent();
            SetLecturersComboBoxValues();
            SetRoomsComboBoxValues();
            lecturerSelectCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomSelectCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void SetLecturersComboBoxValues()
        {
            string query = "SELECT * FROM lecturer";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try {
                using (SqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        lecturer = read["LecturerName"].ToString();
                        lecturerSelectCombobox.Items.Add(lecturer);
                    }
                }
            } finally {
                connection.Close();
            }
        }
        void SetRoomsComboBoxValues()
        {
            string query = "SELECT * FROM location";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try {
                using (SqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read())
                    {
                        room = read["RoomName"].ToString();
                        roomSelectCombobox.Items.Add(room);
                    }
                }
            } finally {
                connection.Close();
            }
        }
        public void Clear()
        {
            lecturerSelectCombobox.Text =
            roomSelectCombobox.Text = string.Empty;
        }

        public void Display()
        {
            string query = "SELECT id, LecturerName, RoomName FROM roomLecturer";
            RoomForLecturerController.Index(query, roomForLecturerDataGridView);
        }

        private void roomForTagSaveBtn_Click(object sender, EventArgs e)
        {
            if (lecturerSelectCombobox.Text == "")
            {
                MessageBox.Show("Lecturer is required.", "ERROR");
                return;
            }

            if (roomSelectCombobox.Text == "")
            {
                MessageBox.Show("Room Name is required.", "ERROR");
                return;
            }

            if (roomForTagSaveBtn.Text == "Save")
            {
                Models.RoomLecturer roomLecturer = new Models.RoomLecturer(
                                                    lecturerSelectCombobox.Text.Trim(),
                                                    roomSelectCombobox.Text.Trim());
                RoomForLecturerController.Store(roomLecturer);
                Clear();
                Display();
            }
        }

        private void RoomsForLecturerForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void roomForLecturerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roomForLecturerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Are you sure? You want to delete this record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    RoomForLecturerController.Delete(roomForLecturerDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
