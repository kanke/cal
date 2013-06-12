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
    public partial class Form14 : Form
    {
         SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kanke\Desktop\cal\cal\appoint.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            DataSet sch = new DataSet();
            public string rcno = String.Empty, rcname = String.Empty, rid = String.Empty, nm = String.Empty;
            string tmpno;

        public Form14()
        {
            InitializeComponent();
            cnn.Open();
            SqlCommand q = new SqlCommand();
            q.Connection = cnn;
            q.CommandText = "select * from call";

            SqlDataAdapter da = new SqlDataAdapter(q);

            da.Fill(sch, "call");
            dataGridView1.DataSource = sch;
            dataGridView1.DataMember = "call";
        }
        public Form14(string id)
        {
            
            InitializeComponent();
            tmpno=id;

            cnn.Open();
            SqlCommand q = new SqlCommand();
            q.Connection = cnn;
            q.CommandText = "select * from call where id=@id";
            q.Parameters.Add("@id", SqlDbType.Int).Value = tmpno.Trim();


            SqlDataAdapter da = new SqlDataAdapter(q);

            da.Fill(sch, "call");
            dataGridView1.DataSource = sch;
            dataGridView1.DataMember = "call";
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
       
        }

        private void Form14_Load(object sender, EventArgs e)
        {
           
            /*cnn.Open();

            if (cnn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Connection Error !");
                return;
            }

            //connectn sql cmd to d main connectn
            SqlCommand q = new SqlCommand();
            q.Connection = cnn;

            q.CommandType = CommandType.Text;

            q.CommandText = "select * from contacts";


            //creatn adapter connect query with dataset
            SqlDataAdapter r = new SqlDataAdapter(q);

            r.Fill(sch, "cont");


            dataGridView1.DataSource = sch;
            dataGridView1.DataMember = "cont";*/

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             if (sch.Tables["call"].Rows.Count == 0)
            {
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            DataRow dr = sch.Tables["call"].Rows[dataGridView1.CurrentCell.RowIndex];
            
            rid = dr["id"].ToString();
            rcname = dr["name"].ToString();
             rcno = dr["phoneno"].ToString();
           
            this.DialogResult = DialogResult.OK;
        }

        private void Form14_Shown(object sender, EventArgs e)
        {
         
            
        
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Form14_Resize(object sender, EventArgs e)
        {
            
        }
       
        }

       
    }

