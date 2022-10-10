using MissionPlanner.timer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MissionPlanner
{
    public partial class TimerForm : Form
    {
        Timer timer;
        private bool _isOn;
        long timeInSeconds = 0;
        bool isRunning = false;
        TimeSpan time;
        public static event TimerAddDelegate _timerEventhandler;

        public TimerForm()
        {
            _timerEventhandler = new TimerAddDelegate(timerEventHandler);
            InitializeComponent();
            
        }

        public bool IsOn
        {
            set {              
                if (_timerEventhandler != null)
                {
                    timerEventArgs args = new timerEventArgs(value);
                    _timerEventhandler.Invoke(args);
                }
            
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {

            startTimer();
            
        }
        
        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopTimer();
        }
        
        private void buttonReset_Click(object sender, EventArgs e)
        {
            if(isRunning)
            {
                stopTimer();
            }
               timeInSeconds = 0;
               showTime();
        }
        public void startTimer()
        {
            try
            {
                timer.Start();
            }
            catch (NullReferenceException ex)
            {
                timer = createTimer();
                timer.Start();
            }
            finally
            {
                isRunning = true;
            }
        }
        public void stopTimer()
        {
            timer.Stop();
            isRunning = false;
        }
        private  void TimerCallback(object sender, EventArgs e)
        {
            timeInSeconds++;
            showTime();
        }
        public Timer createTimer()
        {
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += TimerCallback;
            return t;
        }
        public void showTime()
        {
            time = TimeSpan.FromSeconds(timeInSeconds);
            label.Text = time.ToString(@"hh\:mm\:ss");
        }
        public void timerEventHandler(timerEventArgs args)
        {
            if (args.state)           
                startTimer();           
            else
                stopTimer();          

        }

    }
}
