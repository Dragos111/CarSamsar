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
    public partial class RegisterForm : Form
    {
        private Register register;

        public RegisterForm()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Text1.Text.Equals("") && !Text2.Text.Equals("") && !Text3.Text.Equals(""))
            {
                register = new Register(Text1.Text, Text2.Text, Text3.Text);
                Text1.Clear();
                Text2.Clear();
                Text3.Clear();
                string attempt = register.RegisterAttempt();
                if (attempt.Equals("Successful"))
                {
                    MessageBox.Show("User successfully added to database.", "Welcome", MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                    Close();
                }
                else if (attempt.Equals("Username already taken"))
                    MessageBox.Show("Username already taken !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Failed to connect to database, please try again !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
