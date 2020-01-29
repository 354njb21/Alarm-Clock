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
                if(uxAlarmList.Items.Count != 10)
                {
                    uxAlarmList.Items.Add(alarm.Time);
                }
                
            }
            uxEdit.Enabled = true;
        }

        private void uxEdit_Click(object sender, EventArgs e)
        {
            
            if(uxAlarmList.SelectedItem != null)
            {
                CurItem = uxAlarmList.SelectedItem.ToString();

                AddEditAlarm addEdit = new AddEditAlarm();

                if (addEdit.ShowDialog() == DialogResult.OK)
                {
                    CurItem = addEdit.Time;
                    int x = uxAlarmList.SelectedIndex;
                    uxAlarmList.Items.RemoveAt(x);
                    uxAlarmList.Items.Insert(x, CurItem);
                }
            }
            else
            {
                MessageBox.Show("Select an alarm to edit");
            }
            
        }
    }
}
