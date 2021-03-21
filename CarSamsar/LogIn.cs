using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarSamsar
{
    public class LogIn
    {
        private MySqlCommand command = new MySqlCommand();
        private MySqlConnection connection;
        private String username;
        private String password;
        private String attempt = "Failed";

        /*
        int ok;
        public LogIn(int n) {
          this.ok = n;
        }

        public void scr()
        {
           Console.WriteLine("ok");
        }*/
        public LogIn(String username, String password)
        {
            this.username = username;
            this.password = password;
        }
        public String LogInAttempt()
        {
            connection = new MySqlConnection("Datasource = 127.0.0.1;username=root;password=;database=carsamsar");
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select * from users where Username ='" + this.username + "' and Password = '" + this.password + "';";
            MySqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                if (this.username.Equals(dataReader["Username"]) && this.password.Equals(dataReader["Password"]))
                {
                    attempt = "Successful";
                }
            }
            connection.Close();
            return attempt;
        }
    }
}
