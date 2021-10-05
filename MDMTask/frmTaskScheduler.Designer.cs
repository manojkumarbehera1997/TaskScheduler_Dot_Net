
namespace MDMTask
{
    partial class frmTaskScheduler
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
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.searchBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTriggerTime = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownDaily = new System.Windows.Forms.NumericUpDown();
            this.labelDailyEvery = new System.Windows.Forms.Label();
            this.labelDailyDay = new System.Windows.Forms.Label();
            this.labelWeeklyDays = new System.Windows.Forms.Label();
            this.checkedListBoxWeeklyDays = new System.Windows.Forms.CheckedListBox();
            this.tabControlMonthlyMode = new System.Windows.Forms.TabControl();
            this.tabPageMonthlyDayOfMonth = new System.Windows.Forms.TabPage();
            this.checkedListBoxMonthlyDays = new System.Windows.Forms.CheckedListBox();
            this.tabPageMonthlyWeekDay = new System.Windows.Forms.TabPage();
            this.checkedListBoxMonthlyWeekNumber = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxMonthlyWeekDay = new System.Windows.Forms.CheckedListBox();
            this.labelMonthlyMonth = new System.Windows.Forms.Label();
            this.checkedListBoxMonthlyMonths = new System.Windows.Forms.CheckedListBox();
            this.oneTimeRadio = new System.Windows.Forms.RadioButton();
            this.dailyRadio = new System.Windows.Forms.RadioButton();
            this.weeklyRadio = new System.Windows.Forms.RadioButton();
            this.monthlyRadio = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAddArgument = new System.Windows.Forms.Label();
            this.labelStartIn = new System.Windows.Forms.Label();
            this.ArgumentBox = new System.Windows.Forms.TextBox();
            this.startInBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthlyPanel = new System.Windows.Forms.Panel();
            this.connectToLabel = new System.Windows.Forms.Label();
            this.connectToCheckBox = new System.Windows.Forms.CheckBox();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.domainLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.domainTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDaily)).BeginInit();
            this.tabControlMonthlyMode.SuspendLayout();
            this.tabPageMonthlyDayOfMonth.SuspendLayout();
            this.tabPageMonthlyWeekDay.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.monthlyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(275, 120);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(75, 20);
            this.btnCreateTask.TabIndex = 0;
            this.btnCreateTask.Text = "Create Task";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // searchBox1
            // 
            this.searchBox1.Location = new System.Drawing.Point(145, 34);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Size = new System.Drawing.Size(205, 20);
            this.searchBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Program/Script :";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(154, 165);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(32, 13);
            this.labelStartDate.TabIndex = 3;
            this.labelStartDate.Text = "Start:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(192, 158);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(158, 20);
            this.dateTimePickerStartDate.TabIndex = 4;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(389, 164);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(29, 13);
            this.labelEndDate.TabIndex = 39;
            this.labelEndDate.Text = "End:";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(424, 157);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerEndDate.TabIndex = 40;
            this.dateTimePickerEndDate.Value = new System.DateTime(2022, 9, 17, 17, 25, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Time:";
            // 
            // dateTimePickerTriggerTime
            // 
            this.dateTimePickerTriggerTime.CustomFormat = "";
            this.dateTimePickerTriggerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTriggerTime.Location = new System.Drawing.Point(649, 157);
            this.dateTimePickerTriggerTime.Name = "dateTimePickerTriggerTime";
            this.dateTimePickerTriggerTime.ShowUpDown = true;
            this.dateTimePickerTriggerTime.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerTriggerTime.TabIndex = 51;
            // 
            // numericUpDownDaily
            // 
            this.numericUpDownDaily.Location = new System.Drawing.Point(54, 10);
            this.numericUpDownDaily.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownDaily.Name = "numericUpDownDaily";
            this.numericUpDownDaily.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownDaily.TabIndex = 0;
            // 
            // labelDailyEvery
            // 
            this.labelDailyEvery.AutoSize = true;
            this.labelDailyEvery.Location = new System.Drawing.Point(14, 12);
            this.labelDailyEvery.Name = "labelDailyEvery";
            this.labelDailyEvery.Size = new System.Drawing.Size(34, 13);
            this.labelDailyEvery.TabIndex = 4;
            this.labelDailyEvery.Text = "Every";
            // 
            // labelDailyDay
            // 
            this.labelDailyDay.AutoSize = true;
            this.labelDailyDay.Location = new System.Drawing.Point(109, 12);
            this.labelDailyDay.Name = "labelDailyDay";
            this.labelDailyDay.Size = new System.Drawing.Size(24, 13);
            this.labelDailyDay.TabIndex = 5;
            this.labelDailyDay.Text = "day";
            // 
            // labelWeeklyDays
            // 
            this.labelWeeklyDays.AutoSize = true;
            this.labelWeeklyDays.Location = new System.Drawing.Point(109, 12);
            this.labelWeeklyDays.Name = "labelWeeklyDays";
            this.labelWeeklyDays.Size = new System.Drawing.Size(34, 13);
            this.labelWeeklyDays.TabIndex = 28;
            this.labelWeeklyDays.Text = "Days:";
            // 
            // checkedListBoxWeeklyDays
            // 
            this.checkedListBoxWeeklyDays.CheckOnClick = true;
            this.checkedListBoxWeeklyDays.FormattingEnabled = true;
            this.checkedListBoxWeeklyDays.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.checkedListBoxWeeklyDays.Location = new System.Drawing.Point(145, 12);
            this.checkedListBoxWeeklyDays.Name = "checkedListBoxWeeklyDays";
            this.checkedListBoxWeeklyDays.Size = new System.Drawing.Size(104, 109);
            this.checkedListBoxWeeklyDays.TabIndex = 0;
            // 
            // tabControlMonthlyMode
            // 
            this.tabControlMonthlyMode.Controls.Add(this.tabPageMonthlyDayOfMonth);
            this.tabControlMonthlyMode.Controls.Add(this.tabPageMonthlyWeekDay);
            this.tabControlMonthlyMode.Location = new System.Drawing.Point(201, 14);
            this.tabControlMonthlyMode.Name = "tabControlMonthlyMode";
            this.tabControlMonthlyMode.SelectedIndex = 0;
            this.tabControlMonthlyMode.Size = new System.Drawing.Size(229, 155);
            this.tabControlMonthlyMode.TabIndex = 1;
            // 
            // tabPageMonthlyDayOfMonth
            // 
            this.tabPageMonthlyDayOfMonth.Controls.Add(this.checkedListBoxMonthlyDays);
            this.tabPageMonthlyDayOfMonth.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonthlyDayOfMonth.Name = "tabPageMonthlyDayOfMonth";
            this.tabPageMonthlyDayOfMonth.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMonthlyDayOfMonth.Size = new System.Drawing.Size(221, 129);
            this.tabPageMonthlyDayOfMonth.TabIndex = 0;
            this.tabPageMonthlyDayOfMonth.Text = "Day of Month";
            this.tabPageMonthlyDayOfMonth.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxMonthlyDays
            // 
            this.checkedListBoxMonthlyDays.CheckOnClick = true;
            this.checkedListBoxMonthlyDays.FormattingEnabled = true;
            this.checkedListBoxMonthlyDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "Last Day"});
            this.checkedListBoxMonthlyDays.Location = new System.Drawing.Point(3, 1);
            this.checkedListBoxMonthlyDays.Name = "checkedListBoxMonthlyDays";
            this.checkedListBoxMonthlyDays.Size = new System.Drawing.Size(219, 124);
            this.checkedListBoxMonthlyDays.TabIndex = 29;
            // 
            // tabPageMonthlyWeekDay
            // 
            this.tabPageMonthlyWeekDay.Controls.Add(this.checkedListBoxMonthlyWeekNumber);
            this.tabPageMonthlyWeekDay.Controls.Add(this.checkedListBoxMonthlyWeekDay);
            this.tabPageMonthlyWeekDay.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonthlyWeekDay.Name = "tabPageMonthlyWeekDay";
            this.tabPageMonthlyWeekDay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMonthlyWeekDay.Size = new System.Drawing.Size(221, 129);
            this.tabPageMonthlyWeekDay.TabIndex = 1;
            this.tabPageMonthlyWeekDay.Text = "Weekday";
            this.tabPageMonthlyWeekDay.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxMonthlyWeekNumber
            // 
            this.checkedListBoxMonthlyWeekNumber.CheckOnClick = true;
            this.checkedListBoxMonthlyWeekNumber.FormattingEnabled = true;
            this.checkedListBoxMonthlyWeekNumber.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Last"});
            this.checkedListBoxMonthlyWeekNumber.Location = new System.Drawing.Point(8, 8);
            this.checkedListBoxMonthlyWeekNumber.Name = "checkedListBoxMonthlyWeekNumber";
            this.checkedListBoxMonthlyWeekNumber.Size = new System.Drawing.Size(95, 94);
            this.checkedListBoxMonthlyWeekNumber.TabIndex = 33;
            // 
            // checkedListBoxMonthlyWeekDay
            // 
            this.checkedListBoxMonthlyWeekDay.CheckOnClick = true;
            this.checkedListBoxMonthlyWeekDay.FormattingEnabled = true;
            this.checkedListBoxMonthlyWeekDay.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.checkedListBoxMonthlyWeekDay.Location = new System.Drawing.Point(109, 6);
            this.checkedListBoxMonthlyWeekDay.Name = "checkedListBoxMonthlyWeekDay";
            this.checkedListBoxMonthlyWeekDay.Size = new System.Drawing.Size(104, 109);
            this.checkedListBoxMonthlyWeekDay.TabIndex = 34;
            // 
            // labelMonthlyMonth
            // 
            this.labelMonthlyMonth.AutoSize = true;
            this.labelMonthlyMonth.Location = new System.Drawing.Point(29, 14);
            this.labelMonthlyMonth.Name = "labelMonthlyMonth";
            this.labelMonthlyMonth.Size = new System.Drawing.Size(40, 13);
            this.labelMonthlyMonth.TabIndex = 29;
            this.labelMonthlyMonth.Text = "Month:";
            // 
            // checkedListBoxMonthlyMonths
            // 
            this.checkedListBoxMonthlyMonths.CheckOnClick = true;
            this.checkedListBoxMonthlyMonths.FormattingEnabled = true;
            this.checkedListBoxMonthlyMonths.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.checkedListBoxMonthlyMonths.Location = new System.Drawing.Point(75, 14);
            this.checkedListBoxMonthlyMonths.Name = "checkedListBoxMonthlyMonths";
            this.checkedListBoxMonthlyMonths.ScrollAlwaysVisible = true;
            this.checkedListBoxMonthlyMonths.Size = new System.Drawing.Size(120, 109);
            this.checkedListBoxMonthlyMonths.TabIndex = 0;
            // 
            // oneTimeRadio
            // 
            this.oneTimeRadio.AutoSize = true;
            this.oneTimeRadio.Checked = true;
            this.oneTimeRadio.Location = new System.Drawing.Point(13, 9);
            this.oneTimeRadio.Name = "oneTimeRadio";
            this.oneTimeRadio.Size = new System.Drawing.Size(95, 17);
            this.oneTimeRadio.TabIndex = 53;
            this.oneTimeRadio.TabStop = true;
            this.oneTimeRadio.Text = "One Time Only";
            this.oneTimeRadio.UseVisualStyleBackColor = true;
            this.oneTimeRadio.CheckedChanged += new System.EventHandler(this.oneTimeRadio_CheckedChanged);
            // 
            // dailyRadio
            // 
            this.dailyRadio.AutoSize = true;
            this.dailyRadio.Location = new System.Drawing.Point(13, 32);
            this.dailyRadio.Name = "dailyRadio";
            this.dailyRadio.Size = new System.Drawing.Size(48, 17);
            this.dailyRadio.TabIndex = 54;
            this.dailyRadio.Text = "Daily";
            this.dailyRadio.UseVisualStyleBackColor = true;
            this.dailyRadio.CheckedChanged += new System.EventHandler(this.dailyRadio_CheckedChanged);
            // 
            // weeklyRadio
            // 
            this.weeklyRadio.AutoSize = true;
            this.weeklyRadio.Location = new System.Drawing.Point(13, 55);
            this.weeklyRadio.Name = "weeklyRadio";
            this.weeklyRadio.Size = new System.Drawing.Size(61, 17);
            this.weeklyRadio.TabIndex = 55;
            this.weeklyRadio.Text = "Weekly";
            this.weeklyRadio.UseVisualStyleBackColor = true;
            this.weeklyRadio.CheckedChanged += new System.EventHandler(this.weeklyRadio_CheckedChanged);
            // 
            // monthlyRadio
            // 
            this.monthlyRadio.AutoSize = true;
            this.monthlyRadio.Location = new System.Drawing.Point(13, 78);
            this.monthlyRadio.Name = "monthlyRadio";
            this.monthlyRadio.Size = new System.Drawing.Size(62, 17);
            this.monthlyRadio.TabIndex = 56;
            this.monthlyRadio.Text = "Monthly";
            this.monthlyRadio.UseVisualStyleBackColor = true;
            this.monthlyRadio.CheckedChanged += new System.EventHandler(this.monthlyRadio_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.oneTimeRadio);
            this.panel1.Controls.Add(this.monthlyRadio);
            this.panel1.Controls.Add(this.dailyRadio);
            this.panel1.Controls.Add(this.weeklyRadio);
            this.panel1.Location = new System.Drawing.Point(25, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 223);
            this.panel1.TabIndex = 57;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelAddArgument
            // 
            this.labelAddArgument.AutoSize = true;
            this.labelAddArgument.Location = new System.Drawing.Point(22, 71);
            this.labelAddArgument.Name = "labelAddArgument";
            this.labelAddArgument.Size = new System.Drawing.Size(123, 13);
            this.labelAddArgument.TabIndex = 58;
            this.labelAddArgument.Text = "Add Argument(optional) :";
            // 
            // labelStartIn
            // 
            this.labelStartIn.AutoSize = true;
            this.labelStartIn.Location = new System.Drawing.Point(23, 103);
            this.labelStartIn.Name = "labelStartIn";
            this.labelStartIn.Size = new System.Drawing.Size(92, 13);
            this.labelStartIn.TabIndex = 59;
            this.labelStartIn.Text = "Start in (optional) :";
            // 
            // ArgumentBox
            // 
            this.ArgumentBox.Location = new System.Drawing.Point(145, 68);
            this.ArgumentBox.Name = "ArgumentBox";
            this.ArgumentBox.Size = new System.Drawing.Size(205, 20);
            this.ArgumentBox.TabIndex = 60;
            // 
            // startInBox
            // 
            this.startInBox.Location = new System.Drawing.Point(145, 94);
            this.startInBox.Name = "startInBox";
            this.startInBox.Size = new System.Drawing.Size(205, 20);
            this.startInBox.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(143, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 2);
            this.label3.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.monthlyPanel);
            this.panel2.Controls.Add(this.labelDailyEvery);
            this.panel2.Controls.Add(this.numericUpDownDaily);
            this.panel2.Controls.Add(this.labelWeeklyDays);
            this.panel2.Controls.Add(this.labelDailyDay);
            this.panel2.Controls.Add(this.checkedListBoxWeeklyDays);
            this.panel2.Location = new System.Drawing.Point(151, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 200);
            this.panel2.TabIndex = 63;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // monthlyPanel
            // 
            this.monthlyPanel.Controls.Add(this.tabControlMonthlyMode);
            this.monthlyPanel.Controls.Add(this.checkedListBoxMonthlyMonths);
            this.monthlyPanel.Controls.Add(this.labelMonthlyMonth);
            this.monthlyPanel.Location = new System.Drawing.Point(109, 3);
            this.monthlyPanel.Name = "monthlyPanel";
            this.monthlyPanel.Size = new System.Drawing.Size(433, 175);
            this.monthlyPanel.TabIndex = 64;
            // 
            // connectToLabel
            // 
            this.connectToLabel.AutoSize = true;
            this.connectToLabel.Location = new System.Drawing.Point(23, 127);
            this.connectToLabel.Name = "connectToLabel";
            this.connectToLabel.Size = new System.Drawing.Size(93, 13);
            this.connectToLabel.TabIndex = 64;
            this.connectToLabel.Text = "Connect to Server";
            // 
            // connectToCheckBox
            // 
            this.connectToCheckBox.AutoSize = true;
            this.connectToCheckBox.Location = new System.Drawing.Point(145, 127);
            this.connectToCheckBox.Name = "connectToCheckBox";
            this.connectToCheckBox.Size = new System.Drawing.Size(15, 14);
            this.connectToCheckBox.TabIndex = 65;
            this.connectToCheckBox.UseVisualStyleBackColor = true;
            this.connectToCheckBox.CheckedChanged += new System.EventHandler(this.connectToCheckBox_CheckedChanged);
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(389, 38);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(69, 13);
            this.serverNameLabel.TabIndex = 66;
            this.serverNameLabel.Text = "Server Name";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(389, 71);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(29, 13);
            this.userLabel.TabIndex = 67;
            this.userLabel.Text = "User";
            // 
            // domainLabel
            // 
            this.domainLabel.AutoSize = true;
            this.domainLabel.Location = new System.Drawing.Point(389, 99);
            this.domainLabel.Name = "domainLabel";
            this.domainLabel.Size = new System.Drawing.Size(43, 13);
            this.domainLabel.TabIndex = 68;
            this.domainLabel.Text = "Domain";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(389, 124);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 69;
            this.passwordLabel.Text = "Password";
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(482, 35);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(205, 20);
            this.ServerTextBox.TabIndex = 70;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(482, 68);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(205, 20);
            this.userTextBox.TabIndex = 71;
            // 
            // domainTextBox
            // 
            this.domainTextBox.Location = new System.Drawing.Point(482, 92);
            this.domainTextBox.Name = "domainTextBox";
            this.domainTextBox.Size = new System.Drawing.Size(205, 20);
            this.domainTextBox.TabIndex = 72;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(482, 120);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(205, 20);
            this.passwordTextBox.TabIndex = 73;
            // 
            // frmTaskScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 447);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.domainTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.ServerTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.domainLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.connectToCheckBox);
            this.Controls.Add(this.connectToLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startInBox);
            this.Controls.Add(this.ArgumentBox);
            this.Controls.Add(this.labelStartIn);
            this.Controls.Add(this.labelAddArgument);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePickerTriggerTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox1);
            this.Controls.Add(this.btnCreateTask);
            this.Name = "frmTaskScheduler";
            this.Text = "Task Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDaily)).EndInit();
            this.tabControlMonthlyMode.ResumeLayout(false);
            this.tabPageMonthlyDayOfMonth.ResumeLayout(false);
            this.tabPageMonthlyWeekDay.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.monthlyPanel.ResumeLayout(false);
            this.monthlyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.TextBox searchBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTriggerTime;
        private System.Windows.Forms.NumericUpDown numericUpDownDaily;
        private System.Windows.Forms.Label labelDailyEvery;
        private System.Windows.Forms.Label labelDailyDay;
        private System.Windows.Forms.Label labelWeeklyDays;
        private System.Windows.Forms.CheckedListBox checkedListBoxWeeklyDays;
        private System.Windows.Forms.TabControl tabControlMonthlyMode;
        private System.Windows.Forms.TabPage tabPageMonthlyDayOfMonth;
        private System.Windows.Forms.CheckedListBox checkedListBoxMonthlyDays;
        private System.Windows.Forms.TabPage tabPageMonthlyWeekDay;
        private System.Windows.Forms.CheckedListBox checkedListBoxMonthlyWeekNumber;
        private System.Windows.Forms.CheckedListBox checkedListBoxMonthlyWeekDay;
        private System.Windows.Forms.Label labelMonthlyMonth;
        private System.Windows.Forms.CheckedListBox checkedListBoxMonthlyMonths;
        private System.Windows.Forms.RadioButton oneTimeRadio;
        private System.Windows.Forms.RadioButton dailyRadio;
        private System.Windows.Forms.RadioButton weeklyRadio;
        private System.Windows.Forms.RadioButton monthlyRadio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAddArgument;
        private System.Windows.Forms.Label labelStartIn;
        private System.Windows.Forms.TextBox ArgumentBox;
        private System.Windows.Forms.TextBox startInBox;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel monthlyPanel;
        private System.Windows.Forms.Label connectToLabel;
        private System.Windows.Forms.CheckBox connectToCheckBox;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label domainLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox domainTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}