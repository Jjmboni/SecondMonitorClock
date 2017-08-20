namespace Clock
{
    partial class frmClock
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
            this.lblHour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblAMPM = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHour
            // 
            this.lblHour.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(6, 0);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(26, 20);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "12";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHour.Click += new System.EventHandler(this.Clock_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            this.label2.Click += new System.EventHandler(this.Clock_Click);
            // 
            // lblMin
            // 
            this.lblMin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(38, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(26, 20);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "59";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMin.Click += new System.EventHandler(this.Clock_Click);
            // 
            // lblAMPM
            // 
            this.lblAMPM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMPM.Location = new System.Drawing.Point(61, 0);
            this.lblAMPM.Name = "lblAMPM";
            this.lblAMPM.Size = new System.Drawing.Size(33, 20);
            this.lblAMPM.TabIndex = 3;
            this.lblAMPM.Text = "PM";
            this.lblAMPM.Click += new System.EventHandler(this.Clock_Click);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(88, 20);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "12/31/2016";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDate.Click += new System.EventHandler(this.Clock_Click);
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(99, 40);
            this.ControlBox = false;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAMPM);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Shown += new System.EventHandler(this.frmClock_Shown);
            this.Click += new System.EventHandler(this.Clock_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblAMPM;
        private System.Windows.Forms.Label lblDate;
    }
}

