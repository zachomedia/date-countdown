namespace ca.zacharyseguin.DateCountdown
{
    partial class DateCountdownForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateCountdownForm));
            this.lblCountdownTitle = new System.Windows.Forms.Label();
            this.conCountdown = new System.Windows.Forms.TableLayoutPanel();
            this.lblSecondsTitle = new System.Windows.Forms.Label();
            this.lblMinutesTitle = new System.Windows.Forms.Label();
            this.lblHoursTitle = new System.Windows.Forms.Label();
            this.lblDaysTitle = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.tmrUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.mnuRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conCountdown.SuspendLayout();
            this.mnuRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCountdownTitle
            // 
            this.lblCountdownTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountdownTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdownTitle.Location = new System.Drawing.Point(17, 9);
            this.lblCountdownTitle.Name = "lblCountdownTitle";
            this.lblCountdownTitle.Size = new System.Drawing.Size(455, 25);
            this.lblCountdownTitle.TabIndex = 0;
            this.lblCountdownTitle.Text = "Countdown Title";
            this.lblCountdownTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCountdownTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Handler);
            // 
            // conCountdown
            // 
            this.conCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conCountdown.ColumnCount = 4;
            this.conCountdown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.conCountdown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.conCountdown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.conCountdown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.conCountdown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.conCountdown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.conCountdown.Controls.Add(this.lblSecondsTitle, 3, 1);
            this.conCountdown.Controls.Add(this.lblMinutesTitle, 2, 1);
            this.conCountdown.Controls.Add(this.lblHoursTitle, 1, 1);
            this.conCountdown.Controls.Add(this.lblDaysTitle, 0, 1);
            this.conCountdown.Controls.Add(this.lblDays, 0, 0);
            this.conCountdown.Controls.Add(this.lblHours, 1, 0);
            this.conCountdown.Controls.Add(this.lblMinutes, 2, 0);
            this.conCountdown.Controls.Add(this.lblSeconds, 3, 0);
            this.conCountdown.Location = new System.Drawing.Point(17, 41);
            this.conCountdown.Name = "conCountdown";
            this.conCountdown.RowCount = 2;
            this.conCountdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.35484F));
            this.conCountdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.64516F));
            this.conCountdown.Size = new System.Drawing.Size(455, 73);
            this.conCountdown.TabIndex = 1;
            // 
            // lblSecondsTitle
            // 
            this.lblSecondsTitle.AutoSize = true;
            this.lblSecondsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSecondsTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondsTitle.Location = new System.Drawing.Point(342, 50);
            this.lblSecondsTitle.Name = "lblSecondsTitle";
            this.lblSecondsTitle.Size = new System.Drawing.Size(110, 23);
            this.lblSecondsTitle.TabIndex = 11;
            this.lblSecondsTitle.Text = "Seconds";
            this.lblSecondsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSecondsTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Handler);
            // 
            // lblMinutesTitle
            // 
            this.lblMinutesTitle.AutoSize = true;
            this.lblMinutesTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMinutesTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutesTitle.Location = new System.Drawing.Point(229, 50);
            this.lblMinutesTitle.Name = "lblMinutesTitle";
            this.lblMinutesTitle.Size = new System.Drawing.Size(107, 23);
            this.lblMinutesTitle.TabIndex = 10;
            this.lblMinutesTitle.Text = "Minutes";
            this.lblMinutesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinutesTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Handler);
            // 
            // lblHoursTitle
            // 
            this.lblHoursTitle.AutoSize = true;
            this.lblHoursTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoursTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursTitle.Location = new System.Drawing.Point(116, 50);
            this.lblHoursTitle.Name = "lblHoursTitle";
            this.lblHoursTitle.Size = new System.Drawing.Size(107, 23);
            this.lblHoursTitle.TabIndex = 9;
            this.lblHoursTitle.Text = "Hours";
            this.lblHoursTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHoursTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Handler);
            // 
            // lblDaysTitle
            // 
            this.lblDaysTitle.AutoSize = true;
            this.lblDaysTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDaysTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysTitle.Location = new System.Drawing.Point(3, 50);
            this.lblDaysTitle.Name = "lblDaysTitle";
            this.lblDaysTitle.Size = new System.Drawing.Size(107, 23);
            this.lblDaysTitle.TabIndex = 8;
            this.lblDaysTitle.Text = "Days";
            this.lblDaysTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDaysTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Handler);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDays.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(3, 0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(107, 50);
            this.lblDays.TabIndex = 3;
            this.lblDays.Text = "0";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDays.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Handler);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHours.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(116, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(107, 50);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "0";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHours.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Handler);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMinutes.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(229, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(107, 50);
            this.lblMinutes.TabIndex = 5;
            this.lblMinutes.Text = "0";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinutes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Handler);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeconds.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(342, 0);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(110, 50);
            this.lblSeconds.TabIndex = 0;
            this.lblSeconds.Text = "0";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeconds.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Handler);
            // 
            // tmrUpdateTimer
            // 
            this.tmrUpdateTimer.Interval = 1000;
            this.tmrUpdateTimer.Tick += new System.EventHandler(this.tmUpdateTimer_Tick);
            // 
            // mnuRightClick
            // 
            this.mnuRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.mnuRightClick.Name = "mnuRightClick";
            this.mnuRightClick.Size = new System.Drawing.Size(128, 54);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.configureToolStripMenuItem.Text = "Configure";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // DateCountdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 126);
            this.ContextMenuStrip = this.mnuRightClick;
            this.Controls.Add(this.conCountdown);
            this.Controls.Add(this.lblCountdownTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateCountdownForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Date Countdown";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DateCountdownForm_FormClosing);
            this.Shown += new System.EventHandler(this.DateCountdownForm_Shown);
            this.LocationChanged += new System.EventHandler(this.DateCountdownForm_LocationChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Handler);
            this.conCountdown.ResumeLayout(false);
            this.conCountdown.PerformLayout();
            this.mnuRightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCountdownTitle;
        private System.Windows.Forms.TableLayoutPanel conCountdown;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Timer tmrUpdateTimer;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblSecondsTitle;
        private System.Windows.Forms.Label lblMinutesTitle;
        private System.Windows.Forms.Label lblHoursTitle;
        private System.Windows.Forms.Label lblDaysTitle;
        private System.Windows.Forms.ContextMenuStrip mnuRightClick;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

