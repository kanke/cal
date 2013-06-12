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
    public partial class Form7 : Form
    {
        private DateTime alarmTime;
        private bool alarmEnabled;
        private string alarmSound;
        private string alarmMessage;

        private System.Media.SoundPlayer player = new System.Media.SoundPlayer();


        SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\kanke\Desktop\cal\cal\appoint.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter da;
        DataSet sch = new DataSet();
        public Form7()
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
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete button.
            if (cnn.State != ConnectionState.Open) cnn.Open();
            textBox1.Text = textBox1.Text.Trim();
            textBox3.Text = textBox3.Text.Trim();
         
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Please type id to search");
                return;
            }
            int id;
            bool ifint = int.TryParse(textBox3.Text, out id);
            if (!ifint)
            {
                MessageBox.Show(" id has to be an integer");
                return;
            }
            DataRow dr = sch.Tables["reminder"].Rows.Find(id);
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
            q.CommandText = "delete from reminder where id=@id";
            q.Parameters.Add("@id", SqlDbType.Int).Value = id;


            int res = q.ExecuteNonQuery();

            if (res > 0)
            {
                MessageBox.Show("Record with id '" + textBox1.Text + "' deleted.");
                textBox1.Clear();
                textBox3.Clear();
                comboBox2.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                textBox3.Focus();
            }

            else
            {
                MessageBox.Show("Record with id '" + textBox1.Text + "' not found.");
                textBox1.Clear();
                textBox3.Clear();
                comboBox2.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                textBox3.Focus();
            }
            cnn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            alarmSound = @"C:\Users\kanke\Desktop\cal\cal\Resources\alarm.wav";
            if (alarmSound.Length > 0)
            {
                player.SoundLocation = alarmSound;
                player.Load();
            }

            alarmMessage = "Attention!";
            
            String str = "Alarm on";
            
            str = comboBox1.Text;

            if (str == "Alarm on")
            {
                alarmTime = dateTimePicker6.Value;
                RolloverTime();
            }
            if (str != "Alarm on")
            {
                return;
            }
            
        

            if (comboBox1.Text.Length > 0)
            {
                timer1.Enabled = true;
            }

            
            //save button.
            textBox1.Text = textBox1.Text.Trim();
            textBox3.Text = textBox3.Text.Trim();
            int x = -1,res;
            bool itisanupdate = false;

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Remind about must be specified");
                return;
            }

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
            DataRow dr = sch.Tables["reminder"].Rows.Find(x);
            if (dr == null)
            {
                MessageBox.Show("Record not found");
                return;
            }

            dr["id"] = textBox3.Text;
            dr["remindabout"] = textBox1.Text;
            //sch.Tables["reminder"].Rows.Add(dr);
            sch.AcceptChanges();
           
                q.CommandText = "update reminder set remindabout=@rmnd,date=@date,alarm=@alarm,alarmtime=@atime,repeat=@repeat where id=@id";
                q.Parameters.Add("@rmnd", SqlDbType.VarChar, 50).Value = textBox1.Text;
                q.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value.ToShortDateString();
                q.Parameters.Add("@alarm", SqlDbType.VarChar, 10).Value = comboBox1.Text;
                q.Parameters.Add("@atime", SqlDbType.Time).Value = dateTimePicker6.Value.ToShortTimeString();
                q.Parameters.Add("@repeat", SqlDbType.VarChar, 20).Value = comboBox2.Text;
                q.Parameters.Add("@id", SqlDbType.Int).Value =x;
                res = q.ExecuteNonQuery();

                if (res > 0)
                {

                    MessageBox.Show("Record is updated");
                    textBox1.Clear();
                    textBox3.Clear();
                    comboBox2.SelectedIndex = -1;
                    comboBox1.SelectedIndex = -1;
                    textBox3.Focus();
                }
                else
                {
                    MessageBox.Show("reminder is missing in our DB");
                    textBox3.Focus();
                }

                return;
            }

            // for saving
            q.CommandText = "insert into reminder(remindabout,date,alarm,alarmtime,repeat) values(@rmnd,@date,@alarm,@atime,@repeat);Select @@IDENTITY";
            q.Parameters.Add("@rmnd", SqlDbType.VarChar, 50).Value = textBox1.Text;
            q.Parameters.Add("@date", SqlDbType.Date).Value = dateTimePicker1.Value.ToShortDateString();
            q.Parameters.Add("@alarm", SqlDbType.VarChar, 10).Value = comboBox1.Text;
            q.Parameters.Add("@atime", SqlDbType.Time).Value = dateTimePicker6.Value.ToShortTimeString();
            q.Parameters.Add("@repeat", SqlDbType.VarChar, 20).Value = comboBox2.Text;
            SqlDataReader rd = q.ExecuteReader();

            if (rd.RecordsAffected > 0)
            {
                rd.Read();
                DataRow nr = sch.Tables["reminder"].NewRow();
                nr["id"] = rd.GetDecimal(0).ToString();
                nr["remindabout"] = textBox1.Text;
                sch.Tables["reminder"].Rows.Add(nr);
                sch.AcceptChanges();
                MessageBox.Show("Record saved.");
                textBox1.Clear();
                textBox3.Clear();
                comboBox2.SelectedIndex = -1;
                comboBox1.SelectedIndex = -1;
                textBox3.Focus();
            }
            cnn.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            alarmEnabled = false;
            notifyIcon1.Visible = true;

            // Initialize the various values for consistency
            alarmTime = DateTime.Now;
            dateTimePicker6.Value = alarmTime;
            alarmMessage = "Attention!";

            da = new SqlDataAdapter("select * from reminder order by id", cnn);
            da.Fill(sch, "reminder");
            sch.Tables["reminder"].PrimaryKey = new DataColumn[] { sch.Tables["reminder"].Columns["id"] };
            sch.Tables["reminder"].CaseSensitive = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form7_Resize(object sender, EventArgs e)
        {
            
        }

        private void ttingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarmEnabled = !enabledToolStripMenuItem.Checked;
            enabledToolStripMenuItem.Checked = alarmEnabled;


            // Set the time for the current or next day accordingly
            RolloverTime();

            // Activate/deactive the timer
            timer1.Enabled = alarmEnabled;

            ContextMenuStrip.Hide();
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

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip.Show();
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip.Hide();
            this.Show();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            // When the user stops the alarm...
            player.Stop();
            RolloverTime();
        }
    }
}
