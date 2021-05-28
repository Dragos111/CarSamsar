using System;
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = searchBox.Text.ToString();
            string departmentID = departmentBox.SelectedIndex.ToString();
            searchGrid.DataSource = SearchData.SearchDataByDepartment(valueToSearch, departmentID);
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

    }
}
