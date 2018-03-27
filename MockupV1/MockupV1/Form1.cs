using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MockupV1
{
    public partial class Form1 : Form
    {
        private static ConnectDatabase databasecmd;
        private Thread tesk;

        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
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

        private void checkText()
        {
            //if(textBox1.Text == "admin" && textBox2.Text == "1234")
            if (validate_login(textBox1.Text, textBox2.Text))
            {
                tesk = new Thread(changeOtherForm);
                this.Close();
                tesk.Start();
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }
        }

        private void changeOtherForm()
        {
            Application.Run(new Form2());
        }

        //key event
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                checkText();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }
    }
}
