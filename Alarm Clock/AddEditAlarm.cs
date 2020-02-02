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
    /// <summary>
    /// Partial class for the second form which is for adding and editing alarms
    /// </summary>
    public partial class AddEditAlarm : Form
    {
        /// <summary>
        /// Private backing variable for the public Time property
        /// </summary>
        private string time;

        /// <summary>
        /// Public string time field for the first form to access
        /// </summary>
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        /// <summary>
        /// Private backing variable for the Run field
        /// </summary>
        private bool run;

        /// <summary>
        /// Public bool field for the status of the alarm being on or off
        /// </summary>
        public bool Run
        {
            get { return run; }
            set { run = value; }
        }

        
        /// <summary>
        /// Constructor for the Add click method
        /// </summary>
        public AddEditAlarm()
        {
            InitializeComponent();
            uxTime.Value = DateTime.Now;
        }

        /// <summary>
        /// Separate constructor specifically for the Edit event because the time picker needs
        /// to represent the alarm time selected in the listbox
        /// </summary>
        /// <param name="edit">The value of the time selected in the listbox</param>
        public AddEditAlarm(string edit)
        {
            InitializeComponent();
            DateTime dateTime = Convert.ToDateTime(edit);
            uxTime.Value = dateTime;
        }

        /// <summary>
        /// Click event for the set button
        /// If the radio button is checked then the bool is set to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
