using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace Clock
{
    public partial class frmClock : Form
    {
        private readonly Timer _timer;
        public frmClock()
        {
            InitializeComponent();

            _timer = new Timer(Callback, null, 1000, Timeout.Infinite);            
        }

        private void Callback(Object state)
        {
            this.Invoke((MethodInvoker)UpdateClock);
            
            _timer.Change(1000, Timeout.Infinite);
        }

        private void UpdateClock()
        {
            string meridian = "AM";
            int intHour = DateTime.Now.Hour;
            
            if (intHour >= 12)
            {
                if (intHour == 12 || intHour == 0) {
                    intHour = 12;
                }
                else {
                    intHour -= 12;
                }

                meridian = "PM";
            }
            lblHour.Text = intHour.ToString("##"); // runs on UI thread
            lblMin.Text = DateTime.Now.Minute.ToString("00");
            lblAMPM.Text = meridian;
            lblDate.Text = DateTime.Now.ToShortDateString();
            PositionClock();
        }

        private void frmClock_Shown(object sender, EventArgs e)
        {
            UpdateClock();
            PositionClock();
        }

        private void PositionClock()
        {
            TopMost = true;
            Width = lblAMPM.Left + lblAMPM.Width;
            //Set in lower right of second monitor
            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens)
            {
                if (!screen.Primary)
                {
                    Left = screen.Bounds.X + screen.Bounds.Width - Width;
                    Top = screen.Bounds.Y + screen.Bounds.Height - Height;
                    break;
                }
            }
        }

        private void Clock_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                Application.Exit();
            }
            if (me.Button == MouseButtons.Left)
            {
                PositionClock();
            }
        }
    }
}
