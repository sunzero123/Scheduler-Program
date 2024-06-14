using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scheduler_Prototype.Data;
using Scheduler_Prototype.Models;
using System.Security.Cryptography;
using DocumentFormat.OpenXml.Office2010.Excel;
using Org.BouncyCastle.Asn1.X509;

namespace Scheduler_Prototype.Data
{
    internal class DBUtilsForScheduler
    {
        private static string connStr = "Server=tcp:bestiesforever.database.windows.net,1433;Initial Catalog=Company;Persist Security Info=False;User ID=aja175;Password=Blurp!ty467Blurp$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static SqlConnection MakeConnection()
        {
            return new SqlConnection(connStr);
        }

        /*
          _____      _        _                  __  __       _ _   _       _        _____                        _     
         |  __ \    | |      (_)                |  \/  |     | | | (_)     | |      |  __ \                      | |    
         | |__) |___| |_ _ __ _  _____   _____  | \  / |_   _| | |_ _ _ __ | | ___  | |__) |___  ___ ___  _ __ __| |___ 
         |  _  // _ \ __| '__| |/ _ \ \ / / _ \ | |\/| | | | | | __| | '_ \| |/ _ \ |  _  // _ \/ __/ _ \| '__/ _` / __|
         | | \ \  __/ |_| |  | |  __/\ V /  __/ | |  | | |_| | | |_| | |_) | |  __/ | | \ \  __/ (_| (_) | | | (_| \__ \
         |_|  \_\___|\__|_|  |_|\___| \_/ \___| |_|  |_|\__,_|_|\__|_| .__/|_|\___| |_|  \_\___|\___\___/|_|  \__,_|___/
                                                                     | |                                                
                                                                     |_|                                                
         */

