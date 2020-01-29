using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Clock
{
    public partial class AddEditAlarm : Form
    {
        private string time;

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        AlarmClock clock = new AlarmClock();

        public AddEditAlarm()
        {
            InitializeComponent();
            if(clock.CurItem != null)
            {
                uxTime.Text.Replace(uxTime.Text, clock.CurItem); 
            }
        }

        private void uxSet_Click(object sender, EventArgs e)
        {
            Time = uxTime.Text;
        }
    }
}
