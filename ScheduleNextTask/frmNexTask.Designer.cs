namespace ScheduleNextTask
{
    partial class FrmTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTask));
            this.BtnStart = new System.Windows.Forms.Button();
            this.lblTask = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Timer(this.components);
            this.txtTask = new System.Windows.Forms.TextBox();
            this.BtnStop = new System.Windows.Forms.Button();
            this.mtxtSchedule = new System.Windows.Forms.MaskedTextBox();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.NtfIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(12, 68);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(201, 23);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(9, 20);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(43, 17);
            this.lblTask.TabIndex = 0;
            this.lblTask.Text = "Task:";
            // 
            // T
            // 
            this.T.Interval = 1000;
            this.T.Tick += new System.EventHandler(this.T_Tick);
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(12, 40);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(201, 22);
            this.txtTask.TabIndex = 1;
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(231, 68);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(81, 23);
            this.BtnStop.TabIndex = 5;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // mtxtSchedule
            // 
            this.mtxtSchedule.Location = new System.Drawing.Point(231, 40);
            this.mtxtSchedule.Mask = "##:##";
            this.mtxtSchedule.Name = "mtxtSchedule";
            this.mtxtSchedule.Size = new System.Drawing.Size(81, 22);
            this.mtxtSchedule.TabIndex = 3;
            this.mtxtSchedule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(228, 20);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(71, 17);
            this.lblSchedule.TabIndex = 2;
            this.lblSchedule.Text = "Schedule:";
            // 
            // NtfIcon
            // 
            this.NtfIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NtfIcon.Icon")));
            this.NtfIcon.Text = "Next Task";
            this.NtfIcon.Visible = true;
            this.NtfIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NtfIcon_MouseDoubleClick);
            // 
            // FrmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 111);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.mtxtSchedule);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.BtnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Next Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Timer T;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.MaskedTextBox mtxtSchedule;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.NotifyIcon NtfIcon;
    }
}

