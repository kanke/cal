namespace cal
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.monthCalendar1 = new Pabo.Calendar.MonthCalendar();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ActiveMonth.Month = 5;
            this.monthCalendar1.ActiveMonth.Year = 2010;
            this.monthCalendar1.Culture = new System.Globalization.CultureInfo("en-GB");
            this.monthCalendar1.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar1.ImageList = null;
            this.monthCalendar1.Location = new System.Drawing.Point(1, 2);
            this.monthCalendar1.MaxDate = new System.DateTime(2020, 5, 10, 21, 1, 18, 135);
            this.monthCalendar1.MinDate = new System.DateTime(2000, 5, 10, 21, 1, 18, 135);
            this.monthCalendar1.Month.BackgroundImage = null;
            this.monthCalendar1.Month.Colors.BackColor1 = System.Drawing.Color.Gold;
            this.monthCalendar1.Month.Colors.BackColor2 = System.Drawing.Color.DarkRed;
            this.monthCalendar1.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.Size = new System.Drawing.Size(370, 290);
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.DayRender += new Pabo.Calendar.DayRenderEventHandler(this.monthCalendar1_DayRender);
            this.monthCalendar1.DayQueryInfo += new Pabo.Calendar.DayQueryInfoEventHandler(this.monthCalendar1_DayQueryInfo);
            this.monthCalendar1.MonthChanged += new Pabo.Calendar.MonthChangedEventHandler(this.monthCalendar1_MonthChanged);
            // 
            // button3
            // 
            this.button3.Image = global::cal.Properties.Resources._1225770321258316602emyller_close_button_svg1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(236, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 333);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.Text = "Month View";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.Resize += new System.EventHandler(this.Form9_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Pabo.Calendar.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button3;
    }
}