using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagmentSystem.Configurations
{
    class Connection_Example
    {
        public static SqlConnection GetConnection()
        {
            string url = "YOUR_SQL_SERVER_MANAGEMENT_CONNECTION_STRING";
            SqlConnection connection = new SqlConnection(url);

            try {
                connection.Open();
            } catch (SqlException e)  {
                MessageBox.Show("SQL Server Connection! \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }
    }
}
