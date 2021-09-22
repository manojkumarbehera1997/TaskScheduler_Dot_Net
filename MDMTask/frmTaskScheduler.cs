using System;
using System.Drawing;
using System.Windows.Forms;
using TaskScheduler;

namespace MDMTask
{
    public partial class frmTaskScheduler : Form
    {
        public frmTaskScheduler()
        {
            InitializeComponent();
            dateTimePickerTriggerTime.Value = DateTime.Now.AddMinutes(2);
            if (oneTimeRadio.Checked)
            {              
                labelDailyEvery.Visible = false;
                numericUpDownDaily.Visible = false;
                labelDailyDay.Visible = false;
                labelWeeklyDays.Visible = false;
                checkedListBoxWeeklyDays.Visible = false;
                labelMonthlyMonth.Visible = false;
                checkedListBoxMonthlyMonths.Visible = false;
                tabControlMonthlyMode.Visible = false;
            }
        }
        TaskSchedulerClass objScheduler;
        //To hold Task Definition
        ITaskDefinition objTaskDef;
        //To hold Trigger Information
        ITimeTrigger objTrigger;
        //For Daily Trigger
        IDailyTrigger objDailyTrigger;
        //For Weekly Trigger
        IWeeklyTrigger objweeklyTrigger;
        //For Monthly Trigger
        IMonthlyTrigger objMonthlyTrigger;
        //For MothlyDow Trigger
        IMonthlyDOWTrigger objMonthlyDOWTrigger;
        //To hold Action Information
        IExecAction objAction;

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            try
            {
                objScheduler = new TaskSchedulerClass();
                objScheduler.Connect();

                //Setting Task Definition
                SetTaskDefinition();
                //Setting Task Trigger Information
                SetTriggerInfo();
                //Setting Task Action Information
                SetActionInfo();

                //Getting the roort folder
                ITaskFolder root = objScheduler.GetFolder("\\MDM");
                //Registering the task, if the task is already exist then it will be updated
                IRegisteredTask regTask = root.RegisterTaskDefinition("MDMTask", objTaskDef, (int)_TASK_CREATION.TASK_CREATE_OR_UPDATE, null, null, _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN, "");

                //To execute the task immediately calling Run()
                //IRunningTask runtask = regTask.Run(null);

                MessageBox.Show("Task is created successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Setting Task Definition
        private void SetTaskDefinition()
        {
            try
            {
                objTaskDef = objScheduler.NewTask(0);
                //Registration Info for task
                //Name of the task Author
                objTaskDef.RegistrationInfo.Author = "TataPower";
                //Description of the task 
                objTaskDef.RegistrationInfo.Description = "MDMTask";
                //Registration date of the task 
                objTaskDef.RegistrationInfo.Date = DateTime.Today.ToString("yyyy-MM-ddTHH:mm:ss"); //Date format 

                //Settings for task
                //Thread Priority
                objTaskDef.Settings.Priority = 7;
                //Enabling the task
                objTaskDef.Settings.Enabled = true;
                //To hide/show the task
                objTaskDef.Settings.Hidden = false;
                //Execution Time Lmit for task
                objTaskDef.Settings.ExecutionTimeLimit = "PT10M"; //10 minutes
                //Specifying no need of network connection
                objTaskDef.Settings.RunOnlyIfNetworkAvailable = false;

                //Set to run on battery and AC power
                objTaskDef.Settings.DisallowStartIfOnBatteries = false;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Setting Task Trigger Information
        private void SetTriggerInfo()
        {
            //string startDate = dateTimePickerStartDate.Value.ToString("yyyy-MM-ddTHH:mm:ss");
            string endDate = dateTimePickerEndDate.Value.ToString("yyyy-MM-ddTHH:mm:ss");
            var startTrigger = dateTimePickerStartDate.Value.Date.Add(dateTimePickerTriggerTime.Value.TimeOfDay).ToString("yyyy-MM-ddTHH:mm:ss");
            if (oneTimeRadio.Checked)
            {

                try
                {
                    //Trigger information based on time - TASK_TRIGGER_TIME
                    objTrigger = (ITimeTrigger)objTaskDef.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_TIME);
                    //Trigger ID
                    objTrigger.Id = "MDMTaskTrigger";
                    //Start Time
                    objTrigger.StartBoundary = startTrigger; //yyyy-MM-ddTHH:mm:ss
                    objTrigger.EndBoundary = endDate; //yyyy-MM-ddTHH:mm:ss
                                                   
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
           else if (dailyRadio.Checked)
            {
                try
                {
                    //Trigger information based on time - TASK_TRIGGER_TIME
                    objDailyTrigger = (IDailyTrigger)objTaskDef.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_DAILY);
                    //Start Time
                    objDailyTrigger.StartBoundary = startTrigger; //yyyy-MM-ddTHH:mm:ss                                                          
                    objTrigger.EndBoundary = endDate; //yyyy-MM-ddTHH:mm:ss
                    objDailyTrigger.DaysInterval = (short)numericUpDownDaily.Value;                
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (weeklyRadio.Checked)
            {
                try
                {
                    //Trigger information based on time - TASK_TRIGGER_TIME
                    objweeklyTrigger = (IWeeklyTrigger)objTaskDef.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_WEEKLY);
                    //Start Time
                    objweeklyTrigger.StartBoundary = startTrigger; //yyyy-MM-ddTHH:mm:ss                                                             //End Time
                    objweeklyTrigger.EndBoundary = endDate; //yyyy-MM-ddTHH:mm:ss              
                    var indexofDay = checkedListBoxWeeklyDays.CheckedItems;
                    short day = 0;
                    foreach (var weekDay in indexofDay)
                    {
                        if (weekDay.ToString() == "Sunday")
                            day += 1;
                        else if (weekDay.ToString() == "Monday")
                            day += 2;
                        else if (weekDay.ToString() == "Tuesday")
                            day += 4;
                        else if (weekDay.ToString() == "Wednesday")
                            day += 8;
                        else if (weekDay.ToString() == "Thursday")
                            day += 16;
                        else if (weekDay.ToString() == "Friday")
                            day += 32;
                        else if (weekDay.ToString() == "Saturday")
                            day += 64;
                    }
                    objweeklyTrigger.DaysOfWeek = day;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (monthlyRadio.Checked)
            {

                if (tabControlMonthlyMode.SelectedTab.Text == "Day of Month")
                {
                    try
                    {
                        //Trigger information based on time - TASK_TRIGGER_TIME
                        objMonthlyTrigger = (IMonthlyTrigger)objTaskDef.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_MONTHLY);
                        //Start Time
                        objMonthlyTrigger.StartBoundary = startTrigger; //yyyy-MM-ddTHH:mm:ss                                                            
                        objMonthlyTrigger.EndBoundary = endDate; //yyyy-MM-ddTHH:mm:ss
                        var monthIndex = checkedListBoxMonthlyMonths.CheckedItems;
                        short month = 0;
                        foreach (var months in monthIndex)
                        {
                            if (months.ToString() == "January")
                                month += 1;
                            else if (months.ToString() == "February")
                                month += 2;
                            else if (months.ToString() == "March")
                                month += 4;
                            else if (months.ToString() == "April")
                                month += 8;
                            else if (months.ToString() == "May")
                                month += 16;
                            else if (months.ToString() == "June")
                                month += 32;
                            else if (months.ToString() == "July")
                                month += 64;
                            else if (months.ToString() == "August")
                                month += 128;
                            else if (months.ToString() == "September")
                                month += 256;
                            else if (months.ToString() == "October")
                                month += 512;
                            else if (months.ToString() == "November")
                                month += 1024;
                            else if (months.ToString() == "December")
                                month += 2048;
                        }
                        objMonthlyTrigger.MonthsOfYear = month;
                        var DaysOfMonth = checkedListBoxMonthlyDays.CheckedItems;
                        int day = 0;
                        foreach(var days in DaysOfMonth)
                        {
                            if (days.ToString() == "1")
                                day += 1;
                            else if (days.ToString() == "2")
                                day += 2;
                            else if (days.ToString() == "3")
                                day += 4;
                            else if (days.ToString() == "4")
                                day += 8;
                            else if (days.ToString() == "5")
                                day += 16;
                            else if (days.ToString() == "6")
                                day += 32;
                            else if (days.ToString() == "7")
                                day += 64;
                            else if (days.ToString() == "8")
                                day += 128;
                            else if (days.ToString() == "9")
                                day += 256;
                            else if (days.ToString() == "10")
                                day += 512;
                            else if (days.ToString() == "11")
                                day += 1024;
                            else if (days.ToString() == "12")
                                day += 2048;
                            else if (days.ToString() == "13")
                                day += 4096;
                            else if (days.ToString() == "14")
                                day += 8192;
                            else if (days.ToString() == "15")
                                day += 16384;
                            else if (days.ToString() == "16")
                                day += 32768;
                            else if (days.ToString() == "17")
                                day += 65536;
                            else if (days.ToString() == "18")
                                day += 131072;
                            else if (days.ToString() == "19")
                                day += 262144;
                            else if (days.ToString() == "20")
                                day += 524288;
                            else if (days.ToString() == "21")
                                day += 1048576;
                            else if (days.ToString() == "22")
                                day += 2097152;
                            else if (days.ToString() == "23")
                                day += 4194304;
                            else if (days.ToString() == "24")
                                day += 8388608;
                            else if (days.ToString() == "25")
                                day += 16777216;
                            else if (days.ToString() == "26")
                                day += 33554432;
                            else if (days.ToString() == "27")
                                day += 67108864;
                            else if (days.ToString() == "28")
                                day += 134217728;
                            else if (days.ToString() == "29")
                                day += 268435456 ;
                            else if (days.ToString() == "30")
                                day += 536870912;
                            else if (days.ToString() == "31")
                                day += 1073741824;
                            else if (days.ToString() == "Last Day")
                                objMonthlyTrigger.RunOnLastDayOfMonth = true;                                                        
                        }
                        objMonthlyTrigger.DaysOfMonth = day;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    try
                    {
                        //Trigger information based on time - TASK_TRIGGER_TIME
                        objMonthlyDOWTrigger = (IMonthlyDOWTrigger)objTaskDef.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_MONTHLYDOW);
                        //Start Time
                        objMonthlyDOWTrigger.StartBoundary = startTrigger; //yyyy-MM-ddTHH:mm:ss                                                            
                        objMonthlyDOWTrigger.EndBoundary = endDate; //yyyy-MM-ddTHH:mm:ss
                        var monthIndex = checkedListBoxMonthlyMonths.CheckedItems;
                        short month = 0;
                        foreach (var months in monthIndex)
                        {
                            if (months.ToString() == "January")
                                month += 1;
                            else if (months.ToString() == "February")
                                month += 2;
                            else if (months.ToString() == "March")
                                month += 4;
                            else if (months.ToString() == "April")
                                month += 8;
                            else if (months.ToString() == "May")
                                month += 16;
                            else if (months.ToString() == "June")
                                month += 32;
                            else if (months.ToString() == "July")
                                month += 64;
                            else if (months.ToString() == "August")
                                month += 128;
                            else if (months.ToString() == "September")
                                month += 256;
                            else if (months.ToString() == "October")
                                month += 512;
                            else if (months.ToString() == "November")
                                month += 1024;
                            else if (months.ToString() == "December")
                                month += 2048;                           
                        }
                        objMonthlyDOWTrigger.MonthsOfYear = month;
                        var noOfWeek = checkedListBoxMonthlyWeekNumber.CheckedItems;
                        short week = 0;
                        foreach (var weekNumber in noOfWeek)
                        {
                            if (weekNumber.ToString() == "First")
                                week += 1;
                            else if (weekNumber.ToString() == "Second")
                                week += 2;
                            else if (weekNumber.ToString() == "Third")
                                week += 4;
                            else if (weekNumber.ToString() == "Fourth")
                                week += 8;                                                         
                        }
                        objMonthlyDOWTrigger.WeeksOfMonth = week;
                        if (noOfWeek.Contains("Last"))
                        {
                            objMonthlyDOWTrigger.RunOnLastWeekOfMonth = true;
                        }                                                                    
                        var daysWeek = checkedListBoxMonthlyWeekDay.CheckedItems;
                        short day = 0;
                        foreach (var weekDay in daysWeek)
                        {
                            if (weekDay.ToString() == "Sunday")
                                day += 1;
                            else if (weekDay.ToString() == "Monday")
                                day += 2;
                            else if (weekDay.ToString() == "Tuesday")
                                day += 4;
                            else if (weekDay.ToString() == "Wednesday")
                                day += 8;
                            else if (weekDay.ToString() == "Thursday")
                                day += 16;
                            else if (weekDay.ToString() == "Friday")
                                day += 32;
                            else if (weekDay.ToString() == "Saturday")
                                day += 64;
                        }
                        objMonthlyDOWTrigger.DaysOfWeek = day;                                                                    
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }                                
        }

        //Setting Task Action Information
        private void SetActionInfo()
        {
            try
            {
                //Action information based on exe- TASK_ACTION_EXEC
                objAction = (IExecAction)objTaskDef.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
                //Action ID
                objAction.Id = "Action";
                //Set the path of the exe file to execute.
                objAction.Path = searchBox1.Text;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }       
        private void oneTimeRadio_CheckedChanged(object sender, EventArgs e)
        {
            labelDailyEvery.Visible = false;
            numericUpDownDaily.Visible = false;
            labelDailyDay.Visible = false;
            labelWeeklyDays.Visible = false;
            checkedListBoxWeeklyDays.Visible = false;
            labelMonthlyMonth.Visible = false;
            checkedListBoxMonthlyMonths.Visible = false;
            tabControlMonthlyMode.Visible = false;
        }
        private void dailyRadio_CheckedChanged(object sender, EventArgs e)
        {
            labelDailyEvery.Visible = true;
            numericUpDownDaily.Visible = true;
            labelDailyDay.Visible = true;
            labelWeeklyDays.Visible = false;
            checkedListBoxWeeklyDays.Visible = false;
            monthlyPanel.Visible = false;
        }
        private void weeklyRadio_CheckedChanged(object sender, EventArgs e)
        {
            labelDailyEvery.Visible = false;
            numericUpDownDaily.Visible = false;
            labelDailyDay.Visible = false;
            labelWeeklyDays.Visible = true;
            checkedListBoxWeeklyDays.Visible = true;
            monthlyPanel.Visible = false;
        }
        private void monthlyRadio_CheckedChanged(object sender, EventArgs e)
        {
            labelDailyEvery.Visible = false;
            numericUpDownDaily.Visible = false;
            labelDailyDay.Visible = false;
            labelWeeklyDays.Visible = false;
            checkedListBoxWeeklyDays.Visible = false;
            monthlyPanel.Visible = true;
            labelMonthlyMonth.Visible = true;
            checkedListBoxMonthlyMonths.Visible = true;
            tabControlMonthlyMode.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
            Color.Empty, 0, ButtonBorderStyle.None, // left
            Color.Empty, 0, ButtonBorderStyle.None, // top
            Color.Black, 1, ButtonBorderStyle.Solid, // right
            Color.Empty, 0, ButtonBorderStyle.None);// bottom
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle,
               Color.White, 1, ButtonBorderStyle.Solid, // left
               Color.White, 1, ButtonBorderStyle.Solid, // top
               Color.White, 1, ButtonBorderStyle.Solid, // right
               Color.White, 1, ButtonBorderStyle.Solid);// bottom
        }       
    }
}
