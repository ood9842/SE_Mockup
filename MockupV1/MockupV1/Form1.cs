using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MockupV1
{
    public partial class Form1 : Form
    {
        private Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                this.Close();
                th = new Thread(openAnotherForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }
        }

        private void openAnotherForm()
        {
            Application.Run(new Form2());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
