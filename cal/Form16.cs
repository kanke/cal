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
    public partial class Form16 : Form
    {
        //connecting to database
        SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kanke\Desktop\cal\cal\appoint.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        DataSet sch = new DataSet();
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
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
            q.CommandText = "select * from meeting";

            //creatn adapter connect query with dataset
            SqlDataAdapter r = new SqlDataAdapter(q);

            r.Fill(sch, "meeting");


            dataGridView1.DataSource = sch;
            dataGridView1.DataMember = "meeting";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form16_Resize(object sender, EventArgs e)
        {
           
        }
    }
}
