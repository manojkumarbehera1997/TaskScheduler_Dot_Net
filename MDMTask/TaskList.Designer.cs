
namespace MDMTask
{
    partial class TaskList
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewItems = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Triggers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nextRunTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastRunTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastRunResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewItems
            // 
            this.listViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Status,
            this.Triggers,
            this.nextRunTime,
            this.lastRunTime,
            this.lastRunResult,
            this.Author,
            this.Created});
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(3, 12);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(761, 145);
            this.listViewItems.TabIndex = 6;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 99;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 54;
            // 
            // Triggers
            // 
            this.Triggers.Text = "Triggers";
            this.Triggers.Width = 140;
            // 
            // nextRunTime
            // 
            this.nextRunTime.Text = "Next Run Time";
            this.nextRunTime.Width = 96;
            // 
            // lastRunTime
            // 
            this.lastRunTime.Text = "LastRunTime";
            this.lastRunTime.Width = 104;
            // 
            // lastRunResult
            // 
            this.lastRunResult.Text = "Last Run Result";
            this.lastRunResult.Width = 95;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 116;
            // 
            // Created
            // 
            this.Created.Text = "Created";
            this.Created.Width = 149;
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 409);
            this.Controls.Add(this.listViewItems);
            this.Text = "TaskList";
            this.Load += new System.EventHandler(this.TaskList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Triggers;
        private System.Windows.Forms.ColumnHeader nextRunTime;
        private System.Windows.Forms.ColumnHeader lastRunTime;
        private System.Windows.Forms.ColumnHeader lastRunResult;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Created;
    }
}