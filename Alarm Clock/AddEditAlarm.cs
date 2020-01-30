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

        private bool run;

        public bool Run
        {
            get { return run; }
            set { run = value; }
        }

        AlarmClock clock = new AlarmClock();

        public AddEditAlarm()
        {
            InitializeComponent();
            uxTime.Value = DateTime.Now;
        }

        public AddEditAlarm(string edit)
        {
            InitializeComponent();
            DateTime dateTime = Convert.ToDateTime(edit);
            uxTime.Value = dateTime;
        }

        private void uxSet_Click(object sender, EventArgs e)
        {
            time = uxTime.Text;
            if(uxRadioButton.Checked == true)
            {
                run = true;
            }
        }
    }
}
