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
using TimeTableManagmentSystem.Models;

namespace TimeTableManagmentSystem
{
    public partial class AddLocationForm : Form
    {
        private readonly ManageLocation _parent;
        private int type;

        public AddLocationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labTypeRadio_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void roomClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            buildingNameInput.Text = roomNameInput.Text = roomCapacityInput.Text = string.Empty;
        }
        private void roomSaveBtn_Click(object sender, EventArgs e)
        {
            if (lectureTypeRadio.Checked == true)
            {
                type = 0;
            }
            else if (labTypeRadio.Checked == true)
            {
                type = 1;
            }

            if (buildingNameInput.Text == "")
            {
                MessageBox.Show("Builing Name is required.", "ERROR");
                return;
            }

            if (roomNameInput.Text == "")
            {
                MessageBox.Show("Room Name is required.", "ERROR");
                return;
            }

            if (roomCapacityInput.Text == "")
            {
                MessageBox.Show("Room capacity is required.", "ERROR");
                return;
            }

            if (roomSaveBtn.Text == "Save")
            {
                int capacity = Int16.Parse(roomCapacityInput.Text.Trim());
                Location location = new Location(buildingNameInput.Text.Trim(), roomNameInput.Text.Trim(), type, capacity);
                LocationController.Store(location);
                Clear();
            }
        }

        private void headerBackgroundPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
