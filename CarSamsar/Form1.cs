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
      /*  private LogIn lg;

        public Form1(LogIn k)
        {
            InitializeComponent();
            lg = k;

        }
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            LogIn login = new LogIn(Text1.Text, Text2.Text);
            Text1.Clear();
            Text2.Clear();
            String attempt = login.LogInAttempt();
            if (attempt.Equals("Failed")) MessageBox.Show("Either your username or password is incorrect !", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                MessageBox.Show("Amu ar trebui sa sara intr-un form nou. Am lasat in Form1 si Login codu scris de Matei/David si l-am comentat." +
                    " Mi se pare inutil de complicat ce ati construit acolo. ", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("Logged In");
            }
            /*
            Users u1 = new Users("dragos", "1234");
            Users u2 = new Users("david", "1234");
            Users u3 = new Users("matei", "1234");
            Users u4 = new Users("pavel", "1234");
            lg.scr();

            List<Users> users = new List<Users>();
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);
            string u = Text1.Text;
            string p = Text2.Text;
            Text1.Clear();
            Text2.Clear();
            Login_data ld = new Login_data(u, p);
            Boolean ok = false;
            foreach (Users user in users)
            {
                if (String.Equals(user.username, ld.username) && String.Equals(user.password, ld.password))
                {
                    ok = true;
                    break;
                }
            }
            if (ok)
                MessageBox.Show("Login reusit!");
            else
                MessageBox.Show("Username sau parola gresite!");*/


        }
    }
    /*
    class Users
    {
        public string username;
        public string password;

        public Users(string u, string p)
        {
            this.username = u;
            this.password = p;
        }
    }


    class Login_data
    {
        public string username;
        public string password;

        public Login_data() { }
        public Login_data(string u, string p)
        {
            this.username = u;
            this.password = p;
        }

        public string getPassword()
        {
            return this.password;
        }
        public string getUsername()
        {
            return this.username;
        }
    }*/
}

