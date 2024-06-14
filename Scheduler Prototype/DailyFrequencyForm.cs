using Org.BouncyCastle.Bcpg;
using Scheduler_Prototype.Data;
using Scheduler_Prototype.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Scheduler_Prototype
{
    public partial class DailyFrequencyForm : Form
    {
        DateTime event2StartTime;
        DateTime event3StartTime;
        DateTime event4StartTime;
        DateTime event5StartTime;
        DateTime baseTime;
        string dailyFreq;
        int isTimedMode = 0;

        public DailyFrequencyForm()
        {
            InitializeComponent();
        }
        public DailyFrequencyForm(string dailyFreq, DateTime baseTime, int isTimedMode)
        {
            InitializeComponent();
            this.baseTime = baseTime;
            this.dailyFreq = dailyFreq;
            this.isTimedMode = isTimedMode;
        }

        private void DailyFrequencyForm_Load(object sender, EventArgs e)
        {
            if (isTimedMode == 1)
            {
                label2.Text = "Second Event Desired Start Time:";
                label3.Text = "Third Event Desired Start Time:";
                label4.Text = "Fourth Event Desired Start Time:";
                label5.Text = "Fifth Event Desired Start Time:";
            }
            if (dailyFreq == "Twice a day")
            {
                label2.Visible = true;
                cbEvent2StartTime.Visible = true;
            }
            if (dailyFreq == "Three times a day")
            {
                label2.Visible = true;
                cbEvent2StartTime.Visible = true;
                label3.Visible = true;
                cbEvent3StartTime.Visible = true;
            }
            if (dailyFreq == "Four times a day")
            {
                label2.Visible = true;
                cbEvent2StartTime.Visible = true;
                label3.Visible = true;
                cbEvent3StartTime.Visible = true;
                label4.Visible = true;
                cbEvent4StartTime.Visible = true;
            }
            if (dailyFreq == "Five times a day")
            {
                label2.Visible = true;
                cbEvent2StartTime.Visible = true;
                label3.Visible = true;
                cbEvent3StartTime.Visible = true;
                label4.Visible = true;
                cbEvent4StartTime.Visible = true;
                label5.Visible = true;
                cbEvent5StartTime.Visible = true;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DateTime event2StartTime = baseTime;
            DateTime event3StartTime = baseTime;
            DateTime event4StartTime = baseTime;
            DateTime event5StartTime = baseTime;

            // Calculate the time based on the selected index and 15-minute increments
            if (dailyFreq == "Twice a day" || dailyFreq == "Three times a day" || dailyFreq == "Four times a day" || dailyFreq == "Five times a day")
            {
                int selectedIndex = cbEvent2StartTime.SelectedIndex;
                event2StartTime = event2StartTime.AddMinutes(selectedIndex * 15);
                this.event2StartTime = event2StartTime;
                if (dailyFreq == "Three times a day")
                {
                    int selectedIndex2 = cbEvent3StartTime.SelectedIndex;
                    event3StartTime = event3StartTime.AddMinutes(selectedIndex2 * 15);
                    this.event3StartTime = event3StartTime;
                }
                if (dailyFreq == "Four times a day")
                {
                    int selectedIndex2 = cbEvent3StartTime.SelectedIndex;
                    event3StartTime = event3StartTime.AddMinutes(selectedIndex2 * 15);
                    this.event3StartTime = event3StartTime;

                    int selectedIndex3 = cbEvent4StartTime.SelectedIndex;
                    event4StartTime = event4StartTime.AddMinutes(selectedIndex3 * 15);
                    this.event4StartTime = event4StartTime;
                }
                if (dailyFreq == "Five times a day")
                {
                    int selectedIndex2 = cbEvent3StartTime.SelectedIndex;
                    event3StartTime = event3StartTime.AddMinutes(selectedIndex2 * 15);
                    this.event3StartTime = event3StartTime;

                    int selectedIndex3 = cbEvent4StartTime.SelectedIndex;
                    event4StartTime = event4StartTime.AddMinutes(selectedIndex3 * 15);
                    this.event4StartTime = event4StartTime;

                    int selectedIndex4 = cbEvent5StartTime.SelectedIndex;
                    event5StartTime = event5StartTime.AddMinutes(selectedIndex4 * 15);
                    this.event5StartTime = event5StartTime;
                }
            }
 
            this.DialogResult = DialogResult.OK;
        }

        public void specificStartTime()
        {
            label2.Text = "Second Event Start Time:";
            label3.Text = "Third Event Start Time:";
            label4.Text = "Fourth Event Start Time:";
            label5.Text = "Fifth Event Start Time:";
            
        }

        public void desiredStartTime()
        {
            label2.Text = "Second Event Desired Start Time:";
            label3.Text = "Third Event Desired Start Time:";
            label4.Text = "Fourth Event Desired Start Time:";
            label5.Text = "Fifth Event Desired Start Time:";

        }
        public DateTime Event2Value
        {
            get { return event2StartTime; }
        }
        public DateTime Event3Value
        {
            get { return event3StartTime; }
        }
        public DateTime Event4Value
        {
            get { return event4StartTime; }
        }
        public DateTime Event5Value
        {
            get { return event5StartTime; }
        }
    }
}
