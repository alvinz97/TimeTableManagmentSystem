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
            roomSelectCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
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
            string query = "SELECT id, GroupID, SubGroupID, RoomName FROM roomGroup";
            RoomForGroupController.Index(query, roomForGroupDataGridView);
        }
        private void RoomsForGroupsForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void roomForGroupDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {
                if (MessageBox.Show("Are you sure? You want to delete this record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    RoomForGroupController.Delete(roomForGroupDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void roomForTagSaveBtn_Click(object sender, EventArgs e)
        {
            if (groupSelectCombobox.Text == "") {
                MessageBox.Show("Group is required.", "ERROR");
                return;
            }

            if (subGroupSelectCombobox.Text == "") {
                MessageBox.Show("Sub Group is required.", "ERROR");
                return;
            }

            if (roomSelectCombobox.Text == "") {
                MessageBox.Show("Room is required.", "ERROR");
                return;
            }

            if (roomForTagSaveBtn.Text == "Save") {
                Models.RoomGroup roomGroup = new Models.RoomGroup(
                                                    groupSelectCombobox.Text.Trim(),
                                                    subGroupSelectCombobox.Text.Trim(),
                                                    roomSelectCombobox.Text.Trim());
                RoomForGroupController.Store(roomGroup);
                Clear();
                Display();
            }
        }
    }
}
