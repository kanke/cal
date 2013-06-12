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
    public partial class Form3 : Form
    {
        private DateTime alarmTime;
        private bool alarmEnabled;
        private string alarmSound;
        private string alarmMessage;

        private System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kanke\Desktop\cal\cal\appoint.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        DataSet sch = new DataSet();
        public Form3()
        {
            InitializeComponent();
        }

        private void RolloverTime()
        {
            // If the user selects a time already passed, it must be for tomorrow
            if (DateTime.Now.TimeOfDay.CompareTo(alarmTime.TimeOfDay) > 0)
            {
                alarmTime = new DateTime(DateTime.Now.Year,
                    DateTime.Now.Month, DateTime.Now.Day + 1,
                    alarmTime.Hour, alarmTime.Minute, alarmTime.Second);
            }
            // Otherwise, set it for today
            else
            {
                alarmTime = new DateTime(DateTime.Now.Year,
                    DateTime.Now.Month, DateTime.Now.Day,
                    alarmTime.Hour, alarmTime.Minute, alarmTime.Second);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            textBox3.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (cnn.State != ConnectionState.Open) cnn.Open();
          
            textBox3.Text = textBox3.Text.Trim();
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Please type something to search");
                return;
            }

            int id;
            bool ifint = int.TryParse(textBox3.Text, out id);
            if (!ifint)
            {
                MessageBox.Show("meeting id has to be an integer");
                return;
            }


            DataRow dr = sch.Tables["meeting"].Rows.Find(id);
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
            q.CommandText = "delete from meeting where id=@id";
            q.Parameters.Add("@id", SqlDbType.Int).Value = id;
             

            int res = q.ExecuteNonQuery();

            if (res > 0)
            {
                MessageBox.Show("Record with id '" + textBox3.Text + "' deleted.");
                 textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox2.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                textBox3.Focus();
            }

            else
            {
                MessageBox.Show("Record with id '" + textBox3.Text + "' not found.");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox2.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                textBox3.Focus();
            }
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            alarmSound = @"C:\Users\kanke\Desktop\cal\cal\Resources\alarm.wav";
            if (alarmSound.Length > 0)
            {
                player.SoundLocation = alarmSound;
                player.Load();
            }

            alarmMessage = "Attention!";

            String str = "With tone";

            str  = comboBox1.Text;

            if (str == "With tone")
            {
                alarmTime = dateTimePicker6.Value;
                RolloverTime();
            }
            if (str == "Silent"|| str== "No alarm")
            {
                return;
            }


            if (comboBox1.Text.Length > 0)
            {
                timer1.Enabled = true;
            }

            //for record
            textBox1.Text = textBox1.Text.Trim();
            textBox2.Text = textBox2.Text.Trim();
            textBox3.Text= textBox3.Text.Trim();
            
            int x = -1, res;
            bool itisanupdate = false;

            if (textBox3.Text.Length > 0)
            {
                bool ifint = int.TryParse(textBox3.Text, out x);
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

            DataRow dr = sch.Tables["meeting"].Rows.Find(x);
            if (dr == null)
                {
                MessageBox.Show("Record not found");
                return;

                }

            dr["id"] = textBox3.Text;
            dr["subject"] = textBox1.Text;
            dr["location"] = textBox2.Text;
            //sch.Tables["meeting"].Rows.Add(dr);
            sch.AcceptChanges();

            
                q.CommandText = "update meeting set subject=@sub,location=@loc,starttime=@start,startdate=@sdate,endtime=@end,enddate=@edate,alarmtype=@type,alarmdate=@adate,alarmtime=@atime,repeat=@repeat where id=@id";
                q.Parameters.Add("@sub", SqlDbType.VarChar, 50).Value = textBox1.Text;
                q.Parameters.Add("@loc", SqlDbType.VarChar, 50).Value = textBox2.Text;
                q.Parameters.Add("@start", SqlDbType.Time).Value = dateTimePicker2.Value.ToShortTimeString();
                q.Parameters.Add("@sdate", SqlDbType.Date).Value = dateTimePicker1.Value.ToShortDateString();
                q.Parameters.Add("@end", SqlDbType.Time).Value = dateTimePicker4.Value.ToShortTimeString();
                q.Parameters.Add("@edate", SqlDbType.Date).Value = dateTimePicker3.Value.ToShortDateString();
                q.Parameters.Add("@type", SqlDbType.VarChar, 12).Value = comboBox1.Text;
                q.Parameters.Add("@adate", SqlDbType.Date).Value = dateTimePicker5.Value.ToShortDateString();
                q.Parameters.Add("@atime", SqlDbType.Time).Value = dateTimePicker6.Value.ToShortTimeString();
                q.Parameters.Add("@repeat", SqlDbType.VarChar, 20).Value = comboBox2.Text;
                q.Parameters.Add("@id", SqlDbType.Int).Value =x;



              res = q.ExecuteNonQuery();

                if (res > 0)
                {
              
                MessageBox.Show("Record is updated");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox2.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                textBox3.Focus();
                }
                else
                {
                    MessageBox.Show("meeting id is missing in our DB");
                    textBox3.Focus();
                }

                return;
            }

            // for saving
            q.CommandText = "insert into meeting(subject,location,starttime,startdate,endtime,enddate,alarmtype,alarmdate,alarmtime,repeat) values(@sub,@loc,@start,@sdate,@end,@edate,@type,@adate,@atime,@repeat);Select @@IDENTITY";
            q.Parameters.Add("@sub", SqlDbType.VarChar, 50).Value = textBox1.Text;
                q.Parameters.Add("@loc", SqlDbType.VarChar, 50).Value = textBox2.Text;
                q.Parameters.Add("@start", SqlDbType.Time).Value = dateTimePicker2.Value.ToShortTimeString();
                q.Parameters.Add("@sdate", SqlDbType.Date).Value = dateTimePicker1.Value.ToShortDateString();
                q.Parameters.Add("@end", SqlDbType.Time).Value = dateTimePicker4.Value.ToShortTimeString();
                q.Parameters.Add("@edate", SqlDbType.Date).Value = dateTimePicker3.Value.ToShortDateString();
                q.Parameters.Add("@type", SqlDbType.VarChar, 20).Value = comboBox1.Text;
                q.Parameters.Add("@adate", SqlDbType.Date).Value = dateTimePicker5.Value.ToShortDateString();
                q.Parameters.Add("@atime", SqlDbType.Time).Value = dateTimePicker6.Value.ToShortTimeString();
                q.Parameters.Add("@repeat", SqlDbType.VarChar, 20).Value = comboBox2.Text;
                SqlDataReader rd = q.ExecuteReader();

                if (rd.RecordsAffected > 0)
                {
                    rd.Read();
                    DataRow nr = sch.Tables["meeting"].NewRow();
                    nr["id"] = rd.GetDecimal(0).ToString();
                    nr["subject"] = textBox1.Text;
                    nr["location"] = textBox2.Text;
                    sch.Tables["meeting"].Rows.Add(nr);
                    sch.AcceptChanges();
                MessageBox.Show("Record saved.");
                 textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox2.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                textBox3.Focus();
            }
                cnn.Close();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

        }

        
        private void Form3_Load(object sender, EventArgs e)
        {

            alarmEnabled = false;
            notifyIcon1.Visible = true;

            // Initialize the various values for consistency
            alarmTime = DateTime.Now;
            dateTimePicker6.Value = alarmTime;
            alarmMessage = "Attention!";

             
            
            
            SqlDataAdapter da = new SqlDataAdapter("select * from meeting order by id", cnn);
            da.Fill(sch, "meeting");
            sch.Tables["meeting"].PrimaryKey = new DataColumn[] { sch.Tables["meeting"].Columns["id"] };
            sch.Tables["meeting"].CaseSensitive = false;

           
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form3_Resize(object sender, EventArgs e)
        {
           
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {


            if (DateTime.Now.CompareTo(alarmTime) >= 0)
            {
                // Add a day to the alarm to reset it for the next day
                RolloverTime();

                // Show the notification for up to a minute.
                // After that, no one must be paying attention!
                notifyIcon1.BalloonTipText =
                    (alarmMessage.Length > 0 ? alarmMessage : "Attention!");
                notifyIcon1.ShowBalloonTip(120000);

                // Play the alarm sound
                if (alarmSound.Length > 0)
                {
                    player.PlayLooping();
                }
            }
        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip.Hide();
            this.Show();
        }

        private void enabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Toggle the checkbox on the menu item
            alarmEnabled = !enabledToolStripMenuItem.Checked;
            enabledToolStripMenuItem.Checked = alarmEnabled;
            

            // Set the time for the current or next day accordingly
            RolloverTime();

            // Activate/deactive the timer
            timer1.Enabled = alarmEnabled;

            ContextMenuStrip.Hide();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            // When the user stops the alarm...
            player.Stop();
            RolloverTime();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip.Show();
            }
        }
        }
        }
