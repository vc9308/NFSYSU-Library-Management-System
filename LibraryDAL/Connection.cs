using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryDAL
{
    public class Connection
    {
        public static SqlConnection cn = null;

        public Connection(string connectionString)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
        }

        public static void CloseConnection()
        {
            cn.Close();
        }
    }
}
