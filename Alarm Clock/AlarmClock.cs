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
    public partial class AlarmClock : Form
    {
        
        public AlarmClock()
        {
            InitializeComponent();
        }

        private void uxSnooze_Click(object sender, EventArgs e)
        {

        }

        private void uxStop_Click(object sender, EventArgs e)
        {

        }

        private void uxAdd_Click(object sender, EventArgs e)
        {
            AddEditAlarm alarm = new AddEditAlarm();
            if(alarm.ShowDialog() == DialogResult.OK)
            {
                uxAlarmList.Items.Add(alarm.Time);
            }
        }

        private void uxEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
