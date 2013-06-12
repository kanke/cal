using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cal
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        
        private void monthCalendar1_DayQueryInfo(object sender, Pabo.Calendar.DayQueryInfoEventArgs e)
        {
// Check date
    if (e.Date.DayOfWeek == DayOfWeek.Thursday)  
    {
       // Add custom formatting
       e.Info.BackColor1 = Color.Yellow;
       e.Info.BackColor2 = Color.GhostWhite;
       e.Info.ImageListIndex = 3; 
       e.Info.GradientMode= Pabo.Calendar.mcGradientMode.Horizontal;
       // Set ownerdraw = true to add custom formatting
       e.OwnerDraw = true; 
    }
}

        private void monthCalendar1_DayRender(object sender, Pabo.Calendar.DayRenderEventArgs e)
        {
            
        Brush bgBrush =  new SolidBrush(Color.White);
        Brush dateBrush = new SolidBrush(Color.Black); 
        Font dateFont = new Font("Microsoft Sans Serif",(float)8.25);
        StringFormat dateAlign = new StringFormat();

        dateAlign.Alignment = StringAlignment.Far;   
        dateAlign.LineAlignment = StringAlignment.Near;

        Rectangle rect = new Rectangle(0,0,e.Width,e.Height); 

        // Set OwnerDraw = true to override built in formatting...
        e.OwnerDraw = true; 
        // ...then Draw the appearance of the date
        e.Graphics.FillRectangle(bgBrush,rect);
        e.Graphics.DrawString(e.Date.Day.ToString(), 
                   dateFont,dateBrush,rect,dateAlign);

        // Clean up
        bgBrush.Dispose();
        dateBrush.Dispose();
        dateAlign.Dispose();
        dateFont.Dispose();
}

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_MonthChanged(object sender, Pabo.Calendar.MonthChangedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form9_Resize(object sender, EventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
        }
        }
    
