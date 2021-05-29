using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarSamsar
{
    public partial class AdminLoginForm : Form
    {
        private AdminLogin register;

        public AdminLoginForm()
        {
            InitializeComponent();
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
                    Logs.addUserLog("admin ", " AddUser ", attempt, usernameTextBox.Text);
                }
                else if (attempt.Equals("Username already taken"))
                {
                    MessageBox.Show("Username already taken !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logs.addUserLog("admin ", " AddUser ", attempt + "(username already taken) ", usernameTextBox.Text);
                }
                else if (attempt.Equals("CNP is not valid"))
                {
                    MessageBox.Show("CNP is not valid!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logs.addUserLog("admin ", " AddUser ", attempt + "(CNP is not valid) ", usernameTextBox.Text);
                }
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


        private void removeButton_Click(object sender, EventArgs e)
        { //Remove by CNP/Username
            string attempt = RemoveRecord.removeUserByUsername(usernameTextBox.Text);
            if (attempt.Equals("Successful"))
            {
                MessageBox.Show("User successfully deleted from database.", "Welcome", MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                Logs.addUserLog("admin ", " RemoveUser ", attempt + " ", usernameTextBox.Text);
            }
            else if (attempt.Equals("Failed"))
            {
                MessageBox.Show("Could not perform operation. Please enter a valid 'username' or 'cnp'", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logs.addUserLog("admin ", " RemoveUser ", attempt + " ", usernameTextBox.Text);
            }
        }



        public void clearDateMasini()
        {
            department_textbox.Clear();
            VIN_textbox.Clear();
            marca_textbox.Clear();
            pret_textbox.Clear();
            an_textbox.Clear();
            proprietari_textbox.Clear();
            model_textbox.Clear();
            km_textbox.Clear();
        }

      
        private void register_car_Click_1(object sender, EventArgs e)
        {
            if (!department_textbox.Text.Equals("") && !VIN_textbox.Text.Equals("") && !marca_textbox.Text.Equals("") && !pret_textbox.Text.Equals("")
               && !an_textbox.Text.Equals("") && !proprietari_textbox.Text.Equals("") && !model_textbox.Equals("")
                && !km_textbox.Text.Equals(""))
            {
                DBConnection.Connect();
                if (DBConnection.IsConnected() == false)
                {
                    MessageBox.Show("DB connection failed");

                }

                MySqlDataReader dataReader = DBConnection.Command("select * from masini where VIN ='" + VIN_textbox.Text + "';").ExecuteReader();
                if (!dataReader.Read())
                {



                    Masina masina = new Masina(department_textbox.Text, VIN_textbox.Text, marca_textbox.Text, pret_textbox.Text, an_textbox.Text,
                     proprietari_textbox.Text, model_textbox.Text, km_textbox.Text);

                    masina.RegisterAttempt();

                    Logs.addCarLog("admin", " AddCar ", "Successful ", "VIN: " + VIN_textbox.Text);

                    MessageBox.Show("Car successfully added to database.", "Welcome", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    clearDateMasini();
                }
                else
                {

                    MessageBox.Show("Car is already registered!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Logs.addCarLog("admin", " AddCar ", "Failed ", "VIN: " + VIN_textbox.Text);

                    clearDateMasini();

                }
                dataReader.Close();
            }
            else MessageBox.Show("Please fill al the fields !", "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void remove_car_Click_1(object sender, EventArgs e)
        {
            string attempt = RemoveRecord.removeCarByVIN(VIN_textbox.Text);
            if (attempt.Equals("Successful"))
            {
                MessageBox.Show("Car successfully deleted from database.", "Welcome", MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                VIN_textbox.Clear();

                Logs.addCarLog("admin", " RemoveCar ", "Successful ", "VIN: " + VIN_textbox.Text);
            }
            else if (attempt.Equals("Failed"))
            {
                MessageBox.Show("Could not perform operation. VIN could not be found.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                VIN_textbox.Clear();
                Logs.addCarLog("admin", " RemoveCar ", "Failed ", "VIN: " + VIN_textbox.Text + " could not be found");
            }
        }
    }
}
