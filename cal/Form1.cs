using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace cal
{
    public partial class Form1 : Form
    {
        class TestObject
        {
            public int OneValue { get; set; }
            public int TwoValue { get; set; }
        }

        public Form1()
        {
            InitializeComponent();

            TestObject test = new TestObject
            {
                OneValue = 5,
                TwoValue = 4
            };
            //
            // Send argument to our worker thread
            //
            backgroundWorker1.RunWorkerAsync(test);

        }
      
        private void dayViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        
        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearfont();
            comicSansToolStripMenuItem.Checked = true;
            label4.Font = new Font("comic sans", 12, label1.Font.Style);
            label2.Font = new Font("comic sans", 12, label1.Font.Style);
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearfont();
            courierToolStripMenuItem.Checked = true;
            label4.Font = new Font("courier new", 12, label1.Font.Style);
            label2.Font = new Font("courier new", 12, label1.Font.Style);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Time_Click(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void Date_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void schedulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void schedulerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearcolor()
        {
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            bToolStripMenuItem.Checked = false;
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearcolor();
            label4.ForeColor = Color.Green;
            bToolStripMenuItem.Checked = true;

            label2.ForeColor = Color.Green;
            bToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearcolor();
            label4.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;

            label2.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearcolor();
            label4.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;

            label2.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearcolor();
            label4.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;

            label2.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearfont()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            comicSansToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
        }

        

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;
            label4.Font = new Font(label1.Font.FontFamily, 12,
                label4.Font.Style ^ FontStyle.Italic);
            label2.Font = new Font(label1.Font.FontFamily, 12,
               label2.Font.Style ^ FontStyle.Italic);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            label4.Font = new Font(label1.Font.FontFamily, 12,
                label4.Font.Style ^ FontStyle.Bold);
            label2.Font = new Font(label1.Font.FontFamily, 12,
                label2.Font.Style ^ FontStyle.Bold);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearfont();
            timesNewRomanToolStripMenuItem.Checked = true;
            label4.Font = new Font("times new roman", 12, label1.Font.Style);
            label2.Font = new Font("times new roman", 12, label1.Font.Style);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutBox1 frm = new AboutBox1();
            frm.ShowDialog();
            this.Show();
        
        }

        private void meetingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 frm = new Form3();
            frm.ShowDialog();
            this.Show();
        }

        private void callToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm = new Form4();
            frm.ShowDialog();
            this.Show();
        }

        private void birthdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm = new Form5();
            frm.ShowDialog();
            this.Show();
        }

        private void memoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm = new Form6();
            frm.ShowDialog();
            this.Show();
        }

        private void reminderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form7 frm = new Form7();
            frm.ShowDialog();
            this.Show();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 frm = new Form8();
            frm.ShowDialog();
            this.Show();
        }

       
        private void monthCalendar2_MonthChanged(object sender, Pabo.Calendar.MonthChangedEventArgs e)
        {
           
            
        }

        private void dayViewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 frm = new Form13();
            frm.ShowDialog();
            this.Show();
        }

        private void monthViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 frm = new Form9();
            frm.ShowDialog();
            this.Show();
        }

        private void weekViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 frm = new Form11();
            frm.ShowDialog();
            this.Show();
        }

        private void viewReminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 frm = new Form14();
            frm.ShowDialog();
            this.Show();
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.ShowDialog();
            this.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog newdialog = new OpenFileDialog();
            newdialog.Filter = " Jpg files (*.jpg)|*.jpg" ;
            newdialog.InitialDirectory = @"C:\";

            if (newdialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(newdialog.FileName);
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            toolStripLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("notepad");
        }

        private void callToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 frm = new Form12();
            frm.ShowDialog();
            this.Show();
        }

        private void viewBirthdaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 frm = new Form10();
            frm.ShowDialog();
            this.Show();
        }

        private void viewMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 frm = new Form15();
            frm.ShowDialog();
            this.Show();
        }

        private void meetingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 frm = new Form16();
            frm.ShowDialog();
            this.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Kanke's calendar ";
            notifyIcon1.BalloonTipText = "You have successfully minimized your calendar.";

            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
           
        



        }
        

      
        
       
    }
