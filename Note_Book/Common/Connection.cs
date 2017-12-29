using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using System.Data;


namespace Common
{
    public class Connection
    {
      

        public static  MySqlConnection sqlConn() {
            string constr = System.Configuration.ConfigurationSettings.AppSettings["MyConnectionStringModel"];
            MySqlConnection connection = new MySqlConnection(constr);
            connection.Open();
            return connection;
        }
        static void Main(string[] args)
        {


            //string constr = "server=127.0.0.1;User Id=root;password=root;Database=text";
            MySqlConnection connection = sqlConn();
            //connection.Open();

            string sql = "insert into user values ('jamy','imjamy','n','xxxxxxxx')";
            MySqlCommand scd = new MySqlCommand(sql, connection);
            scd.ExecuteNonQuery();
            connection.Close();

            //String sql = "select distinct * from text where user = 'tom'";
            //MySqlCommand scd = new MySqlCommand(sql, connection);
            //MySqlDataReader result = scd.ExecuteReader();
            //while (result.Read())
            //{

            //    Console.WriteLine((string)result[1]);
            //}

        }
    }
}
