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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ca.zacharyseguin.DateCountdown
{
    public partial class DateCountdownConfigureForm : Form
    {
        public DateCountdownConfigureForm()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DateCountdownConfigureForm_Load(object sender, EventArgs e)
        {
            this.txtCountdownTitle.Text = Properties.Settings.Default.CountdownTitle;
            this.dtCountdownDate.Value = Properties.Settings.Default.CountdownDate;
        }

        private void cmdSetBackgroundColour_Click(object sender, EventArgs e)
        {
            ColorDialog colourDialog = new ColorDialog();
            colourDialog.Color = Properties.Settings.Default.WindowBackgroundColour;

            DialogResult result = colourDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.WindowBackgroundColour = colourDialog.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void cmdSetForegroundColour_Click(object sender, EventArgs e)
        {
            ColorDialog colourDialog = new ColorDialog();
            colourDialog.Color = Properties.Settings.Default.WindowBackgroundColour;

            DialogResult result = colourDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.WindowForegroundColour = colourDialog.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void txtCountdownTitle_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CountdownTitle = txtCountdownTitle.Text;
            Properties.Settings.Default.Save();
        }

        private void dtCountdownDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dtCountdownDate.Value;
            date = date.AddHours(-date.Hour);
            date = date.AddMinutes(-date.Minute);
            date = date.AddSeconds(-date.Second);
            date = date.AddMilliseconds(-date.Millisecond);

            Properties.Settings.Default.CountdownDate = date;
            Properties.Settings.Default.Save();
        }

        private void cmdDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
