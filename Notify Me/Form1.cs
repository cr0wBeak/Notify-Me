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
        }

        private void BtnNotifyMe(object sender, EventArgs e)
        {
            // ensure that notification fields are not blank
            if (txtNotification.Text == "" || txtNotifTitle.Text == "")
            {
                MessageBox.Show("An error has occured: notification fields cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SendNotif(); // prepare notification
                MessageBox.Show("Your notification will be sent on time!", "Success", MessageBoxButtons.OK);
            }
        }

        async void SendNotif()
        {
            isWaiting = true; // prevent app from ending
            activeReminders++; // increase number of reminders waiting
            await Task.Delay(TimeSpan.FromSeconds
                (Decimal.ToInt32(
                    (txtDelayMinutes.Value * 60) + txtDelaySeconds.Value)
                )
            ); // convert to seconds, then milliseconds
            activeReminders--; // decrease reminders waiting
            if (activeReminders == 0)
            {
                isWaiting = false; // if not handling another reminder, stop waiting
            }

            // create notification
            NotifyIcon notifyicon = new()
            {
                Icon = SystemIcons.Information, // default notification icon
                Visible = true,
                BalloonTipTitle = txtNotifTitle.Text,
                BalloonTipText = txtNotification.Text
            }; // create a new notif
            notifyicon.ShowBalloonTip(3000); // 3 second duration
            
            // if no timers are running, close app.
            if (!isWaiting)
            {
                notifyicon.Dispose(); // prevent memory leaks
                Application.ExitThread(); // stop outgoing notif
                Application.Exit(); // end program because it's evil and will destroy humanity otherwise
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isWaiting)
            {
                e.Cancel = true; // stop form from closing
                this.Hide(); // hide form
            }
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
            icoSystemTray.Dispose(); // prevent memory leaks
            Application.ExitThread(); // stop outgoing notif
            Application.Exit(); // end program because it's evil and will destroy humanity otherwise
        }
    }
}
