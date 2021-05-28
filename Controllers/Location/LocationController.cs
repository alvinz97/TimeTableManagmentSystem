using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Configurations;
using TimeTableManagmentSystem.Models;

namespace TimeTableManagmentSystem.Controllers
{
    class LocationController
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

        public static void Store(Location location)
        {
            string query = "INSERT INTO location " +
                "(BuildingName, RoomName, RoomType, RoomCapacity, CreatedAt, UpdatedAt) " +
                "VALUES " +
                "(@BuildingName, @RoomName, @RoomType, @RoomCapacity, @CreatedAt, @UpdatedAt)";

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@BuildingName", location.BuildingName);
            command.Parameters.AddWithValue("@RoomName", location.RoomName);
            command.Parameters.AddWithValue("@RoomType", Convert.ToInt16(location.RoomType));
            command.Parameters.AddWithValue("@RoomCapacity", Convert.ToInt16(location.RoomCapacity));
            command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
            command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManageLocation manageLocation = new ManageLocation();
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

        public static void Update(Location location, string id)
        {
            string query = "UPDATE location SET " +
                "BuildingName = @BuildingName, " +
                "RoomName = @RoomName, " +
                "RoomType = @RoomType, " +
                "RoomCapacity = @RoomCapacity, " +
                "UpdatedAt = @UpdatedAt " +
                "WHERE id =" + id;

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@BuildingName", location.BuildingName);
            command.Parameters.AddWithValue("@RoomName", location.RoomName);
            command.Parameters.AddWithValue("@RoomType", Convert.ToInt16(location.RoomType));
            command.Parameters.AddWithValue("@RoomCapacity", Convert.ToInt16(location.RoomCapacity));
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
            string query = "DELETE FROM location WHERE id = @ID";
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
