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

namespace TimeTableManagmentSystem.Views.Generate
{
    public partial class TimeTableForm : Form
    {
        string lecturer = string.Empty;
        public TimeTableForm()
        {
            InitializeComponent();
            SetTagsComboBoxValues();
            setEmpty();
            TimeTableSearchInput.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void setEmpty() {
            r1c1.Text =  r1c2.Text = r1c3.Text = r1c4.Text = r1c5.Text = r1c6.Text = r1c7.Text = r2c1.Text = r2c2.Text = r2c3.Text = r2c4.Text =
            r2c5.Text = r2c6.Text = r2c7.Text = r3c1.Text = r3c2.Text = r3c3.Text =  r3c4.Text = r3c5.Text = r3c6.Text = r3c7.Text = r4c1.Text = r4c2.Text =
            r4c3.Text = r4c4.Text = r4c5.Text = r4c6.Text = r4c7.Text = r5c1.Text = r4c2.Text = r4c3.Text = r4c4.Text = r4c5.Text = r4c6.Text =
            r4c7.Text = r5c1.Text = r5c2.Text = r5c3.Text = r5c4.Text = r5c5.Text = r5c6.Text = r5c7.Text = r6c1.Text = r6c2.Text =
            r6c3.Text = r6c4.Text = r6c5.Text = r6c6.Text = r6c7.Text = r7c1.Text = r7c2.Text = r7c3.Text = r7c4.Text = r7c5.Text = r7c6.Text =
            r7c7.Text = r8c1.Text = r8c2.Text = r8c3.Text = r8c4.Text = r8c5.Text = r8c6.Text = r8c7.Text = r9c1.Text = r9c2.Text =
            r9c3.Text = r9c4.Text = r9c5.Text = r9c6.Text =
            r9c7.Text = string.Empty;
        }

        private void SetTagsComboBoxValues()
        {
            string query = "SELECT * FROM lecturer";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try {
                using (SqlDataReader read = command.ExecuteReader()) {
                    while (read.Read()) {
                        lecturer = read["LecturerName"].ToString();
                        TimeTableSearchInput.Items.Add(lecturer);
                    }
                }
            } finally {
                connection.Close();
            }
        }

        public void getSession() {
            String getStartingTime;
            String getLecturers;
            String getSubject;
            String getStudentGroup;
            String getDay;
            String getRoom;
            String sessionDetails;

            string query = "SELECT s.Lecturer , s.Tag , " +
                "s.Hours , s.Minutes , s.GroupID , " +
                "s.SubGroupID , r.SessionRoom " +
                "FROM session s, sessionRoom r " +
                "WHERE s.id = r.SessionID and s.Lecturer = " + lecturer;
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
        }
    }
}