        public static System.Data.DataTable GetAllStudiesUsingSP()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetAllStudies", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving All Studies Recs using Stored Proc! " +
                        "Error=" + ex.Message);
                }
            }
            return dt;
        }

        public static System.Data.DataTable GetAllTasksUsingSP()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetAllTasks", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving All Tasks Recs using Stored Proc! " +
                        "Error=" + ex.Message);
                }
            }
            return dt;
        }

        public static System.Data.DataTable GetAllTasksByStudySP(int sid)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetStudyTasks", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sid", sid);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Task Recs by  Study ID! " +
                        "Error=" + ex.Message);
                }
            }
            return dt;
        }
        public static System.Data.DataTable GetAllTechniciansUsingSP()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetAllTechniciansSP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Technicians! " +
                        "Error=" + ex.Message);
                }
                return dt;
            }
        }

        public static System.Data.DataTable GetEventsByTasksSP(int tid)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetTaskEvents", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tid", tid);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Task Recs by  Study ID! " +
                        "Error=" + ex.Message);
                }
            }
            return dt;

        }

        public static System.Data.DataTable GetEventsByTechSP(int techid)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetAllEventsForTech", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@techid", techid);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Event Recs by Technician ID! " +
                        "Error=" + ex.Message);
                }
            }
            return dt;

        }
        /*
          _____      _        _                   _____ _             _        _____                        _ 
         |  __ \    | |      (_)                 / ____(_)           | |      |  __ \                      | |
         | |__) |___| |_ _ __ _  _____   _____  | (___  _ _ __   __ _| | ___  | |__) |___  ___ ___  _ __ __| |
         |  _  // _ \ __| '__| |/ _ \ \ / / _ \  \___ \| | '_ \ / _` | |/ _ \ |  _  // _ \/ __/ _ \| '__/ _` |
         | | \ \  __/ |_| |  | |  __/\ V /  __/  ____) | | | | | (_| | |  __/ | | \ \  __/ (_| (_) | | | (_| |
         |_|  \_\___|\__|_|  |_|\___| \_/ \___| |_____/|_|_| |_|\__, |_|\___| |_|  \_\___|\___\___/|_|  \__,_|
                                                                 __/ |                                        
                                                                |___/                                         
         */


        public static Studies GetAStudyUsingSP(int sid)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            Studies s = null;
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetAStudy", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sid", sid);
                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    // Check if rows are returned
                    if (dt.Rows.Count == 1)
                    {
                        DataRow row = dt.Rows[0];

                        // Create instance and map columns
                        s = new Studies();
                        s.studyID = Convert.ToInt32(row["study_id"]);
                        if (row["study_id"] == DBNull.Value)
                        {
                            // I feel like this is probably a bad way to handle this if this situation is possible
                            MessageBox.Show("Study ID is null. Defaulting to 1. Other details loaded successfully.");
                        }
                        s.studyNum = row["study_num"].ToString();
                        s.sponsor = row["sponsor"].ToString();
                        s.technicianID = Convert.ToInt32(row["technician_id"]);
                        s.color = row["color"].ToString();
                        s.startDate = Convert.ToDateTime(row["start_date"]);
                        s.endDate = Convert.ToDateTime(row["end_date"]);

                    }
                    else
                    {
                        MessageBox.Show($"Study with ID {sid} not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Study by ID using Stored Proc! " + "Error = " + ex.Message);
                }
                return s;
            }
        }
        public static Tasks GetATaskUsingSP(int tid)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            Tasks t = null;
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetATask", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tid", tid);
                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    // Check if rows are returned
                    if (dt.Rows.Count == 1)
                    {
                        DataRow row = dt.Rows[0];

                        // Create instance and map columns
                        t = new Tasks();
                        t.taskID = Convert.ToInt32(row["task_id"]);
                        if (row["task_id"] == DBNull.Value)
                        {
                            // I feel like this is probably a bad way to handle this if this situation is possible
                            MessageBox.Show("Task ID is null. Defaulting to 1. Other details loaded successfully.");
                        }
                        t.studyNum = row["study_num"].ToString();
                        t.studyID = Convert.ToInt32(row["study_id"]);
                        t.techID = Convert.ToInt32(row["tech_id"]);
                        t.studyStartDate = Convert.ToDateTime(row["study_start_date"]);
                        t.studyEndDate = Convert.ToDateTime(row["study_end_date"]);
                        t.taskStartDate = Convert.ToDateTime(row["task_start_date"]);
                        t.Duration = TimeSpan.FromMinutes(Convert.ToInt32(row["duration"]));
                        t.type = row["type"].ToString();
                        t.daily_frequency = row["daily_frequency"].ToString();
                        t.weekly_frequency = row["weekly_frequency"].ToString();
                        //t.timeOfDay = row["time_of_day"].ToString();
                        t.numOccurrences = Convert.ToInt32(row["num_occurrences"]);
                        t.customDays = (byte[])row["custom_days"];
                        t.comments = row["comments"].ToString();



                    }
                    else
                    {
                        MessageBox.Show($"Task with ID {tid} not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Task by ID using Stored Proc! " + "Error = " + ex.Message);
                }
                return t;
            }
        }

        public static Events GetAnEventUsingSP(int eventid)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            Events e = null;
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetAnEvent", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@eventid", eventid);
                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    // Check if rows are returned
                    if (dt.Rows.Count == 1)
                    {
                        DataRow row = dt.Rows[0];

                        // Create instance and map columns
                        e = new Events();
                        e.eventID = Convert.ToInt32(row["event_id"]);
                        if (row["event_id"] == DBNull.Value)
                        {
                            // I feel like this is probably a bad way to handle this if this situation is possible
                            MessageBox.Show("Event ID is null. Defaulting to 1. Other details loaded successfully.");
                        }

                        e.taskID = Convert.ToInt32(row["task_id"]);
                        e.eventCount = Convert.ToInt32(row["event_count"]);
                        e.studyID = Convert.ToInt32(row["study_id"]);
                        e.studyNum = row["study_num"].ToString();
                        e.techID = Convert.ToInt32(row["tech_id"]);
                        e.startDateTime = Convert.ToDateTime(row["date"]);
                        e.Duration = TimeSpan.FromMinutes(Convert.ToInt32(row["duration"]));
                        e.type = row["type"].ToString();
                        e.comments = row["comments"].ToString();
                    }
                    else
                    {
                        MessageBox.Show($"Event with ID {eventid} not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Event by ID using Stored Proc! " + "Error = " + ex.Message);
                }
                return e;
            }
        }
        public static Technicians GetATechnicianUsingSP(int tid)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            Technicians t = null;
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetATechnicianSP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tid", tid);
                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    // Check if rows are returned
                    if (dt.Rows.Count == 1)
                    {
                        DataRow row = dt.Rows[0];

                        // Create instance and map columns
                        t = new Technicians();
                        t.techID = Convert.ToInt32(row["tech_id"]);
                        if (row["tech_id"] == DBNull.Value)
                        {
                            // I feel like this is probably a bad way to handle this if this situation is possible
                            MessageBox.Show("Tech ID is null. Defaulting to 1. Other details loaded successfully.");
                        }
                        t.techID = Convert.ToInt32(row["tech_id"]);
                        t.techFirstName = row["tech_first_name"].ToString();
                        t.techLastName = row["tech_last_name"].ToString();
                        t.techNickname = row["tech_nickname"].ToString();
                        t.initials = row["tech_initials"].ToString();
                        t.techEmail = row["tech_email"].ToString();


                    }
                    else
                    {
                        MessageBox.Show($"Technician with ID {tid} not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Technician by ID using Stored Proc! " + "Error = " + ex.Message);
                }
                return t;
            }
        }

        public static Models.Users GetAUserUsingSP(string username)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            Models.Users u = null;
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetAUserSP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    // Check if rows are returned
                    if (dt.Rows.Count == 1)
                    {
                        DataRow row = dt.Rows[0];

                        // Create instance and map columns
                        u = new Models.Users();
                        u.username = row["username"].ToString();
                        if (Convert.ToInt32(row["isAdmin"]) == 1)
                        {
                            u.isAdmin = true;
                        }
                        else
                        {
                            u.isAdmin = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"User {username} not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving User by ID using Stored Proc! " + "Error = " + ex.Message);
                }
                return u;
            }
        }

        /*
          _____                     _     _____                        _ 
         |_   _|                   | |   |  __ \                      | |
           | |  _ __  ___  ___ _ __| |_  | |__) |___  ___ ___  _ __ __| |
           | | | '_ \/ __|/ _ \ '__| __| |  _  // _ \/ __/ _ \| '__/ _` |
          _| |_| | | \__ \  __/ |  | |_  | | \ \  __/ (_| (_) | | | (_| |
         |_____|_| |_|___/\___|_|   \__| |_|  \_\___|\___\___/|_|  \__,_|


         */

        public static int InsertStudyUsingSP(Studies s)
        {
            using (SqlConnection conn = MakeConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("InsertStudy", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sponsor_param", s.sponsor);
                cmd.Parameters.AddWithValue("@studynum_param", s.studyNum);
                cmd.Parameters.AddWithValue("@technicianID_param", s.technicianID);
                cmd.Parameters.AddWithValue("@color_param", s.color);
                cmd.Parameters.AddWithValue("@startdate", s.startDate);
                cmd.Parameters.AddWithValue("@endDate", s.endDate);

                // Add OUTPUT parameter for the inserted ID
                SqlParameter insertedIDParam = new SqlParameter("@insertedID", SqlDbType.Int);
                insertedIDParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(insertedIDParam);

                try
                {
                    int recsReturned = cmd.ExecuteNonQuery();
                    // Retrieve the last inserted Study ID
                    try
                    {
                        // Retrieve the inserted ID from the OUTPUT parameter
                        int insertedID = Convert.ToInt32(cmd.Parameters["@insertedID"].Value);
                        s.studyID = insertedID;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving newly inserted Study ID!" + ex.Message);
                    }
                    return recsReturned;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exectuting stored procedure: " + ex.Message);
                    throw; // rethrow the exception
                }

            }
        }
        public static int InsertTaskUsingSP(Tasks t)
        {
            using (SqlConnection conn = MakeConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("InsertTask", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@studynum_param", t.studyNum);
                cmd.Parameters.AddWithValue("@studyid", t.studyID);
                cmd.Parameters.AddWithValue("@techid", t.techID);
                cmd.Parameters.AddWithValue("@studystartdate", t.studyStartDate);
                cmd.Parameters.AddWithValue("@studyenddate", t.studyEndDate);
                cmd.Parameters.AddWithValue("@taskstartdate", t.taskStartDate);
                cmd.Parameters.AddWithValue("@duration_param", Convert.ToInt32(t.Duration.TotalMinutes));
                cmd.Parameters.AddWithValue("@type_param", t.type);
                cmd.Parameters.AddWithValue("@dailyfreq", t.daily_frequency);
                cmd.Parameters.AddWithValue("@weeklyfreq", t.weekly_frequency);
                cmd.Parameters.AddWithValue("@num_occ", t.numOccurrences);
                cmd.Parameters.AddWithValue("@customdays", t.customDays);
                cmd.Parameters.AddWithValue("@comments", t.comments);

                // Add OUTPUT parameter for the inserted ID
                SqlParameter insertedIDParam = new SqlParameter("@insertedID", SqlDbType.Int);
                insertedIDParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(insertedIDParam);

                try
                {
                    int recsReturned = cmd.ExecuteNonQuery();
                    // Retrieve the last inserted Task ID
                    try
                    {
                        // Retrieve the inserted ID from the OUTPUT parameter
                        int insertedID = Convert.ToInt32(cmd.Parameters["@insertedID"].Value);
                        t.taskID = insertedID;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving newly inserted Task ID!" + ex.Message);
                    }
                    return recsReturned;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exectuting stored procedure: " + ex.Message);
                    throw; // rethrow the exception
                }
            }
        }
        public static int InsertEventUsingSP(Events e)
        {
            using (SqlConnection conn = MakeConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("InsertEvent", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@taskid", e.taskID);
                    cmd.Parameters.AddWithValue("@studyid", e.studyID);
                    cmd.Parameters.AddWithValue("@study_num_param", e.studyNum);
                    cmd.Parameters.AddWithValue("@techid", e.techID);
                    cmd.Parameters.AddWithValue("@type_param", e.type);
                    cmd.Parameters.AddWithValue("@start", e.startDateTime);
                    cmd.Parameters.AddWithValue("@duration_param", Convert.ToInt32(e.Duration.TotalMinutes));
                    cmd.Parameters.AddWithValue("@eventcount", e.eventCount);
                    cmd.Parameters.AddWithValue("@comments", e.comments);

                    // Add OUTPUT parameter for the inserted ID
                    SqlParameter insertedIDParam = new SqlParameter("@insertedID", SqlDbType.Int);
                    insertedIDParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(insertedIDParam);

                    try
                    {
                        int recsReturned = cmd.ExecuteNonQuery();
                        // Retrieve the last inserted Task ID
                        try
                        {
                            // Retrieve the inserted ID from the OUTPUT parameter
                            int insertedID = Convert.ToInt32(cmd.Parameters["@insertedID"].Value);
                            e.eventID = insertedID;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error retrieving newly inserted Event ID!" + ex.Message);
                        }
                        return recsReturned;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error executing event stored procedure: " + ex.Message);
                        throw; // rethrow the exception
                    }
                }

            }

        }

        public static int InsertTechnicianUsingSP(Technicians t)
        {
            using (SqlConnection conn = MakeConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("InsertTechnician", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employeeNum", t.techEmpNum);
                cmd.Parameters.AddWithValue("@firstname", t.techFirstName);
                cmd.Parameters.AddWithValue("@lastName", t.techLastName);
                cmd.Parameters.AddWithValue("nickname", t.techNickname);
                cmd.Parameters.AddWithValue("email", t.techEmail);
                cmd.Parameters.AddWithValue("initials_param", t.initials);

                // Add OUTPUT parameter for the inserted ID
                SqlParameter insertedIDParam = new SqlParameter("@insertedID", SqlDbType.Int);
                insertedIDParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(insertedIDParam);

                try
                {
                    int recsReturned = cmd.ExecuteNonQuery();
                    // Retrieve the last inserted Task ID
                    try
                    {
                        // Retrieve the inserted ID from the OUTPUT parameter
                        int insertedID = Convert.ToInt32(cmd.Parameters["@insertedID"].Value);
                        t.techID = insertedID;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving newly inserted Tech ID!" + ex.Message);
                    }
                    return recsReturned;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exectuting stored procedure: " + ex.Message);
                    throw; // rethrow the exception
                }

            }
        }

        public static int InsertUserUsingSP(Models.Users u)
        {
            using (SqlConnection conn = MakeConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("InsertUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.pword);
                if (u.isAdmin)
                {
                    cmd.Parameters.AddWithValue("@isAdmin", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@isAdmin", 0);
                }

                // Add OUTPUT parameter for the inserted ID
                SqlParameter insertedUserParam = new SqlParameter("@insertedUser", SqlDbType.VarChar, 50);
                insertedUserParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(insertedUserParam);

                try
                {
                    int recsReturned = cmd.ExecuteNonQuery();
                    // Retrieve the last inserted Task ID
                    try
                    {
                        // Retrieve the inserted ID from the OUTPUT parameter
                        string insertedUser = cmd.Parameters["@insertedUser"].Value.ToString();
                        u.username = insertedUser;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving newly inserted user!" + ex.Message);
                    }
                    return recsReturned;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exectuting stored procedure: " + ex.Message);
                    throw; // rethrow the exception
                }

            }
        }

        /*
          __  __           _ _  __         _____                        _ 
         |  \/  |         | (_)/ _|       |  __ \                      | |
         | \  / | ___   __| |_| |_ _   _  | |__) |___  ___ ___  _ __ __| |
         | |\/| |/ _ \ / _` | |  _| | | | |  _  // _ \/ __/ _ \| '__/ _` |
         | |  | | (_) | (_| | | | | |_| | | | \ \  __/ (_| (_) | | | (_| |
         |_|  |_|\___/ \__,_|_|_|  \__, | |_|  \_\___|\___\___/|_|  \__,_|
                                    __/ |                                 
                                   |___/                                  
         */

        public static int UpdateStudyUsingSP(Studies s)
        {
            using (SqlConnection conn = MakeConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateStudySP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@studyid", s.studyID);
                cmd.Parameters.AddWithValue("@studynum_param", s.studyNum);
                cmd.Parameters.AddWithValue("@sponsor_param", s.sponsor);
                cmd.Parameters.AddWithValue("@techid", s.technicianID);
                cmd.Parameters.AddWithValue("@color_param", s.color);
                cmd.Parameters.AddWithValue("@startdate_param", s.startDate);
                cmd.Parameters.AddWithValue("@endDate_param", s.endDate);

                try
                {
                    int recsReturned = cmd.ExecuteNonQuery();
                    return recsReturned;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing Update stored procedure: " + ex.Message);
                    throw; // rethrow the exception
                }
            }
        }

        public static int UpdateTaskUsingSP(Tasks t)
        {
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UpdateTaskUsingSP", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@taskid", t.taskID);
                    cmd.Parameters.AddWithValue("@studynum_param", t.studyNum);
                    cmd.Parameters.AddWithValue("@studyid", t.studyID);
                    cmd.Parameters.AddWithValue("@studystartdate", t.studyStartDate);
                    cmd.Parameters.AddWithValue("@studyenddate", t.studyEndDate);
                    cmd.Parameters.AddWithValue("@taskstartdate", t.taskStartDate);
                    cmd.Parameters.AddWithValue("@duration_param", Convert.ToInt32(t.Duration.TotalMinutes));
                    cmd.Parameters.AddWithValue("@type_param", t.type);
                    cmd.Parameters.AddWithValue("@dailyfreq", t.daily_frequency);
                    cmd.Parameters.AddWithValue("@weeklyfreq", t.weekly_frequency);
                    cmd.Parameters.AddWithValue("@num_occ", t.numOccurrences);
                    cmd.Parameters.AddWithValue("@customdays", t.customDays);
                    cmd.Parameters.AddWithValue("@comments", t.comments);


                    int recsReturned = cmd.ExecuteNonQuery();
                    return recsReturned;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing Update stored procedure for Tasks: " + ex.Message);
                    throw; // rethrow the exception
                }
            }
        }

        public static int UpdateTaskEventUsingSP(Events e)
        {
            using (SqlConnection conn = MakeConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateTaskEventSP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eventid", e.eventID);
                cmd.Parameters.AddWithValue("@techID", e.techID);
                cmd.Parameters.AddWithValue("@type_param", e.type);
                cmd.Parameters.AddWithValue("@date_param", e.startDateTime);
                cmd.Parameters.AddWithValue("@duration_param", Convert.ToInt32(e.Duration.TotalMinutes));
                cmd.Parameters.AddWithValue("@comments", e.comments);
                // figure out how this is going to affect task event count
                try
                {
                    int recsReturned = cmd.ExecuteNonQuery();
                    return recsReturned;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error executing UpdateTaskEvent stored procedure: " + ex.Message);
                    throw; // rethrow the exception
                }
            }
        }

        public static int UpdateTechnicianUsingSP(Technicians t)
        {
            using (SqlConnection conn = MakeConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateTechnicianSP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@techid", t.techID);
                cmd.Parameters.AddWithValue("@empNum", t.techEmpNum);
                cmd.Parameters.AddWithValue("@fname", t.techFirstName);
                cmd.Parameters.AddWithValue("@lname", t.techLastName);
                cmd.Parameters.AddWithValue("@nickname", t.techNickname);
                cmd.Parameters.AddWithValue("@email", t.techEmail);
                cmd.Parameters.AddWithValue("@initials", t.initials);

                try
                {
                    int recsReturned = cmd.ExecuteNonQuery();
                    return recsReturned;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing UpdateTechnician stored procedure: " + ex.Message);
                    throw; // rethrow the exception
                }
            }
        }

        public static int UpdateUserUsingSP(Models.Users u)
        {
            using (SqlConnection conn = MakeConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateUserSP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", u.username);
                if (u.isAdmin)
                {
                    cmd.Parameters.AddWithValue("@isAdmin", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@isAdmin", 0);
                }


                try
                {
                    int recsReturned = cmd.ExecuteNonQuery();
                    return recsReturned;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing UpdateUser stored procedure: " + ex.Message);
                    throw; // rethrow the exception
                }
            }
        }

        public static int ResetPassword(string username, string password)
        {
            using (SqlConnection conn = MakeConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ResetUserPassword", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);


                try
                {
                    int recsReturned = cmd.ExecuteNonQuery();
                    return recsReturned;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing ResetUserPassword stored procedure: " + ex.Message);
                    throw; // rethrow the exception
                }
            }
        }



        /*
         ________ ________  ________  _____ ______           _____ ______   ________  ________   ________  ________  _______   _____ ______   _______   ________   _________   
        |\  _____\\   __  \|\   __  \|\   _ \  _   \        |\   _ \  _   \|\   __  \|\   ___  \|\   __  \|\   ____\|\  ___ \ |\   _ \  _   \|\  ___ \ |\   ___  \|\___   ___\ 
        \ \  \__/\ \  \|\  \ \  \|\  \ \  \\\__\ \  \       \ \  \\\__\ \  \ \  \|\  \ \  \\ \  \ \  \|\  \ \  \___|\ \   __/|\ \  \\\__\ \  \ \   __/|\ \  \\ \  \|___ \  \_| 
         \ \   __\\ \  \\\  \ \   _  _\ \  \\|__| \  \       \ \  \\|__| \  \ \   __  \ \  \\ \  \ \   __  \ \  \  __\ \  \_|/_\ \  \\|__| \  \ \  \_|/_\ \  \\ \  \   \ \  \  
          \ \  \_| \ \  \\\  \ \  \\  \\ \  \    \ \  \       \ \  \    \ \  \ \  \ \  \ \  \\ \  \ \  \ \  \ \  \|\  \ \  \_|\ \ \  \    \ \  \ \  \_|\ \ \  \\ \  \   \ \  \ 
           \ \__\   \ \_______\ \__\\ _\\ \__\    \ \__\       \ \__\    \ \__\ \__\ \__\ \__\\ \__\ \__\ \__\ \_______\ \_______\ \__\    \ \__\ \_______\ \__\\ \__\   \ \__\
            \|__|    \|_______|\|__|\|__|\|__|     \|__|        \|__|     \|__|\|__|\|__|\|__| \|__|\|__|\|__|\|_______|\|_______|\|__|     \|__|\|_______|\|__| \|__|    \|__|
         */
        public static bool ConfirmDelete()
        {
            const string message = "Are you sure you would like to delete this record?";
            const string caption = "Record Deleting";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
        }

        public static void EnableControls(Control con)
        {
            if (con != null)
            {
                con.Enabled = true;
                EnableControls(con.Parent);
            }
        }
        public static void EnableAllControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                EnableAllControls(c);
            }
            con.Enabled = true;
        }

        public static void DisableBtn(Control btn) // for modifying the appearance of disabled buttons
        {
            btn.Enabled = false;
            btn.BackColor = System.Drawing.Color.LightGray;
            btn.ForeColor = System.Drawing.Color.Gray;
        }

        public static void EnableBtn(Control btn) // for modifying the appearance of enabled buttons
        {
            EnableControls(btn);
            btn.BackColor = System.Drawing.Color.Navy;
            btn.ForeColor = System.Drawing.Color.White;
        }


        /**********************************  SEARCH STORED PROCEDURES   ***********************************/

        public static System.Data.DataTable SearchStudiesUsingSP(string studyNum, string sponsor, string techName, int boolCurrentFuture)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SearchStudies", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@studyNum", studyNum);
                    cmd.Parameters.AddWithValue("@sponsor", sponsor);
                    cmd.Parameters.AddWithValue("@techName", techName);
                    cmd.Parameters.AddWithValue("@boolCurrentFuture", boolCurrentFuture);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Searched Studies using Stored Proc! " +
                        "Error=" + ex.Message);
                }
            }
            return dt;
        }

        public static System.Data.DataTable SearchTasksUsingSP(string studyNum, string type, string techName, int boolCurrentFuture)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SearchTasks", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@studyNum", studyNum);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@techName", techName);
                    cmd.Parameters.AddWithValue("@boolCurrentFuture", boolCurrentFuture);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Searched Tasks using Stored Proc! " +
                        "Error=" + ex.Message);
                }
            }
            return dt;
        }

        public static System.Data.DataTable SearchTechUsingSP(string input)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SearchTechnicians", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@input", input);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Searched Technicians using Stored Proc! " +
                        "Error=" + ex.Message);
                }
            }
            return dt;
        }

        public static System.Data.DataTable SearchEventsUsingSP(string studyNum, string type, string techName, int boolToday, int boolCurrentFuture)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SearchEvents", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@studyNum", studyNum);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@techName", techName);
                    cmd.Parameters.AddWithValue("@boolToday", boolToday);
                    cmd.Parameters.AddWithValue("@boolCurrentFuture", boolCurrentFuture);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Searched Events using Stored Proc! " +
                        "Error=" + ex.Message);
                }
            }
            return dt;
        }

        public static void FillComboBox(string sp, ComboBox cb)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sp, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    dt.Rows.Add();
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Filling Combo Box using Stored Proc! " +
                        "Error=" + ex.Message);
                }
            }

            cb.ValueMember = "";
            cb.DataSource = dt;
            cb.DisplayMember = dt.Columns[0].ColumnName;
        }
        public static void FillEventTechComboBox(string sp, ComboBox cb, int taskID, int eventCount)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sp, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@taskid", taskID);
                    cmd.Parameters.AddWithValue("@eventCount", eventCount);
                    da.SelectCommand = cmd;
                    dt.Rows.Add();
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Technicians using Stored Proc! " +
                        "Error=" + ex.Message);
                }
            }

            cb.ValueMember = "";
            cb.DataSource = dt;
            cb.DisplayMember = dt.Columns[0].ColumnName;
        }

        public static string GetTechName(int tid)
        {
            string value;
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetTechNameFromID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tid", tid);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    DataRow row = dt.Rows[0];
                    value = row["Name"].ToString();
                    return value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Technician Name using Stored Proc! " +
                        "Error=" + ex.Message);
                    return null;
                }
            }
        }

        public static int GetTechID(string techName)
        {
            int tid;
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetTechIDFromName", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tname", techName);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    DataRow row = dt.Rows[0];
                    tid = Convert.ToInt32(row["ID"]);
                    return tid;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Technician ID using Stored Proc! " +
                        "Error=" + ex.Message);
                    return 0;
                }
            }
        }

        public static int GetStudyID(string studyNum) // this does nothing as of now i'm sorry
        {
            int sid;
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetStudyIDFromNum", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@snum", studyNum);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    DataRow row = dt.Rows[0];
                    sid = Convert.ToInt32(row["study_id"]);
                    return sid;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Study ID using Stored Proc! " +
                        "Error=" + ex.Message);
                    return 0;
                }
            }
        }

        public static string GetStudyNum(int sid)
        {
            string value;
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection conn = MakeConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetStudyNumFromID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sid", sid);
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    DataRow row = dt.Rows[0];
                    value = row["study_num"].ToString();
                    return value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Retrieving Study Number using Stored Proc! " +
                        "Error=" + ex.Message);
                    return null;
                }
            }
        }
        public static void DeleteUser(string username)
        {
            using (SqlConnection connection = MakeConnection())
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM users WHERE username = @username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User '" + username + "' deleted successfully.", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("User '" + username + "' not found.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public static bool CheckIfUserExists(string username)
        {
            using (SqlConnection connection = MakeConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM users WHERE username = @username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false; 
                }
            }
        }

        public static void InsertUser(string username, string password, bool isAdmin)
        {
            using (SqlConnection connection = MakeConnection())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO users (username, password, isAdmin) VALUES (@username, HASHBYTES('SHA2_512', @password), @isAdmin)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        SqlParameter isAdminParam = new SqlParameter("@isAdmin", SqlDbType.Bit);
                        isAdminParam.Value = (object)isAdmin ?? DBNull.Value;
                        command.Parameters.Add(isAdminParam);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public static void UpdateUser(string username, string password, bool isAdmin)
        {
            using (SqlConnection connection = MakeConnection())
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE users SET password = @password, isAdmin = @isAdmin WHERE username = @username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@username", username);

                        SqlParameter isAdminParam = new SqlParameter("@isAdmin", SqlDbType.Bit);
                        isAdminParam.Value = (object)isAdmin ?? DBNull.Value;
                        command.Parameters.Add(isAdminParam);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
       
    }
}
