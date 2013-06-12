namespace cal
{
    partial class Form16
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.subject,
            this.location,
            this.startdate,
            this.starttime,
            this.enddate,
            this.endtime,
            this.alarmtype,
            this.alarmdate,
            this.alarmtime,
            this.repeat});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1149, 290);
            this.dataGridView1.TabIndex = 3;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // subject
            // 
            this.subject.DataPropertyName = "subject";
            this.subject.HeaderText = "Subject";
            this.subject.Name = "subject";
            this.subject.Width = 150;
            // 
            // location
            // 
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            // 
            // startdate
            // 
            this.startdate.DataPropertyName = "startdate";
            this.startdate.HeaderText = "Start Date";
            this.startdate.Name = "startdate";
            // 
            // starttime
            // 
            this.starttime.DataPropertyName = "starttime";
            this.starttime.HeaderText = "Start Time";
            this.starttime.Name = "starttime";
            // 
            // enddate
            // 
            this.enddate.DataPropertyName = "enddate";
            this.enddate.HeaderText = "End Date";
            this.enddate.Name = "enddate";
            // 
            // endtime
            // 
            this.endtime.DataPropertyName = "endtime";
            this.endtime.HeaderText = "End Time";
            this.endtime.Name = "endtime";
            // 
            // alarmtype
            // 
            this.alarmtype.DataPropertyName = "alarmtype";
            this.alarmtype.HeaderText = "Alarm Type";
            this.alarmtype.Name = "alarmtype";
            // 
            // alarmdate
            // 
            this.alarmdate.DataPropertyName = "alarmdate";
            this.alarmdate.HeaderText = "Alarm Date";
            this.alarmdate.Name = "alarmdate";
            // 
            // alarmtime
            // 
            this.alarmtime.DataPropertyName = "alarmtime";
            this.alarmtime.HeaderText = "Alarm Time";
            this.alarmtime.Name = "alarmtime";
            // 
            // repeat
            // 
            this.repeat.DataPropertyName = "repeat";
            this.repeat.HeaderText = "Repeat";
            this.repeat.Name = "repeat";
            // 
            // button1
            // 
            this.button1.Image = global::cal.Properties.Resources._1225770321258316602emyller_close_button_svg1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(611, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1166, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form16";
            this.Text = "Meeting List";
            this.Load += new System.EventHandler(this.Form16_Load);
            this.Resize += new System.EventHandler(this.Form16_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeat;
    }
}