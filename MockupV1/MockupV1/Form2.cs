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

        }
        public void updateDataGridView()
        {
            if(databasecmd.connection.State == ConnectionState.Closed)
            {
                databasecmd.connectDB();

            }
            try
            {
                //using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT epc,time,ant_id FROM checkpoint", databasecmd.connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT epc,time,ant_id FROM checkpoint",databasecmd.connection))
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateDataGridView();
            databasecmd.cmd.CommandText = "SELECT MAX(TIME(time)) as time FROM checkpoint WHERE ant_id = 1";
            using (MySqlDataReader reader = databasecmd.cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    label2.Text = "ant1 : " + reader.GetString(0);
                }
            }
            databasecmd.cmd.CommandText = "SELECT MAX(TIME(time)) as time FROM checkpoint WHERE ant_id = 2";
            using (MySqlDataReader reader = databasecmd.cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    label5.Text = "ant2 : " + reader.GetString(0);
                }
            }
            databasecmd.cmd.CommandText = "SELECT MAX(TIME(time)) as time FROM checkpoint WHERE ant_id = 3";
            using (MySqlDataReader reader = databasecmd.cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    label9.Text = "ant3 : " + reader.GetString(0);
                }
            }
            databasecmd.cmd.CommandText = "SELECT MAX(TIME(time)) as time FROM checkpoint WHERE ant_id = 4";
            using (MySqlDataReader reader = databasecmd.cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    label7.Text = "ant4 : " + reader.GetString(0);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DataGridView();
            label2.Text = "ant1 : 00:00:00:00";
            label5.Text = "ant2 : 00:00:00:00";
            label9.Text = "ant3 : 00:00:00:00";
            label7.Text = "ant4 : 00:00:00:00";
        }
    }
}
