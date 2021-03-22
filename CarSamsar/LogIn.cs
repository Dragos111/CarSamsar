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
        private string username;
        private string password;
        private string attempt = "Failed";

        public LogIn(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string LogInAttempt()
        {
            DBConnection.Connect();
            if (DBConnection.IsConnected() == false)
            {
                return attempt = "DB connection failed";
            }
            MySqlDataReader dataReader = DBConnection.Command("select * from users where Username ='" + username +
                "' and Password = '" + password + "';").ExecuteReader();
            if (dataReader.Read())
            {
                if (username.Equals(dataReader["Username"]) && password.Equals(dataReader["Password"]))
                {
                    attempt = "Successful";
                }
            }
            return attempt;
        }
    }
}
