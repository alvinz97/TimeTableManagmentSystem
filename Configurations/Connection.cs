using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagmentSystem.Configurations
{
    class Connection
    {
        public static MySqlConnection GetConnection() 
        {
            string database = "itpm_time_table_management_system";
            string host = "localhost";
            string port = "3306";
            string username = "root";
            string password = "issa123";

            string url = "datasource=localhost;port=3306;username=root;password=issa123;database=itpm_time_table_management_system";

            MySqlConnection connection = new MySqlConnection(url);

            try
            {
                connection.Open();
            }
            catch (MySqlException e){
                MessageBox.Show("NySQL Connection! \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }
    }
}
