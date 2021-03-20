using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Helpers;
using TimeTableManagmentSystem.Views.Lecturer;
using TimeTableManagmentSystem.Views.Session;
using TimeTableManagmentSystem.Views.Student;
using TimeTableManagmentSystem.Views.Tag;
using TimeTableManagmentSystem.Views.Working;

namespace TimeTableManagmentSystem.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            customizedDetsing();
            openChildContainer(new FrontForm());
            changeHeaderText("Dashboard");
            hideSubmenu();
        }

        public void changeHeaderText(string hedaerText) {
            headerDynamicLabel.Text = hedaerText;
        }

        private void customizedDetsing() {
            workingHDSubMenuPanel.Visible = false;
            locationSubMenuPanel.Visible = false;
            lecturerSubMenuPanel.Visible = false;
            tagSubMenuPanel.Visible = false;
            studentSubMenuPanel.Visible = false;
            subjectSubMenuPanel.Visible = false;
            sessionManagemntSubmenuPanel.Visible = false;
            roomManagmentSubmenuPanel.Visible = false;
        }

        public void hideSubmenu() {
            if (workingHDSubMenuPanel.Visible == true) {
                workingHDSubMenuPanel.Visible = false;
            }
            if (locationSubMenuPanel.Visible == true) {
                locationSubMenuPanel.Visible = false;
            }
            if (lecturerSubMenuPanel.Visible == true) {
                lecturerSubMenuPanel.Visible = false;
            }
            if (tagSubMenuPanel.Visible == true) {
                tagSubMenuPanel.Visible = false;
            }
            if (studentSubMenuPanel.Visible == true) {
                studentSubMenuPanel.Visible = false;
            }
            if (subjectSubMenuPanel.Visible == true) {
                subjectSubMenuPanel.Visible = false;
            }
            if (sessionManagemntSubmenuPanel.Visible == true) {
                sessionManagemntSubmenuPanel.Visible = false;
            }
            if (roomManagmentSubmenuPanel.Visible == true) {
                roomManagmentSubmenuPanel.Visible = false;
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
            openChildContainer(new AddWeekdayWeekendForm());
            changeHeaderText("Add Details");
            hideSubmenu();
        }

        private void dashboardMenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new FrontForm());
            changeHeaderText("Dashboard");
            hideSubmenu();
        }

        private void workingHDMenuBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(workingHDSubMenuPanel);
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

        private void viewWeekdaysDetailsSubmenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new ManageWeekendNWeekdayFrom());
            changeHeaderText("Working Hours And Days Details");
            hideSubmenu();
        }

        private void addSessionSubmenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new AddSessionRoomForm());
            changeHeaderText("Add Session");
            hideSubmenu();
        }

        private void allocateNotAvailableSubmenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new AddNotAvailableSessionForm());
            changeHeaderText("Add Not Available Session");
            hideSubmenu();
        }

        private void lecturersMenuBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(lecturerSubMenuPanel);
        }

        private void tagMenuBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(tagSubMenuPanel);
        }

        private void studentsMenuBtn_Click_1(object sender, EventArgs e)
        {
            showSubMenu(studentSubMenuPanel);
        }

        private void subjectMenuBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(subjectSubMenuPanel);
        }

        private void locationsMenuBtn_Click_2(object sender, EventArgs e)
        {
            showSubMenu(locationSubMenuPanel);
        }

        private void sessionManagemntMenuBtn_Click_1(object sender, EventArgs e)
        {
            showSubMenu(sessionManagemntSubmenuPanel);
        }

        private void roomManagmentMenuBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(roomManagmentSubmenuPanel);
        }

        private void addLecturerSubMenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new AddLecturerForm());
            changeHeaderText("Add Lecturer");
            hideSubmenu();
        }

        private void lecturerListSubMenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new ManageLecturerForm());
            changeHeaderText("Manage Lecturers");
            hideSubmenu();
        }

        private void addStudentGroupSubMenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new AddStudentForm());
            changeHeaderText("Add Students Group");
            hideSubmenu();
        }

        private void listStudentGroupSubMenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new ManageStudentForm());
            changeHeaderText("Manage Student Groups");
            hideSubmenu();
        }

        private void subjectListSubMenuBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void addSubjectSubMenuBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void addTagSubMenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new AddTagForm());
            changeHeaderText("Add Tags");
            hideSubmenu();
        }

        private void tagListSubMenuBtn_Click(object sender, EventArgs e)
        {
            openChildContainer(new ManageTagForm());
            changeHeaderText("Manage Tags");
            hideSubmenu();
        }
    }
}
