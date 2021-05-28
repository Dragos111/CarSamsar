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
            FormBorderStyle = FormBorderStyle.None;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = searchBox.Text.ToString();
            string departmentID = departmentBox.SelectedIndex.ToString();
            searchGrid.DataSource = SearchData.SearchDataByDepartment(valueToSearch, departmentID);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webView_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView.SuspendLayout();
            webView.Stop();
            webView.Visible = false;
            webView.Hide();
            Close();
        }

        private void exitButton2_Click(object sender, EventArgs e)
        {
            webView.SuspendLayout();
            webView.Stop();
            webView.Visible = false;
            webView.Hide();
            Close();
        }

        private void searchGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
