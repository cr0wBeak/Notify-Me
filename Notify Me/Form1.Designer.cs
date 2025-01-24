namespace Notify_Me
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtNotification = new TextBox();
            btnNotify = new Button();
            lblWaitFor = new Label();
            lblSeconds = new Label();
            txtDelaySeconds = new NumericUpDown();
            txtNotifTitle = new TextBox();
            txtDelayMinutes = new NumericUpDown();
            lblMinutes = new Label();
            icoSystemTray = new NotifyIcon(components);
            contextMenuTray = new ContextMenuStrip(components);
            exitToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtDelaySeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDelayMinutes).BeginInit();
            contextMenuTray.SuspendLayout();
            SuspendLayout();
            // 
            // txtNotification
            // 
            txtNotification.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNotification.Location = new Point(12, 272);
            txtNotification.Multiline = true;
            txtNotification.Name = "txtNotification";
            txtNotification.PlaceholderText = "Enter notification message...";
            txtNotification.Size = new Size(776, 126);
            txtNotification.TabIndex = 0;
            // 
            // btnNotify
            // 
            btnNotify.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNotify.Location = new Point(676, 404);
            btnNotify.Name = "btnNotify";
            btnNotify.Size = new Size(112, 34);
            btnNotify.TabIndex = 2;
            btnNotify.Text = "Notify Me!";
            btnNotify.UseVisualStyleBackColor = true;
            btnNotify.Click += BtnNotifyMe;
            // 
            // lblWaitFor
            // 
            lblWaitFor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblWaitFor.AutoSize = true;
            lblWaitFor.Location = new Point(12, 407);
            lblWaitFor.Name = "lblWaitFor";
            lblWaitFor.Size = new Size(75, 25);
            lblWaitFor.TabIndex = 4;
            lblWaitFor.Text = "Wait for";
            // 
            // lblSeconds
            // 
            lblSeconds.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSeconds.AutoSize = true;
            lblSeconds.Location = new Point(308, 407);
            lblSeconds.Name = "lblSeconds";
            lblSeconds.Size = new Size(77, 25);
            lblSeconds.TabIndex = 5;
            lblSeconds.Text = "seconds";
            // 
            // txtDelaySeconds
            // 
            txtDelaySeconds.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtDelaySeconds.Location = new Point(241, 404);
            txtDelaySeconds.Name = "txtDelaySeconds";
            txtDelaySeconds.Size = new Size(61, 31);
            txtDelaySeconds.TabIndex = 6;
            // 
            // txtNotifTitle
            // 
            txtNotifTitle.Location = new Point(12, 235);
            txtNotifTitle.Name = "txtNotifTitle";
            txtNotifTitle.PlaceholderText = "Enter notification title...";
            txtNotifTitle.Size = new Size(776, 31);
            txtNotifTitle.TabIndex = 7;
            // 
            // txtDelayMinutes
            // 
            txtDelayMinutes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtDelayMinutes.Location = new Point(93, 405);
            txtDelayMinutes.Name = "txtDelayMinutes";
            txtDelayMinutes.Size = new Size(61, 31);
            txtDelayMinutes.TabIndex = 9;
            txtDelayMinutes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblMinutes
            // 
            lblMinutes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMinutes.AutoSize = true;
            lblMinutes.Location = new Point(160, 407);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(75, 25);
            lblMinutes.TabIndex = 8;
            lblMinutes.Text = "minutes";
            // 
            // icoSystemTray
            // 
            icoSystemTray.ContextMenuStrip = contextMenuTray;
            icoSystemTray.Text = "notifyIcon1";
            icoSystemTray.Visible = true;
            icoSystemTray.MouseDoubleClick += icoSystemTray_MouseDoubleClick;
            // 
            // contextMenuTray
            // 
            contextMenuTray.ImageScalingSize = new Size(24, 24);
            contextMenuTray.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            contextMenuTray.Name = "contextMenuTray";
            contextMenuTray.Size = new Size(112, 36);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(111, 32);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 61);
            label1.TabIndex = 10;
            label1.Text = "Notify Me";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtDelayMinutes);
            Controls.Add(lblMinutes);
            Controls.Add(txtNotifTitle);
            Controls.Add(txtDelaySeconds);
            Controls.Add(lblSeconds);
            Controls.Add(lblWaitFor);
            Controls.Add(btnNotify);
            Controls.Add(txtNotification);
            Name = "Form1";
            Text = "Notify Me";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txtDelaySeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDelayMinutes).EndInit();
            contextMenuTray.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNotification;
        private Button btnNotify;
        private Label lblWaitFor;
        private Label lblSeconds;
        private NumericUpDown txtDelaySeconds;
        private TextBox txtNotifTitle;
        private NumericUpDown txtDelayMinutes;
        private Label lblMinutes;
        private NotifyIcon icoSystemTray;
        private ContextMenuStrip contextMenuTray;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label1;
    }
}
