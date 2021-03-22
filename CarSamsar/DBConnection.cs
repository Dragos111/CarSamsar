using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarSamsar
{

    public class DBConnection
    {
        private static MySqlConnection connection;
        private static MySqlCommand command;

        public static void Connect()
        {
            connection = new MySqlConnection("Datasource = 127.0.0.1;username=root;password=;database=carsamsar");
            try
            {
                connection.Open();
            }catch(Exception e)
            {
                Console.WriteLine("Can't connect to database: " + e);
            }
            if (IsConnected() == true)
            {
                command = new MySqlCommand();
                command.Connection = connection;
            }

        }

        public static MySqlCommand Command(string instruction)
        {
            command.CommandText = instruction;
            return command;
        }

        public static bool IsConnected()
        {
            if (connection.State == ConnectionState.Closed)
                return false;
            return true;
        }


        public static void CloseConnection()
        {
            connection.Close();
        }

    }
}
