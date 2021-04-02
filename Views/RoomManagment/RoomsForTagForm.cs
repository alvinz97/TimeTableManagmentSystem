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

namespace TimeTableManagmentSystem.Views.Room
{
    public partial class RoomsForTagForm : Form
    {
        string tag = string.Empty;
        string room = string.Empty;
        public RoomsForTagForm()
        {
            InitializeComponent();
            SetTagsComboBoxValues();
            SetRoomsComboBoxValues();
            tagSelectCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomSelectCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void SetTagsComboBoxValues()
        {
            string query = "SELECT * FROM tag";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try {
                using (SqlDataReader read = command.ExecuteReader())
                {
                    while (read.Read()) {
                        tag = read["Name"].ToString();
                        tagSelectCombobox.Items.Add(tag);
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
            tagSelectCombobox.Text =
            roomSelectCombobox.Text = string.Empty;
        }

        public void Display()
        {
            string query = "SELECT id, TagName, RoomName FROM roomTag";
            RoomForTagController.Index(query, roomForTagDataGridView);
        }

        private void roomForTagSaveBtn_Click(object sender, EventArgs e)
        {
            if (tagSelectCombobox.Text == "")
            {
                MessageBox.Show("Tag Name is required.", "ERROR");
                return;
            }

            if (roomSelectCombobox.Text == "")
            {
                MessageBox.Show("Room Name is required.", "ERROR");
                return;
            }

            if (roomForTagSaveBtn.Text == "Save")
            {
                Models.RoomTag roomTag = new Models.RoomTag(
                                                    tagSelectCombobox.Text.Trim(),
                                                    roomSelectCombobox.Text.Trim());
                RoomForTagController.Store(roomTag);
                Clear();
                Display();
            }
        }

        private void roomForTagDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RoomsForTagForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void roomForTagDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure? You want to delete this record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    RoomForTagController.Delete(roomForTagDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
