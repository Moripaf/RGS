using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner.timer
{
    public delegate void TimerAddDelegate(timerEventArgs args);
    public class timerEventArgs  : EventArgs
    {
        public bool state;
        public timerEventArgs(bool state)
        {
            this.state = state;
        }
    }
}
