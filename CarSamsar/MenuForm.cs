using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSamsar
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void searchData(string valueToSearch)
        {
            DBConnection.Connect();
            DataTable table = new DataTable();

            string query = "Select * FROM masini WHERE CONCAT(`departamentID`,`marca`,`pret`,`anFabricatie`,`fostiProprietari`,`Model`,`KM`) like '%" + valueToSearch + "%'";

            string departmentID = departmentBox.SelectedIndex.ToString();

            if (departmentID.Equals("0"))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(DBConnection.Command(query));
                adapter.Fill(table);
                searchGrid.DataSource = table;
            } else
            {
                string queryByDeparment = "Select * FROM masini WHERE departamentID = '" + departmentID + "' AND CONCAT(`marca`,`pret`,`anFabricatie`,`fostiProprietari`,`Model`,`KM`) like '%" + valueToSearch + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(DBConnection.Command(queryByDeparment));
                adapter.Fill(table);
                searchGrid.DataSource = table;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = searchBox.Text.ToString();
            searchData(valueToSearch);
        }

    }
}
