using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Project_SE
{
    class Connection
    {
        public static class DatabaseConnection
        {
            private static string connectionString = "server=BILAL; Integrated security=true; database=Clinic";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }
    }
}
