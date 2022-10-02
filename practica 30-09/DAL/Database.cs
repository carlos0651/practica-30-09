using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practica_30_09.Properties;
using System.Configuration;

namespace practica_30_09.DAL
{
    public class Database
    {
        public static string getStrConnection()
        {
            return Settings.Default.ConnectionString;
        }

        public SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection(getStrConnection();
            return Con;
        } 

    }
}
