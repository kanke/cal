namespace cal
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem deleteAppointmentToolStripMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comicSansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReminderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBirthdaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeNewNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birthdayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reminderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeViewToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayViewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.workViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weekViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timelineViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            deleteAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 85);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.schedulerToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.schedulerToolStripMenuItem1,
            this.makeNewNoteToolStripMenuItem,
            this.changeViewToToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(483, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // schedulerToolStripMenuItem
            // 
            this.schedulerToolStripMenuItem.Name = "schedulerToolStripMenuItem";
            this.schedulerToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.schedulerToolStripMenuItem.Text = "&Time";
            this.schedulerToolStripMenuItem.Click += new System.EventHandler(this.schedulerToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dateToolStripMenuItem.Text = "&Date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayViewToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.viewToolStripMenuItem.Text = "&Format";
            // 
            // dayViewToolStripMenuItem
            // 
            this.dayViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bToolStripMenuItem,
            this.redToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.dayViewToolStripMenuItem.Name = "dayViewToolStripMenuItem";
            this.dayViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dayViewToolStripMenuItem.Text = "Color";
            this.dayViewToolStripMenuItem.Click += new System.EventHandler(this.dayViewToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.bToolStripMenuItem.Text = "Green";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesNewRomanToolStripMenuItem,
            this.comicSansToolStripMenuItem,
            this.courierToolStripMenuItem,
            this.toolStripSeparator1,
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // timesNewRomanToolStripMenuItem
            // 
            this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            this.timesNewRomanToolStripMenuItem.Click += new System.EventHandler(this.timesNewRomanToolStripMenuItem_Click);
            // 
            // comicSansToolStripMenuItem
            // 
            this.comicSansToolStripMenuItem.Name = "comicSansToolStripMenuItem";
            this.comicSansToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.comicSansToolStripMenuItem.Text = "Comic sans";
            this.comicSansToolStripMenuItem.Click += new System.EventHandler(this.comicSansToolStripMenuItem_Click);
            // 
            // courierToolStripMenuItem
            // 
            this.courierToolStripMenuItem.Name = "courierToolStripMenuItem";
            this.courierToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.courierToolStripMenuItem.Text = "Courier";
            this.courierToolStripMenuItem.Click += new System.EventHandler(this.courierToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // schedulerToolStripMenuItem1
            // 
            this.schedulerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.viewAllToolStripMenuItem,
            deleteAppointmentToolStripMenuItem,
            this.viewReminderToolStripMenuItem,
            this.viewBirthdaysToolStripMenuItem,
            this.viewMemoToolStripMenuItem,
            this.meetingListToolStripMenuItem});
            this.schedulerToolStripMenuItem1.Name = "schedulerToolStripMenuItem1";
            this.schedulerToolStripMenuItem1.Size = new System.Drawing.Size(90, 20);
            this.schedulerToolStripMenuItem1.Text = "&Appointment";
            this.schedulerToolStripMenuItem1.Click += new System.EventHandler(this.schedulerToolStripMenuItem1_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentToolStripMenuItem,
            this.callToolStripMenuItem1});
            this.addNewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewToolStripMenuItem.Image")));
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addNewToolStripMenuItem.Text = "Add new";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("appointmentToolStripMenuItem.Image")));
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            this.appointmentToolStripMenuItem.Click += new System.EventHandler(this.appointmentToolStripMenuItem_Click);
            // 
            // callToolStripMenuItem1
            // 
            this.callToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("callToolStripMenuItem1.Image")));
            this.callToolStripMenuItem1.Name = "callToolStripMenuItem1";
            this.callToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.callToolStripMenuItem1.Text = "Contact";
            this.callToolStripMenuItem1.Click += new System.EventHandler(this.callToolStripMenuItem1_Click);
            // 
            // viewAllToolStripMenuItem
            // 
            this.viewAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewAllToolStripMenuItem.Image")));
            this.viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            this.viewAllToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.viewAllToolStripMenuItem.Text = "View appointment";
            this.viewAllToolStripMenuItem.Click += new System.EventHandler(this.viewAllToolStripMenuItem_Click);
            // 
            // deleteAppointmentToolStripMenuItem
            // 
            deleteAppointmentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteAppointmentToolStripMenuItem.Image")));
            deleteAppointmentToolStripMenuItem.Name = "deleteAppointmentToolStripMenuItem";
            deleteAppointmentToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            deleteAppointmentToolStripMenuItem.Text = "List Reminders";
            deleteAppointmentToolStripMenuItem.Click += new System.EventHandler(this.deleteAppointmentToolStripMenuItem_Click);
            // 
            // viewReminderToolStripMenuItem
            // 
            this.viewReminderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewReminderToolStripMenuItem.Image")));
            this.viewReminderToolStripMenuItem.Name = "viewReminderToolStripMenuItem";
            this.viewReminderToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.viewReminderToolStripMenuItem.Text = "view Contacts";
            this.viewReminderToolStripMenuItem.Click += new System.EventHandler(this.viewReminderToolStripMenuItem_Click);
            // 
            // viewBirthdaysToolStripMenuItem
            // 
            this.viewBirthdaysToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBirthdaysToolStripMenuItem.Image")));
            this.viewBirthdaysToolStripMenuItem.Name = "viewBirthdaysToolStripMenuItem";
            this.viewBirthdaysToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.viewBirthdaysToolStripMenuItem.Text = "View Birthdays";
            this.viewBirthdaysToolStripMenuItem.Click += new System.EventHandler(this.viewBirthdaysToolStripMenuItem_Click);
            // 
            // viewMemoToolStripMenuItem
            // 
            this.viewMemoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewMemoToolStripMenuItem.Image")));
            this.viewMemoToolStripMenuItem.Name = "viewMemoToolStripMenuItem";
            this.viewMemoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.viewMemoToolStripMenuItem.Text = "View Memo";
            this.viewMemoToolStripMenuItem.Click += new System.EventHandler(this.viewMemoToolStripMenuItem_Click);
            // 
            // meetingListToolStripMenuItem
            // 
            this.meetingListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("meetingListToolStripMenuItem.Image")));
            this.meetingListToolStripMenuItem.Name = "meetingListToolStripMenuItem";
            this.meetingListToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.meetingListToolStripMenuItem.Text = "Meeting List";
            this.meetingListToolStripMenuItem.Click += new System.EventHandler(this.meetingListToolStripMenuItem_Click);
            // 
            // makeNewNoteToolStripMenuItem
            // 
            this.makeNewNoteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meetingToolStripMenuItem,
            this.callToolStripMenuItem,
            this.birthdayToolStripMenuItem,
            this.memoToolStripMenuItem,
            this.reminderToolStripMenuItem});
            this.makeNewNoteToolStripMenuItem.Name = "makeNewNoteToolStripMenuItem";
            this.makeNewNoteToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.makeNewNoteToolStripMenuItem.Text = "&Make new note";
            // 
            // meetingToolStripMenuItem
            // 
            this.meetingToolStripMenuItem.Image = global::cal.Properties.Resources._0755_royalty_free_rf_clipart_illustration_businessman_holds_cup_of_coffee;
            this.meetingToolStripMenuItem.Name = "meetingToolStripMenuItem";
            this.meetingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.meetingToolStripMenuItem.Text = "Meeting";
            this.meetingToolStripMenuItem.Click += new System.EventHandler(this.meetingToolStripMenuItem_Click);
            // 
            // callToolStripMenuItem
            // 
            this.callToolStripMenuItem.Image = global::cal.Properties.Resources.businessman;
            this.callToolStripMenuItem.Name = "callToolStripMenuItem";
            this.callToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.callToolStripMenuItem.Text = "Call";
            this.callToolStripMenuItem.Click += new System.EventHandler(this.callToolStripMenuItem_Click);
            // 
            // birthdayToolStripMenuItem
            // 
            this.birthdayToolStripMenuItem.Image = global::cal.Properties.Resources._0378_royalty_free_rf_clipart_illustration;
            this.birthdayToolStripMenuItem.Name = "birthdayToolStripMenuItem";
            this.birthdayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.birthdayToolStripMenuItem.Text = "Birthday";
            this.birthdayToolStripMenuItem.Click += new System.EventHandler(this.birthdayToolStripMenuItem_Click);
            // 
            // memoToolStripMenuItem
            // 
            this.memoToolStripMenuItem.Image = global::cal.Properties.Resources._0511_0708_0213_0744;
            this.memoToolStripMenuItem.Name = "memoToolStripMenuItem";
            this.memoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.memoToolStripMenuItem.Text = "Memo";
            this.memoToolStripMenuItem.Click += new System.EventHandler(this.memoToolStripMenuItem_Click);
            // 
            // reminderToolStripMenuItem
            // 
            this.reminderToolStripMenuItem.Image = global::cal.Properties.Resources._0568_royalty_free_rf_clipart_illustration_dog_holds_newspaper_in_mouth;
            this.reminderToolStripMenuItem.Name = "reminderToolStripMenuItem";
            this.reminderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reminderToolStripMenuItem.Text = "Reminder";
            this.reminderToolStripMenuItem.Click += new System.EventHandler(this.reminderToolStripMenuItem_Click);
            // 
            // changeViewToToolStripMenuItem
            // 
            this.changeViewToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayViewToolStripMenuItem1,
            this.workViewToolStripMenuItem,
            this.weekViewToolStripMenuItem,
            this.monthViewToolStripMenuItem,
            this.timelineViewToolStripMenuItem});
            this.changeViewToToolStripMenuItem.Name = "changeViewToToolStripMenuItem";
            this.changeViewToToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.changeViewToToolStripMenuItem.Text = "&Change view to";
            // 
            // dayViewToolStripMenuItem1
            // 
            this.dayViewToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("dayViewToolStripMenuItem1.Image")));
            this.dayViewToolStripMenuItem1.Name = "dayViewToolStripMenuItem1";
            this.dayViewToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dayViewToolStripMenuItem1.Text = "&Day view";
            this.dayViewToolStripMenuItem1.Click += new System.EventHandler(this.dayViewToolStripMenuItem1_Click);
            // 
            // workViewToolStripMenuItem
            // 
            this.workViewToolStripMenuItem.Name = "workViewToolStripMenuItem";
            this.workViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.workViewToolStripMenuItem.Text = "Wo&rk view";
            // 
            // weekViewToolStripMenuItem
            // 
            this.weekViewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("weekViewToolStripMenuItem.Image")));
            this.weekViewToolStripMenuItem.Name = "weekViewToolStripMenuItem";
            this.weekViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.weekViewToolStripMenuItem.Text = "&Week view";
            this.weekViewToolStripMenuItem.Click += new System.EventHandler(this.weekViewToolStripMenuItem_Click);
            // 
            // monthViewToolStripMenuItem
            // 
            this.monthViewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("monthViewToolStripMenuItem.Image")));
            this.monthViewToolStripMenuItem.Name = "monthViewToolStripMenuItem";
            this.monthViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.monthViewToolStripMenuItem.Text = "&Month view";
            this.monthViewToolStripMenuItem.Click += new System.EventHandler(this.monthViewToolStripMenuItem_Click);
            // 
            // timelineViewToolStripMenuItem
            // 
            this.timelineViewToolStripMenuItem.Name = "timelineViewToolStripMenuItem";
            this.timelineViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.timelineViewToolStripMenuItem.Text = "&Timeline view";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Click on month header to see different views";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "------";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "------";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Crimson;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(483, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton1.Text = "Open";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel1.Text = "Notepad";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cal.Properties.Resources.ist1_10320641_calendar_icon;
            this.pictureBox1.Location = new System.Drawing.Point(356, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Image = global::cal.Properties.Resources._1225770321258316602emyller_close_button_svg1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(270, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Main  page";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(483, 260);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " kanke\'s Calendar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comicSansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem schedulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeNewNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeViewToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayViewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem workViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weekViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timelineViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meetingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birthdayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reminderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReminderToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem viewBirthdaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meetingListToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

