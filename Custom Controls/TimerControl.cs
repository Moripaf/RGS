using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.timer;
using MissionPlanner.GCSViews;

namespace MissionPlanner.CustomControls
{
    //TODO- rewrite using stopwatch
    public partial class TimerControl : UserControl
    {
        private bool _isOn;
        long timeInSeconds = 0;
        TimeSpan time;
        public static event TimerAddDelegate _timerEventhandler;
        public TimerControl()
        {
            _timerEventhandler = new TimerAddDelegate(timerEventHandler);
            InitializeComponent();
        }
        public bool isOn
        {
            set
            {
                if (_timerEventhandler != null)
                {
                    timerEventArgs args = new timerEventArgs(value);
                    _timerEventhandler.Invoke(args);
                    _isOn = value;
                }

            }
            get { return _isOn; }
        }
        System.Diagnostics.Stopwatch StopWatch = new System.Diagnostics.Stopwatch();
        public void Timer1_Tick(System.Object sender, System.EventArgs e)
        {
            TimeSpan elapsed = this.StopWatch.Elapsed;
            label.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(!StopWatch.IsRunning)
            {
                Timer1.Start();
                this.StopWatch.Start();
                buttonStart.Text = "توقف";
            }
            else
            {
                Timer1.Stop();
                this.StopWatch.Stop();
                buttonStart.Text = "شروع";
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.StopWatch.Reset();
            label.Text = "00:00:00";
        }
        public void timerEventHandler(timerEventArgs args)
        {
          /*  if (args.state)
                startTimer();
            else
                stopTimer();
          */
        }
    }
}
