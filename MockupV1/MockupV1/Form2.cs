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
        private bool isStart = false;
        private bool isReset = false;
        private int readCount = 0;
        private int addDataCount = 0;
        private int addServerCount = 0;
        private int addFileCount = 0;

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

        private void Form2_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            WindowState = FormWindowState.Maximized;

            ant1.ForeColor = Color.Gray;
            ant2.ForeColor = Color.Gray;
            ant3.ForeColor = Color.Gray;
            ant4.ForeColor = Color.Gray;
            ant5.ForeColor = Color.Gray;
            ant6.ForeColor = Color.Gray;
            ant7.ForeColor = Color.Gray;
            ant8.ForeColor = Color.Gray;
            ant1.Text = "ant1 : 00:00:00:00";
            ant2.Text = "ant2 : 00:00:00:00";
            ant3.Text = "ant3 : 00:00:00:00";
            ant4.Text = "ant4 : 00:00:00:00";
            ant5.Text = "ant1 : 00:00:00:00";
            ant6.Text = "ant2 : 00:00:00:00";
            ant7.Text = "ant3 : 00:00:00:00";
            ant8.Text = "ant4 : 00:00:00:00";
        }

        private void resetAnt()
        {
            ant1.Text = "ant1 : 00:00:00:00";
            ant2.Text = "ant2 : 00:00:00:00";
            ant3.Text = "ant3 : 00:00:00:00";
            ant4.Text = "ant4 : 00:00:00:00";
            ant5.Text = "ant1 : 00:00:00:00";
            ant6.Text = "ant2 : 00:00:00:00";
            ant7.Text = "ant3 : 00:00:00:00";
            ant8.Text = "ant4 : 00:00:00:00";
        }

        private void connectLAN_Click(object sender, EventArgs e)
        {
            if(!port4.Checked && !port8.Checked)
            {
                MessageBox.Show("Please Select Port Enable");
            }
            else if (port4.Checked)
            {
                //sent signal enable Hardware
                //need function to check port status
                ant1.ForeColor = Color.Green;
                ant2.ForeColor = Color.Green;
                ant3.ForeColor = Color.Green;
                ant4.ForeColor = Color.Green;
                port4.Enabled = false;
                port8.Enabled = false;
                connectLAN.Enabled = false;
                pointList.Enabled = false;
                start.Enabled = true;
                status1.ForeColor = Color.LimeGreen;
                status1.Text = "Connected";
            }
            else
            {
                //sent signal enable Hardware
                //need function to check port status
                ant1.ForeColor = Color.Green;
                ant2.ForeColor = Color.Green;
                ant3.ForeColor = Color.Green;
                ant4.ForeColor = Color.Green;
                ant5.ForeColor = Color.Green;
                ant6.ForeColor = Color.Green;
                ant7.ForeColor = Color.Green;
                ant8.ForeColor = Color.Green;
                port4.Enabled = false;
                port8.Enabled = false;
                connectLAN.Enabled = false;
                pointList.Enabled = false;
                start.Enabled = true;
                status1.ForeColor = Color.LimeGreen;
                status1.Text = "Connected";
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void start_Click(object sender, EventArgs e)
        {
            isStart = !isStart;
            if(isStart)
            {
                reset.Enabled = false;
                start.BackColor = Color.Red;
                start.ForeColor = Color.White;
                start.Text = "Stop";
                //updateDataGridView();
                //databasecmd.cmd.CommandText = "SELECT MAX(TIME(time)) as time FROM checkpoint WHERE ant_id = 1";
                //using (MySqlDataReader reader = databasecmd.cmd.ExecuteReader())
                //{
                //    if (reader.Read())
                //    {
                //        ant1.Text = "ant1 : " + reader.GetString(0);
                //    }
                //}
                //databasecmd.cmd.CommandText = "SELECT MAX(TIME(time)) as time FROM checkpoint WHERE ant_id = 2";
                //using (MySqlDataReader reader = databasecmd.cmd.ExecuteReader())
                //{
                //    if (reader.Read())
                //    {
                //        ant2.Text = "ant2 : " + reader.GetString(0);
                //    }
                //}
                //databasecmd.cmd.CommandText = "SELECT MAX(TIME(time)) as time FROM checkpoint WHERE ant_id = 3";
                //using (MySqlDataReader reader = databasecmd.cmd.ExecuteReader())
                //{
                //    if (reader.Read())
                //    {
                //        ant3.Text = "ant3 : " + reader.GetString(0);
                //    }
                //}
                //databasecmd.cmd.CommandText = "SELECT MAX(TIME(time)) as time FROM checkpoint WHERE ant_id = 4";
                //using (MySqlDataReader reader = databasecmd.cmd.ExecuteReader())
                //{
                //    if (reader.Read())
                //    {
                //        ant4.Text = "ant4 : " + reader.GetString(0);
                //    }
                //}
            }
            else
            {
                reset.Enabled = true;
                start.BackColor = Color.White;
                start.ForeColor = Color.Black;
                start.Text = "Start";
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            isReset = !isReset;
            if (isReset)
            {
                reset.Enabled = false;
                dataGridView1.DataSource = new DataGridView();
                resetAnt();
            }
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
