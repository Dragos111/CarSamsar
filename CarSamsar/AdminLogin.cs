using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarSamsar
{
    class AdminLogin
    {
        private string username;
        private string password;
        private string firstname;
        private string lastname;
        private string cnp;
        private string address;
        private string salary;
        private string attempt = "Failed";
        private string angajatId;
        private int fieldLength = 20;

        public AdminLogin(string username, string password, string firstname,
            string lastname, string cnp, string address, string salary)
        {
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.cnp = cnp;
            this.address = address;
            this.salary = salary;
        }

        public string RegisterAttempt()
        {
            DBConnection.Connect();
            if (DBConnection.IsConnected() == false)
            {
                return attempt = "DB connection failed";
            }

            if (username.Length > fieldLength || password.Length > fieldLength || firstname.Length > fieldLength
                || lastname.Length > fieldLength || cnp.Length > fieldLength || address.Length > fieldLength
                || salary.Length > fieldLength) return attempt = "Too long";

            MySqlDataReader dataReader = DBConnection.Command("select * from dateLogare where nume ='" + username + "';").ExecuteReader();
            if (dataReader.Read())
            {
                if (username.Equals(dataReader["nume"]))
                {
                    return attempt = "Username already taken";
                }
            }
            dataReader.Close();


            dataReader = DBConnection.Command("select * from angajati where cnp ='" + cnp + "';").ExecuteReader();
            if (dataReader.Read())
            {
                if (cnp.Equals(dataReader["cnp"]))
                {
                    return attempt = "CNP already taken";
                }
            }
            dataReader.Close();


            DBConnection.Command("insert into angajati(nume,prenume,cnp,adresa,salariu) " +
                   "values('" + firstname + "','" + lastname + "','" + cnp + "','" + address + "','" + salary + "');").ExecuteNonQuery();

            dataReader = DBConnection.Command("select angajatID from angajati where cnp ='" + cnp + "';").ExecuteReader();
            if (dataReader.Read()) angajatId = dataReader["angajatID"].ToString(); // Se ia id angajat pt dateLogare
            dataReader.Close();

            DBConnection.Command("insert into dateLogare(angajatID,parola,nume) " +
                "values('" + angajatId + "','" + password + "','" + username + "');").ExecuteNonQuery();


            dataReader = DBConnection.Command("select * from angajati where nume ='" + firstname + //Se verifica daca s-a bagat angajatul
               "' and cnp = '" + cnp + "';").ExecuteReader();
            if (dataReader.Read())
            {
                if (firstname.Equals(dataReader["nume"]) && cnp.Equals(dataReader["cnp"]))
                {
                    return attempt = "Successful";
                }
            }
            dataReader.Close();
            return attempt;
        }
    }
}
