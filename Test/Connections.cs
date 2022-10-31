using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Connections
    {
        // Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\Test\Test\dbTest.mdf;Integrated Security=True
        public SqlConnection GetSqlConnection()
        {
            string databaseName = "dbTest.mdf";
            string actualPath = AppDomain.CurrentDomain.BaseDirectory.ToLower().Replace("\\bin", "").Replace("\\debug", "").Trim('\\');
            string pathName = Path.GetFullPath(Environment.CurrentDirectory);


            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + actualPath + @"\" + databaseName + ";Integrated Security=True";
            var sqlConnection = new SqlConnection(connectionString);

            return sqlConnection;

        }
    }
}
