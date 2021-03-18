using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagmentSystem.Configurations
{
    class Connection
    {
        public static SqlConnection GetConnection() 
        {
            string url = "Data Source=ALVIN-NOTEBOOK\\DEVELOPERSQL;Initial Catalog=itpm_db;Integrated Security=True";

            SqlConnection connection = new SqlConnection(url);

            try
            {
                connection.Open();
            }
            catch (SqlException e){
                MessageBox.Show("SQL Server Connection! \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }
    }
}
