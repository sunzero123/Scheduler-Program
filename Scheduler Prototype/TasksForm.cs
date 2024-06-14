using System.Data.SqlClient;
using Scheduler_Prototype.Data;
using Scheduler_Prototype.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Lifetime;
using Google.Protobuf.WellKnownTypes;
using DocumentFormat.OpenXml.Bibliography;
using System.Linq.Expressions;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace Scheduler_Prototype
{ // Abandon all hope all ye who enter here
    public partial class TasksForm : Form
    {
        Scheduler scheduler = new Scheduler();

        // 1 is view, 2 is add, 3 is modify
        int FormMode = 1;
        System.Data.DataTable dt;
        int sid;
        int tid; // task id
        Tasks task = new Tasks();
        DateTime event2StartTime;
        DateTime event3StartTime;
        DateTime event4StartTime;
        DateTime event5StartTime;
        [Flags]
        enum DaysOfWeek : byte
        {
            Monday = 1 << 0,
            Tuesday = 1 << 1,
            Wednesday = 1 << 2,
            Thursday = 1 << 3,
            Friday = 1 << 4,
            Saturday = 1 << 5,
            Sunday = 1 << 6
        }
        public TasksForm()
        {
            InitializeComponent();
        }
        public TasksForm(Form f, int sid)
        {
            InitializeComponent();
            this.sid = sid;
            FormMode = 1;
        }
        // if no study id selected form locks
        private void TasksForm_Load(object sender, EventArgs e)
        {
            disableCtrls();
            btnNavToEvents.Visible = false;
            enableNecCtrls();
            FillComboBoxes();
            ClearAllTextboxes(this);
            comboBoxWeeklyFreq.SelectedIndex = 0;
            comboBoxDailyFreq.SelectedIndex = 0;
            btnDailyFreq.Visible = false;
            checkBoxCF.Checked = true;

            if (sid == 0)
            {
                search();
            }
            else if (sid > 0)
            {
                // Get Study for start and end date

                Studies s = DBUtilsForScheduler.GetAStudyUsingSP(sid);

                startDatePicker.Value = s.startDate;
                endDatePicker.Value = s.endDate;
                taskStartDatePicker.Value = startDatePicker.Value.Date;
                cbStudyNumber.Text = s.studyNum.ToString();

                cbTech.Text = DBUtilsForScheduler.GetTechName(s.technicianID);


                cbFilterStudyNum.Text = s.studyNum.ToString();
                
                search();
            }
        }

        /*
         _______               __      __                                ________                                 __               
        |       \             |  \    |  \                              |        \                               |  \              
        | $$$$$$$\ __    __  _| $$_  _| $$_     ______   _______        | $$$$$$$$__     __   ______   _______  _| $$_     _______ 
        | $$__/ $$|  \  |  \|   $$ \|   $$ \   /      \ |       \       | $$__   |  \   /  \ /      \ |       \|   $$ \   /       \
        | $$    $$| $$  | $$ \$$$$$$ \$$$$$$  |  $$$$$$\| $$$$$$$\      | $$  \   \$$\ /  $$|  $$$$$$\| $$$$$$$\\$$$$$$  |  $$$$$$$
        | $$$$$$$\| $$  | $$  | $$ __ | $$ __ | $$  | $$| $$  | $$      | $$$$$    \$$\  $$ | $$    $$| $$  | $$ | $$ __  \$$    \ 
        | $$__/ $$| $$__/ $$  | $$|  \| $$|  \| $$__/ $$| $$  | $$      | $$_____   \$$ $$  | $$$$$$$$| $$  | $$ | $$|  \ _\$$$$$$\
        | $$    $$ \$$    $$   \$$  $$ \$$  $$ \$$    $$| $$  | $$      | $$     \   \$$$    \$$     \| $$  | $$  \$$  $$|       $$
         \$$$$$$$   \$$$$$$     \$$$$   \$$$$   \$$$$$$  \$$   \$$       \$$$$$$$$    \$      \$$$$$$$ \$$   \$$   \$$$$  \$$$$$$$ 

         */

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Insert new Task
            // check if form mode is modify or add to decide save method
            if (taskStartDatePicker.Value > endDatePicker.Value)
            {
                MessageBox.Show("Error: Task Start Date cannot exceed Study End Date");
                return;
            }
            if (cbStudyNumber.Text == "") 
            {
                MessageBox.Show("Error: invalid input for Study Number");
                return;
            }
            if (cbTech.Text == "")
            {
                MessageBox.Show("Error: invalid input for Technician");
                return;
            }
            if (cbTaskType.Text == "")
            {
                MessageBox.Show("Error: invalid input for Task Type");
                return;
            }
            if (comboBoxWeeklyFreq.Text == "")
            {
                MessageBox.Show("Error: invalid input for Weekly Frequency");
                return;
            }
            if (numOccur.Text == "" || Convert.ToInt32(numOccur.Value) < 1) 
            {
                MessageBox.Show("Error: invalid input for Number of Occurrences");
                return;
            }
            if (comboBoxDailyFreq.Text == "")
            {
                MessageBox.Show("Error: invalid input for Daily Frequency");
                return;
            }
            //input validation to ensure additional daily events are added
            if(comboBoxDailyFreq.SelectedIndex == 1 &&
                event2StartTime.ToLongTimeString() == taskStartDatePicker.Value.Date.ToLongTimeString())
            {
                MessageBox.Show("Error: please be sure to add additional daily event time.");
                return;
            }
            if (comboBoxDailyFreq.SelectedIndex == 2 &&
                (event2StartTime.ToLongTimeString() == taskStartDatePicker.Value.Date.ToLongTimeString() ||
                event3StartTime.ToLongTimeString() == taskStartDatePicker.Value.Date.ToLongTimeString()))
            {
                MessageBox.Show("Error: please be sure to add additional daily event time.");
                return;
            }
            if (comboBoxDailyFreq.SelectedIndex == 3 &&
                (event2StartTime.ToLongTimeString() == taskStartDatePicker.Value.Date.ToLongTimeString() ||
                event3StartTime.ToLongTimeString() == taskStartDatePicker.Value.Date.ToLongTimeString() ||
                event4StartTime.ToLongTimeString() == taskStartDatePicker.Value.Date.ToLongTimeString()))
            {
                MessageBox.Show("Error: please be sure to add additional daily event time.");
                return;
            }
            if (comboBoxDailyFreq.SelectedIndex == 4 &&
                (event2StartTime.ToLongTimeString() == taskStartDatePicker.Value.Date.ToLongTimeString() ||
                event3StartTime.ToLongTimeString() == taskStartDatePicker.Value.Date.ToLongTimeString() ||
                event4StartTime.ToLongTimeString() == taskStartDatePicker.Value.Date.ToLongTimeString() ||
                event5StartTime.ToLongTimeString() == taskStartDatePicker.Value.Date.ToLongTimeString()))
            {
                MessageBox.Show("Error: please be sure to add additional daily event time.");
                return;
            }

            if (!string.IsNullOrEmpty(cbTaskType.Text) && (FormMode == 2)) // insert new study
            {
                Tasks task = new Tasks();
                InstantiateTaskFromTextBoxes(task);

                try
                {
                    // This code block gets executed for unassigned time tasks
                    if (!checkBoxTimedEvent.Checked)
                    {
                        Events event1 = new Events();
                        copyTaskPropertiesToEvent(task, event1);

                        event1.startDateTime = task.taskStartDate;
                        event1 = scheduler.AddUnassignedEvent(event1, 1);
                        /* task start time is assigned the first event's start time.
                         * However, auto scheduling means the event start time may be different each day */
                        task.taskStartDate = event1.startDateTime;
                    }
                    int recInserted = DBUtilsForScheduler.InsertTaskUsingSP(task);
                    if (recInserted > 0)
                    {
                        MessageBox.Show("Successfully inserted Task rec!");               
                        // right now even if events have conflicts the task gets created
                        // maybe the task shouldn't get created either
                        createEvents(task);
                        
                        if (checkBoxTimedEvent.Checked) // auto-assigned events don't print dropped events
                        {
                            scheduler.PrintDroppedEvents();
                            scheduler.clearDroppedEvents();
                        }
                        scheduler.ClearEventCount();
                        scheduler.clearDbEvents();
                        scheduler.clearEvents();

                        UpdateTaskTextBoxes(task);
                    }
                    else
                    {
                        MessageBox.Show("Did not insert Task rec!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Task Failed! Error = " + ex.Message);
                }
                disableCtrls();
                enableNecCtrls();
                search();
            }
        
            else if (FormMode == 3) // Modify Study
            {
                InstantiateTaskFromTextBoxes(task);
                try
                {
                    // This code block gets executed for unassigned time tasks
                    if (!checkBoxTimedEvent.Checked)
                    {
                        Events event1 = new Events();
                        copyTaskPropertiesToEvent(task, event1);

                        event1.startDateTime = task.taskStartDate;
                        event1 = scheduler.AddUnassignedEvent(event1, 1);
                        /* task start time is assigned the first event's start time.
                         * However, auto scheduling means the event start time may be different each day */
                        task.taskStartDate = event1.startDateTime;           
                    }
                    int recInserted = DBUtilsForScheduler.UpdateTaskUsingSP(task);
                    if (recInserted > 0)
                    {
                        MessageBox.Show("Successfully updated Task rec!");
                        deleteOldEvents(task);   
                        createEvents(task);
                        if (checkBoxTimedEvent.Checked) // auto-assigned events don't print dropped events
                        {
                            scheduler.PrintDroppedEvents();
                            scheduler.clearDroppedEvents();
                        }
                        scheduler.ClearEventCount();
                        scheduler.clearDbEvents();
                        scheduler.clearEvents();

                        UpdateTaskTextBoxes(task);
                    }
                    else
                    {
                        MessageBox.Show("Did not update Task rec!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Task rec failed: " + ex.Message);
                }
                disableCtrls();
                enableNecCtrls();
                search();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormMode = 2;
            enableAllCtrls();
            disableNonEditControls();
            ClearAllTextboxes(this);
            cbTech.Text = "";
            cbStudyNumber.Text = cbFilterStudyNum.Text;
            numOccur.Value = 1;
            comboBoxDuration.SelectedIndex = 1; // default duration of 30 minutes
            comboBoxStartTime.SelectedIndex = 12; // default time of 9 am
            checkedListBox1.ClearSelected();
            uncheckLisbox();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FormMode = 3;
            enableAllCtrls();
            disableNonEditControls();

            // proper enabling/disabling

            if (!checkBoxOnce.Checked) // if not a one time event
            {
                isNotOneTime();
            }
            else // if a one time event
            {
                isOneTime();
            }

            if (!checkBoxTimedEvent.Checked) // if not a specific timed event
            {
                isNotSpecificTime();
            }
            else // if a specific timed event
            {
                isSpecificTime();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (tid > 0)
            {
                UpdateTaskTextBoxes(task);
            }
            else
            {
                ClearAllTextboxes(this);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DBUtilsForScheduler.ConfirmDelete())
            {
                using (SqlConnection conn = DBUtilsForScheduler.MakeConnection())
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("UPDATE tasks SET deleted = 1 WHERE task_id = @taskid; UPDATE taskevents SET deleted = 1 WHERE task_id = @taskid", conn))
                        {
                            cmd.Parameters.AddWithValue("@taskid", task.taskID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Task with ID {task.taskID} has been soft-deleted.");
                                search();
                                ClearAllTextboxes(this);
                                btnNavToEvents.Visible = false;

                                disableCtrls();
                                enableNecCtrls();
                            }
                            else
                            {
                                MessageBox.Show($"No task found with ID {task.taskID}.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating 'deleted' column! " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No study selected to delete!");
            }
        }

        private void btnDailyFreq_Click(object sender, EventArgs e)
        {
            /* 
             Send task start date to Daily Freq form
             Returns start times of extra events for that day
             */
            string dailyFreq;
            dailyFreq = comboBoxDailyFreq.SelectedItem.ToString();

            DateTime basetime = taskStartDatePicker.Value.Date; 
            // Define the base time (6:00 AM) 
            DateTime baseTime = basetime.AddHours(6);
            int isTimedMode = 0;
            if(checkBoxTimedEvent.Checked)
            {
                isTimedMode = 0;
            }
            else
            {
                isTimedMode = 1;
            }

            using (DailyFrequencyForm fm = new DailyFrequencyForm(dailyFreq, baseTime, isTimedMode)) // specific time is 0, auto schedule is 1
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    this.event2StartTime = fm.Event2Value;
                    this.event3StartTime = fm.Event3Value;
                    this.event4StartTime = fm.Event4Value;
                    this.event5StartTime = fm.Event5Value;
                }
            }
        }

        /*
      __    __                      __                       __      __                            _______               __      __                                   
     |  \  |  \                    |  \                     |  \    |  \                          |       \             |  \    |  \                                  
     | $$\ | $$  ______  __     __  \$$  ______    ______  _| $$_    \$$  ______   _______        | $$$$$$$\ __    __  _| $$_  _| $$_     ______   _______    _______ 
     | $$$\| $$ |      \|  \   /  \|  \ /      \  |      \|   $$ \  |  \ /      \ |       \       | $$__/ $$|  \  |  \|   $$ \|   $$ \   /      \ |       \  /       \
     | $$$$\ $$  \$$$$$$\\$$\ /  $$| $$|  $$$$$$\  \$$$$$$\\$$$$$$  | $$|  $$$$$$\| $$$$$$$\      | $$    $$| $$  | $$ \$$$$$$ \$$$$$$  |  $$$$$$\| $$$$$$$\|  $$$$$$$
     | $$\$$ $$ /      $$ \$$\  $$ | $$| $$  | $$ /      $$ | $$ __ | $$| $$  | $$| $$  | $$      | $$$$$$$\| $$  | $$  | $$ __ | $$ __ | $$  | $$| $$  | $$ \$$    \ 
     | $$ \$$$$|  $$$$$$$  \$$ $$  | $$| $$__| $$|  $$$$$$$ | $$|  \| $$| $$__/ $$| $$  | $$      | $$__/ $$| $$__/ $$  | $$|  \| $$|  \| $$__/ $$| $$  | $$ _\$$$$$$\
     | $$  \$$$ \$$    $$   \$$$   | $$ \$$    $$ \$$    $$  \$$  $$| $$ \$$    $$| $$  | $$      | $$    $$ \$$    $$   \$$  $$ \$$  $$ \$$    $$| $$  | $$|       $$
      \$$   \$$  \$$$$$$$    \$     \$$ _\$$$$$$$  \$$$$$$$   \$$$$  \$$  \$$$$$$  \$$   \$$       \$$$$$$$   \$$$$$$     \$$$$   \$$$$   \$$$$$$  \$$   \$$ \$$$$$$$ 
                                       |  \__| $$                                                                                                                     
                                        \$$    $$                                                                                                                     
                                          \$$$$$$                                                                                                                      


        */

        private void btnNavToEvents_Click(object sender, EventArgs e)
        {
            if (task != null)
            {
                tid = task.taskID;
            }
            else
            {
                tid = 0;
            }
            EventsForm fm = new EventsForm(this, tid);
            fm.Show();
        }
        private void backToMainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.BringToFront();
            }
            this.Close();
        }

        private void btnStudies_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudiesForm fm = new StudiesForm();
            fm.Show();
            this.Close();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventsForm fm = new EventsForm();
            fm.Show();
            this.Close();
        }

        private void btnTechs_Click(object sender, EventArgs e)
        {
            this.Hide();
            TechniciansForm fm = new TechniciansForm();
            fm.Show();
            this.Close();
        }

        /*
          ________                                        __       __             __      __                        __           
        |        \                                      |  \     /  \           |  \    |  \                      |  \          
        | $$$$$$$$______    ______   ______ ____        | $$\   /  $$  ______  _| $$_   | $$____    ______    ____| $$  _______ 
        | $$__   /      \  /      \ |      \    \       | $$$\ /  $$$ /      \|   $$ \  | $$    \  /      \  /      $$ /       \
        | $$  \ |  $$$$$$\|  $$$$$$\| $$$$$$\$$$$\      | $$$$\  $$$$|  $$$$$$\\$$$$$$  | $$$$$$$\|  $$$$$$\|  $$$$$$$|  $$$$$$$
        | $$$$$ | $$  | $$| $$   \$$| $$ | $$ | $$      | $$\$$ $$ $$| $$    $$ | $$ __ | $$  | $$| $$  | $$| $$  | $$ \$$    \ 
        | $$    | $$__/ $$| $$      | $$ | $$ | $$      | $$ \$$$| $$| $$$$$$$$ | $$|  \| $$  | $$| $$__/ $$| $$__| $$ _\$$$$$$\
        | $$     \$$    $$| $$      | $$ | $$ | $$      | $$  \$ | $$ \$$     \  \$$  $$| $$  | $$ \$$    $$ \$$    $$|       $$
         \$$      \$$$$$$  \$$       \$$  \$$  \$$       \$$      \$$  \$$$$$$$   \$$$$  \$$   \$$  \$$$$$$   \$$$$$$$ \$$$$$$$ 



         */
        private void refreshDataGridView()
        {
            try
            {
                dt = DBUtilsForScheduler.GetAllTasksByStudySP(sid);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["task_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Getting Tasks using Stored Proc! " +
                    "Error = " + ex.Message);
            }
        }

        private void UpdateTaskTextBoxes(Tasks t)
        {
            tbTaskID.Text = t.taskID.ToString();
            cbStudyNumber.Text = t.studyNum.ToString();
            cbTech.Text = DBUtilsForScheduler.GetTechName(t.techID);
            numOccur.Value = t.numOccurrences;
            cbTaskType.Text = t.type.ToString();
            comboBoxWeeklyFreq.Text = t.weekly_frequency.ToString();
            comboBoxDailyFreq.Text = t.daily_frequency.ToString();
            tbComments.Text = t.comments;

            if (t.taskStartDate != null)
            {
                taskStartDatePicker.Value = t.taskStartDate;
            }
            else
            {
                taskStartDatePicker.Value = DateTime.Now;
            }

            comboBoxDuration.SelectedIndex = ((int)t.Duration.TotalMinutes / 15) - 1;

            string retrievedTime = t.taskStartDate.ToShortTimeString(); // start time from database
            int selectedIndex = comboBoxStartTime.Items.IndexOf(retrievedTime);
            // check if the retrieved value exists in the ComboBox items
            if (selectedIndex != -1)
            {
                comboBoxStartTime.SelectedIndex = selectedIndex;
            }
            else
            {
                // Handle the case where the retrieved value is not found in the ComboBox items
                comboBoxStartTime.SelectedIndex = 0; // Set to the default index or another suitable value
            }

            // handling specific timed events

            if (comboBoxStartTime.SelectedIndex == 0) // if it's not a specific timed event
            {
                checkBoxTimedEvent.Checked = false; // don't check this
            }
            else // if it is a specific timed event
            {
                checkBoxTimedEvent.Checked = true; // check this
            }

            // Handling one time events

            if (t.numOccurrences == 1 & t.weekly_frequency == "None" & t.daily_frequency == "Once a day") // if it is a true one time event
            {
                checkBoxOnce.Checked = true; // then it is checked as a one time event

            }
            else // if it is not a true one time event
            {
                checkBoxOnce.Checked = false; // dont check that box

            }

            // retrieve checked days if weekly frequency is Custom
            if (t.weekly_frequency == "Custom Days")
            {
                byte checkedDaysByte = t.customDays[0];
                SetCheckedDaysFromByte(checkedDaysByte);
            }

            // get study for the start and end dates
            Studies s = DBUtilsForScheduler.GetAStudyUsingSP(t.studyID);

            startDatePicker.Value = s.startDate;
            endDatePicker.Value = s.endDate;
        }

        private void InstantiateTaskFromTextBoxes(Tasks t)
        {
            t.type = cbTaskType.Text;
            t.numOccurrences = Convert.ToInt32(numOccur.Value);
            t.daily_frequency = comboBoxDailyFreq.SelectedItem.ToString();
            t.weekly_frequency = comboBoxWeeklyFreq.SelectedItem.ToString();

            t.studyNum = cbStudyNumber.Text;

            t.studyID = DBUtilsForScheduler.GetStudyID(t.studyNum.ToString());

            Studies study = DBUtilsForScheduler.GetAStudyUsingSP(t.studyID);

            // add a textbox for this
            t.techID = study.technicianID;

            t.studyStartDate = startDatePicker.Value.Date;
            t.studyEndDate = endDatePicker.Value.Date;

            // Get duration in minutes from ComboBox
            int durationIndex = comboBoxDuration.SelectedIndex + 1;
            t.Duration = TimeSpan.FromMinutes(durationIndex * 15);

            // might need to add error checking if they don't pick start time
            t.taskStartDate = taskStartDatePicker.Value.Date;
            // Define the base time (6:00 AM) 
            DateTime baseTime = t.taskStartDate.AddHours(6);
            // Get the selected index from the ComboBox
            int selectedIndex = comboBoxStartTime.SelectedIndex;
            // Calculate the time based on the selected index and 15-minute increments
            t.taskStartDate = baseTime.AddMinutes(selectedIndex * 15);
            t.comments = tbComments.Text;

            // checked days in custom days listbox
            if ((string)comboBoxWeeklyFreq.SelectedItem == "Custom Days")
            {
                storeCheckedDays();
                t.customDays = task.customDays;
            }
            else
            {
                // Create an empty byte array to represent an empty binary value
                byte[] emptyBytes = new byte[0];

                // Assign the empty byte array to task.customDays
                t.customDays = emptyBytes;
            }
        }

        private void deleteOldEvents(Tasks t)
        {
            if (t != null)
            {
                using (SqlConnection conn = DBUtilsForScheduler.MakeConnection())
                {
                    conn.Open();
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE taskevents SET deleted = 1 WHERE task_id = @taskid", conn))
                        {
                            cmd.Parameters.AddWithValue("@taskid", t.taskID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {

                            }
                            else
                            {
                                MessageBox.Show($"No events found with task ID {t.taskID}.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating 'deleted' column! " + ex.Message);
                    }
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tasks task;
            int tid;
            try
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                tid = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);
                try
                {
                    task = DBUtilsForScheduler.GetATaskUsingSP(tid);

                    this.task = task;
                    this.tid = tid;
     
                    UpdateTaskTextBoxes(task);

                    DBUtilsForScheduler.EnableBtn(btnModify);
                    DBUtilsForScheduler.EnableBtn(btnDelete);


                    // allow to navigate to task
                    btnNavToEvents.Visible = true;
                    btnNavToEvents.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving Task data1! " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving Task data2! " + ex.Message);
            }
        }

        private void ClearAllTextboxes(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)control).Clear();
                }
                else if (control.HasChildren)
                {
                    // Recursively clear textboxes in nested containers
                    ClearAllTextboxes(control);
                }
                if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }
                else if (control.HasChildren)
                {
                    // Recursively clear maskedTextboxes in nested containers
                    ClearAllTextboxes(control);
                }
                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                else if (control.HasChildren)
                {
                    ClearAllTextboxes(control);
                }
            }

            // Reset the Study Number, one time event, specific timed event, and task type to blank
            cbStudyNumber.Text = "";
            checkBoxOnce.Checked = true;
            isOneTime();
            checkBoxTimedEvent.Checked = true;
            isSpecificTime();
            cbTaskType.Text = "";

        }

        private void checkBoxOnce_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxOnce.Checked) // if not a one time event
            {
                isNotOneTime();
            }
            else // if it is a one time event
            {
                isOneTime();
            }
        }

        private void disableNonEditControls()
        {
            startDatePicker.Enabled = false;
            endDatePicker.Enabled = false;
            comboBoxDailyFreq.Enabled = false;
            comboBoxWeeklyFreq.Enabled = false;
        }

        private void checkBoxTimedEvent_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxTimedEvent.Checked) // if it is not a specific timed event
            {
                isNotSpecificTime();
            }
            else // it is a specific timed event
            {
                isSpecificTime();
            }
        }
        private void comboBoxWeeklyFreq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxWeeklyFreq.SelectedIndex == 5) // if custom is selected
            {
                labelCustomWeekly.Visible = true; // make the custom area visible
                checkedListBox1.Visible = true;
            }
            else // if custom isn't selected
            {
                labelCustomWeekly.Visible = false; // don't make these visible
                checkedListBox1.Visible = false;
            }
        }

        private void search()
        {
            try
            {
                string studyNumInput;
                string studyTypeInput;
                string studyTechInput;
                int boolCurrentFuture;

                if (cbFilterStudyNum.Text == "--Select--" || cbFilterStudyNum.Text == null || cbFilterStudyNum.Text == "")
                {
                    studyNumInput = "";
                    cbFilterStudyNum.Text = "--Select--";
                    cbStudyNumber.Text = "";
                }
                else
                {
                    studyNumInput = cbFilterStudyNum.Text;
                    if (cbTaskType.Text == "") // if no selected task
                    {
                        cbStudyNumber.Text = cbFilterStudyNum.Text;
                        if (cbStudyNumber.Text != "" && cbStudyNumber.SelectedIndex == 0)
                        {
                            string snum = cbStudyNumber.Text;

                            int sid = DBUtilsForScheduler.GetStudyID(snum);
                            Studies s = DBUtilsForScheduler.GetAStudyUsingSP(sid);
                            startDatePicker.Value = s.startDate;
                            endDatePicker.Value = s.endDate;
                            if (s.startDate < DateTime.Now)
                            {
                                taskStartDatePicker.Value = DateTime.Now;
                            }
                            else
                            {
                                taskStartDatePicker.Value = s.startDate;
                            }

                            int tech_id = s.technicianID;
                            string tech_name = DBUtilsForScheduler.GetTechName(tech_id);

                            cbTech.Text = tech_name;

                        }
                    }
                }

                if (cbFilterTaskType.Text == "--Select--" || cbFilterTaskType.Text == null || cbFilterTaskType.Text == "")
                {
                    studyTypeInput = "";
                    cbFilterTaskType.Text = "--Select--";
                }
                else
                {
                    studyTypeInput = cbFilterTaskType.Text;
                }

                if (cbFilterTech.Text == "--Select--" || cbFilterTech.Text == null || cbFilterTech.Text == "")
                {
                    studyTechInput = "";
                    cbFilterTech.Text = "--Select--";
                }
                else
                {
                    studyTechInput = cbFilterTech.Text;
                }
                if (checkBoxCF.Checked)
                {
                    boolCurrentFuture = 1;
                }
                else
                {
                    boolCurrentFuture = 0;
                }

                dt = DBUtilsForScheduler.SearchTasksUsingSP(studyNumInput, studyTypeInput, studyTechInput, boolCurrentFuture);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["task_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Searching Tasks using Stored Proc! " +
                    "Error = " + ex.Message);
            }
        }

        private void createEvents(Tasks task)
        {
            switch (task.weekly_frequency)
            {
                case "None":
                    instantiateEvent(task, 0, 0);
                    break;
                case "Once a week":
                    for (int i = 0; i < task.numOccurrences; i++)
                    {
                        instantiateEvent(task, i, 1);
                    }
                    break;
                case "Every Day":
                    for (int i = 0; i < task.numOccurrences; i++)
                    {
                        instantiateEvent(task, i, 2);
                    }
                    break;
                case "Weekdays":
                    for (int i = 0; i < task.numOccurrences; i++)
                    {
                        instantiateEvent(task, i, 3);
                    }
                    break;
                case "Weekends":
                    for (int i = 0; i < task.numOccurrences; i++)
                    {
                        instantiateEvent(task, i, 4);
                    }
                    break;
                case "Custom Days":
                    // number of occurrences would add # of days that fall on specified week days
                    // value of 3 would not add 3 weeks of 'every monday and wednesday' but only 'monday -> wednesday -> monday'
                    int index = 0;
                    DateTime initialDate = task.taskStartDate;
                    

                    while (index < task.numOccurrences)
                    {
                        foreach (var item in checkedListBox1.CheckedItems)
                        {
                            if ((String)item != initialDate.DayOfWeek.ToString() && index == 0)
                            {
                                customInstantiateEvent(index, (String)item, task);
                                index++;
                            }
                            if (index == task.numOccurrences)
                            {
                                index++;
                                break;
                            }
                            customInstantiateEvent(index, (String)item, task);
                            index++;
                            
                        }
                    }
                    break;
            }
        }

        private void customInstantiateEvent(int index, String dayOfWeek, Tasks task)
        {
            if (comboBoxDailyFreq.SelectedItem == null)
            {
                // Handle null selection
                MessageBox.Show("Daily frequency not selected!");
                return;
            }
            string dailyFreq = comboBoxDailyFreq.SelectedItem.ToString();
            // event2 and event3 are daily frequency extra events for that day
            Events event1 = new Events();
            Events event2 = null;
            Events event3 = null;
            Events event4 = null;
            Events event5 = null;

            copyTaskPropertiesToEvent(task, event1);

            if (dailyFreq == "Twice a day" || dailyFreq == "Three times a day" || dailyFreq == "Four times a day" || dailyFreq == "Five times a day")
            {
                event2 = new Events();
                copyTaskPropertiesToEvent(task, event2);

                // Change only the time for event2
                event2.startDateTime = task.taskStartDate.Date + event2StartTime.TimeOfDay;

                if (dailyFreq == "Three times a day")
                {
                    event3 = new Events();
                    copyTaskPropertiesToEvent(task, event3);

                    // Change only the time for event3
                    event3.startDateTime = task.taskStartDate.Date + event3StartTime.TimeOfDay;
                }
                if (dailyFreq == "Four times a day")
                {
                    event4 = new Events();
                    copyTaskPropertiesToEvent(task, event4);

                    event4.startDateTime = task.taskStartDate.Date + event4StartTime.TimeOfDay;
                }
                if (dailyFreq == "Five times a day")
                {
                    event5 = new Events();
                    copyTaskPropertiesToEvent(task, event5);

                    event5.startDateTime = task.taskStartDate.Date + event5StartTime.TimeOfDay;
                }

            }


            // if first event, starttime is origin date
            if (index == 0)
            {
                event1.startDateTime = task.taskStartDate;
                if (event2 != null)
                {
                    /*
                    Sets event2 and 3 start dates equal to task start date. If we didn't, then if the user changes the task
                    start date after adding extra daily events,
                    then the event2 and 3 start dates will still be the original
                    start date when the add daily events button was clicked.
                    */
                    event2.startDateTime = task.taskStartDate.Date + event2StartTime.TimeOfDay; //otherwise we could omit this line and just add event2 as is
                }
                if (event3 != null)
                {
                    event3.startDateTime = task.taskStartDate.Date + event3StartTime.TimeOfDay;
                }
                if (event4 != null)
                {
                    event4.startDateTime = task.taskStartDate.Date + event4StartTime.TimeOfDay;
                }
                if (event5 != null)
                {
                    event5.startDateTime = task.taskStartDate.Date + event5StartTime.TimeOfDay;
                }

                if (!checkBoxTimedEvent.Checked)
                {
                    scheduler.AddUnassignedEvent(event1, 2);
                }
                else
                {
                    scheduler.AddEvent(event1);
                }
                if (event2 != null)
                {
                    if (!checkBoxTimedEvent.Checked)
                    {
                        scheduler.AddUnassignedEvent(event2, 2);
                    }
                    else
                    {
                        scheduler.AddEvent(event2);
                    }
                }
                if (event3 != null)
                {
                    if (!checkBoxTimedEvent.Checked)
                    {
                        scheduler.AddUnassignedEvent(event3, 2);
                    }
                    else
                    {
                        scheduler.AddEvent(event3);
                    }
                }
                if (event4 != null)
                {
                    if (!checkBoxTimedEvent.Checked)
                    {
                        scheduler.AddUnassignedEvent(event4, 2);
                    }
                    else
                    {
                        scheduler.AddEvent(event4);
                    }
                }
                if (event5 != null)
                {
                    if (!checkBoxTimedEvent.Checked)
                    {
                        scheduler.AddUnassignedEvent(event5, 2);
                    }
                    else
                    {
                        scheduler.AddEvent(event5);
                    }
                }
                return;
            }
            
            // increases date by one day until date matches day of week
            while (!string.Equals(task.taskStartDate.DayOfWeek.ToString(), dayOfWeek, StringComparison.OrdinalIgnoreCase))
            {
                task.taskStartDate = task.taskStartDate.AddDays(1);
            }
            // event is now set to next instance of correct day of week
            event1.startDateTime = task.taskStartDate;
            if (event2 != null)
            {
                event2.startDateTime = task.taskStartDate.Date + event2StartTime.TimeOfDay;
            }
            if (event3 != null)
            {
                event3.startDateTime = task.taskStartDate.Date + event3StartTime.TimeOfDay;
            }
            if (event4 != null)
            {
                event4.startDateTime = task.taskStartDate.Date + event4StartTime.TimeOfDay;
            }
            if (event5 != null)
            {
                event5.startDateTime = task.taskStartDate.Date + event5StartTime.TimeOfDay;
            }
            if (!checkBoxTimedEvent.Checked)
            {
                scheduler.AddUnassignedEvent(event1, 2);
            }
            else
            {
                scheduler.AddEvent(event1);
            }
            if (event2 != null)
            {
                if (!checkBoxTimedEvent.Checked)
                {
                    scheduler.AddUnassignedEvent(event2, 2);
                }
                else
                {
                    scheduler.AddEvent(event2);
                }
            }
            if (event3 != null)
            {
                if (!checkBoxTimedEvent.Checked)
                {
                    scheduler.AddUnassignedEvent(event3, 2);
                }
                else
                {
                    scheduler.AddEvent(event3);
                }
            }
            if (event4 != null)
            {
                if (!checkBoxTimedEvent.Checked)
                {
                    scheduler.AddUnassignedEvent(event4, 2);
                }
                else
                {
                    scheduler.AddEvent(event4);
                }
            }
            if (event5 != null)
            {
                if (!checkBoxTimedEvent.Checked)
                {
                    scheduler.AddUnassignedEvent(event5, 2);
                }
                else
                {
                    scheduler.AddEvent(event5);
                }
            }
        }

        private void instantiateEvent(Tasks task, int i, int weeklyChoice)
        {
            string dailyFreq = comboBoxDailyFreq.SelectedItem.ToString();
            // event2 and event3 are daily frequency extra events for that day
            Events event1 = new Events();
            Events event2 = null;
            Events event3 = null;
            Events event4 = null;
            Events event5 = null;

            copyTaskPropertiesToEvent(task, event1);

            if (dailyFreq == "Twice a day" || dailyFreq == "Three times a day" || dailyFreq == "Four times a day" || dailyFreq == "Five times a day")
            {
                event2 = new Events(); // not null
                copyTaskPropertiesToEvent(task, event2);
                // Change only the time for event2
                event2.startDateTime = event2StartTime;

                if (dailyFreq == "Three times a day")
                {
                    event3 = new Events();
                    copyTaskPropertiesToEvent(task, event3);
                    // Change only the time for event3
                    event3.startDateTime = event3StartTime;
                }
                if (dailyFreq == "Four times a day")
                {
                    event3 = new Events();
                    copyTaskPropertiesToEvent(task, event3);
                    event3.startDateTime = event3StartTime;

                    event4 = new Events();
                    copyTaskPropertiesToEvent (task, event4);
                    event4.startDateTime = event4StartTime;

                    
                }
                if (dailyFreq == "Five times a day")
                {
                    event3 = new Events();
                    copyTaskPropertiesToEvent(task, event3);
                    event3.startDateTime = event3StartTime;

                    event4 = new Events();
                    copyTaskPropertiesToEvent(task, event4);
                    event4.startDateTime = event4StartTime;

                    event5 = new Events();
                    copyTaskPropertiesToEvent(task, event5);
                    event5.startDateTime = event5StartTime;
                }
            }

            // if first event, starttime is origin date
            if (i == 0)
            {
                event1.startDateTime = task.taskStartDate;
                if (event2 != null)
                {
                    event2.startDateTime = task.taskStartDate.Date + event2StartTime.TimeOfDay;
                }
                if (event3 != null)
                {
                    event3.startDateTime = task.taskStartDate.Date + event3StartTime.TimeOfDay;
                }
                if (event4 != null)
                {
                    event4.startDateTime = task.taskStartDate.Date + event4StartTime.TimeOfDay;
                }
                if (event5 != null)
                {
                    event5.startDateTime = task.taskStartDate.Date + event5StartTime.TimeOfDay;
                }
                if (!checkBoxTimedEvent.Checked)
                {
                    scheduler.AddUnassignedEvent(event1, 2);
                }
                else
                {
                    scheduler.AddEvent(event1);
                }
                if (event2 != null)
                {
                    if (!checkBoxTimedEvent.Checked)
                    {
                        scheduler.AddUnassignedEvent(event2, 2);
                    }
                    else
                    {
                        scheduler.AddEvent(event2);
                    }
                }
                if (event3 != null)
                {
                    if (!checkBoxTimedEvent.Checked)
                    {
                        scheduler.AddUnassignedEvent(event3, 2);
                    }
                    else
                    {
                        scheduler.AddEvent(event3);
                    }
                }
                if (event4 != null)
                {
                    if (!checkBoxTimedEvent.Checked)
                    {
                        scheduler.AddUnassignedEvent(event4, 2);
                    }
                    else
                    {
                        scheduler.AddEvent(event4);
                    }
                }
                if (event5 != null)
                {
                    if (!checkBoxTimedEvent.Checked)
                    {
                        scheduler.AddUnassignedEvent(event5, 2);
                    }
                    else
                    {
                        scheduler.AddEvent(event5);
                    }
                }
                return;
            }

            else if (i > 0)
            {
                switch (weeklyChoice)
                {
                    case 0:
                        break;
                    case 1:
                        event1.startDateTime = task.taskStartDate.AddDays(7 * i);
                        if (event2 != null)
                        {
                            event2.startDateTime = task.taskStartDate.Date.AddDays(7 * i) + event2StartTime.TimeOfDay;
                        }
                        if (event3 != null)
                        {
                            event3.startDateTime = task.taskStartDate.Date.AddDays(7 * i) + event3StartTime.TimeOfDay;
                        }
                        if (event4 != null)
                        {
                            event4.startDateTime = task.taskStartDate.Date.AddDays(7 * i) + event4StartTime.TimeOfDay;
                        }
                        if (event5 != null)
                        {
                            event5.startDateTime = task.taskStartDate.Date.AddDays(7 * i) + event5StartTime.TimeOfDay;
                        }
                        break;
                    case 2:
                        event1.startDateTime = task.taskStartDate.AddDays(i);
                        if (event2 != null)
                        {
                            event2.startDateTime = task.taskStartDate.Date.AddDays(i) + event2StartTime.TimeOfDay;
                        }
                        if (event3 != null)
                        {
                            event3.startDateTime = task.taskStartDate.Date.AddDays(i) + event3StartTime.TimeOfDay;
                        }
                        if (event4 != null)
                        {
                            event4.startDateTime = task.taskStartDate.Date.AddDays(i) + event4StartTime.TimeOfDay;
                        }
                        if (event5 != null)
                        {
                            event5.startDateTime = task.taskStartDate.Date.AddDays(i) + event5StartTime.TimeOfDay;
                        }
                        break;
                    case 3:
                        // checks if day is a weekend and iterates until it is not
                        task.taskStartDate = task.taskStartDate.AddDays(1);
                        while (task.taskStartDate.DayOfWeek == DayOfWeek.Saturday || task.taskStartDate.DayOfWeek == DayOfWeek.Sunday)
                        {
                            task.taskStartDate = task.taskStartDate.AddDays(1);
                        }
                        event1.startDateTime = task.taskStartDate;
                        if (event2 != null)
                        {
                            event2.startDateTime = task.taskStartDate.Date + event2StartTime.TimeOfDay;
                        }
                        if (event3 != null)
                        {
                            event3.startDateTime = task.taskStartDate.Date + event3StartTime.TimeOfDay;
                        }
                        if (event4 != null)
                        {
                            event4.startDateTime = task.taskStartDate.Date + event4StartTime.TimeOfDay;
                        }
                        if (event5 != null)
                        {
                            event5.startDateTime = task.taskStartDate.Date + event5StartTime.TimeOfDay;
                        }
                        break;
                    case 4:
                        // check if day is a weekday and iterates until weekend
                        task.taskStartDate = task.taskStartDate.AddDays(1);
                        while (task.taskStartDate.DayOfWeek != DayOfWeek.Saturday && task.taskStartDate.DayOfWeek != DayOfWeek.Sunday)
                        {
                            task.taskStartDate = task.taskStartDate.AddDays(1);
                        }
                        event1.startDateTime = task.taskStartDate;
                        if (event2 != null)
                        {
                            event2.startDateTime = task.taskStartDate.Date + event2StartTime.TimeOfDay;
                        }
                        if (event3 != null)
                        {
                            event3.startDateTime = task.taskStartDate.Date + event3StartTime.TimeOfDay;
                        }
                        if (event4 != null)
                        {
                            event4.startDateTime = task.taskStartDate.Date + event4StartTime.TimeOfDay;
                        }
                        if (event5 != null)
                        {
                            event5.startDateTime = task.taskStartDate.Date + event5StartTime.TimeOfDay;
                        }
                        break;
                }
            }
            if (!checkBoxTimedEvent.Checked)
            {
                scheduler.AddUnassignedEvent(event1, 2);
            }
            else
            {
                scheduler.AddEvent(event1);
            }
            if (event2 != null)
            {
                if (!checkBoxTimedEvent.Checked)
                {
                    scheduler.AddUnassignedEvent(event2, 2);
                }
                else
                {
                    scheduler.AddEvent(event2);
                }
            }
            if (event3 != null)
            {
                if (!checkBoxTimedEvent.Checked)
                {
                    scheduler.AddUnassignedEvent(event3, 2);
                }
                else
                {
                    scheduler.AddEvent(event3);
                }
            }
            if (event4 != null)
            {
                if (!checkBoxTimedEvent.Checked)
                {
                    scheduler.AddUnassignedEvent(event4, 2);
                }
                else
                {
                    scheduler.AddEvent(event4);
                }
            }
            if (event5 != null)
            {
                if (!checkBoxTimedEvent.Checked)
                {
                    scheduler.AddUnassignedEvent(event5, 2);
                }
                else
                {
                    scheduler.AddEvent(event5);
                }
            }
        }



        private void disableCtrls() // disable all the controls
        {
            DBUtilsForScheduler.DisableControls(this);
            DBUtilsForScheduler.DisableBtn(btnSave);
            DBUtilsForScheduler.DisableBtn(btnUndo);
            DBUtilsForScheduler.DisableBtn(btnDelete);
            DBUtilsForScheduler.DisableBtn(btnModify);
        }
        private void enableNecCtrls() // enable just the necessary controls
        {
            DBUtilsForScheduler.EnableControls(TopLevelControl);
            DBUtilsForScheduler.EnableControls(dataGridView1);
            DBUtilsForScheduler.EnableBtn(btnNew);
            DBUtilsForScheduler.EnableControls(cbFilterStudyNum);
            DBUtilsForScheduler.EnableControls(cbFilterTaskType);
            DBUtilsForScheduler.EnableControls(cbFilterTech);
            DBUtilsForScheduler.EnableControls(checkBoxCF);
            DBUtilsForScheduler.EnableControls(labelFilterStudy);
            DBUtilsForScheduler.EnableControls(labelFilterType);
            DBUtilsForScheduler.EnableControls(labelFilterTech);
            DBUtilsForScheduler.EnableControls(label16);
            DBUtilsForScheduler.EnableControls(backToMainBtn);
            DBUtilsForScheduler.EnableAllControls(btnNavToEvents);
            DBUtilsForScheduler.EnableControls(btnStudies);
            DBUtilsForScheduler.EnableControls(btnEvents);
            DBUtilsForScheduler.EnableControls(btnTasks);
        }

        private void enableAllCtrls() // enable all the controls
        {
            DBUtilsForScheduler.EnableAllControls(this);
            DBUtilsForScheduler.EnableBtn(btnSave);
            DBUtilsForScheduler.EnableBtn(btnUndo);
            DBUtilsForScheduler.EnableBtn(btnDelete);
            if (checkBoxOnce.Checked) // if checkboxonce is checked
            {
                comboBoxWeeklyFreq.Enabled = false; // don't allow weekly or daily frequencies
                comboBoxDailyFreq.Enabled = false;
            }
            tbTaskID.Enabled = false;
        }

        private void FillComboBoxes()
        {
            DBUtilsForScheduler.FillComboBox("FillComboBoxStudyNum", cbFilterStudyNum);
            DBUtilsForScheduler.FillComboBox("FillComboBoxStudyNum", cbStudyNumber);
            DBUtilsForScheduler.FillComboBox("FillComboBoxTaskTypes", cbFilterTaskType);
            DBUtilsForScheduler.FillComboBox("FillComboBoxTaskTypes", cbTaskType);
            DBUtilsForScheduler.FillComboBox("FillComboBoxTechs", cbFilterTech);
            DBUtilsForScheduler.FillComboBox("FillComboBoxTechs", cbTech);
        }

        private void cbFilterStudyNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void cbFilterTech_SelectedIndexChanged(object sender, EventArgs e) // if tech filter is changed
        {
            search();
            cbTech.Text = cbFilterTech.Text;
        }

        private void cbFilterTaskType_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void cbStudyNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this function changes the study start and end dates
            if (cbStudyNumber.Text != "" && cbStudyNumber.SelectedIndex != 0)
            {
                string snum = cbStudyNumber.Text;

                int sid = DBUtilsForScheduler.GetStudyID(snum);
                Studies s = DBUtilsForScheduler.GetAStudyUsingSP(sid);
                startDatePicker.Value = s.startDate;
                endDatePicker.Value = s.endDate;
                if (s.startDate < DateTime.Now)
                {
                    taskStartDatePicker.Value = DateTime.Now;
                }
                else
                {
                    taskStartDatePicker.Value = s.startDate;
                }

                int tech_id = s.technicianID;
                string tech_name = DBUtilsForScheduler.GetTechName(tech_id);

                cbTech.Text = tech_name;

            }
        }

        private void comboBoxDailyFreq_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDailyFreq.SelectedIndex != 0) // if it has a daily frequency
            {
                btnDailyFreq.Visible = true; // enable the button to add times
                label2.Text = "First Event Start Time:"; // change label to be first event start time
            }
            else // if no daily frequency
            {
                btnDailyFreq.Visible = false; // don't show the button to add times
                label2.Text = "Start Time:"; // just label as start time
            }
        }

        private void checkBoxCF_CheckedChanged(object sender, EventArgs e)
        {
            search();
        }

        private void isOneTime() // changes styles when event is one time
        {
            comboBoxWeeklyFreq.Enabled = false; // don't allow to set weekly frequency 
            comboBoxWeeklyFreq.SelectedIndex = 0; // set the index to 0 "None"
            comboBoxDailyFreq.Enabled = false; // don't allow to set daily frequency
            comboBoxDailyFreq.SelectedIndex = 0; // set the index to 0 "Once a day"
            numOccur.Enabled = false; // don't allow to change number of occurrences
            numOccur.Text = "1"; // set number of occurrences to 1
            label3.Enabled = false; // disable label for weekly frequency
            label9.Enabled = false; // disable label for daily frequency
        }

        private void isNotOneTime() // changes styles when event repeats
        {
            comboBoxWeeklyFreq.Enabled = true; // allow to set weekly frequency
            comboBoxDailyFreq.Enabled = true; // allow to set daily frequency
            numOccur.Enabled = true; // allow to change number of occurrences
            label3.Enabled = true; // enable label for weekly frequency
            label9.Enabled = true; // enable label for daily frequency
        }

        private void isSpecificTime() // changes styles when event has a specific time
        {

            if (comboBoxDailyFreq.SelectedIndex != 0) // if it is does have a daily frequency //index 0 is "once a day"
            {
                btnDailyFreq.Visible = true; // then make this button visible
            }
            label2.Enabled = true; // label for start time enabled
            if (comboBoxDailyFreq.SelectedIndex == 0)
            {
                label2.Text = "Start Time:";
            }
            else
            {
                label2.Text = "First Event Start Time:";
            }
        }

        private void isNotSpecificTime() // changes styles when event does not have a specific time
        {   
            /* if task time is unassigned, disable the button
             * to add the times for extra daily events.
             * Assigning the times will be automatic */
            if(comboBoxDailyFreq.SelectedIndex == 0) // if it doesn't have a daily frequency
            {
                label2.Text = "Desired Start Time:";
            }
            else // if it does have a daily frequency
            {
                label2.Text = "First Event Desired Start Time:";
            }
            
        }

        private void copyTaskPropertiesToEvent(Tasks task, Events event1)
        {
            event1.Duration = task.Duration;
            event1.taskID = task.taskID;
            event1.studyID = task.studyID;
            event1.studyNum = task.studyNum;
            event1.techID = task.techID;
            event1.type = task.type;
            event1.comments = task.comments;
        }

        // stores which custom days of week are checked in bits for database
        private void storeCheckedDays()
        {
            // Initialize a 7-bit variable where each bit represents a day of the week
            DaysOfWeek checkedDays = 0;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    // Set the corresponding bit based on the index
                    switch (i)
                    {
                        case 0: checkedDays |= DaysOfWeek.Monday; break;
                        case 1: checkedDays |= DaysOfWeek.Tuesday; break;
                        case 2: checkedDays |= DaysOfWeek.Wednesday; break;
                        case 3: checkedDays |= DaysOfWeek.Thursday; break;
                        case 4: checkedDays |= DaysOfWeek.Friday; break;
                        case 5: checkedDays |= DaysOfWeek.Saturday; break;
                        case 6: checkedDays |= DaysOfWeek.Sunday; break;
                    }
                }
            }
            // Convert DaysOfWeek enum value to a byte
            byte checkedDaysByte = (byte)checkedDays;

            // Create a byte array with a single element to store the checked days
            byte[] customDaysBytes = new byte[] { checkedDaysByte };

            // Assign the byte array to task.customDays
            task.customDays = customDaysBytes;
        }

        // check custom day checkboxes with value from database
        private void SetCheckedDaysFromByte(byte checkedDaysByte)
        {
            // Clear all selections first
            checkedListBox1.ClearSelected();
            // Clear the checked state of all items
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            // Iterate over each bit in the byte
            for (int i = 0; i < 7; i++)
            {
                // Check if the bit at position i is set
                bool isBitSet = (checkedDaysByte & (1 << i)) != 0;

                // If the bit is set, check the corresponding checkbox
                if (isBitSet)
                {
                    // Since your listbox starts with Monday at index 0, you'll need to adjust the index accordingly
                    // For example, if Monday is represented by the first bit, you'd use i - 1 as the index
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
        }
        private void uncheckLisbox()
        {
            // Iterate through each item in the CheckedListBox
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                // Check if the current item is checked
                if (checkedListBox1.GetItemChecked(i))
                {
                    // If checked, set its checked state to false
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }
    }
}
