using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class myQuickView : UserControl
    {
        public myQuickView()
        {
            InitializeComponent();
        }
        [Description("title label shown above the number"),Category("Appearance")]
        public string title { get => label.Text; set => label.Text = value; }
        public override string Text { get => number.Text; set => number.Text = value; }

        protected override void OnResize(EventArgs e)
        {         
            base.OnResize(e);
            label.Location = new Point((this.Width - label.Width) / 2, 2);
            number.Location = new Point((this.Width - number.Width) /2, this.Height - number.Height - 2);
            fixResize();
        }
       
        private void fixResize()
        {
            if (number.Location.Y < label.Location.Y + label.Height)
                number.Font = new System.Drawing.Font("Bahnschrift Condensed", 25F, FontStyle.Regular);
            Invalidate();
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            if( number.Text == "0")          
                number.Text = "0.00";         
        }
    }
}
