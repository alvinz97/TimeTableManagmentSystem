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
using TimeTableManagmentSystem.Views.Room;
using TimeTableManagmentSystem.Views.RoomManagment;
using TimeTableManagmentSystem.Views.Session;
using TimeTableManagmentSystem.Views.Student;
using TimeTableManagmentSystem.Views.Subject;
using TimeTableManagmentSystem.Views.Tag;
using TimeTableManagmentSystem.Views.Working;

namespace TimeTableManagmentSystem.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CustomizedDetsing();
            OpenChildContainer(new FrontForm());
            ChangeHeaderText("Dashboard");
            HideSubmenu();
            ChangeTitleText("Dashboard");
        }

        public void ChangeHeaderText(string hedaerText) {
            headerDynamicLabel.Text = hedaerText;
        }

        private void CustomizedDetsing() {
            workingHDSubMenuPanel.Visible = false;
            locationSubMenuPanel.Visible = false;
            lecturerSubMenuPanel.Visible = false;
            tagSubMenuPanel.Visible = false;
            studentSubMenuPanel.Visible = false;
            subjectSubMenuPanel.Visible = false;
            sessionManagemntSubmenuPanel.Visible = false;
            roomManagmentSubmenuPanel.Visible = false;
        }

        public void HideSubmenu() {
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
        public void ChangeTitleText(string title)
        {
            this.Text = title;
            this.Update();
        }

        public void ShowSubMenu(Panel submenu) {
            if (submenu.Visible == false) {
                HideSubmenu();
                submenu.Visible = true;
            } else {
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
            OpenChildContainer(new AddWeekdayWeekendForm());
            ChangeHeaderText("Update Details");
            ChangeTitleText("Update Weekday Weekend Details");
            HideSubmenu();
        }

        private void dashboardMenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new FrontForm());
            ChangeHeaderText("Dashboard");
            ChangeTitleText("Dashboard");
            HideSubmenu();
        }

        private void workingHDMenuBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(workingHDSubMenuPanel);
        }

        public Form activeForm = null;
        public void OpenChildContainer(Form childForm) {
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

        private void lecturersMenuBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(lecturerSubMenuPanel);
        }

        private void tagMenuBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(tagSubMenuPanel);
        }

        private void studentsMenuBtn_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(studentSubMenuPanel);
        }

        private void subjectMenuBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subjectSubMenuPanel);
        }

        private void locationsMenuBtn_Click_2(object sender, EventArgs e)
        {
            ShowSubMenu(locationSubMenuPanel);
        }

        private void sessionManagemntMenuBtn_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(sessionManagemntSubmenuPanel);
        }

        private void roomManagmentMenuBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(roomManagmentSubmenuPanel);
        }

        private void locationListSubMenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new ManageLocation());
            ChangeHeaderText("Manage Locations");
            ChangeTitleText("Manage Locations");
            HideSubmenu();
        }

        private void addLocationSubMenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new AddLocationForm());
            ChangeHeaderText("Add Locations");
            ChangeTitleText("Add Locations");
            HideSubmenu();
        }

        private void viewWeekdaysDetailsSubmenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new ManageWeekendNWeekdayFrom());
            ChangeHeaderText("Working Hours And Days Details");
            ChangeTitleText("Working Hours And Days Details");
            HideSubmenu();
        }

        private void addSessionSubmenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new AddSessionRoomForm());
            ChangeHeaderText("Add Session");
            ChangeTitleText("Add Session");
            HideSubmenu();
        }

        private void allocateNotAvailableSubmenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new AddNotAvailableSessionForm());
            ChangeHeaderText("Add Not Available Session");
            ChangeTitleText("Add Not Available Session");
            HideSubmenu();
        }

        private void addLecturerSubMenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new AddLecturerForm());
            ChangeHeaderText("Add Lecturer");
            ChangeTitleText("Add Lecturer");
            HideSubmenu();
        }

        private void lecturerListSubMenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new ManageLecturerForm());
            ChangeHeaderText("Manage Lecturers");
            ChangeTitleText("Manage Lecturer");
            HideSubmenu();
        }

        private void addStudentGroupSubMenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new AddStudentForm());
            ChangeHeaderText("Add Students Group");
            ChangeTitleText("Add Students Group");
            HideSubmenu();
        }

        private void listStudentGroupSubMenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new ManageStudentForm());
            ChangeHeaderText("Manage Student Groups");
            ChangeTitleText("Manage Students Group");
            HideSubmenu();
        }

        private void subjectListSubMenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new ManageSubjectForm());
            ChangeHeaderText("Manage Subjects");
            ChangeTitleText("Manage Subjects");
            HideSubmenu();
        }

        private void addSubjectSubMenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new AddSubjectForm());
            ChangeHeaderText("Add Subjects");
            ChangeTitleText("Add Subjects");
            HideSubmenu();
        }

        private void addTagSubMenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new AddTagForm());
            ChangeHeaderText("Add Tags");
            ChangeTitleText("Add Tags");
            HideSubmenu();
        }

        private void tagListSubMenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new ManageTagForm());
            ChangeHeaderText("Manage Tags");
            ChangeTitleText("Manage Tags");
            HideSubmenu();
        }

        private void roomsForTagsSubmenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new RoomsForTagForm());
            ChangeHeaderText("Rooms For Tags");
            ChangeTitleText("Rooms For Tags");
            HideSubmenu();
        }

        private void roomsForLecturersSubmenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new RoomsForLecturerForm());
            ChangeHeaderText("Rooms For Lecturer");
            ChangeTitleText("Rooms For Lecturer");
            HideSubmenu();
        }

        private void roomsForGroupsSubmenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new RoomsForGroupsForm());
            ChangeHeaderText("Rooms For Groups");
            ChangeTitleText("Rooms For Groups");
            HideSubmenu();
        }

        private void roomsForSubjectsSubmenuBtn_Click(object sender, EventArgs e)
        {
            OpenChildContainer(new RoomsForSubjectsForm());
            ChangeHeaderText("Rooms For Subjects");
            ChangeTitleText("Rooms For Subjects");
            HideSubmenu();
        }
    }
}
