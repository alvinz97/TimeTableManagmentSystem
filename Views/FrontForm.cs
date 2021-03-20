using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Helpers;

namespace TimeTableManagmentSystem.Views
{
    public partial class FrontForm : Form
    {
        Helper helper = new Helper();
        public FrontForm()
        {
            InitializeComponent();
            lecturerCount.Text = helper.getRegisteredLecturersCount().ToString();
            studentCount.Text = helper.getRegisteredStudentsCount().ToString();
            subjectCount.Text = helper.getRegisteredSubjectsCount().ToString();
            roomCount.Text = helper.getRegisteredRoomsCount().ToString();

            latestLectDisplay.Text = helper.getLatestLecturer();
            latestGroupDisplay.Text = helper.getLatestStudentGroup();
            latestSubjectDisplay.Text = helper.getLatestSubject();
        }
    }
}
