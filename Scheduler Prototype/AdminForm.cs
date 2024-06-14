using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Office.Interop.Excel;
using Scheduler_Prototype.Data;
using Scheduler_Prototype.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler_Prototype
{
    public partial class AdminForm : Form
    {
        int FormMode = 1;
        string username;
        System.Data.DataTable dt = new System.Data.DataTable();
        SqlConnection conn;
        Models.Users user;
        private void LoadUserData()
        {
            dataGridView1.EndEdit();

            using (SqlConnection connection = DBUtilsForScheduler.MakeConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT username AS 'Username' FROM users WHERE deleted = 0 AND username != 'admin'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        System.Data.DataTable dataTable = new System.Data.DataTable();

                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public AdminForm()
        {
            InitializeComponent();
            LoadUserData();
            disableCtrls();
            enableNecCtrls();
            cbPassword.Visible = false;
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormMode = 2;
            enableAllCtrls();
            ClearAllTextboxes(this);
            cbPassword.Visible = false;
            tbUsername.Enabled = true;
            labelPassword.Text = "Password:";
            labelConfirm.Text = "Confirm Password:";
            labelPassword.Visible = true;
            labelConfirm.Visible = true;
            tbPassword.Visible = true;
            tbConfirm.Visible = true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FormMode = 3;
            enableAllCtrls();
            labelPassword.Text = "New Password:";
            labelConfirm.Text = "Confirm New Password:";
            cbPassword.Visible = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // input validation
            if(tbUsername.Text == "")
            {
                MessageBox.Show("Error: invalid input for username");
                return;
            }
            if(FormMode == 2)
            {
                Models.Users user = new Models.Users();
                InstantiateUserFromTextBoxes(user);
                user.pword = tbPassword.Text;
                try
                {
                    int recInserted = DBUtilsForScheduler.InsertUserUsingSP(user);
                    if (recInserted > 0)
                    {
                        MessageBox.Show("Successfully inserted user!");
                        UpdateUserTextBoxes(user);
                    }
                    else
                    {
                        MessageBox.Show("Did not insert user!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert User Failed! Error = " + ex.Message);
                }
                disableCtrls();
                enableNecCtrls();
                LoadUserData();

            }
            else if (FormMode == 3)
            {
                InstantiateUserFromTextBoxes(user);
                try
                {
                    if (cbPassword.Checked)
                    {
                        if (tbPassword.Text != "" & tbPassword.Text == tbConfirm.Text)
                        {
                            int recsInserted = DBUtilsForScheduler.ResetPassword(user.username, tbPassword.Text);
                            if (recsInserted > 0)
                            {
                                MessageBox.Show("Password successfully changed!");
                            }
                            else
                            {
                                MessageBox.Show("Did not update password!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: please ensure both passwords match.");
                            return;
                        }
                    }
                    int recInserted = DBUtilsForScheduler.UpdateUserUsingSP(user);
                    if (recInserted > 0)
                    {
                        MessageBox.Show("Successfully updated user!");
                        UpdateUserTextBoxes(user);
                    }
                    else
                    {
                        MessageBox.Show("Did not update user!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update user failed: " + ex.Message);
                }
                try
                {
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update password failed: " + ex.Message);
                }

                disableCtrls();
                enableNecCtrls();
                LoadUserData();
                ClearAllTextboxes(this);
            }

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (username != null)
            {
                UpdateUserTextBoxes(user);
            }
            else
            {
                ClearAllTextboxes(this);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                if (DBUtilsForScheduler.ConfirmDelete())
                {
                    using (conn = DBUtilsForScheduler.MakeConnection())
                    {
                        conn.Open();
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE users SET deleted = 1 WHERE username = @username", conn))
                            {
                                cmd.Parameters.AddWithValue("@username", user.username);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show($"User {user.username} has been soft-deleted.");
                                    user = new Models.Users();
                                    LoadUserData();
                                    UpdateUserTextBoxes(user);
                                    disableCtrls();
                                    enableNecCtrls();
                                }
                                else
                                {
                                    MessageBox.Show($"No username {user.username} found.");
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
                MessageBox.Show("No user selected to delete!");
            }

        }
        private void UpdateUserTextBoxes(Models.Users u)
        {
            tbUsername.Text = u.username;
            if (u.isAdmin)
            {
                cbAdmin.Checked = true;
            }
            else
            {
                cbAdmin.Checked = false;
            }
        }

        private void InstantiateUserFromTextBoxes(Models.Users u)
        {
            u.username = tbUsername.Text;
            if (cbAdmin.Checked)
            {
                u.isAdmin = true;
            }
            else
            {
                u.isAdmin = false;
            }
        }

        private void ClearAllTextboxes(System.Windows.Forms.Control container)
        {
            foreach (System.Windows.Forms.Control control in container.Controls)
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
            }
            labelPassword.Visible = false;
            labelConfirm.Visible = false;
            tbPassword.Visible = false;
            tbConfirm.Visible = false;
            cbPassword.Checked = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.Users user;
            string username;
            cbPassword.Checked = false;
            try
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                username = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                DBUtilsForScheduler.EnableBtn(btnModify);
                try
                {
                    user = DBUtilsForScheduler.GetAUserUsingSP(username);
                    this.user = user;
                    this.username = username;
                    UpdateUserTextBoxes(user);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving user data! " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving user data! " + ex.Message);
            }
        }

        private void disableCtrls() // disable all the controls
        {
            DBUtilsForScheduler.DisableControls(this);
            DBUtilsForScheduler.DisableBtn(btnSave);
            DBUtilsForScheduler.DisableBtn(btnUndo);
            DBUtilsForScheduler.DisableBtn(btnDelete);
            DBUtilsForScheduler.DisableBtn(btnModify);
            labelPassword.Visible = false;
            labelConfirm.Visible = false;
            tbPassword.Visible = false;
            tbConfirm.Visible = false;
        }

        private void enableNecCtrls() // enable just the necessary controls
        {
            DBUtilsForScheduler.EnableControls(TopLevelControl);
            DBUtilsForScheduler.EnableControls(dataGridView1);
            DBUtilsForScheduler.EnableBtn(btnNew);
            DBUtilsForScheduler.EnableControls(label11);
        }

        private void enableAllCtrls()
        {
            DBUtilsForScheduler.EnableAllControls(this);
            DBUtilsForScheduler.EnableBtn(btnSave);
            DBUtilsForScheduler.EnableBtn(btnUndo);
            DBUtilsForScheduler.EnableBtn(btnDelete);
            DBUtilsForScheduler.DisableControls(tbUsername);
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                labelPassword.Visible = true;
                labelConfirm.Visible = true;
                tbPassword.Visible = true;
                tbConfirm.Visible = true;
            }
            else
            {
                labelPassword.Visible = false;
                labelConfirm.Visible = false;
                tbPassword.Visible = false;
                tbConfirm.Visible = false;
            }
        }
    }
}