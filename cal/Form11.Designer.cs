namespace cal
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remindabout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Olive;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.remindabout,
            this.date,
            this.alarm,
            this.alarmtime,
            this.repeat});
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // remindabout
            // 
            this.remindabout.DataPropertyName = "remindabout";
            this.remindabout.HeaderText = "Remind About";
            this.remindabout.Name = "remindabout";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // alarm
            // 
            this.alarm.DataPropertyName = "alarm";
            this.alarm.HeaderText = "Alarm";
            this.alarm.Name = "alarm";
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
            this.button1.Location = new System.Drawing.Point(232, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(611, 299);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "List Reminders";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.Resize += new System.EventHandler(this.Form11_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn remindabout;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeat;
    }
}