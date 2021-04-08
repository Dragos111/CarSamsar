using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSamsar
{
    public partial class AdminLoginForm : Form
    {
        private AdminLogin register;

        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!usernameTextBox.Text.Equals("") && !passwordTextBox.Text.Equals("") && !firstnameTextBox.Text.Equals("")
                && !lastnameTextBox.Text.Equals("") && !cnpTextBox.Text.Equals("") && !addressTextBox.Text.Equals("")
                && !salaryTextBox.Text.Equals(""))
            {
                register = new AdminLogin(usernameTextBox.Text, passwordTextBox.Text, firstnameTextBox.Text,
                    lastnameTextBox.Text, cnpTextBox.Text, addressTextBox.Text, salaryTextBox.Text);
                
                string attempt = register.RegisterAttempt();
                if (attempt.Equals("Successful"))
                {
                    MessageBox.Show("User successfully added to database.", "Welcome", MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                }
                else if (attempt.Equals("Username already taken"))
                    MessageBox.Show("Username already taken !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (attempt.Equals("CNP already taken"))
                    MessageBox.Show("An account already exists for this CNP !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (attempt.Equals("Too long"))
                    MessageBox.Show("Please enter maximum 20 characters for each field !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Failed to connect to database, please try again !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please fill al the fields !", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void clearTextBoxes()
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            firstnameTextBox.Clear();
            lastnameTextBox.Clear();
            cnpTextBox.Clear();
            addressTextBox.Clear();
            salaryTextBox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void employeesTab_Click(object sender, EventArgs e)
        {

        }
    }
}
