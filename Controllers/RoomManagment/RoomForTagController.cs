using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Configurations;

namespace TimeTableManagmentSystem.Controllers.RoomManagment
{
    class RoomForTagController
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
        public static void Store(Models.RoomTag roomTag)
        {
            string query = "INSERT INTO roomTag " +
                "(TagName, RoomName, CreatedAt, UpdatedAt) " +
                "VALUES " +
                "(@TagName, @RoomName, @CreatedAt, @UpdatedAt)";

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@TagName", roomTag.TagName);
            command.Parameters.AddWithValue("@RoomName", roomTag.RoomName);
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

        public static void Update(Models.Student student, string id)
        {
            string query = "UPDATE roomTag SET " +
                "Year = @Year, " +
                "Semester = @Semester, " +
                "Program = @Program, " +
                "GroupNo = @GroupNo, " +
                "GroupID = @GroupID, " +
                "SubGroupNo = @SubGroupNo, " +
                "SubGroupID = @SubGroupID, " +
                "UpdatedAt = @UpdatedAt " +
                "WHERE id = @ID";

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Year", Convert.ToInt16(student.Year));
            command.Parameters.AddWithValue("@Semester", Convert.ToInt16(student.Semester));
            command.Parameters.AddWithValue("@Program", student.Program);
            command.Parameters.AddWithValue("@GroupNo", Convert.ToInt16(student.GroupNo));
            command.Parameters.AddWithValue("@GroupID", student.GroupID);
            command.Parameters.AddWithValue("@SubGroupNo", Convert.ToInt16(student.SubGroupNo));
            command.Parameters.AddWithValue("@SubGroupID", student.SubGroupID);
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

        public static void Delete(string id)
        {
            string query = "DELETE FROM roomTag WHERE id = @ID";
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
