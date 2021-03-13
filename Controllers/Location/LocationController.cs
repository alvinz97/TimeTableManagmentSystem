using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
            MySqlConnection connection = Connection.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            connection.Close();
        }

        public static void Store(Location location)
        {
            string query = "INSERT INTO itpm_location (BuildingName, RoomName, RoomType, RoomCapacity, CreatedAt) VALUES (@BuildingName, @RoomName, @RoomType, @RoomCapacity, @CreatedAt)";

            MySqlConnection connection = Connection.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@BuildingName", MySqlDbType.VarChar).Value = location.BuildingName;
            command.Parameters.Add("@RoomName", MySqlDbType.VarChar).Value = location.RoomName;
            command.Parameters.Add("@RoomType", MySqlDbType.Int16).Value = location.RoomType;
            command.Parameters.Add("@RoomCapacity", MySqlDbType.Int16).Value = location.RoomCapacity;
            command.Parameters.Add("@CreatedAt", MySqlDbType.DateTime).Value = DateTime.Now;

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManageLocation manageLocation = new ManageLocation();
            }
            catch (MySqlException e)
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
            string query = "UPDATE itpm_location SET BuildingName = @BuildingName, RoomName = @RoomName, RoomType = @RoomType, RoomCapacity = @RoomCapacity WHERE id = @ID";

            MySqlConnection connection = Connection.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@BuildingName", MySqlDbType.VarChar).Value = location.BuildingName;
            command.Parameters.Add("@RoomName", MySqlDbType.VarChar).Value = location.RoomName;
            command.Parameters.Add("@RoomType", MySqlDbType.Int16).Value = location.RoomType;
            command.Parameters.Add("@RoomCapacity", MySqlDbType.Int16).Value = location.RoomCapacity;
            command.Parameters.Add("@CreatedAt", MySqlDbType.DateTime).Value = DateTime.Now;

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
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
            string query = "DELETE FROM itpm_location WHERE id = @ID";
            MySqlConnection connection = Connection.GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
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
