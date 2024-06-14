using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;
using Scheduler_Prototype.Data;
using System.Security.Cryptography;


namespace Scheduler_Prototype
{
    public partial class Form1 : Form
    {
        /*
         This program was created by Jesse Gates, Alex Rodriguez, and Abbie McDowell in spring of 2024 for our Purdue Northwest senior project
        For questions or help editing the program, contact Jesse at jgsylvester12@gmail.com or call/text 219-677-3411
        Good luck to all who enter and God bless the rats
         */
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
            { 
        }
        private void button2_Click(object sender, EventArgs e) // Login button
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Username and Password cannot be empty.");
                return;
            }

            using (SqlConnection conn = DBUtilsForScheduler.MakeConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1), isAdmin FROM users " +
                        "WHERE username=@username " +
                        "AND password=@password " +
                        "AND deleted = 0 GROUP BY isAdmin";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@username", textBoxUsername.Text);
                        using(SHA512 sha512 = SHA512.Create())
                        {
                            byte[] hashedPasswordBytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(textBoxPassword.Text));
                            command.Parameters.AddWithValue("@password", hashedPasswordBytes);
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read() && reader.GetInt32(0) == 1) // If the user exists
                            {
                                bool isAdmin = reader.GetBoolean(1); // Get the isAdmin value
                                MainForm fm = new MainForm(isAdmin); // Pass isAdmin to MainForm
                                this.Hide(); // Hide the login form
                                fm.ShowDialog();
                                this.Close(); // Close the login form after the main form is closed
                            }
                            else
                            {
                                MessageBox.Show("Username or Password is incorrect.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

    }
}
