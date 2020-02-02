namespace Alarm_Clock
{
    partial class AlarmClock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uxEdit = new System.Windows.Forms.Button();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxAlarmList = new System.Windows.Forms.ListBox();
            this.uxSnooze = new System.Windows.Forms.Button();
            this.uxStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // uxEdit
            // 
            this.uxEdit.Enabled = false;
            this.uxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEdit.Location = new System.Drawing.Point(12, 12);
            this.uxEdit.Name = "uxEdit";
            this.uxEdit.Size = new System.Drawing.Size(76, 46);
            this.uxEdit.TabIndex = 0;
            this.uxEdit.Text = "Edit";
            this.uxEdit.UseVisualStyleBackColor = true;
            this.uxEdit.Click += new System.EventHandler(this.uxEdit_Click);
            // 
            // uxAdd
            // 
            this.uxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAdd.Location = new System.Drawing.Point(150, 12);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(76, 46);
            this.uxAdd.TabIndex = 0;
            this.uxAdd.Text = "+";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxAlarmList
            // 
            this.uxAlarmList.FormattingEnabled = true;
            this.uxAlarmList.Location = new System.Drawing.Point(12, 104);
            this.uxAlarmList.Name = "uxAlarmList";
            this.uxAlarmList.ScrollAlwaysVisible = true;
            this.uxAlarmList.Size = new System.Drawing.Size(214, 147);
            this.uxAlarmList.TabIndex = 1;
            // 
            // uxSnooze
            // 
            this.uxSnooze.Enabled = false;
            this.uxSnooze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSnooze.Location = new System.Drawing.Point(12, 284);
            this.uxSnooze.Name = "uxSnooze";
            this.uxSnooze.Size = new System.Drawing.Size(76, 46);
            this.uxSnooze.TabIndex = 0;
            this.uxSnooze.Text = "Snooze";
            this.uxSnooze.UseVisualStyleBackColor = true;
            this.uxSnooze.Click += new System.EventHandler(this.uxSnooze_Click);
            // 
            // uxStop
            // 
            this.uxStop.Enabled = false;
            this.uxStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStop.Location = new System.Drawing.Point(150, 284);
            this.uxStop.Name = "uxStop";
            this.uxStop.Size = new System.Drawing.Size(76, 46);
            this.uxStop.TabIndex = 0;
            this.uxStop.Text = "Stop";
            this.uxStop.UseVisualStyleBackColor = true;
            this.uxStop.Click += new System.EventHandler(this.uxStop_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 353);
            this.Controls.Add(this.uxAlarmList);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxStop);
            this.Controls.Add(this.uxSnooze);
            this.Controls.Add(this.uxEdit);
            this.Name = "AlarmClock";
            this.Text = "Alarms";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AlarmClock_FormClosed);
            this.Load += new System.EventHandler(this.AlarmClock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxEdit;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Button uxSnooze;
        private System.Windows.Forms.Button uxStop;
        public System.Windows.Forms.ListBox uxAlarmList;
        private System.Windows.Forms.Timer timer1;
    }
}

