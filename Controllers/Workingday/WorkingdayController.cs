using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Configurations;

namespace TimeTableManagmentSystem.Controllers.Workingday
{
    class WorkingdayController
    {
        public static void Index(string query, DataGridView dataGridView) {
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            connection.Close();
        }

        public static void Store(Models.Workingday workingday) {
            string query = "INSERT INTO workingday " +
                "(NoOfWorkingDay, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Hour, Minute, CreatedAt, UpdatedAt) " +
                "VALUES " +
                "(@NoOfWorkingDay, @Monday, @Tuesday, @Wednesday, @Thursday, @Friday, @Saturday, @Sunday, @Hour, @Minute, @CreatedAt, @UpdatedAt)";

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@NoOfWorkingDay", Convert.ToInt16(workingday.NoOfWorkingDay));
            command.Parameters.AddWithValue("@Monday", Convert.ToInt16(workingday.Monday));
            command.Parameters.AddWithValue("@Tuesday", Convert.ToInt16(workingday.Tuesday));
            command.Parameters.AddWithValue("@Wednesday", Convert.ToInt16(workingday.Wednesday));
            command.Parameters.AddWithValue("@Thursday", Convert.ToInt16(workingday.Thursday));
            command.Parameters.AddWithValue("@Friday", Convert.ToInt16(workingday.Friday));
            command.Parameters.AddWithValue("@Saturday", Convert.ToInt16(workingday.Saturday));
            command.Parameters.AddWithValue("@Sunday", Convert.ToInt16(workingday.Sunday));
            command.Parameters.AddWithValue("@Hour", Convert.ToInt16(workingday.Hour));
            command.Parameters.AddWithValue("@Minute", Convert.ToInt16(workingday.Minute));
            command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
            command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

            try {
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManageLocation manageLocation = new ManageLocation();
            } catch (SqlException e) {
                MessageBox.Show("Error Occur. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                connection.Close();
            }
        }

        public static void Update(Models.Workingday workingday, int id)
        {
            string query = "UPDATE workingday SET " +
                "NoOfWorkingDay = @NoOfWorkingDay, " +
                "Monday = @Monday, " +
                "Tuesday = @Tuesday, " +
                "Wednesday = @Wednesday, " +
                "Thursday = @Thursday, " +
                "Friday = @Friday, " +
                "Saturday = @Saturday, " +
                "Sunday = @Sunday, " +
                "Hour = @Hour, " +
                "Minute = @Minute, " +
                "UpdatedAt = @UpdatedAt WHERE id = "+id;

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@NoOfWorkingDay", Convert.ToInt16(workingday.NoOfWorkingDay));
            command.Parameters.AddWithValue("@Monday", Convert.ToInt16(workingday.Monday));
            command.Parameters.AddWithValue("@Tuesday", Convert.ToInt16(workingday.Tuesday));
            command.Parameters.AddWithValue("@Wednesday", Convert.ToInt16(workingday.Wednesday));
            command.Parameters.AddWithValue("@Thursday", Convert.ToInt16(workingday.Thursday));
            command.Parameters.AddWithValue("@Friday", Convert.ToInt16(workingday.Friday));
            command.Parameters.AddWithValue("@Saturday", Convert.ToInt16(workingday.Saturday));
            command.Parameters.AddWithValue("@Sunday", Convert.ToInt16(workingday.Sunday));
            command.Parameters.AddWithValue("@Hour", Convert.ToInt16(workingday.Hour));
            command.Parameters.AddWithValue("@Minute", Convert.ToInt16(workingday.Minute));
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
            string query = "DELETE FROM workinday WHERE id = @ID";
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
