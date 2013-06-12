using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cal
{
    public partial class Form15 : Form
    { //connecting to database
        SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kanke\Desktop\cal\cal\appoint.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        DataSet sch = new DataSet();
        public Form15()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

            //opening connect
            cnn.Open();

            //checkn if connect exist
            if (cnn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Connection Error !");
                return;
            }

            //connectn sql cmd to d main connectn
            SqlCommand q = new SqlCommand();
            q.Connection = cnn;

            q.CommandType = CommandType.Text;
            q.CommandText = "select * from memo";

            //creatn adapter connect query with dataset
            SqlDataAdapter r = new SqlDataAdapter(q);

            r.Fill(sch, "memo");


            dataGridView1.DataSource = sch;
            dataGridView1.DataMember = "memo";
        }

        private void Form15_Resize(object sender, EventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
