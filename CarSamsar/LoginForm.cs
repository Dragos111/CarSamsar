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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!Text1.Text.Equals("") && !Text2.Text.Equals(""))
            {
                login = new LogIn(Text1.Text, Text2.Text);
                Text1.Clear();
                Text2.Clear();
                string attempt = login.LogInAttempt();
                if (attempt.Equals("Failed")) MessageBox.Show("Either your username or password is incorrect !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (attempt.Equals("Successful"))
                //MessageBox.Show("Amu ar trebui sa sara intr-un form nou.", "Welcome",
                // MessageBoxButtons.OK,MessageBoxIcon.Information);
                {
                    MenuForm menuForm = new MenuForm();
                    menuForm.ShowDialog();
                    this.Hide();
                }
                else if (attempt.Equals("Too long"))
                    MessageBox.Show("Please enter maximum 20 characters for each field !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Failed to connect to database, please try again !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please fill al the fields !", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm f2 = new RegisterForm();
            f2.ShowDialog(); // Shows Form2
        }
    }
}

