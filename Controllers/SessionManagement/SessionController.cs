using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Configurations;

namespace TimeTableManagmentSystem.Controllers.SessionManagement
{
    class SessionController
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
        public static void Store(Models.Session session)
        {
            string query = "INSERT INTO session " +
                "(Lecturer, Tag, GroupID, SubGroupID, NoOfStudents, Hours, Minutes, CreatedAt, UpdatedAt) " +
                "VALUES " +
                "(@Lecturer, @Tag, @GroupID, @SubGroupID, @NoOfStudents, @Hours, @Minutes, @CreatedAt, @UpdatedAt)";

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Lecturer", session.Lecturer);
            command.Parameters.AddWithValue("@Tag", session.Tag);
            command.Parameters.AddWithValue("@GroupID", session.GroupID);
            command.Parameters.AddWithValue("@SubGroupID", session.SubGroupID);
            command.Parameters.AddWithValue("@NoOfStudents", Convert.ToInt16(session.NoOfStudents));
            command.Parameters.AddWithValue("@Hours", Convert.ToInt16(session.Hours));
            command.Parameters.AddWithValue("@Minutes", Convert.ToInt16(session.Minutes));
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

        public static void Delete(string id)
        {
            string query = "DELETE FROM roomGroup WHERE id = @ID";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
