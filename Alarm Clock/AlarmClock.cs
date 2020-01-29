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
        System.Timers.Timer clock;

        private string curItem;

        public string CurItem
        {
            get { return curItem; }
            set { curItem = value; }
        }

        public BindingList<string> alarms = new BindingList<string>();

        


        public AlarmClock()
        {
            InitializeComponent();
            uxAlarmList.DataSource = alarms;
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
                if(alarms.Count != 10)
                {
                    alarms.Add(alarm.Time);
                }
                
            }
            uxEdit.Enabled = true;
        }

        private void uxEdit_Click(object sender, EventArgs e)
        {
            
            if(uxAlarmList.SelectedItem != null)
            {
                AddEditAlarm addEdit = new AddEditAlarm();
                CurItem = uxAlarmList.SelectedItem.ToString();

                if (addEdit.ShowDialog() == DialogResult.OK)
                {
                    alarms.Remove(CurItem);
                    CurItem = addEdit.Time;
                    alarms.Add(CurItem);
                   
                }
            }
            else
            {
                MessageBox.Show("Select an alarm to edit");
            }
            
        }

        private void 
    }
}
