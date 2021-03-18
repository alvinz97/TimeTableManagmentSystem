using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Controllers.Workingday;

namespace TimeTableManagmentSystem.Views.Working
{
    public partial class ManageWeekendNWeekdayFrom : Form
    {
        public ManageWeekendNWeekdayFrom()
        {
            InitializeComponent();
        }
        public void Display()
        {
            string query = "SELECT id, BuildingName, RoomName, RoomType, RoomCapacity FROM location";
            WorkingdayController.Index(query, weekendWeekdayDataGridView);
        }

        private void weekendWeekdayDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void weekendWeekdaySearchInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNewWeekdayNWeekendBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
