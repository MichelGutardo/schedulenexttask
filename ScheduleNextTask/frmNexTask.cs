using System;
using System.Windows.Forms;

namespace ScheduleNextTask
{
    public partial class FrmTask : Form
    {
        public FrmTask()
        {
            InitializeComponent();
        }

        //Start Timer's tick and hide application
        private void BtnStart_Click(object sender, EventArgs e)
        {
            T.Enabled = true;
            BtnStart.Enabled = false;
            BtnStop.Enabled = true;
            txtTask.ReadOnly = true;
            this.Visible = false;
            this.ShowInTaskbar = false;
            mtxtSchedule.ReadOnly = true;
        }

        //For each timer's tick
        private void T_Tick(object sender, EventArgs e)
        {
            if (mtxtSchedule.Text == DateTime.Now.ToString("HH:mm"))
            {
                this.TopMost = true;
                this.Visible = true;
                this.ShowInTaskbar = true;
                System.Media.SystemSounds.Exclamation.Play();
                T.Enabled = false;
                MessageBox.Show("It's time for the next task!\n" + txtTask.Text);
            }
        }

        //Double click action on NotifyIcon 
        private void NtfIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.BtnStop.PerformClick();
        }

        //Click on Stop button
        private void BtnStop_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            T.Enabled = false;
            BtnStart.Enabled = true;
            BtnStop.Enabled = false;
            txtTask.ReadOnly = false;
            mtxtSchedule.ReadOnly = false;
            this.Visible = true;
            this.ShowInTaskbar = true;
        }
    }
}
