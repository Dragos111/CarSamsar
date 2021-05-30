using System;


namespace CarSamsar
{
    /**
     * Class used to construct a car with all it's details.
     */
    public class Masina
    {
        private string departmentId;
        private string seria_VIN;
        private string marca;
        private string pret;
        private string anFabricatie;
        private string fostiProprietari;
        private string model;
        private string km;

        public Masina(string d, string s, string marca, string p, string a, string f, string model, string k)
        {
            this.departmentId = d;
            this.seria_VIN = s;
            this.marca = marca;
            this.pret = p;
            this.anFabricatie = a;
            this.fostiProprietari = f;
            this.model = model;
            this.km = k;
        }
        //Inserts the car into the database
        public void RegisterAttempt()
        {
            DBConnection.Connect();
            if (DBConnection.IsConnected() == false)
            {
                Console.WriteLine("DB connection failed!");
            }
            DBConnection.Command("insert into masini(departamentID,VIN,marca,pret,anFabricatie,fostiProprietari,Model,KM) " +
                   "values('" + departmentId + "','" + seria_VIN + "','" + marca + "','" + pret + "','" + anFabricatie + "','" + fostiProprietari + "','" + model + "','" + km + "');").ExecuteNonQuery();

        }
    }
}


