/*
    The MIT License (MIT)

    Copyright (c) 2014 Zachary Seguin

    Permission is hereby granted, free of charge, to any person obtaining a copy of
    this software and associated documentation files (the "Software"), to deal in
    the Software without restriction, including without limitation the rights to
    use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
    the Software, and to permit persons to whom the Software is furnished to do so,
    subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
    FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
    COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
    IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
    CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ca.zacharyseguin.DateCountdown
{
    public partial class DateCountdownForm : Form
    {
        /// <summary>
        /// Title of the countdown.
        /// </summary>
        public string CountdownTitle { get; set; }

        /// <summary>
        /// Date of the countdown.
        /// </summary>
        public DateTime CountdownDate { get; set; }

        /// <summary>
        /// Window background colour.
        /// </summary>
        public Color BackgroundColour
        {
            get
            {
                return this.BackColor;
            }

            set
            {
                this.BackColor = value;
            }
        }

        /// <summary>
        /// Window Foreground Colour.
        /// </summary>
        public Color ForegroundColour
        {
            get
            {
                return this.ForeColor;
            }

            set
            {
                this.ForeColor = value;
            }
        }

        /// <summary>
        /// If the window has loaded.
        /// </summary>
        private bool loaded = false;

        /// <summary>
        /// Constructs a new Date Countdown Window.
        /// </summary>
        public DateCountdownForm()
        {
            InitializeComponent();
            Init();
        }// End of constructor method

        /// <summary>
        /// Initializes the countdown
        /// </summary>
        private void Init()
        {
            this.LoadSettings();
            Properties.Settings.Default.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
            {
                this.LoadSettings();
            };

            this.UpdateGUI();
            this.tmrUpdateTimer.Start();
        }// End of Init method

        /// <summary>
        /// Loads the user settings.
        /// </summary>
        private void LoadSettings()
        {
            this.CountdownTitle = Properties.Settings.Default.CountdownTitle;
            this.CountdownDate = Properties.Settings.Default.CountdownDate;
            this.BackgroundColour = Properties.Settings.Default.WindowBackgroundColour;
            this.ForegroundColour = Properties.Settings.Default.WindowForegroundColour;
        }// End of LoadSettings method

        /// <summary>
        /// Updates the GUI.
        /// </summary>
        private void UpdateGUI()
        {
            TimeSpan diff = this.CountdownDate - DateTime.Now;

            this.lblCountdownTitle.Text = this.CountdownTitle;
            this.lblDays.Text = diff.Days.ToString();
            this.lblHours.Text = diff.Hours.ToString();
            this.lblMinutes.Text = diff.Minutes.ToString();
            this.lblSeconds.Text = diff.Seconds.ToString();
        }// End of UpdateGUI method

        /// <summary>
        /// Update timer tick event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmUpdateTimer_Tick(object sender, EventArgs e)
        {
            this.UpdateGUI();
            this.tmrUpdateTimer.Start();
        }// End of UpdateGUI method

        /// <summary>
        /// Puts the form on the desktop.
        /// </summary>
        /// <param name="hwnd"></param>
        [DllImport("User32.dll")]
        static extern IntPtr FindWindow(String lpClassName, String lpWindowName);
        [DllImport("user32.dll")]
        static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        /// <summary>
        /// Puts the form on the desktop.
        /// </summary>
        private void SetFormOnDesktop()
        {
            IntPtr hwndf = this.Handle;
            IntPtr hwndParent = FindWindow("ProgMan", null);
            SetParent(hwndf, hwndParent);

            int x = Properties.Settings.Default.WindowLocationX;
            if (x == -1)
                x = Screen.PrimaryScreen.Bounds.Width - this.Size.Width - 20;

            int y = Properties.Settings.Default.WindowLocationY;
            if (y == -1)
                y = Screen.PrimaryScreen.Bounds.Height - this.Size.Height - 20;

            this.SetBounds(x, y, this.Width, this.Height);
        }// End of SetFormOnDesktop method

        /// <summary>
        /// Form shown event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateCountdownForm_Shown(object sender, EventArgs e)
        {
            this.SetFormOnDesktop();
            this.loaded = true;
        }// End of DateCountdownForm_Shown method

        /// <summary>
        /// Exit button clicket.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }// End of exitToolStripMenuItem_Click method

        /// <summary>
        /// Configure button clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateCountdownConfigureForm frm = new DateCountdownConfigureForm();
            frm.ShowDialog();

            this.LoadSettings();

            this.UpdateGUI();
        }// End of configureToolStripMenuItem_Click method

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        /// <summary>
        /// Mouse down handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseDown_Handler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }// End of MouseDown_Handler

        /// <summary>
        /// Window location changed event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateCountdownForm_LocationChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                Properties.Settings.Default.WindowLocationX = this.Bounds.X;
                Properties.Settings.Default.WindowLocationY = this.Bounds.Y;
            }
        }// End of DateCountdownForm_LocationChanged method

        /// <summary>
        /// For closing event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateCountdownForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }// End of DateCountdownForm_FormClosing method
    }// End of DateCountdownForm class
}// End of namespace
