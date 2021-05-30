using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarSamsar
{

    public partial class LoginForm : Form
    {
        private LogIn login;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//Employee login button
        {
            if (!Text1.Text.Equals("") && !Text2.Text.Equals(""))
            {
                login = new LogIn(Text1.Text, Text2.Text);

                string attempt = login.LogInAttempt();//attempt to log in as employee
                if (attempt.Equals("Failed"))
                {
                    MessageBox.Show("Either your username or password is incorrect !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logs.addLog(Text1.Text, " UserLogin ", attempt + " ");//saving logs
                }
                else if (attempt.Equals("Successful"))
                {
                    MenuForm menuForm = new MenuForm();//starting Employee form
                    menuForm.ShowDialog();
                    Logs.addLog(Text1.Text, " UserLogin ", attempt + " ");//saving Logs
                }
                else if (attempt.Equals("Too long"))
                    MessageBox.Show("Please enter maximum 20 characters for each field !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Failed to connect to database, please try again !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logs.addLog(Text1.Text, " UserLogin ", " Failed(database problems) ");
                }
            }
            else MessageBox.Show("Please fill al the fields !", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            Text1.Clear();
            Text2.Clear();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//Admin log in button
        {
            if (!Text1.Text.Equals("") && !Text2.Text.Equals(""))
            {
                login = new LogIn(Text1.Text, Text2.Text);

                string attempt = login.LogInAttemptAdmin();//Attempt to log in as Admin
                if (attempt.Equals("Failed"))
                {
                    MessageBox.Show("Either your username or password is incorrect !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logs.addLog(Text1.Text, " AdminLogin ", attempt + " ");//Saving logs
                }
                else if (attempt.Equals("Successful"))
                {
                    AdminLoginForm f2 = new AdminLoginForm();
                    f2.ShowDialog(); // Shows register form
                    Logs.addLog(Text1.Text, " AdminLogin ", attempt + " ");//Saving logs
                }
                else if (attempt.Equals("Too long"))
                    MessageBox.Show("Please enter maximum 20 characters for each field !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Failed to connect to database, please try again !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logs.addLog(Text1.Text, " AdminLogin ", "Failed(database problems) ");
                }
            }
            else MessageBox.Show("Please fill al the fields !", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            Text1.Clear();
            Text2.Clear();
        }
        /**
         * Saving logs in a file.
         */
        private void exitButton_Click(object sender, EventArgs e)
        {
            // uncomment this only if you have created "Logs.txt" in \CarSamsar\bin\Debug
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs.txt");
            File.WriteAllLines(path, Logs.getLogs().Cast<string>());
            MessageBox.Show(path);
            Application.Exit();
        }
    }
}

