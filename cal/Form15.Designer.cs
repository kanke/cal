namespace cal
{
    partial class Form15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.subject,
            this.startdate,
            this.enddate,
            this.alarmtype,
            this.alarmdate,
            this.alarmtime,
            this.repeat});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(859, 340);
            this.dataGridView1.TabIndex = 19;
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
            // startdate
            // 
            this.startdate.DataPropertyName = "startdate";
            this.startdate.HeaderText = "Start Date";
            this.startdate.Name = "startdate";
            // 
            // enddate
            // 
            this.enddate.DataPropertyName = "enddate";
            this.enddate.HeaderText = "End Date";
            this.enddate.Name = "enddate";
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
            this.repeat.HeaderText = "Reapeat";
            this.repeat.Name = "repeat";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::cal.Properties.Resources._1225770321258316602emyller_close_button_svg1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(450, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(883, 382);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form15";
            this.Text = "View Memo";
            this.Load += new System.EventHandler(this.Form15_Load);
            this.Resize += new System.EventHandler(this.Form15_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeat;
    }
}