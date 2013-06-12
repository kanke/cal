namespace cal
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.dateofbirth,
            this.yearofbirth,
            this.alarmtype,
            this.alarmdate,
            this.alarmtime});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // dateofbirth
            // 
            this.dateofbirth.DataPropertyName = "dateofbirth";
            this.dateofbirth.HeaderText = "Date of Birth";
            this.dateofbirth.Name = "dateofbirth";
            // 
            // yearofbirth
            // 
            this.yearofbirth.DataPropertyName = "yearofbirth";
            this.yearofbirth.HeaderText = "Year of Birth";
            this.yearofbirth.Name = "yearofbirth";
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
            // button1
            // 
            this.button1.Image = global::cal.Properties.Resources._1225770321258316602emyller_close_button_svg1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(363, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(768, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.Text = "View Birthdays";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.Resize += new System.EventHandler(this.Form10_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmtime;


    }
}