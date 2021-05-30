using MySql.Data.MySqlClient;

namespace CarSamsar
{
    /**
     * Class used to construct an employee with all his details.
     */
    public class AdminLogin
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
        /**
         * Inserting employees.
         */
        public string RegisterAttempt()
        {
            DBConnection.Connect();//Database connection
            if (DBConnection.IsConnected() == false)
            {
                return attempt = "DB connection failed";
            }

            MySqlDataReader dataReader = DBConnection.Command("select * from dateLogare where nume ='" + username + "';").ExecuteReader();
            if (dataReader.Read()) //Check existing username
            { 
                if (username.Equals(dataReader["nume"]))
                {
                    return attempt = "Username already taken";
                }
            }
            dataReader.Close();


            dataReader = DBConnection.Command("select * from angajati where cnp ='" + cnp + "';").ExecuteReader();

            if (dataReader.Read())//Check existing employee
            {
                if (cnp.Equals(dataReader["cnp"]))
                {
                    return attempt = "CNP already taken";
                }
            }
            dataReader.Close();

            if (!CnpValidator.IsValidCnp(cnp))//CNP Validation
            {
                return attempt = "CNP is not valid";
            }

            DBConnection.Command("insert into angajati(nume,prenume,cnp,adresa,salariu) " +
                   "values('" + firstname + "','" + lastname + "','" + cnp + "','" + address + "','" + salary + "');").ExecuteNonQuery();//Inserting employee

            dataReader = DBConnection.Command("select angajatID from angajati where cnp ='" + cnp + "';").ExecuteReader();
            if (dataReader.Read()) angajatId = dataReader["angajatID"].ToString(); // Taking inserted emplyee's ID
            dataReader.Close();

            DBConnection.Command("insert into dateLogare(angajatID,parola,nume) " +
                "values('" + angajatId + "','" + password + "','" + username + "');").ExecuteNonQuery();//Inserting employee in dateLogare


            dataReader = DBConnection.Command("select * from angajati where nume ='" + firstname +
               "' and cnp = '" + cnp + "';").ExecuteReader();
            if (dataReader.Read())// Verify if user added
            {
                if (firstname.Equals(dataReader["nume"]) && cnp.Equals(dataReader["cnp"]))
                {
                    dataReader.Close();
                    return attempt = "Successful";
                }
            }
            dataReader.Close();
            return attempt;
        }
    }
}
