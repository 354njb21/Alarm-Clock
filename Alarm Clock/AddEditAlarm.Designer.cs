namespace Alarm_Clock
{
    partial class AddEditAlarm
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
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxSet = new System.Windows.Forms.Button();
            this.uxTime = new System.Windows.Forms.DateTimePicker();
            this.uxOnButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(12, 71);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 35);
            this.uxCancel.TabIndex = 0;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            // 
            // uxSet
            // 
            this.uxSet.Location = new System.Drawing.Point(215, 71);
            this.uxSet.Name = "uxSet";
            this.uxSet.Size = new System.Drawing.Size(75, 35);
            this.uxSet.TabIndex = 0;
            this.uxSet.Text = "Set";
            this.uxSet.UseVisualStyleBackColor = true;
            this.uxSet.Click += new System.EventHandler(this.uxSet_Click);
            // 
            // uxTime
            // 
            this.uxTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxTime.Location = new System.Drawing.Point(12, 28);
            this.uxTime.Name = "uxTime";
            this.uxTime.Size = new System.Drawing.Size(200, 20);
            this.uxTime.TabIndex = 1;
            this.uxTime.Value = new System.DateTime(2020, 1, 24, 21, 25, 36, 0);
            // 
            // uxOnButton
            // 
            this.uxOnButton.AutoSize = true;
            this.uxOnButton.Location = new System.Drawing.Point(218, 31);
            this.uxOnButton.Name = "uxOnButton";
            this.uxOnButton.Size = new System.Drawing.Size(39, 17);
            this.uxOnButton.TabIndex = 2;
            this.uxOnButton.TabStop = true;
            this.uxOnButton.Text = "On";
            this.uxOnButton.UseVisualStyleBackColor = true;
            // 
            // AddEditAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 118);
            this.Controls.Add(this.uxOnButton);
            this.Controls.Add(this.uxTime);
            this.Controls.Add(this.uxSet);
            this.Controls.Add(this.uxCancel);
            this.Name = "AddEditAlarm";
            this.Text = "AddEditAlarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxSet;
        private System.Windows.Forms.DateTimePicker uxTime;
        private System.Windows.Forms.RadioButton uxOnButton;
    }
}