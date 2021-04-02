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
    public partial class RoomsForGroupsForm : Form
    {
        string group = string.Empty;
        string subGroup = string.Empty;
        string room = string.Empty;
        public RoomsForGroupsForm()
        {
            InitializeComponent();
            SetGroupsComboBoxValues();
            SetSubGroupsComboBoxValues();
            SetRoomsComboBoxValues();
            groupSelectCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            subGroupSelectCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SetRoomsComboBoxValues()
        {
            string query = "SELECT * FROM location";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try {
                using (SqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read()) {
                        room = read["RoomName"].ToString();
                        roomSelectCombobox.Items.Add(room);
                    }
                }
            } finally {
                connection.Close();
            }
        }

        private void SetSubGroupsComboBoxValues()
        {
            string query = "SELECT * FROM student";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try {
                using (SqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read()) {
                        subGroup = read["SubGroupID"].ToString();
                        subGroupSelectCombobox.Items.Add(subGroup);
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
                using (SqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read()) {
                        group = read["GroupID"].ToString();
                        groupSelectCombobox.Items.Add(group);
                    }
                }
            } finally {
                connection.Close();
            }
        }
        public void Clear()
        {
            groupSelectCombobox.Text =
            subGroupSelectCombobox.Text =
            roomSelectCombobox.Text = string.Empty;
        }

        public void Display()
        {
            string query = "SELECT id, LecturerName, RoomName FROM roomLecturer";
            RoomForGroupController.Index(query, roomForGroupDataGridView);
        }
        private void RoomsForGroupsForm_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
