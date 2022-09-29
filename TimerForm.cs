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
        public TimerForm()
        {
            InitializeComponent();
            
        }

        long timeInSeconds=0;
        bool isRunning = false;
        TimeSpan time;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                timer.Start();
            }
            catch(NullReferenceException ex)
            {
                timer = createTimer();
                timer.Start();
            }
            finally
            {
                isRunning = true;
            }
            
            
        }
        
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            isRunning = false;
        }
        
        private void buttonReset_Click(object sender, EventArgs e)
        {
            if(isRunning)
            {
                buttonStop_Click(sender,e);
            }
               timeInSeconds = 0;
               showTime();
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
        
    }
}
