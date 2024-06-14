using Scheduler_Prototype.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scheduler_Prototype.Models;
using System.Data.SqlClient;
using System.Globalization;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing;
using System.Linq.Expressions;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Scheduler_Prototype
{
    // can't name object 'event' because it's probably a system variable or something
    public partial class EventsForm : Form
    {
        // 1 is view, 2 is add, 3 is modify
        int FormMode = 1;
        int eventid;
        SqlConnection conn;
        System.Data.DataTable dt;
        Events event1;
        Scheduler scheduler = new Scheduler();
        Tasks task;
        int tid;
        
        public EventsForm()
        {
            InitializeComponent();
        }
        public EventsForm(Form f, int tid)
        {
            InitializeComponent();
            this.tid = tid;
            FormMode = 1;
        }
        private void EventsForm_Load(object sender, EventArgs e)
        {
            disableCtrls(); 
            enableNecCtrls();
            FillComboBoxes();
            ClearAllTextboxes(this);
            checkBoxCF.Checked = true;
            comboBoxExtraTechs.Visible = false;
            btnAddTechs.Visible = false;

            if (tid == 0) // not coming in from a previous task
            {
                search();
                tbTaskID.Text = "";

            }
            else if (tid > 0)
            {
                // Get Study for start and end date
                Tasks t = DBUtilsForScheduler.GetATaskUsingSP(tid);
                this.task = t;

                tbTaskID.Text = tid.ToString();


                cbFilterStudyNum.Text = t.studyNum.ToString();
                cbFilterTaskType.Text = t.type;
                cbFilterTech.Text = "--Select--";
                cbStudyNum.Text = t.studyNum.ToString();
                cbPrimaryTech.Text = DBUtilsForScheduler.GetTechName(t.techID);
                cbTaskType.Text = t.type;
                DBUtilsForScheduler.EnableBtn(btnNew);
                // if task start date is ahead of today - set event date to task start date
                // else - set event date to today

                refreshDataGridView();

            }
        }


        /*
        .-. .-')               .-') _    .-') _                     .-') _          ('-.        (`-.      ('-.       .-') _  .-') _     .-')    
        \  ( OO )             (  OO) )  (  OO) )                   ( OO ) )       _(  OO)     _(OO  )_  _(  OO)     ( OO ) )(  OO) )   ( OO ).  
         ;-----.\  ,--. ,--.  /     '._ /     '._  .-'),-----. ,--./ ,--,'       (,------.,--(_/   ,. \(,------.,--./ ,--,' /     '._ (_)---\_) 
         | .-.  |  |  | |  |  |'--...__)|'--...__)( OO'  .-.  '|   \ |  |\        |  .---'\   \   /(__/ |  .---'|   \ |  |\ |'--...__)/    _ |  
         | '-' /_) |  | | .-')'--.  .--''--.  .--'/   |  | |  ||    \|  | )       |  |     \   \ /   /  |  |    |    \|  | )'--.  .--'\  :` `.  
         | .-. `.  |  |_|( OO )  |  |      |  |   \_) |  |\|  ||  .     |/       (|  '--.   \   '   /, (|  '--. |  .     |/    |  |    '..`''.) 
         | |  \  | |  | | `-' /  |  |      |  |     \ |  | |  ||  |\    |         |  .--'    \     /__) |  .--' |  |\    |     |  |   .-._)   \ 
         | '--'  /('  '-'(_.-'   |  |      |  |      `'  '-'  '|  | \   |         |  `---.    \   /     |  `---.|  | \   |     |  |   \       / 
         `------'   `-----'      `--'      `--'        `-----' `--'  `--'         `------'     `-'      `------'`--'  `--'     `--'    `-----'                   
        */

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Insert new event
            // check if form mode is modify or add to decide save method

            // input validation
            if(cbStudyNum.Text == "")
            {
                MessageBox.Show("Error: invalid input for Study Number");
                return;
            }
            if (cbPrimaryTech.Text == "")
            {
                MessageBox.Show("Error: invalid input for Primary Technician");
                return;
            }
            if (cbTaskType.Text == "")
            {
                MessageBox.Show("Error: invalid input for Task Type");
                return;
            }
            if(comboBoxDuration.Text == "")
            {
                MessageBox.Show("Error: invalid input for Duration");
                return;
            }


            if (!string.IsNullOrEmpty(cbTaskType.Text) && (FormMode == 2))
            {
                Events event1 = new Events();
                InstantiateEventFromTextBoxes(event1);
                Tasks task = DBUtilsForScheduler.GetATaskUsingSP(tid);
                event1.taskID = tid;
                event1.studyID = task.studyID;
                event1.studyNum = task.studyNum;
                using (conn = DBUtilsForScheduler.MakeConnection())
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT MAX(event_count) FROM taskevents WHERE task_id = @taskid AND deleted = 0", conn))
                        {
                            cmd.Parameters.AddWithValue("@taskid", tid);
                            int maxCount = Convert.ToInt32(cmd.ExecuteScalar());
                            event1.eventCount = maxCount + 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving max count:" + ex);
                    }

                }

                try
                {
                    int recInserted = DBUtilsForScheduler.InsertEventUsingSP(event1);
                    if (recInserted > 0)
                    {
                        MessageBox.Show("Successfully inserted Event rec!");
                        UpdateEventTextBoxes(event1);
                        disableCtrls();
                        enableNecCtrls();
                    }
                    else
                    {
                        MessageBox.Show("Did not insert Event rec!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Event Failed! Error = " + ex.Message);
                }
                disableCtrls();
                enableNecCtrls();
                search();
            }
            // Modify Study
            else if (FormMode == 3)
            {
                // event1 is global so it has the event id retrieved from datagridview click 
                InstantiateEventFromTextBoxes(event1);

                Scheduler s = new Scheduler();

                if (s.EventTechHasConflict(event1))
                {
                    MessageBox.Show("Error: technician is already busy at this time");
                    return;
                }

                try
                {
                    int recInserted = DBUtilsForScheduler.UpdateTaskEventUsingSP(event1);
                    MessageBox.Show("Got rec inserted int");
                    if (recInserted > 0)
                    {
                        MessageBox.Show("Successfully updated Event rec!");
                        UpdateEventTextBoxes(event1);
                    }
                    else
                    {
                        MessageBox.Show("Did not update Event rec!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Event rec failed: " + ex.Message);
                }
                disableCtrls();
                enableNecCtrls();
                search();
                ClearAllTextboxes(this);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormMode = 2;
            enableAllCtrls();
            tbEventID.Enabled = false;
            Tasks t = DBUtilsForScheduler.GetATaskUsingSP(tid);
            cbPrimaryTech.Text = DBUtilsForScheduler.GetTechName(t.techID);
            cbTaskType.Text = t.type;
            tbEventID.Text = "";
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FormMode = 3;
            enableAllCtrls();
            disableNonEditControls();
        }
        
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (tid > 0)
            {
                UpdateEventTextBoxes(event1);
            }
            else
            {
                ClearAllTextboxes(this);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (event1 != null)
            {
                if (DBUtilsForScheduler.ConfirmDelete())
                {
                    using (SqlConnection conn = DBUtilsForScheduler.MakeConnection())
                    {
                        try
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand("UPDATE taskevents SET deleted = 1 WHERE event_id = @eventid", conn))
                            {
                                cmd.Parameters.AddWithValue("@eventid", event1.eventID);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show($"Event with ID {event1.eventID} has been soft-deleted.");
                                    event1 = new Events();
                                    search();
                                    ClearAllTextboxes(this);
                                    disableCtrls();
                                    enableNecCtrls();
                                }
                                else
                                {
                                    MessageBox.Show($"No task found with ID {event1.eventID}.");
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
            else
            {
                MessageBox.Show("No event selected to delete!");
            }
        }

        private void btnAddTechs_Click(object sender, EventArgs e)
        {
            if(comboBoxExtraTechs.Text == "")
            {
                MessageBox.Show("Error: please select another technician.");
                return;
            }
            using (SqlConnection conn = DBUtilsForScheduler.MakeConnection())
            {
                try
                {
                    conn.Open();
                    string new_tname = comboBoxExtraTechs.Text;
                    int new_techid = DBUtilsForScheduler.GetTechID(new_tname);
                    int studyID = DBUtilsForScheduler.GetStudyID(cbStudyNum.Text);
                    InstantiateEventFromTextBoxes(event1);
                    event1.techID = new_techid;
                    Scheduler s = new Scheduler();
                    s.AddTech(event1);
                }
                    
                catch (Exception ex)
                {
                    MessageBox.Show("Error in adding technician: " + ex.Message);
                }
                
            }
            disableCtrls();
            enableNecCtrls();
            cbFilterTech.Text = "--Select--";
            cbFilterStudyNum.Text = event1.studyNum;
            cbFilterTaskType.Text = event1.type;
            search();
            cbAddHelp.Checked = false;
            comboBoxExtraTechs.Visible = false;
            btnAddTechs.Visible = false;
        }

        private void btnEventCountSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            bool matchFound = false;
            int selectedEventCount = Convert.ToInt32(numericUpDown1.Value);
            if (selectedEventCount != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells[1].Value) == selectedEventCount) // find row with matching event count
                    {
                        row.Selected = true;
                        matchFound = true;
                        eventid = Convert.ToInt32(row.Cells[0].Value);
                        try // populate textboxes if match is found
                        {
                            event1 = DBUtilsForScheduler.GetAnEventUsingSP(eventid);
                            UpdateEventTextBoxes(event1);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error retrieving event data! " + ex.Message);
                        }
                        break;
                    }
                }
                if (matchFound == false)
                {
                    MessageBox.Show("No matching event count found!");
                }
            }
        }

        /*
          _   _             _             _   _               ____        _   _                  
         | \ | | __ ___   _(_) __ _  __ _| |_(_) ___  _ __   | __ ) _   _| |_| |_ ___  _ __  ___ 
         |  \| |/ _` \ \ / / |/ _` |/ _` | __| |/ _ \| '_ \  |  _ \| | | | __| __/ _ \| '_ \/ __|
         | |\  | (_| |\ V /| | (_| | (_| | |_| | (_) | | | | | |_) | |_| | |_| || (_) | | | \__ \
         |_| \_|\__,_| \_/ |_|\__, |\__,_|\__|_|\___/|_| |_| |____/ \__,_|\__|\__\___/|_| |_|___/
                              |___/                                                              
         */

        private void backToMainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if(mainForm != null)
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

        private void btnTasks_Click(object sender, EventArgs e)
        {
            this.Hide();
            TasksForm fm = new TasksForm();
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
                                _  .-')  _   .-')           _   .-')       ('-.   .-') _    ('-. .-.             _ .-') _    .-')    
                               ( \( -O )( '.( OO )_        ( '.( OO )_   _(  OO) (  OO) )  ( OO )  /            ( (  OO) )  ( OO ).  
           ,------. .-'),-----. ,------. ,--.   ,--.)       ,--.   ,--.)(,------./     '._ ,--. ,--. .-'),-----. \     .'_ (_)---\_) 
        ('-| _.---'( OO'  .-.  '|   /`. '|   `.'   |        |   `.'   |  |  .---'|'--...__)|  | |  |( OO'  .-.  ',`'--..._)/    _ |  
        (OO|(_\    /   |  | |  ||  /  | ||         |        |         |  |  |    '--.  .--'|   .|  |/   |  | |  ||  |  \  '\  :` `.  
        /  |  '--. \_) |  |\|  ||  |_.' ||  |'.'|  |        |  |'.'|  | (|  '--.    |  |   |       |\_) |  |\|  ||  |   ' | '..`''.) 
        \_)|  .--'   \ |  | |  ||  .  '.'|  |   |  |        |  |   |  |  |  .--'    |  |   |  .-.  |  \ |  | |  ||  |   / :.-._)   \ 
          \|  |_)     `'  '-'  '|  |\  \ |  |   |  |        |  |   |  |  |  `---.   |  |   |  | |  |   `'  '-'  '|  '--'  /\       / 
           `--'         `-----' `--' '--'`--'   `--'        `--'   `--'  `------'   `--'   `--' `--'     `-----' `-------'  `-----'  
         */

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
                cbPrimaryTech.SelectedIndex = 0;
                cbTaskType.SelectedIndex = 0;
                comboBoxDuration.SelectedIndex = 1;
                dateTimePickerEvents.Value = DateTime.Now;
                cbStudyNum.SelectedIndex = 0;
                comboBoxStartTime.SelectedIndex = 12;


            }
        }

        private void refreshDataGridView()
        {
            try
            {
                dt = DBUtilsForScheduler.GetEventsByTasksSP(tid);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Getting All events using Stored Proc! " +
                    "Error = " + ex.Message);
            }
        }

        private void disableCtrls() // disable all the controls
        {
            DBUtilsForScheduler.DisableControls(this);
            DBUtilsForScheduler.DisableBtn(btnSave);
            DBUtilsForScheduler.DisableBtn(btnUndo);
            DBUtilsForScheduler.DisableBtn(btnDelete);
            DBUtilsForScheduler.DisableBtn(btnNew);
            DBUtilsForScheduler.DisableBtn(btnModify);
        }
        private void enableNecCtrls() // enable just the necessary controls
        {
            DBUtilsForScheduler.EnableControls(TopLevelControl);
            DBUtilsForScheduler.EnableControls(dataGridView1);
            DBUtilsForScheduler.EnableControls(label16);
            DBUtilsForScheduler.EnableControls(backToMainBtn);
            DBUtilsForScheduler.EnableControls(btnStudies);
            DBUtilsForScheduler.EnableControls(btnTasks);
            DBUtilsForScheduler.EnableControls(btnTechs);
            DBUtilsForScheduler.EnableControls(labelFilterStudy);
            DBUtilsForScheduler.EnableControls(labelFilterTech);
            DBUtilsForScheduler.EnableControls(labelFilterType);
            DBUtilsForScheduler.EnableControls(cbFilterStudyNum);
            DBUtilsForScheduler.EnableControls(cbFilterTaskType);
            DBUtilsForScheduler.EnableControls(cbFilterTech);
            DBUtilsForScheduler.EnableControls(checkBoxToday);
            DBUtilsForScheduler.EnableControls(checkBoxCF);
        }

        private void enableAllCtrls()
        {
            DBUtilsForScheduler.EnableAllControls(this);
            DBUtilsForScheduler.EnableBtn(btnSave);
            DBUtilsForScheduler.EnableBtn(btnUndo);
            DBUtilsForScheduler.EnableBtn(btnDelete);
            tbTaskID.Enabled = false;
        }

        
        private void UpdateEventTextBoxes(Events e)
        {
            tbEventID.Text = e.eventID.ToString();
            tbStudyID.Text = e.studyID.ToString();
            cbStudyNum.Text = e.studyNum.ToString();
            cbPrimaryTech.Text = DBUtilsForScheduler.GetTechName(e.techID);
            tbTaskID.Text = e.taskID.ToString();        
            cbTaskType.Text = e.type.ToString();
            numericUpDown1.Value = Convert.ToDecimal(e.eventCount);
            tbComments.Text = e.comments;

            comboBoxDuration.SelectedIndex = ((int)e.Duration.TotalMinutes / 15) - 1;

            if (e.startDateTime != null)
            {
                dateTimePickerEvents.Value = e.startDateTime;
            }
            else
            {
                dateTimePickerEvents.Value = DateTime.Now;
            }
            string retrievedTime = e.startDateTime.ToShortTimeString(); // start time from database
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

        }
        private void InstantiateEventFromTextBoxes(Events e)
        {
            e.type = cbTaskType.Text;
            
            e.studyNum = cbStudyNum.Text;

            e.studyID = DBUtilsForScheduler.GetStudyID(e.studyNum);

            e.techID = DBUtilsForScheduler.GetTechID(cbPrimaryTech.Text);

            e.startDateTime = dateTimePickerEvents.Value.Date;

            // Get duration in minutes from ComboBox
            int durationIndex = comboBoxDuration.SelectedIndex + 1;
            e.Duration = TimeSpan.FromMinutes(durationIndex * 15);

            e.eventCount = Convert.ToInt32(numericUpDown1.Value);

            
            // Define the base time (6:00 AM)
            DateTime baseTime = e.startDateTime.AddHours(6);
            // Get the selected index from the ComboBox
            int selectedIndex = comboBoxStartTime.SelectedIndex;
            // Calculate the time based on the selected index and 15-minute increments
            e.startDateTime = baseTime.AddMinutes(selectedIndex * 15);
            e.comments = tbComments.Text;
        }

        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Events event1;
            int eventid;
            try
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                eventid = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);
                try
                {
                    event1 = DBUtilsForScheduler.GetAnEventUsingSP(eventid);
                    this.eventid = eventid;
                    this.event1 = event1;
                    UpdateEventTextBoxes(event1);

                    DBUtilsForScheduler.EnableBtn(btnModify);
                    DBUtilsForScheduler.EnableBtn(btnDelete);
                    DBUtilsForScheduler.EnableBtn(btnNew);
                    DBUtilsForScheduler.FillEventTechComboBox("FillComboBoxEventTechs", comboBoxExtraTechs, tid, event1.eventCount);



                    tid = event1.taskID;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving event data! " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving event data! " + ex.Message);
            }
            cbAddHelp.Checked = false;
            comboBoxExtraTechs.Visible = false;
            btnAddTechs.Visible = false;
        }
        private void disableNonEditControls()
        {
            tbStudyID.Enabled = false;
            cbStudyNum.Enabled = false;
            tbTaskID.Enabled = false;
            tbEventID.Enabled = false;
            cbTaskType.Enabled = false;
        }

        private void search()
        {
            try
            {
                string eventStudyInput;
                string eventTypeInput;
                string eventTechInput;
                int boolToday;
                int boolCurrentFuture;

                if (cbFilterStudyNum.Text == "--Select--" || cbFilterStudyNum.Text == null || cbFilterStudyNum.Text == "")
                {
                    eventStudyInput = "";
                    cbFilterStudyNum.Text = "--Select--";
                }
                else
                {
                    eventStudyInput = cbFilterStudyNum.Text;
                    if(comboBoxDuration.Text == "") { // if there's no event selected 
                        cbStudyNum.Text = cbFilterStudyNum.Text;
                        if (cbStudyNum.Text != "" && cbStudyNum.SelectedIndex == 0)
                        {
                            int sid = DBUtilsForScheduler.GetStudyID(cbStudyNum.Text);
                            Studies s = DBUtilsForScheduler.GetAStudyUsingSP(sid); // create a study instance

                            if (s != null)
                            {
                                cbPrimaryTech.Text = DBUtilsForScheduler.GetTechName(s.technicianID); // set the primary tech to the studies tech auto
                                if(s.startDate < DateTime.Today) // if the study started before today
                                {
                                    dateTimePickerEvents.Value = DateTime.Today;
                                }
                                else
                                {
                                    dateTimePickerEvents.Value = s.startDate;
                                }
                            }
                        }
                    }

                }

                if (cbFilterTaskType.Text == "--Select--" || cbFilterTaskType.Text == null || cbFilterTaskType.Text == "")
                {
                    eventTypeInput = "";
                    cbFilterTaskType.Text = "--Select--";
                }
                else
                {
                    eventTypeInput = cbFilterTaskType.Text;
                }

                if (cbFilterTech.Text == "--Select--" || cbFilterTech.Text == null || cbFilterTech.Text == "")
                {
                    eventTechInput = "";
                    cbFilterTech.Text = "--Select--";
                }
                else
                {
                    eventTechInput = cbFilterTech.Text;
                }

                if (checkBoxToday.Checked)
                {
                    boolToday = 1;
                }
                else
                {
                    boolToday = 0;
                }
                if (checkBoxCF.Checked)
                {
                    boolCurrentFuture = 1;
                }
                else
                {
                    boolCurrentFuture = 0;
                }

                dt = DBUtilsForScheduler.SearchEventsUsingSP(eventStudyInput, eventTypeInput, eventTechInput, boolToday, boolCurrentFuture);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["event_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Searching Events using Stored Proc! " +
                    "Error = " + ex.Message);
            }
        }

        private void FillComboBoxes()
        {
            DBUtilsForScheduler.FillComboBox("FillComboBoxStudyNum", cbFilterStudyNum);
            DBUtilsForScheduler.FillComboBox("FillComboBoxStudyNum", cbStudyNum);
            DBUtilsForScheduler.FillComboBox("FillComboBoxTaskTypes", cbFilterTaskType);
            DBUtilsForScheduler.FillComboBox("FillComboBoxTaskTypes", cbTaskType);
            DBUtilsForScheduler.FillComboBox("FillComboBoxTechs", cbFilterTech);
            DBUtilsForScheduler.FillComboBox("FillComboBoxTechs", cbPrimaryTech);
        }

        private void cbFilterStudyNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
            cbPrimaryTech.Text = "";
            cbTaskType.Text = "";

        }

        private void cbFilterTech_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
            cbPrimaryTech.Text = "";
            cbTaskType.Text = "";
        }

        private void cbFilterTaskType_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
            cbPrimaryTech.Text = "";
            cbTaskType.Text = "";
        }

        private void checkBoxToday_CheckedChanged(object sender, EventArgs e)
        {
            search();
        }

        private void checkBoxUnassigned_CheckedChanged(object sender, EventArgs e)
        {
            search();
        }
        private void checkBoxCF_CheckedChanged(object sender, EventArgs e)
        {
            search();
        }


        private void cbStudyNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStudyNum.Text != "" && cbStudyNum.SelectedIndex != 0)
            {
                int sid = DBUtilsForScheduler.GetStudyID(cbStudyNum.Text);
                Studies s = DBUtilsForScheduler.GetAStudyUsingSP(sid); // create a study instance

                if (s != null)
                {
                    cbPrimaryTech.Text = DBUtilsForScheduler.GetTechName(s.technicianID);
                    if (s.startDate < DateTime.Today) // if the study started before today
                    {
                        dateTimePickerEvents.Value = DateTime.Today;
                    }
                    else
                    {
                        dateTimePickerEvents.Value = s.startDate;
                    }
                }
            }
        }

        private void cbAddHelp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddHelp.Checked)
            {
                comboBoxExtraTechs.Visible = true;
                btnAddTechs.Visible = true;
            }
            else
            {
                comboBoxExtraTechs.Visible = false;
                btnAddTechs.Visible = false;
            }
            
        }
    }
}
