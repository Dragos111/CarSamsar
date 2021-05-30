using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarSamsar
{
    /**
     * Used to check if entered credentials match with database.
     */
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
        /**
         * Attempt to login as employee
        */
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
            if (dataReader.Read())//Check if entered credentials match with database.
            {
                if (username.Equals(dataReader["nume"]) && password.Equals(dataReader["parola"]))
                {
                    dataReader.Close();
                    attempt = "Successful";   
                }
            }
            dataReader.Close();

            return attempt;
        }
        /**
         * Attempt to login as Admin
        */
        public string LogInAttemptAdmin()
        {
            DBConnection.Connect();
            if (DBConnection.IsConnected() == false)
            {
                Console.WriteLine("Ad");
                return attempt = "DB connection failed";
            }

            if (username.Length > fieldLength || password.Length > fieldLength) return attempt = "Too long";

            MySqlDataReader dataReader = DBConnection.Command("select * from admin where nume ='" + username +
                "' and parola = '" + password + "';").ExecuteReader();
            if (dataReader.Read())//Check if entered credentials match with database.
            {
                if (username.Equals(dataReader["nume"]) && password.Equals(dataReader["parola"]))
                {
                    dataReader.Close();
                    attempt = "Successful";
                }
                dataReader.Close();
            }
            dataReader.Close();
            return attempt;
        }
    }
}
