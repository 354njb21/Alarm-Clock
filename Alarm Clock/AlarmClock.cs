﻿using System;
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
        string path = @"C:\Users\19132\Source\Repos\354njb21_CW_CIS501\Proj1\alarm-clock\Alarm Clock\AlarmList.txt";

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
        
        
       
        /// <summary>
        /// Adds 5 minutes to the alarm and the timer is started again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSnooze_Click(object sender, EventArgs e)
        {
            curItem = uxAlarmList.SelectedItem.ToString();
            int index = uxAlarmList.SelectedIndex;
            string trim = curItem.Substring(0, 11);
            DateTime snooze = Convert.ToDateTime(trim);
            status = " Snoozed";
            DateTime five = snooze.AddMinutes(5);
            alarms.RemoveAt(index);
            alarms.Insert(index, five.ToLongTimeString() + status);
            timer1.Start();
        }

        /// <summary>
        /// Stops the alarm, status is changed and the timer is started again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStop_Click(object sender, EventArgs e)
        {
            int index = uxAlarmList.SelectedIndex;

            curItem = uxAlarmList.SelectedItem.ToString();
            curItem = curItem.Substring(0, 11);

            status = " Stopped";
            alarms.RemoveAt(index);
            alarms.Insert(index, curItem + status);

            timer1.Start();
        }

        /// <summary>
        /// The second form pops up and the user is able to set an alarm
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
        /// When the edit button is clicked the second form is loaded and the user can edit the alarm
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
        /// When the form is loaded then the alarms are loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlarmClock_Load(object sender, EventArgs e)
        {
            //string[] file = File.ReadAllLines(path);
            //for(int i = 0; i < file.Length; i++)
            //{
              //  alarms.Add(file[i]);
            //}
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
            if (hour > 12)
            {
                
            }
            if (uxAlarmList.Items.Count > 0)
            {
                Alarm_Going_Off();
            }
            

        }

        void Alarm_Going_Off()
        {
            
            foreach (string s in alarms)
            {
                if (s.Contains("Running") == true || s.Contains("Snoozed")== true)
                {
                    
                    string check = s;
                    check = check.Substring(0, 11);
                    
                    DateTime userTime = Convert.ToDateTime(check);
                    if (userTime.Hour.Equals(hour) && userTime.Minute.Equals(minute) && userTime.Second.Equals(second))
                    {
                        timer1.Stop();
                        MessageBox.Show(userTime + " alarm is going off");
                        uxSnooze.Enabled = true;
                        uxStop.Enabled = true;
                        
                    }

                }
            }
        }

        

        /// <summary>
        /// When the form is closed the alarms are written to the text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlarmClock_FormClosed(object sender, FormClosedEventArgs e)
        {
            int num = alarms.Count;
            string[] done = new string[num]; 
           // using (StreamWriter sw = File.WriteAllText(path))
            //{
                for(int i = 0; i < alarms.Count; i++)
                {
                done[i] = alarms[i];
                    //sw.WriteLine(alarms[i]);
                }
            File.WriteAllLines(path, done);
            //}
            alarms.Clear();
                
        }
    }
}
