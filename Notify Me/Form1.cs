using System.Text;

namespace Notify_Me
{
    public partial class Form1 : Form
    {
        bool isWaiting = false;
        int activeReminders;

        public Form1()
        {
            InitializeComponent();
            InitializeSystemTrayIcon();
        }

        private void BtnNotifyMe(object sender, EventArgs e)
        {

            sendNotif(); // prepare notification
            MessageBox.Show("Your notification will be sent on time!", "Success", MessageBoxButtons.OK);
        }

        async void sendNotif()
        {
            isWaiting = true; // prevent app from ending
            activeReminders++; // increase number of reminders waiting
            await Task.Delay(TimeSpan.FromMilliseconds((int.Parse(txtDelayMinutes.Text) * 60) + int.Parse(txtDelaySeconds.Text)) * 1000); // convert to seconds, then milliseconds
            activeReminders--; // decrease reminders waiting
            if (activeReminders == 0)
            {
                isWaiting = false; // if not handling another reminder, stop waiting
            }
            NotifyIcon notifyicon = new NotifyIcon(); // create a new notif
            notifyicon.Icon = SystemIcons.Information; // default notification icon
            notifyicon.Visible = true;
            notifyicon.BalloonTipTitle = txtNotifTitle.Text;
            notifyicon.BalloonTipText = txtNotification.Text;
            notifyicon.ShowBalloonTip(3000); // 3 second duration
            
            // if no timers are running, close app.
            if (isWaiting == false)
            {
                Application.ExitThread();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isWaiting == true)
            {
                e.Cancel = true; // stop form from closing
                this.Hide(); // hide form
            }
        }

        private void InitializeSystemTrayIcon()
        {
            ContextMenuStrip = new ContextMenuStrip();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            icoSystemTray.Icon = SystemIcons.Application; // test icon
            icoSystemTray.Text = "Remind Me";
            icoSystemTray.Visible = true; // Make the tray icon visible
        }

        private void icoSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show(); // show form
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            icoSystemTray.Visible = false;
            Application.ExitThread();
        }
    }
}