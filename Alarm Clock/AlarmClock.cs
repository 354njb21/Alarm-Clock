using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                if(alarms.Count != 10)
                {
                    if(alarm.Run == true)
                    {
                        alarms.Add(alarm.Time + "  Running");
                    }
                    else
                    {
                        alarms.Add(alarm.Time);
                    }
                    
                }
                
            }
            uxEdit.Enabled = true;
        }

        private void uxEdit_Click(object sender, EventArgs e)
        {
            
            if(uxAlarmList.SelectedItem != null)
            {
                int index = uxAlarmList.SelectedIndex;
                
                curItem = uxAlarmList.SelectedItem.ToString();
                
                AddEditAlarm addEdit = new AddEditAlarm(curItem);
                if (addEdit.ShowDialog() == DialogResult.OK)
                {
                    alarms.RemoveAt(index);
                    curItem = addEdit.Time;
                    alarms.Insert(index, curItem);
                   
                }
            }
            else
            {
                MessageBox.Show("Select an alarm to edit");
            }
            
        }

        private void AlarmClock_Load(object sender, EventArgs e)
        {

        }

        private void AlarmClock_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            if(save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);

                if(alarms.Count > 0)
                {
                    for(int i = 0; i < alarms.Count; i++)
                    {
                        writer.WriteLine(alarms[i]);
                    }
                    writer.Close();
                }
            }
        }
    }
}
