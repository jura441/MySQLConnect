using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Net.Configuration;

namespace MySQLConnect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection mysql = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
            mysql.Open();
            Console.WriteLine("Open");
            mysql.CreateCommand();
            MySqlCommand mySqlCommand = new MySqlCommand("select count(*) FROM Books", mysql);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (reader.Read())
                Console.WriteLine(reader.GetValue(0));
            mysql.Close();
            Console.WriteLine("Close");

            Console.ReadLine();
        }
    }
}
