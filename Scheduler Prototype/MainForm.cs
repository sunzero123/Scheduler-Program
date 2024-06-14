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
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Scheduler_Prototype.Data;


namespace Scheduler_Prototype
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(bool isAdmin = false)
        {
            InitializeComponent();
            // Set visibility based on the isAdmin parameter
            button4.Visible = isAdmin;
        }

        private void button1_Click(object sender, EventArgs e) // open studies form
        {
            StudiesForm fm = new StudiesForm();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e) // open tasks form
        {
            TasksForm fm = new TasksForm();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e) // open events form
        {
            EventsForm fm = new EventsForm();
            fm.Show();
        }

        private void button5_Click(object sender, EventArgs e) // open technicians form
        {
            TechniciansForm fm = new TechniciansForm();
            fm.Show();
        }

        /*
         ________                                __       
        |        \                              |  \  
        | $$$$$$$$ __    __   _______   ______  | $$      
        | $$__    |  \  /  \ /       \ /      \ | $$      
        | $$  \    \$$\/  $$|  $$$$$$$|  $$$$$$\| $$      
        | $$$$$     >$$  $$ | $$      | $$    $$| $$      
        | $$_____  /  $$$$\ | $$_____ | $$$$$$$$| $$      
        | $$     \|  $$ \$$\ \$$     \ \$$     \| $$      
         \$$$$$$$$ \$$   \$$  \$$$$$$$  \$$$$$$$ \$$       
                                                                                                                                                  
         */
        private void button6_Click(object sender, EventArgs e)
        {
            //string connStr = "Server=tcp:bestiesforever.database.windows.net,1433;Initial Catalog=Company;Persist Security Info=False;User ID=aja175;Password=Blurp!ty467Blurp$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string sqlQueryTechnicians = "SELECT tech_id, tech_nickname, deleted FROM dbo.technicians WHERE deleted = 0";
            string sqlQueryEvents = @"
                                    SELECT 
                                    s.study_num,  
                                    e.type, 
                                    e.date, 
                                    e.duration, 
                                    e.comments,
                                    t.tech_nickname, 
                                    s.color, 
                                    e.deleted,
                                    t.deleted
                                    FROM dbo.taskevents e
                                    JOIN dbo.technicians t ON e.tech_id = t.tech_id AND t.deleted = 0
                                    JOIN dbo.studies s ON e.study_id = s.study_id
                                    WHERE CAST(e.date AS date) = @EventDate AND e.deleted = 0 AND t.deleted=0";

            DataTable dataTableTechnicians = new DataTable();
            DataTable dataTableEvents = new DataTable();

            using (SqlConnection conn = DBUtilsForScheduler.MakeConnection())
            {
                conn.Open();

                // Fetch technicians
                using (SqlCommand cmd = new SqlCommand(sqlQueryTechnicians, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataTableTechnicians.Load(reader);
                    }
                }
                // Fetch events
                using (SqlCommand cmd = new SqlCommand(sqlQueryEvents, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@EventDate", dateTimePicker1.Value.Date);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataTableEvents.Load(reader);
                    }
                }
            }

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Schedule");

                worksheet.Cell(1, 1).Value = "Technicians";

                DateTime startTime = new DateTime(2024, 1, 1, 6, 0, 0);
                DateTime endTime = new DateTime(2024, 1, 2, 0, 0, 0);
                int row = 2;

                List<DateTime> timeslots = new List<DateTime>();

                while (startTime < endTime)
                {
                    worksheet.Cell(row, 1).Value = startTime.ToString("h:mm tt");
                    timeslots.Add(startTime);
                    startTime = startTime.AddMinutes(15);
                    row++;
                }

                Dictionary<string, int> techColumnMapping = new Dictionary<string, int>();

                for (int i = 0; i < dataTableTechnicians.Rows.Count; i++)
                {
                    string techNickname = dataTableTechnicians.Rows[i]["tech_nickname"].ToString();
                    worksheet.Cell(1, i + 2).Value = techNickname;
                    techColumnMapping[techNickname] = i + 2;
                }

                Dictionary<string, string> colorHexCodes = new Dictionary<string, string>();

                string sqlQueryColors = "SELECT color_name, hex FROM dbo.Colors";

                using (SqlConnection connColors = DBUtilsForScheduler.MakeConnection())
                {
                    connColors.Open();
                    // Fetch colors
                    using (SqlCommand cmdColors = new SqlCommand(sqlQueryColors, connColors))
                    {
                        cmdColors.CommandType = CommandType.Text;
                        using (SqlDataReader readerColors = cmdColors.ExecuteReader())
                        {
                            while (readerColors.Read())
                            {
                                string colorName = readerColors["color_name"].ToString();
                                string hexCode = readerColors["hex"].ToString();
                                colorHexCodes[colorName] = hexCode;
                            }
                        }
                    }
                }

                //The magic that makes hex code work. It gets rid of the 0x because it causes enumeration errors otherwise.
                List<string> keysToRemovePrefix = new List<string>();

                foreach (var pair in colorHexCodes)
                {
                    string hexCode = pair.Value;
                    if (hexCode.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                    {
                        keysToRemovePrefix.Add(pair.Key);
                    }
                }

                foreach (string key in keysToRemovePrefix)
                {
                    string hexCode = colorHexCodes[key];
                    hexCode = hexCode.Substring(2);
                    colorHexCodes[key] = hexCode;
                }
                //---------------------------------------------------------------------------------------------------------


                foreach (DataRow eventRow in dataTableEvents.Rows)
                {
                    string eventType = eventRow["type"].ToString();
                    DateTime eventDate = DateTime.Parse(eventRow["date"].ToString());
                    string techNickname = eventRow["tech_nickname"].ToString();
                    string colorName = eventRow["color"].ToString();
                    string studyNumber = eventRow["study_num"].ToString(); 
                    int duration = Convert.ToInt32(eventRow["duration"]);
                    int deleted = Convert.ToInt32(eventRow["duration"]);

                    string comments = eventRow["comments"].ToString();
                    string cellValueWithComments = $"{studyNumber}-{eventType}\n{comments}";

                    if (deleted != 0)
                    { 

                    string cellValue = $"{studyNumber}-{eventType}";

                    int eventColumn = techColumnMapping[techNickname];
                    int eventStartRowNum = timeslots.FindIndex(t => t.Hour == eventDate.Hour && t.Minute == eventDate.Minute) + 2;
                    int numberOfIntervals = duration / 15;

                    int eventEndRowNum = eventStartRowNum + numberOfIntervals - 1;
                    eventEndRowNum = Math.Min(eventEndRowNum, timeslots.Count + 1);

                        if (eventStartRowNum >= 2)
                        {
                            if (numberOfIntervals > 1)
                            {
                                var rangeToMerge = worksheet.Range(eventStartRowNum, eventColumn, eventEndRowNum, eventColumn);
                                rangeToMerge.Merge();
                                rangeToMerge.Style.Alignment.WrapText = true;
                                rangeToMerge.Value = cellValueWithComments;
                                rangeToMerge.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                                rangeToMerge.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                                rangeToMerge.Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                                rangeToMerge.Style.Border.BottomBorderColor = XLColor.Black;

                                rangeToMerge.Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                                rangeToMerge.Style.Border.LeftBorderColor = XLColor.Black;

                                rangeToMerge.Style.Border.TopBorder = XLBorderStyleValues.Thick;
                                rangeToMerge.Style.Border.TopBorderColor = XLColor.Black;

                                rangeToMerge.Style.Border.RightBorder = XLBorderStyleValues.Thick;
                                rangeToMerge.Style.Border.RightBorderColor = XLColor.Black;

                                if (colorHexCodes.ContainsKey(colorName))
                                {
                                    rangeToMerge.Style.Fill.BackgroundColor = XLColor.FromHtml(colorHexCodes[colorName]);
                                }
                            }
                            else
                            {
                                var cell = worksheet.Cell(eventStartRowNum, eventColumn);
                                cell.Value = cellValueWithComments;
                                cell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                                cell.Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                                cell.Style.Border.BottomBorderColor = XLColor.Black;

                                cell.Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                                cell.Style.Border.LeftBorderColor = XLColor.Black;

                                cell.Style.Border.TopBorder = XLBorderStyleValues.Thick;
                                cell.Style.Border.TopBorderColor = XLColor.Black;

                                cell.Style.Border.RightBorder = XLBorderStyleValues.Thick;
                                cell.Style.Border.RightBorderColor = XLColor.Black;

                                if (colorHexCodes.ContainsKey(colorName))
                                {
                                    cell.Style.Fill.BackgroundColor = XLColor.FromHtml(colorHexCodes[colorName]);
                                }
                            }
                        }
                    }
                }

                string sqlQueryStudyColors = "SELECT study_num, color FROM dbo.studies";

                Dictionary<string, string> studyColors = new Dictionary<string, string>();

                using (SqlConnection connStudyColors = DBUtilsForScheduler.MakeConnection())
                {
                    using (SqlCommand cmdStudyColors = new SqlCommand(sqlQueryStudyColors, connStudyColors))
                    {
                        cmdStudyColors.CommandType = CommandType.Text;
                        connStudyColors.Open();

                        using (SqlDataReader readerStudyColors = cmdStudyColors.ExecuteReader())
                        {
                            while (readerStudyColors.Read())
                            {
                                string studyNum = readerStudyColors["study_num"].ToString();
                                string colorName = readerStudyColors["color"].ToString();
                                studyColors[studyNum] = colorName;
                            }
                        }
                    }
                }

                worksheet.Cell(1, dataTableTechnicians.Rows.Count + 3).Value = "Study #";
                worksheet.Cell(1, dataTableTechnicians.Rows.Count + 4).Value = "Color";

                int legendRow = 2;

                HashSet<string> uniqueEvents = new HashSet<string>();

                foreach (DataRow eventRow in dataTableEvents.Rows)
                {
                    DateTime eventDate = DateTime.Parse(eventRow["date"].ToString());

                    if (eventDate.Date == dateTimePicker1.Value.Date)
                    {
                        string studyNum = eventRow["study_num"].ToString();
                        string colorName = eventRow["color"].ToString();

                        if (!uniqueEvents.Contains(studyNum))
                        {
                            for (int i = 0; i < dataTableTechnicians.Rows.Count; i++)
                            {
                                string techNickname = dataTableTechnicians.Rows[i]["tech_nickname"].ToString();
                                worksheet.Column(i + 2).Width = 25; // Adjust the width of technician columns
                            }
                                worksheet.Cell(legendRow, dataTableTechnicians.Rows.Count + 3).Value = studyNum;
                            worksheet.Cell(legendRow, dataTableTechnicians.Rows.Count + 4).Style.Fill.BackgroundColor = XLColor.FromHtml(colorHexCodes[colorName]);

                            uniqueEvents.Add(studyNum);

                            legendRow++;
                        }
                    }
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.Title = "Save Excel File";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        workbook.SaveAs(filePath);

                        MessageBox.Show("Export completed successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Export canceled.");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminForm fm = new AdminForm();
            fm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
