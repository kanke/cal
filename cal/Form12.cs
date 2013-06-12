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
    public partial class Form12 : Form
    {
         SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kanke\Desktop\cal\cal\appoint.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
         SqlDataAdapter da;
         DataSet sch = new DataSet();
         
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete button.
            if (cnn.State != ConnectionState.Open) cnn.Open();
            
            textBox4.Text = textBox4.Text.Trim();
            if (textBox4.Text.Length == 0)
            {
                MessageBox.Show("Please type id to search");
                return;
            }

            int id;
            bool ifint = int.TryParse(textBox4.Text, out id);
            if (!ifint)
            {
                MessageBox.Show(" id has to be an integer");
                return;
            }

            if (cnn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Connection Error !");
                return;
            }

            DataRow dr = sch.Tables["call"].Rows.Find(id);
            if (dr == null)
            {
                MessageBox.Show("Record not found");
                return;
            }
            dr.Delete();
            sch.AcceptChanges();

            //connectn sql cmd to d main connectn
            SqlCommand q = new SqlCommand();
            q.Connection = cnn;

            q.CommandType = CommandType.Text;
            q.CommandText = "delete from call where id=@id ";
            q.Parameters.Add("@id", SqlDbType.Int).Value = id;

            int res = q.ExecuteNonQuery();

            if (res > 0)
            {
                MessageBox.Show("Contact with id '" + textBox1.Text + "' deleted.");
                textBox1.Clear();
                textBox2.Clear();
             
                textBox4.Clear();
                textBox4.Focus();
            }

            else

            {
                MessageBox.Show("Contact with id '" + textBox1.Text + "' not found.");
                textBox1.Clear();
                textBox2.Clear();
                
                textBox4.Clear();
                textBox4.Focus();
        }
            cnn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //save button.
            textBox1.Text = textBox1.Text.Trim();
            textBox2.Text = textBox2.Text.Trim();
            
            textBox4.Text = textBox4.Text.Trim();
            int x = -1;
            int res;
            bool itisanupdate = false;

           if (textBox4.Text.Length > 0)
            {
                bool ifint = int.TryParse(textBox4.Text, out x);
                if (!ifint)
                {
                    MessageBox.Show(" id has to be an integer");
                    return;
                }
                itisanupdate = true;
            }

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("name must be specified");
                return;
            }

            cnn.Open();
            if (cnn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Connection Error !");
                return;
            }

        
            
            //connectn sql cmd to d main connectn
            SqlCommand q = new SqlCommand();
            q.Connection = cnn;

            q.CommandType = CommandType.Text;

            if (itisanupdate)
            {

            DataRow dr = sch.Tables["call"].Rows.Find(x);
            if (dr == null)
            {
                MessageBox.Show("Record not found");
                return;
            }
            dr["name"] = textBox1.Text;
            //dr["surname"] = textBox3.Text;
            dr["phoneno"] = textBox2.Text;
            //sch.Tables["contacts"].Rows.Add(dr);
            sch.AcceptChanges();
           

           
                q.CommandText = "update call set name=@name,phoneno=@no where id=@id";
                q.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = textBox1.Text;
                //q.Parameters.Add("@sname", SqlDbType.VarChar, 50).Value = textBox2.Text;
                q.Parameters.Add("@no", SqlDbType.VarChar, 50).Value = textBox2.Text;
                q.Parameters.Add("@id", SqlDbType.Int).Value = x;

                res = q.ExecuteNonQuery();

                if (res > 0)
                {

                    MessageBox.Show("Contact is updated");
                    textBox1.Clear();
                    textBox2.Clear();
                   
                    textBox4.Clear();
                    textBox4.Focus();
                }
                else
                {
                    MessageBox.Show("Contact is missing in our DB");
                    textBox4.Focus();
                }

                return;
            }

            // for saving
            q.CommandText = "insert into call(name,phoneno) values(@name,@no);Select @@IDENTITY";
            q.Parameters.Add("@name", SqlDbType.VarChar,50).Value = textBox1.Text;
            //q.Parameters.Add("@sname", SqlDbType.VarChar, 50).Value = textBox2.Text;
            q.Parameters.Add("@no", SqlDbType.VarChar, 50).Value = textBox2.Text;

            SqlDataReader rd = q.ExecuteReader();

            if (rd.RecordsAffected > 0)
            {
                rd.Read();
                DataRow nr = sch.Tables["call"].NewRow();
                nr["id"] = rd.GetDecimal(0).ToString();
                nr["name"] = textBox1.Text;
                //nr["surname"] = textBox3.Text;
                nr["phoneno"] = textBox2.Text;

                sch.Tables["call"].Rows.Add(nr);
                sch.AcceptChanges();
                MessageBox.Show("Contact saved.");
                textBox1.Clear();
                textBox2.Clear();
                
                textBox4.Clear();
                textBox4.Focus();
            }
            cnn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            
        }

        private void Form12_Shown(object sender, EventArgs e)
        {
            if (cnn.State != ConnectionState.Open) cnn.Open();

            da = new SqlDataAdapter("select name,phoneno,id from call order by id", cnn);

            da.Fill(sch, "call");
            sch.Tables["call"].PrimaryKey = new DataColumn[] { sch.Tables["call"].Columns["id"] };
            sch.Tables["call"].CaseSensitive = false;
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView.DataSource = sch;
            dataGridView.DataMember = "call";
            cnn.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //search button.
            Form14 kk = new Form14(textBox4.Text);
            DialogResult dlgres = kk.ShowDialog();
            textBox1.Text = kk.rcname;
            textBox2.Text = kk.rcno;
           
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form12_Resize(object sender, EventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
        }
    }
