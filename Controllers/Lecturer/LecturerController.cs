using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Configurations;

namespace TimeTableManagmentSystem.Controllers.Lecturer
{
    class LecturerController
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

        public static void Store(Models.Lecturer lecturer)
        {
            string query = "INSERT INTO lecturer " +
                "(LecturerName, Faculty, Department, Center, Building, LecturerLevel, Rank, CreatedAt, UpdatedAt) " +
                "VALUES " +
                "(@LecturerName, @Faculty, @Department, @Center, @Building, @LecturerLevel, @Rank, @CreatedAt, @UpdatedAt)";

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@LecturerName", lecturer.LecturerName);
            command.Parameters.AddWithValue("@Faculty", lecturer.Faculty);
            command.Parameters.AddWithValue("@Department", lecturer.Department);
            command.Parameters.AddWithValue("@Center", lecturer.Center);
            command.Parameters.AddWithValue("@Building", lecturer.Building);
            command.Parameters.AddWithValue("@LecturerLevel", Convert.ToInt16(lecturer.LecturerLevel));
            command.Parameters.AddWithValue("@Rank", lecturer.Rank);
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

        public static void Update(Models.Lecturer lecturer, string id)
        {
            string query = "UPDATE lecturer SET " +
                "LecturerName = @LecturerName, " +
                "Faculty = @Faculty, " +
                "Department = @Department, " +
                "Center = @Center, " +
                "Building = @Building, " +
                "LecturerLevel = @LecturerLevel, " +
                "Rank = @Rank, " +
                "UpdatedAt = @UpdatedAt " +
                "WHERE id = @ID";

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@LecturerName", lecturer.LecturerName);
            command.Parameters.AddWithValue("@Faculty", lecturer.Faculty);
            command.Parameters.AddWithValue("@Department", lecturer.Department);
            command.Parameters.AddWithValue("@Center", lecturer.Center);
            command.Parameters.AddWithValue("@Building", lecturer.Building);
            command.Parameters.AddWithValue("@LecturerLevel", Convert.ToInt16(lecturer.LecturerLevel));
            command.Parameters.AddWithValue("@Rank", lecturer.Rank);
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
            string query = "DELETE FROM lecturer WHERE id = @ID";
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
