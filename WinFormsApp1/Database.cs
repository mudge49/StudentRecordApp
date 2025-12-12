using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

class Database
{
    public static string connStr = 
        "server=localhost;" +
        "user=root;" +
        "password=;" +
        "database=studentdb;";
    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connStr);
    }
}
