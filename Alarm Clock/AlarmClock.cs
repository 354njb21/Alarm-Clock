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
    /// <summary>
    /// Main form that includes the list of alarms and their statuses
    /// </summary>
    public partial class AlarmClock : Form
    {
        string path = @"C:\Users\19132\source\repos\Alarm Clock\Alarm Clock\AlarmList.txt";

        /// <summary>
        /// Private variable for the status of an alarm
        /// </summary>
        private string status;

        /// <summary>
        /// Private backing variable for the public CurItem field
        /// </summary>
        private string curItem;

        /// <summary>
        /// Public field storing the current selected alarm so the second form can access that data
        /// </summary>
        public string CurItem
        {
            get { return curItem; }
            set { curItem = value; }
        }

        /// <summary>
        /// A list of the alarms that is binded to the listbox
        /// </summary>
        public BindingList<string> alarms = new BindingList<string>();

        


        public AlarmClock()
        {
            InitializeComponent();
            uxAlarmList.DataSource = alarms;
            
        }

        int hour, minute, second;
        TimeSpan timeOfDay;
        
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSnooze_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStop_Click(object sender, EventArgs e)
        {
            int index = uxAlarmList.SelectedIndex;

            curItem = uxAlarmList.SelectedItem.ToString();
            curItem = curItem.Substring(0, 10);

            status = " Stopped";
            alarms.RemoveAt(index);
            alarms.Insert(index, curItem + status);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAdd_Click(object sender, EventArgs e)
        {
            
            AddEditAlarm alarm = new AddEditAlarm();
            if(alarm.ShowDialog() == DialogResult.OK)
            {
                if(alarms.Count != 10)
                {
                    if(alarm.Run == true)
                    {
                        status = " Running";
                        alarms.Add(alarm.Time + status);
                    }
                    else
                    {
                        status = " Off";
                        alarms.Add(alarm.Time + status);
                    }
                }
                
            }
            uxEdit.Enabled = true;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEdit_Click(object sender, EventArgs e)
        {
            
            if(uxAlarmList.SelectedItem != null)
            {
                int index = uxAlarmList.SelectedIndex;
                
                curItem = uxAlarmList.SelectedItem.ToString();
                curItem = curItem.Substring(0, 10);
                
                AddEditAlarm addEdit = new AddEditAlarm(curItem);
                if (addEdit.ShowDialog() == DialogResult.OK)
                {
                    alarms.RemoveAt(index);
                    curItem = addEdit.Time;

                    if(addEdit.Run == true)
                    {
                        status = " Running";
                        alarms.Insert(index, curItem + status);
                    }
                    else
                    {
                        status = " Off";
                        alarms.Insert(index, curItem + status);
                    }
                    
                    
                   
                }
            }
            else
            {
                MessageBox.Show("Select an alarm to edit");
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlarmClock_Load(object sender, EventArgs e)
        {

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
            timeOfDay = DateTime.Now.TimeOfDay;
            if (uxAlarmList.Items.Count > 0)
            {
                Alarm_Going_Off();
            }

        }

        void Alarm_Going_Off()
        {
            
            foreach (string s in alarms)
            {
                if (s.Contains("Running") == true)
                {
                    string check = s;
                    check = check.Substring(0, 10);
                    DateTime userTime = Convert.ToDateTime(check);
                    if (userTime.Hour == hour && userTime.Minute == minute && userTime.Second == second && userTime.TimeOfDay == timeOfDay)
                    {
                        MessageBox.Show(userTime + "alarm is going off");
                        uxSnooze.Enabled = true;
                        uxStop.Enabled = true;

                    }

                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime curTime = DateTime.Now;
            foreach (string s in uxAlarmList.Items)
            {
                if (s.Contains(" Running") == true)
                {
                    curItem = s.Substring(0, 10);
                    DateTime userTime = Convert.ToDateTime(curItem);
                    if(curTime.Hour == userTime.Hour && curTime.Minute == userTime.Minute && curTime.Second == userTime.Second && curTime.TimeOfDay == userTime.TimeOfDay)
                    {
                        MessageBox.Show(userTime + "alarm is going off");
                        uxSnooze.Enabled = true;
                        uxStop.Enabled = true;
                        
                    }

                }
            }
        }*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlarmClock_FormClosed(object sender, FormClosedEventArgs e)
        {
            

            using (StreamWriter sw = File.AppendText(path))
            {

            }

                
        }
    }
}
