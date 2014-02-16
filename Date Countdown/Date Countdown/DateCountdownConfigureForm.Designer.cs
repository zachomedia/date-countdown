namespace ca.zacharyseguin.DateCountdown
{
    partial class DateCountdownConfigureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateCountdownConfigureForm));
            this.dtCountdownDate = new System.Windows.Forms.DateTimePicker();
            this.lblCountdownDateTitle = new System.Windows.Forms.Label();
            this.lblCountdownTitleTitle = new System.Windows.Forms.Label();
            this.txtCountdownTitle = new System.Windows.Forms.TextBox();
            this.cmdDone = new System.Windows.Forms.Button();
            this.cmdSetBackgroundColour = new System.Windows.Forms.Button();
            this.cmdSetForegroundColour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtCountdownDate
            // 
            this.dtCountdownDate.CustomFormat = "dddd, MMMM dd, yyyy";
            this.dtCountdownDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCountdownDate.Location = new System.Drawing.Point(16, 69);
            this.dtCountdownDate.Name = "dtCountdownDate";
            this.dtCountdownDate.Size = new System.Drawing.Size(255, 20);
            this.dtCountdownDate.TabIndex = 2;
            this.dtCountdownDate.ValueChanged += new System.EventHandler(this.dtCountdownDate_ValueChanged);
            // 
            // lblCountdownDateTitle
            // 
            this.lblCountdownDateTitle.AutoSize = true;
            this.lblCountdownDateTitle.Location = new System.Drawing.Point(13, 53);
            this.lblCountdownDateTitle.Name = "lblCountdownDateTitle";
            this.lblCountdownDateTitle.Size = new System.Drawing.Size(84, 13);
            this.lblCountdownDateTitle.TabIndex = 1;
            this.lblCountdownDateTitle.Text = "Coutdown Date:";
            // 
            // lblCountdownTitleTitle
            // 
            this.lblCountdownTitleTitle.AutoSize = true;
            this.lblCountdownTitleTitle.Location = new System.Drawing.Point(13, 13);
            this.lblCountdownTitleTitle.Name = "lblCountdownTitleTitle";
            this.lblCountdownTitleTitle.Size = new System.Drawing.Size(95, 13);
            this.lblCountdownTitleTitle.TabIndex = 2;
            this.lblCountdownTitleTitle.Text = "Countdown Name:";
            // 
            // txtCountdownTitle
            // 
            this.txtCountdownTitle.Location = new System.Drawing.Point(16, 30);
            this.txtCountdownTitle.Name = "txtCountdownTitle";
            this.txtCountdownTitle.Size = new System.Drawing.Size(255, 20);
            this.txtCountdownTitle.TabIndex = 1;
            this.txtCountdownTitle.TextChanged += new System.EventHandler(this.txtCountdownTitle_TextChanged);
            // 
            // cmdDone
            // 
            this.cmdDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDone.Location = new System.Drawing.Point(197, 154);
            this.cmdDone.Name = "cmdDone";
            this.cmdDone.Size = new System.Drawing.Size(75, 23);
            this.cmdDone.TabIndex = 3;
            this.cmdDone.Text = "Done";
            this.cmdDone.UseVisualStyleBackColor = true;
            this.cmdDone.Click += new System.EventHandler(this.cmdDone_Click);
            // 
            // cmdSetBackgroundColour
            // 
            this.cmdSetBackgroundColour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSetBackgroundColour.Location = new System.Drawing.Point(16, 96);
            this.cmdSetBackgroundColour.Name = "cmdSetBackgroundColour";
            this.cmdSetBackgroundColour.Size = new System.Drawing.Size(255, 23);
            this.cmdSetBackgroundColour.TabIndex = 5;
            this.cmdSetBackgroundColour.Text = "Set Background Colour...";
            this.cmdSetBackgroundColour.UseVisualStyleBackColor = true;
            this.cmdSetBackgroundColour.Click += new System.EventHandler(this.cmdSetBackgroundColour_Click);
            // 
            // cmdSetForegroundColour
            // 
            this.cmdSetForegroundColour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSetForegroundColour.Location = new System.Drawing.Point(16, 125);
            this.cmdSetForegroundColour.Name = "cmdSetForegroundColour";
            this.cmdSetForegroundColour.Size = new System.Drawing.Size(255, 23);
            this.cmdSetForegroundColour.TabIndex = 6;
            this.cmdSetForegroundColour.Text = "Set Foreground Colour...";
            this.cmdSetForegroundColour.UseVisualStyleBackColor = true;
            this.cmdSetForegroundColour.Click += new System.EventHandler(this.cmdSetForegroundColour_Click);
            // 
            // DateCountdownConfigureForm
            // 
            this.AcceptButton = this.cmdDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.cmdSetForegroundColour);
            this.Controls.Add(this.cmdSetBackgroundColour);
            this.Controls.Add(this.cmdDone);
            this.Controls.Add(this.txtCountdownTitle);
            this.Controls.Add(this.lblCountdownTitleTitle);
            this.Controls.Add(this.lblCountdownDateTitle);
            this.Controls.Add(this.dtCountdownDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateCountdownConfigureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure Countdown";
            this.Load += new System.EventHandler(this.DateCountdownConfigureForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtCountdownDate;
        private System.Windows.Forms.Label lblCountdownDateTitle;
        private System.Windows.Forms.Label lblCountdownTitleTitle;
        private System.Windows.Forms.TextBox txtCountdownTitle;
        private System.Windows.Forms.Button cmdDone;
        private System.Windows.Forms.Button cmdSetBackgroundColour;
        private System.Windows.Forms.Button cmdSetForegroundColour;
    }
}