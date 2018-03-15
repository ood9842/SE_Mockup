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
    public partial class Form2 : Form
    {
        private static ConnectDatabase databasecmd;

        public Form2()
        {
            InitializeComponent();
            databasecmd = new ConnectDatabase();
            databasecmd.connectDB();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT epc,time,ant_id FROM checkpoint", databasecmd.connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (databasecmd.connection.State == ConnectionState.Open)
                {
                    databasecmd.connection.Clone();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }
    }
}
