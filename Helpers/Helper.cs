using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableManagmentSystem.Configurations;
using TimeTableManagmentSystem.Views.Student;

namespace TimeTableManagmentSystem.Helpers
{
    class Helper
    {
        public int GenerateID() { 
            Random random = new Random();
            return random.Next(1000000);
        }

        public int getRegisteredLecturersCount() {
            return RunQuery("SELECT COUNT(*) FROM lecturer;");
        }

        public int getRegisteredStudentsCount() {
            return RunQuery("SELECT COUNT(*) FROM student;");
        }

        public int getRegisteredSubjectsCount() {
            return RunQuery("SELECT COUNT(*) FROM student;");
        }

        public int getRegisteredRoomsCount() {
            return RunQuery("SELECT COUNT(*) FROM location;");
        }

        public string getLatestLecturer() {
            return FindLatest("SELECT TOP 1 LecturerName FROM lecturer ORDER BY id DESC;");
        }
        public string getLatestStudentGroup()
        {
            return FindLatest("SELECT TOP 1 SubGroupID FROM student ORDER BY id DESC;");
        }
        public string getLatestSubject()
        {
            return FindLatest("SELECT TOP 1 SubGroupID FROM student ORDER BY id DESC;");
        }

        protected string FindLatest(string query) {
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            String latestValue = (String)command.ExecuteScalar();
            return latestValue;
        }

        protected int RunQuery(string query) {
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count;
        }
    }
}
