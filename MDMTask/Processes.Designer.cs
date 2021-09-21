
namespace MDMTask
{
    partial class Processes
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
            this.lvprocesslist = new System.Windows.Forms.ListView();
            this.procname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procstarttime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proccputime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartProcess = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.lvContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.endProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lvContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvprocesslist
            // 
            this.lvprocesslist.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvprocesslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.procname,
            this.PID,
            this.procstarttime,
            this.proccputime});
            this.lvprocesslist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvprocesslist.FullRowSelect = true;
            this.lvprocesslist.HideSelection = false;
            this.lvprocesslist.Location = new System.Drawing.Point(34, 165);
            this.lvprocesslist.Name = "lvprocesslist";
            this.lvprocesslist.Size = new System.Drawing.Size(641, 339);
            this.lvprocesslist.TabIndex = 1;
            this.lvprocesslist.UseCompatibleStateImageBehavior = false;
            this.lvprocesslist.View = System.Windows.Forms.View.Details;
            // 
            // procname
            // 
            this.procname.Text = "Process Name";
            this.procname.Width = 199;
            // 
            // PID
            // 
            this.PID.Text = "PID";
            this.PID.Width = 95;
            // 
            // procstarttime
            // 
            this.procstarttime.Text = "Start Time";
            this.procstarttime.Width = 127;
            // 
            // proccputime
            // 
            this.proccputime.Text = "CPU Time";
            this.proccputime.Width = 80;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(271, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 22);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Process Name";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(152, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total Processes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Program";
            // 
            // txtStartProcess
            // 
            this.txtStartProcess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStartProcess.Location = new System.Drawing.Point(152, 80);
            this.txtStartProcess.Name = "txtStartProcess";
            this.txtStartProcess.Size = new System.Drawing.Size(100, 20);
            this.txtStartProcess.TabIndex = 9;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(271, 78);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(69, 22);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(346, 34);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(69, 22);
            this.btnClearSearch.TabIndex = 11;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // lvContextMenu
            // 
            this.lvContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endProcessToolStripMenuItem});
            this.lvContextMenu.Name = "lvContextMenu";
            this.lvContextMenu.Size = new System.Drawing.Size(138, 26);
            // 
            // endProcessToolStripMenuItem
            // 
            this.endProcessToolStripMenuItem.Name = "endProcessToolStripMenuItem";
            this.endProcessToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.endProcessToolStripMenuItem.Text = "End Process";
            this.endProcessToolStripMenuItem.Click += new System.EventHandler(this.endProcessToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(34, 135);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Processes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 516);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtStartProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lvprocesslist);
            this.Name = "Processes";
            this.Text = "Processes";
            this.Load += new System.EventHandler(this.Processes_Load);
            this.lvContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvprocesslist;
        private System.Windows.Forms.ColumnHeader procname;
        private System.Windows.Forms.ColumnHeader PID;
        private System.Windows.Forms.ColumnHeader procstarttime;
        private System.Windows.Forms.ColumnHeader proccputime;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartProcess;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.ContextMenuStrip lvContextMenu;
        private System.Windows.Forms.ToolStripMenuItem endProcessToolStripMenuItem;
        private System.Windows.Forms.Button btnRefresh;
    }
}