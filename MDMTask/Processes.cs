using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MDMTask
{
    public partial class Processes : Form
    {
		public static string newprocpathandparm, machinename;

		public Processes()
        {
            InitializeComponent();
        }

        private void Processes_Load(object sender, EventArgs e)
        {
			lvprocesslist.ContextMenuStrip = lvContextMenu;
			machinename = ".";
			GetAllProcesses();
		}

        private void btnSearch_Click(object sender, EventArgs e)
        {
			string processName = txtSearch.Text;
			if (String.IsNullOrEmpty(processName))
            {
				MessageBox.Show("Please input a process name");
				return;
			}

			GetAllProcesses(processName);
		}

		private void GetAllProcesses(string processName = "")
		{
			lvprocesslist.Items.Clear();
			Process[] processes = null;
			try
			{
                if (string.IsNullOrEmpty(processName))
                {
					processes = Process.GetProcesses(machinename);
				}
                else
                {
					processes = Process.GetProcessesByName(processName, machinename);
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Application.Exit();
				return;
			}
			int threadscount = 0;
			foreach (Process p in processes)
			{
				try
				{
					string[] prcdetails = new string[] { p.ProcessName, p.Id.ToString(), p.StartTime.ToShortTimeString(), p.TotalProcessorTime.Duration().Hours.ToString() + ":" + p.TotalProcessorTime.Duration().Minutes.ToString() + ":" + p.TotalProcessorTime.Duration().Seconds.ToString(), (p.WorkingSet / 1024).ToString() + "k", (p.PeakWorkingSet / 1024).ToString() + "k", p.HandleCount.ToString(), p.Threads.Count.ToString() };
					ListViewItem proc = new ListViewItem(prcdetails);
					lvprocesslist.Items.Add(proc);
					threadscount += p.Threads.Count;
				}
				catch { }
			}
			label1.Text = "Total Processes: " + processes.Length.ToString();
		}

        private void btnStart_Click(object sender, EventArgs e)
        {
			string processName = txtStartProcess.Text;
			Process.Start(processName, machinename);
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
			txtSearch.Text = "";
			GetAllProcesses();
		}

        private void endProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (lvprocesslist.SelectedItems.Count >= 1)
			{
				try
				{
					int selectedpid = Convert.ToInt32(lvprocesslist.SelectedItems[0].SubItems[1].Text.ToString());
					Process.GetProcessById(selectedpid, machinename).Kill();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
			GetAllProcesses();
		}

        private void GetAllProcessesByName(string processName)
		{
			lvprocesslist.Items.Clear();
			Process[] processes = null;
			try
			{
				processes = Process.GetProcessesByName(processName, machinename);
				//processes = Process.GetProcesses(machinename);
				//processes = processes.Where(p => processes.Contains(processName));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Application.Exit();
				return;
			}
			int threadscount = 0;
			foreach (Process p in processes)
			{
				try
				{
					string[] prcdetails = new string[] { p.ProcessName, p.Id.ToString(), p.StartTime.ToShortTimeString(), p.TotalProcessorTime.Duration().Hours.ToString() + ":" + p.TotalProcessorTime.Duration().Minutes.ToString() + ":" + p.TotalProcessorTime.Duration().Seconds.ToString(), (p.WorkingSet / 1024).ToString() + "k", (p.PeakWorkingSet / 1024).ToString() + "k", p.HandleCount.ToString(), p.Threads.Count.ToString() };
					
					ListViewItem proc = new ListViewItem(prcdetails);
					lvprocesslist.Items.Add(proc);
					threadscount += p.Threads.Count;
				}
				catch { }
			}
			label1.Text = "Total Processes: " + processes.Length.ToString();
		}
	}
}
