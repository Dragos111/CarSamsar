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

    public partial class Form1 : Form
    {
        private LogIn login;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login = new LogIn(Text1.Text, Text2.Text);
            Text1.Clear();
            Text2.Clear();
            string attempt = login.LogInAttempt();
            if (attempt.Equals("Failed")) MessageBox.Show("Either your username or password is incorrect !", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (attempt.Equals("Successful"))
                MessageBox.Show("Amu ar trebui sa sara intr-un form nou.", "Welcome", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else MessageBox.Show("Failed to connect to database, please try again !", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

