using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Views.Session;
using TimeTableManagmentSystem.Views.Working;

namespace TimeTableManagmentSystem.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            customizedDetsing();
            changeHeaderText("Dashboard");
        }

        public void changeHeaderText(string hedaerText) {
            headerDynamicLabel.Text = hedaerText;
        }

        private void customizedDetsing() {
            workingHDSubMenuPanel.Visible = false;
            locationSubMenuPanel.Visible = false;
            sessionManagemntSubmenuPanel.Visible = false;
        }

        public void hideSubmenu() {
            if (workingHDSubMenuPanel.Visible == true) {
                workingHDSubMenuPanel.Visible = false;
            }
            if (locationSubMenuPanel.Visible == true) {
                locationSubMenuPanel.Visible = false;
            }
            if (sessionManagemntSubmenuPanel.Visible == true) {
                sessionManagemntSubmenuPanel.Visible = false;
            }
        }

        public void showSubMenu(Panel submenu) {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else {
                submenu.Visible = false;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void topHeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void weekendDetailsSubmenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new AddWeekendForm());
            changeHeaderText("Add Weekend Details");
            hideSubmenu();
        }

        private void weekdayDetailsSubmenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new AddWeekdayForm());
            changeHeaderText("Add Weekday Details");
            hideSubmenu();
        }

        private void dashboardMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void workingHDMenuBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(workingHDSubMenuPanel);
        }

        private void locationsMenuBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(locationSubMenuPanel);
        }

        private Form activeForm = null;
        public void openChildContainer(Form childForm) {
            if (activeForm != null) {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childContainerPanel.Controls.Add(childForm);
            childContainerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void locationListSubMenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new ManageLocation());
            changeHeaderText("Manage Locations");
            hideSubmenu();
        }

        private void addLocationSubMenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new AddLocationForm());
            changeHeaderText("Add Locations");
            hideSubmenu();
        }

        private void workingHDSubMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentsMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void locationsMenuBtn_Click_1(object sender, EventArgs e)
        {
            showSubMenu(locationSubMenuPanel);
        }

        private void viewWeekdaysDetailsSubmenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new ViewDetailsFrom());
            changeHeaderText("Working Hours And Days Details");
            hideSubmenu();
        }

        private void addSessionSubmenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new AddSessionRoomForm());
            changeHeaderText("Add Session");
            hideSubmenu();
        }

        private void sessionManagemntMenuBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(sessionManagemntSubmenuPanel);
        }
    }
}
