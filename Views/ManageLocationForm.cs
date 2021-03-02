using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagmentSystem
{
    public partial class ManageLocation : Form
    {
        public ManageLocation()
        {
            InitializeComponent();
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
            AddLocationForm manageLocation = new AddLocationForm();
            manageLocation.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
