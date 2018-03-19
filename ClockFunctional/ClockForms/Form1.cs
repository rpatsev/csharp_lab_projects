using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockForms
{
    public partial class Form1 : Form
    {
        Thread clockThread;
        public Form1()
        {
            InitializeComponent();
            clockThread = new Thread(StartClock);
            clockThread.Start();
        }

        private void StartClock()
        {
            var clock = new Clock();
            clock.Ticked += SetClockLabel;
            clock.Tick();
        }

        private void SetClockLabel(object sender, TimeEventArgs e)
        {
            var clock = sender as Clock;
            lblClock.Text = String.Format("{0}:{1}:{2}", e.Hour, e.Minute, e.Second);
        }

    }
}
