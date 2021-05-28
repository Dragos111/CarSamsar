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

        public static string removeCarByVIN(string VIN)
        {
            string attempt = "Failed";
            string car_vin = "";

            MySqlDataReader dataReader = DBConnection.Command("select VIN from masini where VIN ='" + VIN + "';").ExecuteReader();
            if (dataReader.Read())
            {
                car_vin = dataReader["VIN"].ToString();
            }
            dataReader.Close();
            if (!car_vin.Equals(""))
            {
                DBConnection.Command("DELETE FROM masini WHERE VIN = '" + VIN + "'; ").ExecuteNonQuery();
                return attempt = "Successful";
            }
            return attempt;
        }
    }
}


