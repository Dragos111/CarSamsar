using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSamsar
{
    class SearchData
    {
        private static DataTable table = new DataTable();

        /*
         Returns a DataTable object wich contains the infos from "masini" table filtered by department
         If "departmentID" is null (slected "All" in deparrtmentBox) you can search all the data in "masini"
         */
        public static DataTable SearchDataByDepartment(string valueToSearch, string departmentID)
        {
            table.Clear();
            DBConnection.Connect();
            string queryByDeparment = "Select * FROM masini WHERE departamentID = '" + departmentID + "' AND CONCAT(`marca`,`pret`,`anFabricatie`,`fostiProprietari`,`Model`,`KM`) like '%" + valueToSearch + "%'";
            string query = "Select * FROM masini WHERE CONCAT(`departamentID`,`marca`,`pret`,`anFabricatie`,`fostiProprietari`,`Model`,`KM`) like '%" + valueToSearch + "%'";

            if (departmentID.Equals("0"))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(DBConnection.Command(query));
                adapter.Fill(table);
            }
            else
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(DBConnection.Command(queryByDeparment));
                adapter.Fill(table);

            }

            return table;
        }
    }
}
