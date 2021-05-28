﻿using System;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

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

        private void sellButton_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text != "" && vinTextBox.Text != "" && IsValidEmail(emailTextBox.Text))
            {
                string message;
                string mesajEmail = "";
                DBConnection.Connect();
                if (DBConnection.IsConnected() != false)
                {
                    MySqlDataReader dataReader = DBConnection.Command("select marca,Model from masini where VIN ='" + vinTextBox.Text + "';").ExecuteReader();
                    if (dataReader.Read())
                    {
                        message = dataReader["marca"] + " " + dataReader["Model"];
                        mesajEmail = string.Format("Congratulations, you bought yourself a {0}", message);

                        dataReader.Close();
                        string attempt = RemoveRecord.removeCarByVIN(vinTextBox.Text);
                        if (attempt.Equals("Successful"))
                        {

                            MailMessage mail = new MailMessage("carsamsar@gmail.com", emailTextBox.Text, "CarSamsar Acquisition", mesajEmail);
                            SmtpClient client = new SmtpClient("smtp.gmail.com")
                            {
                                Port = 587,
                                Credentials = new System.Net.NetworkCredential("carsamsar@gmail.com", "proiect1234"),
                                EnableSsl = true
                            };
                            client.Send(mail);
                            MessageBox.Show("Car SOLD !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else MessageBox.Show("VIN not found !", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataReader.Close();    
                }
                else MessageBox.Show("Can't connect to DataBase !", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please check the fields!", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
    }
}
