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
    class SessionRoomController
    {
        public static void Store(Models.SessionRoom sessionRoom)
        {
            string query = "INSERT INTO sessionRoom " +
                "(SessionID, Room, CreatedAt, UpdatedAt) " +
                "VALUES " +
                "(@SessionID, @Room, @CreatedAt, @UpdatedAt)";

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@SessionID", Convert.ToInt16(sessionRoom.SessionID));
            command.Parameters.AddWithValue("@Room", sessionRoom.Room);
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
    }
}
