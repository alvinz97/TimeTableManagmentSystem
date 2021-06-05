using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Configurations;

namespace TimeTableManagmentSystem.Controllers.Subject
{
    class SubjectController
    {
        public static void Index(string query, DataGridView dataGridView)
        {
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            connection.Close();
        }

        public static void Store(Models.Subject subject)
        {
            string query = "INSERT INTO subject " +
                "(Year, " +
                "Semester, " +
                "SubjectName, " +
                "SubjectCode, " +
                "LectureHours, " +
                "TutorialHours, " +
                "LabHours, " +
                "EvaluationHours, " +
                "CreatedAt, " +
                "UpdatedAt) VALUES " +
                "(@Year, " +
                "@Semester, " +
                "@SubjectName, " +
                "@SubjectCode, " +
                "@LectureHours, " +
                "@TutorialHours, " +
                "@LabHours, " +
                "@EvaluationHours, " +
                "@CreatedAt, " +
                "@UpdatedAt)";

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Year", Convert.ToInt16(subject.Year));
            command.Parameters.AddWithValue("@Semester", Convert.ToInt16(subject.Semester));
            command.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
            command.Parameters.AddWithValue("@SubjectCode", subject.SubjectCode);
            command.Parameters.AddWithValue("@LectureHours", Convert.ToInt16(subject.LectureHours));
            command.Parameters.AddWithValue("@TutorialHours", Convert.ToInt16(subject.TutorialHours));
            command.Parameters.AddWithValue("@LabHours", Convert.ToInt16(subject.LabHours));
            command.Parameters.AddWithValue("@EvaluationHours", Convert.ToInt16(subject.EvaluationHours));
            command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
            command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error Occur. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void Update(Models.Subject subject, string id)
        {
            string query = "UPDATE subject SET " +
                "Year = @Year, " +
                "Semester = @Semester, " +
                "SubjectName = @SubjectName, " +
                "SubjectCode = @SubjectCode, " +
                "LectureHours = @LectureHours, " +
                "TutorialHours = @TutorialHours, " +
                "LabHours = @LabHours, " +
                "EvaluationHours = @EvaluationHours, " +
                "UpdatedAt = @UpdatedAt " +
                "WHERE id =" + id;

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Year", Convert.ToInt16(subject.Year));
            command.Parameters.AddWithValue("@Semester", Convert.ToInt16(subject.Semester));
            command.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
            command.Parameters.AddWithValue("@SubjectCode", subject.SubjectCode);
            command.Parameters.AddWithValue("@LectureHours", Convert.ToInt16(subject.LectureHours));
            command.Parameters.AddWithValue("@TutorialHours", Convert.ToInt16(subject.TutorialHours));
            command.Parameters.AddWithValue("@LabHours", Convert.ToInt16(subject.LabHours));
            command.Parameters.AddWithValue("@EvaluationHours", Convert.ToInt16(subject.EvaluationHours));
            command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error Occur. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
