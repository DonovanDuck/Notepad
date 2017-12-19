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
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "server=127.0.0.1;User Id=root;password=root;Database=booking";
            MySqlConnection connection = new MySqlConnection(constr);
            connection.Open();
            if (connection.State == ConnectionState.Open) {
                Console.WriteLine("success");
                connection.Close();
            }

        }
    }
}
