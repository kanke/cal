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
    public partial class Form2 : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kanke\Desktop\cal\cal\appoint.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
      
        DataSet sch = new DataSet();
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Time;

            dateTimePicker2.ShowUpDown = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox4.Clear();
            checkBox1.Checked = false;
            comboBox3.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            textBox4.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            textBox2.Text = textBox2.Text.Trim();
            textBox3.Text = textBox3.Text.Trim();
            textBox4.Text = textBox4.Text.Trim();
            int x = -1, res;
            bool itisanupdate = false;


            if (textBox4.Text.Length > 0)
            {
                bool ifint = int.TryParse(textBox4.Text, out x);
                if (!ifint)
                {
                    MessageBox.Show(" id has to be an integer");
                    cnn.Close();
                    return;
                }
                itisanupdate = true;
            }


            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Subject must be specified");
                return;
            }

            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Location must be specified");
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
                DataRow dr = sch.Tables["scheduling"].Rows.Find(x);
                if (dr == null)
                {
                    MessageBox.Show("Record not found");
                    return;
                }

                dr["id"] = textBox4.Text;
                dr["subject"] = textBox1.Text;
                dr["location"] = textBox2.Text;
                //sch.Tables["scheduling"].Rows.Add(dr);
                sch.AcceptChanges();


                q.CommandText = "update scheduling set subject=@sub,location=@loc,label=@lab,startime=@start,endtime=@end,status=@stat,description=@des,allday=@all,eventtype=@event where id=@id";

                q.Parameters.Add("@sub", SqlDbType.VarChar, 50).Value = textBox1.Text;
                q.Parameters.Add("@loc", SqlDbType.VarChar, 50).Value = textBox2.Text;
                q.Parameters.Add("@lab", SqlDbType.VarChar, 20).Value = comboBox1.Text;
                q.Parameters.Add("@start", SqlDbType.Time).Value = dateTimePicker2.Value.ToShortTimeString();
                q.Parameters.Add("@end", SqlDbType.Time).Value = dateTimePicker4.Value.ToShortTimeString();
                q.Parameters.Add("@stat", SqlDbType.VarChar, 20).Value = comboBox3.Text;
                q.Parameters.Add("@des", SqlDbType.VarChar, 50).Value = textBox3.Text;
                q.Parameters.Add("@all", SqlDbType.VarChar, 5).Value = checkBox1.Text;
                q.Parameters.Add("@event", SqlDbType.VarChar, 20).Value = textBox5.Text;
                q.Parameters.Add("@id", SqlDbType.Int).Value =x;

                res = q.ExecuteNonQuery();

                if (res > 0)
                {
                    MessageBox.Show("Record is updated");
                    textBox4.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    checkBox1.Checked = false;
                    comboBox3.SelectedIndex = -1;
                    comboBox1.SelectedIndex = -1;
                    textBox4.Focus();
                }
                else
                {
                    MessageBox.Show("schedule id is missing in our DB");
                    textBox4.Focus();
                }

                return;
            }

            // for saving
            q.CommandText = "insert into scheduling(subject,location,label,startime,endtime,status,description,allday,eventtype) values(@sub,@loc,@lab,@start,@end,@stat,@des,@all,@event);Select @@IDENTITY";
            q.Parameters.Add("@sub", SqlDbType.VarChar, 50).Value = textBox1.Text;
            q.Parameters.Add("@loc", SqlDbType.VarChar, 50).Value = textBox2.Text;
            q.Parameters.Add("@lab", SqlDbType.VarChar, 20).Value = comboBox1.Text;
            q.Parameters.Add("@start", SqlDbType.Time).Value = dateTimePicker2.Value.ToShortTimeString();
            q.Parameters.Add("@end", SqlDbType.Time).Value = dateTimePicker4.Value.ToShortTimeString();
            q.Parameters.Add("@stat", SqlDbType.VarChar, 20).Value = comboBox3.Text;
            q.Parameters.Add("@des", SqlDbType.VarChar, 50).Value = textBox3.Text;
            q.Parameters.Add("@all", SqlDbType.VarChar, 5).Value = checkBox1.Text;
            q.Parameters.Add("@event", SqlDbType.VarChar, 20).Value = textBox5.Text;
            SqlDataReader rd = q.ExecuteReader();
            
            if (rd.RecordsAffected > 0)
            {
                rd.Read();
                DataRow nr = sch.Tables["scheduling"].NewRow();
                nr["id"] = rd.GetDecimal(0).ToString();
                nr["subject"] = textBox1.Text;
                nr["location"] = textBox2.Text;
                sch.Tables["scheduling"].Rows.Add(nr);
                sch.AcceptChanges();
                MessageBox.Show("Record saved.");
                textBox4.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                checkBox1.Checked = false;
                comboBox3.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                textBox4.Focus();

            }

            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete button.
            if (cnn.State!=ConnectionState.Open) cnn.Open();
            textBox4.Text = textBox4.Text.Trim();
            if (textBox4.Text.Length == 0)
            {
                MessageBox.Show("Please type something to search");
                return;
            }
            int id;
            bool ifint = int.TryParse(textBox4.Text, out id);
            if (!ifint)
            {
                MessageBox.Show("Schedule id has to be an integer");
                return;
            }

            DataRow dr = sch.Tables["scheduling"].Rows.Find(id);
            if (dr == null)
            {
                MessageBox.Show("Record not found");
                return;
            }
            dr.Delete();
            sch.AcceptChanges();
            
            if (cnn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Connection Error !");
                return;
            }

            //connectn sql cmd to d main connectn
            SqlCommand q = new SqlCommand();
            q.Connection = cnn;

            q.CommandType = CommandType.Text;
            q.CommandText = "delete from scheduling where id=@id";
            q.Parameters.Add("@id", SqlDbType.Int).Value = id;

            int res = q.ExecuteNonQuery();

            if (res > 0)
            {
                MessageBox.Show("Record with id '" + textBox4.Text + "' deleted.");
                textBox4.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                checkBox1.Checked = false;
                comboBox3.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                textBox4.Focus();
            }
            else
            {
                MessageBox.Show("Record with id '" + textBox4.Text + "' not found.");
                textBox4.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                checkBox1.Checked = false;
                comboBox3.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                textBox4.Focus();
            }
            cnn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from scheduling order by id", cnn);

            da.Fill(sch, "scheduling");
            sch.Tables["scheduling"].PrimaryKey = new DataColumn[] { sch.Tables["scheduling"].Columns["id"] };
            sch.Tables["scheduling"].CaseSensitive = false;
            //dataGridView1.AutoGenerateColumns = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
           
        }

        private void label9_Resize(object sender, EventArgs e)
        {

        }
    }
}
      