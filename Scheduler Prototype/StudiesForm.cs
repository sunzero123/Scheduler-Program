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
using System.Security.Cryptography;
using System.Runtime.InteropServices.ComTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;
using System.CodeDom.Compiler;
using DocumentFormat.OpenXml.Drawing;

namespace Scheduler_Prototype
{
    public partial class StudiesForm : Form
    {
        // 1 is view, 2 is add, 3 is modify
        int FormMode = 1;
        int sid; // study id
        SqlConnection conn;
        DataTable dt;
        Studies study;
        public StudiesForm()
        {
            InitializeComponent();
        }
        private void StudiesForm_Load(object sender, EventArgs e)
        {
            disableCtrls(); // disable controls and change button appearance
            btnNavtoTasks.Visible = false; // make button invisible until task is selected
            enableNecCtrls(); // enable the search feature
            refreshDataGridView();
            FillComboBoxes();
            ClearAllTextboxes(this);
            checkBoxCF.Checked = true;
            
        }
        /*
           ____        _   _                ______               _       
         |  _ \      | | | |              |  ____|             | |      
         | |_) |_   _| |_| |_ ___  _ __   | |____   _____ _ __ | |_ ___ 
         |  _ <| | | | __| __/ _ \| '_ \  |  __\ \ / / _ \ '_ \| __/ __|
         | |_) | |_| | |_| || (_) | | | | | |___\ V /  __/ | | | |_\__ \
         |____/ \__,_|\__|\__\___/|_| |_| |______\_/ \___|_| |_|\__|___/


         */

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (sid > 0)
            {
                UpdateStudyTextBoxes(study);
            }
            else
            {
                ClearAllTextboxes(this);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FormMode = 3;
            enableAllCtrls();
            btnNavtoTasks.Visible = true;
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Insert new Study
            // check if form mode is modify or add to decide save method

            // input validation
            if (tbMaskedStudyNum.Text == "-" || tbMaskedStudyNum.Text.Length != 7) 
            {
                MessageBox.Show("Error: invalid input for Study Number");
                return;
            }
            if (tbSponsor.Text == "")
            {
                MessageBox.Show("Error: invalid input for Sponsor");
                return;
            }
            if (cbTechName.Text == "" || cbTechName.SelectedIndex == 0)
            {
                MessageBox.Show("Error: invalid input for Technician Name");
                return;
            }
            if (EndDatePicker.Value < StartDatePicker.Value)
            {
                MessageBox.Show("Error: End Date must be after the Start Date");
                return;
            }
            if (cbColor.Text == "" || cbColor.SelectedIndex == 0)
            {
                MessageBox.Show("Error: invalid input for Color");
                return;
            }

            if (!string.IsNullOrEmpty(tbSponsor.Text) &&
                !string.IsNullOrEmpty(tbMaskedStudyNum.Text) && (FormMode == 2))
            {
                // tbh not sure why I have to create local study here instead of using global
                Studies study = new Studies();
                InstantiateStudyFromTextBoxes(study);
                try
                {
                    int recInserted = DBUtilsForScheduler.InsertStudyUsingSP(study);
                    if (recInserted > 0)
                    {
                        MessageBox.Show("Successfully inserted Study rec!");
                        UpdateStudyTextBoxes(study);
                    }
                    else
                    {
                        MessageBox.Show("Did not insert Study rec!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Study Failed! Error = " + ex.Message);
                }
                disableCtrls();
                enableNecCtrls();
                btnNavtoTasks.Visible = false; // make button invisible until task is selected
                search();
            }
            // Modify Study
            else if (FormMode == 3)
            {
                InstantiateStudyFromTextBoxes(study);
                try
                {
                    int recInserted = DBUtilsForScheduler.UpdateStudyUsingSP(study);
                    if (recInserted > 0)
                    {
                        MessageBox.Show("Successfully updated Study rec!");
                        UpdateStudyTextBoxes(study);
                    }
                    else
                    {
                        MessageBox.Show("Did not update Study rec!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Study rec failed: " + ex.Message);
                }
                disableCtrls();
                enableNecCtrls();
                btnNavtoTasks.Visible = false; // make button invisible until task is selected
                search();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormMode = 2;
            enableAllCtrls();
            btnNavtoTasks.Visible = true; // make button visble 
            ClearAllTextboxes(this);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (study != null)
            {
                if (DBUtilsForScheduler.ConfirmDelete())
                {
                    using (conn = DBUtilsForScheduler.MakeConnection())
                    {
                        try
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand("UPDATE studies SET deleted = 1 WHERE study_id = @studyid; UPDATE tasks SET deleted = 1 WHERE study_id = @studyid; UPDATE taskevents SET deleted = 1 WHERE study_id = @studyid;", conn))
                            {
                                cmd.Parameters.AddWithValue("@studyid", study.studyID);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show($"Study with ID {study.studyID} has been soft-deleted.");
                                    study = new Studies();
                                    search();
                                    ClearAllTextboxes(this);
                                    btnNavtoTasks.Visible = false;
                                    disableCtrls();
                                    enableNecCtrls();
                                }
                                else
                                {
                                    MessageBox.Show($"No study found with ID {study.studyID}.");
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
                MessageBox.Show("No study selected to delete!");
            }
        }

        /*
          _   _             _             _   _               ____        _   _                  
         | \ | |           (_)           | | (_)             |  _ \      | | | |                 
         |  \| | __ ___   ___  __ _  __ _| |_ _  ___  _ __   | |_) |_   _| |_| |_ ___  _ __  ___ 
         | . ` |/ _` \ \ / / |/ _` |/ _` | __| |/ _ \| '_ \  |  _ <| | | | __| __/ _ \| '_ \/ __|
         | |\  | (_| |\ V /| | (_| | (_| | |_| | (_) | | | | | |_) | |_| | |_| || (_) | | | \__ \
         |_| \_|\__,_| \_/ |_|\__, |\__,_|\__|_|\___/|_| |_| |____/ \__,_|\__|\__\___/|_| |_|___/
                               __/ |                                                             
                              |___/                                                              
         */
        private void btnNavtoTasks_Click(object sender, EventArgs e)
        {
            if (study != null)
            {
                sid = study.studyID;
            }
            else
            {
                sid = 0;
            }
            TasksForm fm = new TasksForm(this, sid);
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
        private void btnTasks_Click(object sender, EventArgs e)
        {
            this.Hide();
            TasksForm fm = new TasksForm();
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
         8888888888                                  888b     d888          888    888                    888          
         888                                         8888b   d8888          888    888                    888          
         888                                         88888b.d88888          888    888                    888          
         8888888  .d88b.  888d888 88888b.d88b.       888Y88888P888  .d88b.  888888 88888b.   .d88b.   .d88888 .d8888b  
         888     d88""88b 888P"   888 "888 "88b      888 Y888P 888 d8P  Y8b 888    888 "88b d88""88b d88" 888 88K      
         888     888  888 888     888  888  888      888  Y8P  888 88888888 888    888  888 888  888 888  888 "Y8888b. 
         888     Y88..88P 888     888  888  888      888   "   888 Y8b.     Y88b.  888  888 Y88..88P Y88b 888      X88 
         888      "Y88P"  888     888  888  888      888       888  "Y8888   "Y888 888  888  "Y88P"   "Y88888  88888P' 
                                                                                                              
         */



        private void UpdateStudyTextBoxes(Studies s)
        {
            tbMaskedStudyNum.Text = s.studyNum.ToString();
            tbSponsor.Text = s.sponsor;
            cbTechName.Text = DBUtilsForScheduler.GetTechName(s.technicianID);
            if (s.startDate != DateTime.MinValue)
            {
                StartDatePicker.Value = s.startDate;
            }
            else
            {
                StartDatePicker.Value = DateTime.Now;
            }
            if (s.endDate != DateTime.MinValue)
            {
                EndDatePicker.Value = s.endDate;
            }
            else
            {
                EndDatePicker.Value = DateTime.Now;
            }
            
            
            cbColor.Text = s.color;
        }

        private void InstantiateStudyFromTextBoxes(Studies s)
        {
            s.studyNum = tbMaskedStudyNum.Text;
            s.sponsor = tbSponsor.Text;
            s.technicianID = DBUtilsForScheduler.GetTechID((cbTechName.Text).ToString());
            s.startDate = StartDatePicker.Value.Date;
            s.endDate = EndDatePicker.Value.Date;
            s.color = cbColor.Text;
        }
        private void ClearAllTextboxes(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control.HasChildren)
                {
                    // Recursively clear textboxes in nested containers
                    ClearAllTextboxes(control);
                }
                if(control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }
                else if (control.HasChildren)
                {
                    // Recursively clear maskedTextboxes in nested containers
                    ClearAllTextboxes(control);
                }
                if(control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                else if (control.HasChildren)
                {
                    ClearAllTextboxes(control);
                }

                cbTechName.Text = "";
                cbColor.Text = "";
            }
        }

        private void refreshDataGridView()
        {
            try
            {
                dt = DBUtilsForScheduler.GetAllStudiesUsingSP();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["study_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Getting All Studies using Stored Proc! " +
                    "Error = " + ex.Message);
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
            DBUtilsForScheduler.EnableBtn(btnAdd);
            DBUtilsForScheduler.EnableBtn(btnSearch);
            DBUtilsForScheduler.EnableControls(checkBoxCF);
            DBUtilsForScheduler.EnableControls(label11);
            DBUtilsForScheduler.EnableControls(backToMainBtn);
            DBUtilsForScheduler.EnableControls(btnTasks);
            DBUtilsForScheduler.EnableControls(btnEvents);
            DBUtilsForScheduler.EnableControls(btnTechs);
            DBUtilsForScheduler.EnableControls(tbSearchStudyNum);
            DBUtilsForScheduler.EnableControls(cbSearchSponsor);
            DBUtilsForScheduler.EnableControls(cbSearchTech);
            DBUtilsForScheduler.EnableControls(labelSearchStudy);
            DBUtilsForScheduler.EnableControls(labelFilterSponsor);
            DBUtilsForScheduler.EnableControls(labelFilterTech);
        }

        private void enableAllCtrls()
        {
            DBUtilsForScheduler.EnableAllControls(this);
            DBUtilsForScheduler.EnableBtn(btnSave);
            DBUtilsForScheduler.EnableBtn(btnUndo);
            DBUtilsForScheduler.EnableBtn(btnDelete);
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Studies study;
            int sid;
            try
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                sid = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);
                try
                {
                    study = DBUtilsForScheduler.GetAStudyUsingSP(sid);
                    this.study = study;
                    this.sid = sid;
                    UpdateStudyTextBoxes(study);
                    DBUtilsForScheduler.EnableBtn(btnModify);
                    DBUtilsForScheduler.EnableBtn(btnDelete);
                    btnNavtoTasks.Visible = true;
                    btnNavtoTasks.Enabled = true;
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving study data! " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving study data! " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }
    
        private void search()
        {
            try
            {
                string studyNumInput;
                string studySponsorInput;
                string studyTechInput;
                int boolCurrentFuture;

                if (tbSearchStudyNum.Text == null || tbSearchStudyNum.Text == "")
                {
                    studyNumInput = "";
                    tbSearchStudyNum.Text = "";
                }
                else
                {
                    studyNumInput = tbSearchStudyNum.Text; ;
                }

                if (cbSearchSponsor.Text == "--Select--" || cbSearchSponsor.Text == null || cbSearchSponsor.Text == "")
                {
                    studySponsorInput = "";
                    cbSearchSponsor.Text = "--Select--";
                }
                else
                {
                    studySponsorInput = cbSearchSponsor.Text;
                }

                if (cbSearchTech.Text == "--Select--" || cbSearchTech.Text == null || cbSearchTech.Text == "")
                {
                    studyTechInput = "";
                    cbSearchTech.Text = "--Select--";
                }
                else
                {
                    studyTechInput = cbSearchTech.Text;
                }
                if (checkBoxCF.Checked)
                {
                    boolCurrentFuture = 1;
                }
                else
                {
                    boolCurrentFuture = 0;
                }

                dt = DBUtilsForScheduler.SearchStudiesUsingSP(studyNumInput, studySponsorInput, studyTechInput, boolCurrentFuture);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Searching Studies using Stored Proc! " +
                    "Error = " + ex.Message);
            }
        }
        
        private void cbSearchReset()
        {
            tbSearchStudyNum.Text = "";
            cbSearchSponsor.Text = "--Select--";
            cbSearchTech.Text = "--Select--";
        }

        private void FillComboBoxes()
        {
            DBUtilsForScheduler.FillComboBox("FillComboBoxTechs", cbTechName);
            DBUtilsForScheduler.FillComboBox("FillComboBoxSponsor", cbSearchSponsor);
            DBUtilsForScheduler.FillComboBox("FillComboBoxTechs", cbSearchTech);
            DBUtilsForScheduler.FillComboBox("FillComboBoxColors", cbColor);
        }

        private void cbSearchSponsor_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void cbSearchTech_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void tbSearchStudyNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            search();
        }

        private void checkBoxCF_CheckedChanged(object sender, EventArgs e)
        {
            search();
        }


        /*                    (\,/)          <- Barry
                             oo   '''//,        _
                           ,/_;~,        \,    / '
                           "'   \    (    \    !
                                 ',|  \    |__.'
                                 '~  '~----''              */
    }
}
