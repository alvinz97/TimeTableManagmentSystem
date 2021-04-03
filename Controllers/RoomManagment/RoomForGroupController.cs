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
    class RoomForGroupController
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
        public static void Store(Models.RoomGroup roomGroup)
        {
            string query = "INSERT INTO roomGroup " +
                "(GroupID, SubGroupID, RoomName, CreatedAt, UpdatedAt) " +
                "VALUES " +
                "(@GroupID, @SubGroupID, @RoomName, @CreatedAt, @UpdatedAt)";

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@GroupID", roomGroup.GroupID);
            command.Parameters.AddWithValue("@SubGroupID", roomGroup.SubGroupID);
            command.Parameters.AddWithValue("@RoomName", roomGroup.RoomName);
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

            try {
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (SqlException e) {
                MessageBox.Show("Error Occur. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                connection.Close();
            }
        }
    }
}
