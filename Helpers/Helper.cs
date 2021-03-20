using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableManagmentSystem.Configurations;

namespace TimeTableManagmentSystem.Helpers
{
    class Helper
    {
        public int GenerateID() { 
            Random random = new Random();
            return random.Next(10000000);
        }
    }
}
