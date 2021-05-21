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
    public partial class AddSessionRoomForm : Form
    {
        string session = string.Empty;
        string room = string.Empty;
        public AddSessionRoomForm()
        {
            InitializeComponent();
            SetSessionComboBoxValues();
            SetRoomComboBoxValues();
            selectSessionInput.DropDownStyle = ComboBoxStyle.DropDownList;
            selectRoomInput.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SetSessionComboBoxValues() {
            string query = "SELECT * FROM session";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try {
                using (SqlDataReader read = command.ExecuteReader()) {
                    while (read.Read()) {
                        session = read["id"].ToString();
                        selectSessionInput.Items.Add(session);
                    }
                }
            } finally {
                connection.Close();
            }
        }
        private void SetRoomComboBoxValues()
        {
            string query = "SELECT * FROM location";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try {
                using (SqlDataReader read = command.ExecuteReader()) {
                    while (read.Read()) {
                        room = read["RoomName"].ToString();
                        selectRoomInput.Items.Add(room);
                    }
                }
            } finally {
                connection.Close();
            }
        }

        private void roomSaveBtn_Click(object sender, EventArgs e)
        {
            if (selectSessionInput.Text == "")
            {
                MessageBox.Show("Select Session.", "ERROR");
                return;
            }

            if (selectRoomInput.Text == "")
            {
                MessageBox.Show("Select Room.", "ERROR");
                return;
            }

            if (sessionSaveBtn.Text == "Save")
            {
                int sessionID = Int16.Parse(selectSessionInput.Text.Trim());
                Models.SessionRoom sessionRoom = new Models.SessionRoom(
                                                    sessionID,
                                                    selectRoomInput.Text.Trim());
                SessionRoomController.Store(sessionRoom);
            }
        }
    }
}
