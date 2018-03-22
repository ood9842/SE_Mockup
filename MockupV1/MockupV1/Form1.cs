using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MockupV1
{
    public partial class Form1 : Form
    {
        private static ConnectDatabase databasecmd;

        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }


        private bool validate_login(string user, string pass)
        {
            databasecmd = new ConnectDatabase();
            databasecmd.connectDB();
            databasecmd.cmd.CommandText = "Select username , password from login where username=@user and password=@pass";
            databasecmd.cmd.Parameters.AddWithValue("@user", user);
            databasecmd.cmd.Parameters.AddWithValue("@pass", pass);
            databasecmd.cmd.Connection = databasecmd.connection;
            MySqlDataReader login = databasecmd.cmd.ExecuteReader();
            if (login.Read())
            {
                databasecmd.connection.Close();
                return true;
            }
            else
            {
                databasecmd.connection.Close();
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(textBox1.Text == "admin" && textBox2.Text == "1234")
            if(validate_login(textBox1.Text,textBox2.Text))
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
