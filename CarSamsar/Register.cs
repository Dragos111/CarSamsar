using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarSamsar
{
    class Register
    {
        private string username;
        private string password;
        private string key;
        private string attempt = "Failed";
        private int fieldLength = 20;

        public Register(string username, string password, string key)
        {
            this.username = username;
            this.password = password;
            this.key = key;

        }

        public string RegisterAttempt()
        {
            DBConnection.Connect();
            if (DBConnection.IsConnected() == false)
            {
                return attempt = "DB connection failed";
            }

            if (username.Length > fieldLength || password.Length > fieldLength || key.Length > fieldLength) return attempt = "Too long";

            MySqlDataReader dataReader = DBConnection.Command("select * from users where Username ='" + username + "';").ExecuteReader();
            if (dataReader.Read())
            {
                if (username.Equals(dataReader["Username"])) return attempt = "Username already taken";
            }
            dataReader.Close();

            dataReader = DBConnection.Command("select * from enrolmentkeys where Cheie ='" + key + "';").ExecuteReader();
            if (!dataReader.Read())
            {
                return attempt = "Wrong key";
            }
            dataReader.Close();


            DBConnection.Command("insert into users(username,password) values('" + username + "','" + password + "');").ExecuteNonQuery();

            dataReader = DBConnection.Command("select * from users where Username ='" + username +
               "' and Password = '" + password + "';").ExecuteReader();
            if (dataReader.Read())
            {
                if (username.Equals(dataReader["Username"]) && password.Equals(dataReader["Password"]))
                {
                    attempt = "Successful";
                }
            }

            dataReader.Close();

            return attempt;
        }
    }
}
