using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Controllers;
using TimeTableManagmentSystem.Views;
using TimeTableManagmentSystem.Models;

namespace TimeTableManagmentSystem
{
    public partial class ManageLocation : Form
    {
        public string id, BuildingName, RoomName, RoomType, RoomCapacity;
        AddLocationForm locationForm;
        public ManageLocation()
        {
            InitializeComponent();
            locationForm = new AddLocationForm();
        }

        private void headerLable_Click(object sender, EventArgs e)
        {

        }

        private void ManageLocation_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.openChildContainer(new AddLocationForm());
            dashboard.changeHeaderText("Add Locations");
            dashboard.hideSubmenu();
            /*
            AddLocationForm manageLocation = new AddLocationForm();
            manageLocation.ShowDialog();
            */
        }

        public void Display()
        {
            string query = "SELECT id, BuildingName, RoomName, RoomType, RoomCapacity FROM itpm_location";
            LocationController.Index(query, dataGridView);
        }

        private void locationSearcheIcon_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageLocation_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void locationSearchInput_TextChanged(object sender, EventArgs e)
        {
            string query = 
                "SELECT id, BuildingName, RoomName, RoomType, RoomCapacity " +
                "FROM itpm_location " +
                "WHERE BuildingName " +
                "LIKE '%"+ locationSearchInput.Text + "%' " +
                "OR RoomName " +
                "LIKE '%" + locationSearchInput.Text + "%' " + 
                "OR RoomName " +
                "LIKE '%" + locationSearchInput.Text + "%' " +
                "OR RoomCapacity " +
                "LIKE '%" + locationSearchInput.Text + "%' ";
            LocationController.Index(query, dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) {
                Dashboard dashboard = new Dashboard();
                dashboard.openChildContainer(new AddLocationForm());
                dashboard.changeHeaderText("Add Locations");
                dashboard.hideSubmenu();
                return;
            }
            if (e.ColumnIndex == 1) {
                if (MessageBox.Show("Are you sure? You want to delete this record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes) {
                    LocationController.Delete(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
