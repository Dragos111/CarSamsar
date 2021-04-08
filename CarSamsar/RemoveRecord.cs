using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarSamsar
{
    class RemoveRecord
    {
        public static string removeUserByUsername(string username)
        {
            string attempt = "Failed";
            string angajatID = "";

            MySqlDataReader dataReader = DBConnection.Command("select angajatID from dateLogare where nume ='" + username + "';").ExecuteReader();
            if (dataReader.Read())
            {
                angajatID = dataReader["angajatID"].ToString(); // Se ia id angajat pt dateLogare
            }
            dataReader.Close();
            if (!angajatID.Equals(""))
            {
                DBConnection.Command("DELETE FROM angajati WHERE angajatID = '" + angajatID + "'; ").ExecuteNonQuery();
                DBConnection.Command("DELETE FROM dateLogare WHERE angajatID= '" + angajatID + "'; ").ExecuteNonQuery();
                return attempt = "Successful";
            }
            return attempt;
        }
    }
}
