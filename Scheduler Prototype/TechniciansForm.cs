using System.Data.SqlClient;
using Scheduler_Prototype.Data;
using Scheduler_Prototype.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler_Prototype
{
    public partial class TechniciansForm : Form
    {
        // 1 is view, 2 is add, 3 is modify
        int FormMode = 1;
        int tid; // tech id
        DataTable dt = new DataTable();
        SqlConnection conn;
        Technicians tech;
        public TechniciansForm()
        {
            InitializeComponent();
        }
        private void TechniciansForm_Load(object sender, EventArgs e)
        {
            disableCtrls();
            enableNecCtrls();
            refreshDataGridView();
        }

        /*
          ____        _   _                _____                 _       
         | __ ) _   _| |_| |_ ___  _ __   | ____|_   _____ _ __ | |_ ___ 
         |  _ \| | | | __| __/ _ \| '_ \  |  _| \ \ / / _ \ '_ \| __/ __|
         | |_) | |_| | |_| || (_) | | | | | |___ \ V /  __/ | | | |_\__ \
         |____/ \__,_|\__|\__\___/|_| |_| |_____| \_/ \___|_| |_|\__|___/
         */
        private void btnNew_Click(object sender, EventArgs e)
        {
            FormMode = 2;
            enableAllCtrls();
            tbTechID.Enabled = false;
            ClearAllTextboxes(this);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FormMode = 3;
            enableAllCtrls();
            tbTechID.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // input validation
            if (tbFname.Text == "") // regular expression needed
            {
                MessageBox.Show("Error: invalid input for first name");
            }
            if (tbLname.Text == "") // regular expression needed
            {
                MessageBox.Show("Error: invalid input for last name");
            }
            if (tbNickname.Text == "") // regular expression needed
            {
                MessageBox.Show("Error: invalid input for nickname");
            }
            if (tbInitials.Text == "") // regular expression needed
            {
                MessageBox.Show("Error: invalid input for initials");
            }

            // Insert new Tech
            // check if form mode is modify or add to decide save method
            if (!string.IsNullOrEmpty(tbFname.Text) &&
                !string.IsNullOrEmpty(tbLname.Text) && (FormMode == 2))
            {
                Technicians tech = new Technicians();
                InstantiateTechFromTextBoxes(tech);
                try
                {
                    int recInserted = DBUtilsForScheduler.InsertTechnicianUsingSP(tech);
                    if (recInserted > 0)
                    {
                        MessageBox.Show("Successfully inserted Technician rec!");
                        UpdateTechnicianTextBoxes(tech);
                    }
                    else
                    {
                        MessageBox.Show("Did not insert Technician rec!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Technician Failed! Error = " + ex.Message);
                }
                disableCtrls();
                enableNecCtrls();
                refreshDataGridView();
            }
            // Modify Study
            else if (FormMode == 3)
            {
                InstantiateTechFromTextBoxes(tech);
                try
                {
                    int recInserted = DBUtilsForScheduler.UpdateTechnicianUsingSP(tech);
                    if (recInserted > 0)
                    {
                        MessageBox.Show("Successfully updated Technician rec!");
                        UpdateTechnicianTextBoxes(tech);
                    }
                    else
                    {
                        MessageBox.Show("Did not update Technician rec!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Technician rec failed: " + ex.Message);
                }
                disableCtrls();
                enableNecCtrls();
                refreshDataGridView();

            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (tid > 0)
            {
                UpdateTechnicianTextBoxes(tech);
            }
            else
            {
                ClearAllTextboxes(this);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tech != null)
            {
                if (DBUtilsForScheduler.ConfirmDelete())
                {
                    using (conn = DBUtilsForScheduler.MakeConnection())
                    {
                        conn.Open();
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE technicians SET deleted = 1 WHERE tech_id = @techid", conn))
                            {
                                cmd.Parameters.AddWithValue("@techid", tech.techID);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show($"Technician with ID {tech.techID} has been soft-deleted.");
                                    tech = new Technicians();
                                    refreshDataGridView();
                                    UpdateTechnicianTextBoxes(tech);
                                    disableCtrls();
                                    enableNecCtrls();
                                }
                                else
                                {
                                    MessageBox.Show($"No technician found with ID {tech.techID}.");
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
                MessageBox.Show("No technician selected to delete!");
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
        /*
          _____                      __  __      _   _               _     
         |  ___|__  _ __ _ __ ___   |  \/  | ___| |_| |__   ___   __| |___ 
         | |_ / _ \| '__| '_ ` _ \  | |\/| |/ _ \ __| '_ \ / _ \ / _` / __|
         |  _| (_) | |  | | | | | | | |  | |  __/ |_| | | | (_) | (_| \__ \
         |_|  \___/|_|  |_| |_| |_| |_|  |_|\___|\__|_| |_|\___/ \__,_|___/
         */
        private void UpdateTechnicianTextBoxes(Technicians t)
        {
            tbTechID.Text = t.techID.ToString();
            tbFname.Text = t.techFirstName;
            tbLname.Text = t.techLastName;
            tbNickname.Text = t.techNickname;
            tbInitials.Text = t.initials;
            tbEmail.Text = t.techEmail;
        }

        private void InstantiateTechFromTextBoxes(Technicians t)
        {
            t.techFirstName = tbFname.Text;
            t.techLastName = tbLname.Text;
            t.techNickname = tbNickname.Text;
            t.initials = tbInitials.Text;
            t.techEmail = tbEmail.Text;
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
                if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }
                else if (control.HasChildren)
                {
                    // Recursively clear maskedTextboxes in nested containers
                    ClearAllTextboxes(control);
                }
            }
        }
        private void refreshDataGridView()
        {
            try
            {
                dt = DBUtilsForScheduler.GetAllTechniciansUsingSP();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["tech_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Getting All Technicians using Stored Proc! " +
                    "Error = " + ex.Message);
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Technicians tech;
            int tid;
            try
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                tid = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);
                DBUtilsForScheduler.EnableBtn(btnModify);
                DBUtilsForScheduler.EnableBtn(btnDelete);
                try
                {
                    tech = DBUtilsForScheduler.GetATechnicianUsingSP(tid);
                    this.tech = tech;
                    this.tid = tid;
                    UpdateTechnicianTextBoxes(tech);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving technician data! " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving technician data! " + ex.Message);
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
            DBUtilsForScheduler.EnableBtn(btnSearch);
            DBUtilsForScheduler.EnableControls(tbSearch);
            DBUtilsForScheduler.EnableControls(label11);
            DBUtilsForScheduler.EnableControls(backToMainBtn);
            DBUtilsForScheduler.EnableControls(btnTasks);
            DBUtilsForScheduler.EnableControls(btnEvents);
            DBUtilsForScheduler.EnableControls(btnStudies);
            DBUtilsForScheduler.EnableControls(labelSearchTech);
        }

        private void enableAllCtrls()
        {
            DBUtilsForScheduler.EnableAllControls(this);
            DBUtilsForScheduler.EnableBtn(btnSave);
            DBUtilsForScheduler.EnableBtn(btnUndo);
            DBUtilsForScheduler.EnableBtn(btnDelete);
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            try
            {
                string input = tbSearch.Text;
                dt = DBUtilsForScheduler.SearchTechUsingSP(input);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Searching Technicians using Stored Proc! " +
                    "Error = " + ex.Message);
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                search();
            }
        }
    }
}
