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
        private int fieldLength = 20;

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

            if (username.Length > fieldLength || password.Length > fieldLength) return attempt = "Too long";

            MySqlDataReader dataReader = DBConnection.Command("select * from dateLogare where nume ='" + username +
                "' and parola = '" + password + "';").ExecuteReader();
            if (dataReader.Read())
            {
                if (username.Equals(dataReader["nume"]) && password.Equals(dataReader["parola"]))
                {
                    attempt = "Successful";
                }
            }
            return attempt;
        }

        public string LogInAttemptAdmin()
        {
            DBConnection.Connect();
            if (DBConnection.IsConnected() == false)
            {
                return attempt = "DB connection failed";
            }

            if (username.Length > fieldLength || password.Length > fieldLength) return attempt = "Too long";

            MySqlDataReader dataReader = DBConnection.Command("select * from admin where nume ='" + username +
                "' and parola = '" + password + "';").ExecuteReader();
            if (dataReader.Read())
            {
                if (username.Equals(dataReader["nume"]) && password.Equals(dataReader["parola"]))
                {
                    attempt = "Successful";
                }
            }
            return attempt;
        }
    }
}
