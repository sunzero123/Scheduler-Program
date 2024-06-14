namespace Scheduler_Prototype
{
    partial class TasksForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkBoxTimedEvent = new System.Windows.Forms.CheckBox();
            this.comboBoxStartTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxWeeklyFreq = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxDailyFreq = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.taskStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBoxOnce = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNavToEvents = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.labelCustomWeekly = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.backToMainBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.numOccur = new System.Windows.Forms.NumericUpDown();
            this.cbTaskType = new System.Windows.Forms.ComboBox();
            this.labelTech = new System.Windows.Forms.Label();
            this.cbTech = new System.Windows.Forms.ComboBox();
            this.cbStudyNumber = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnStudies = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cbFilterStudyNum = new System.Windows.Forms.ComboBox();
            this.labelFilterTech = new System.Windows.Forms.Label();
            this.labelFilterStudy = new System.Windows.Forms.Label();
            this.cbFilterTech = new System.Windows.Forms.ComboBox();
            this.labelFilterType = new System.Windows.Forms.Label();
            this.cbFilterTaskType = new System.Windows.Forms.ComboBox();
            this.btnDailyFreq = new System.Windows.Forms.Button();
            this.checkBoxCF = new System.Windows.Forms.CheckBox();
            this.tbTaskID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOccur)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(8, 192);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(724, 600);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(210, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(222, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 39);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkBoxTimedEvent
            // 
            this.checkBoxTimedEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxTimedEvent.AutoSize = true;
            this.checkBoxTimedEvent.Checked = true;
            this.checkBoxTimedEvent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTimedEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTimedEvent.ForeColor = System.Drawing.Color.Navy;
            this.checkBoxTimedEvent.Location = new System.Drawing.Point(57, 366);
            this.checkBoxTimedEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxTimedEvent.Name = "checkBoxTimedEvent";
            this.checkBoxTimedEvent.Size = new System.Drawing.Size(189, 24);
            this.checkBoxTimedEvent.TabIndex = 6;
            this.checkBoxTimedEvent.Text = "Specific Timed Event";
            this.checkBoxTimedEvent.UseVisualStyleBackColor = true;
            this.checkBoxTimedEvent.CheckedChanged += new System.EventHandler(this.checkBoxTimedEvent_CheckedChanged);
            // 
            // comboBoxStartTime
            // 
            this.comboBoxStartTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxStartTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxStartTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStartTime.FormattingEnabled = true;
            this.comboBoxStartTime.Items.AddRange(new object[] {
            "6:00 AM",
            "6:15 AM",
            "6:30 AM",
            "6:45 AM",
            "7:00 AM",
            "7:15 AM",
            "7:30 AM",
            "7:45 AM",
            "8:00 AM",
            "8:15 AM",
            "8:30 AM",
            "8:45 AM",
            "9:00 AM",
            "9:15 AM",
            "9:30 AM",
            "9:45 AM",
            "10:00 AM",
            "10:15 AM",
            "10:30 AM",
            "10:45 AM",
            "11:00 AM",
            "11:15 AM",
            "11:30 AM",
            "11:45 AM",
            "12:00 PM",
            "12:15 PM",
            "12:30 PM",
            "12:45 PM",
            "1:00 PM",
            "1:15 PM",
            "1:30 PM",
            "1:45 PM",
            "2:00 PM",
            "2:15 PM",
            "2:30 PM",
            "2:45 PM",
            "3:00 PM",
            "3:15 PM",
            "3:30 PM",
            "3:45 PM",
            "4:00 PM",
            "4:15 PM",
            "4:30 PM",
            "4:45 PM",
            "5:00 PM",
            "5:15 PM",
            "5:30 PM",
            "5:45 PM",
            "6:00 PM",
            "6:15 PM",
            "6:30 PM",
            "6:45 PM",
            "7:00 PM",
            "7:15 PM",
            "7:30 PM",
            "7:45 PM",
            "8:00 PM",
            "8:15 PM",
            "8:30 PM",
            "8:45 PM",
            "9:00 PM",
            "9:15 PM",
            "9:30 PM",
            "9:45 PM",
            "10:00 PM",
            "10:15 PM",
            "10:30 PM",
            "10:45 PM",
            "11:00 PM",
            "11:15 PM",
            "11:30 PM",
            "11:45 PM",
            "12:00 AM (Midnight)"});
            this.comboBoxStartTime.Location = new System.Drawing.Point(307, 400);
            this.comboBoxStartTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStartTime.Name = "comboBoxStartTime";
            this.comboBoxStartTime.Size = new System.Drawing.Size(156, 28);
            this.comboBoxStartTime.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(150, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Weekly Frequency:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(51, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number of Occurrences (Days):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startDatePicker.Enabled = false;
            this.startDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Location = new System.Drawing.Point(840, 128);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(260, 22);
            this.startDatePicker.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(1102, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "to";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.Enabled = false;
            this.endDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Location = new System.Drawing.Point(1127, 128);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(261, 22);
            this.endDatePicker.TabIndex = 16;
            // 
            // comboBoxWeeklyFreq
            // 
            this.comboBoxWeeklyFreq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxWeeklyFreq.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxWeeklyFreq.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxWeeklyFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWeeklyFreq.FormattingEnabled = true;
            this.comboBoxWeeklyFreq.Items.AddRange(new object[] {
            "None",
            "Once a week",
            "Every Day",
            "Weekdays",
            "Weekends",
            "Custom Days"});
            this.comboBoxWeeklyFreq.Location = new System.Drawing.Point(307, 220);
            this.comboBoxWeeklyFreq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxWeeklyFreq.Name = "comboBoxWeeklyFreq";
            this.comboBoxWeeklyFreq.Size = new System.Drawing.Size(180, 28);
            this.comboBoxWeeklyFreq.TabIndex = 17;
            this.comboBoxWeeklyFreq.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeeklyFreq_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(166, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Daily Frequency:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxDailyFreq
            // 
            this.comboBoxDailyFreq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxDailyFreq.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDailyFreq.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDailyFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDailyFreq.FormattingEnabled = true;
            this.comboBoxDailyFreq.Items.AddRange(new object[] {
            "Once a day",
            "Twice a day",
            "Three times a day",
            "Four times a day",
            "Five times a day"});
            this.comboBoxDailyFreq.Location = new System.Drawing.Point(307, 328);
            this.comboBoxDailyFreq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDailyFreq.Name = "comboBoxDailyFreq";
            this.comboBoxDailyFreq.Size = new System.Drawing.Size(180, 28);
            this.comboBoxDailyFreq.TabIndex = 19;
            this.comboBoxDailyFreq.SelectedIndexChanged += new System.EventHandler(this.comboBoxDailyFreq_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.BackColor = System.Drawing.Color.Navy;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(4, 5);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 39);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModify.BackColor = System.Drawing.Color.Navy;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(113, 5);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(100, 39);
            this.btnModify.TabIndex = 22;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUndo.BackColor = System.Drawing.Color.Navy;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.Location = new System.Drawing.Point(331, 5);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(100, 39);
            this.btnUndo.TabIndex = 23;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Navy;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(442, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 39);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(181, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Study Number:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(1040, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Study Date Range";
            // 
            // taskStartDatePicker
            // 
            this.taskStartDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.taskStartDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskStartDatePicker.Location = new System.Drawing.Point(307, 43);
            this.taskStartDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskStartDatePicker.Name = "taskStartDatePicker";
            this.taskStartDatePicker.Size = new System.Drawing.Size(279, 22);
            this.taskStartDatePicker.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(174, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Task Start Date";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxOnce
            // 
            this.checkBoxOnce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxOnce.AutoSize = true;
            this.checkBoxOnce.Checked = true;
            this.checkBoxOnce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOnce.ForeColor = System.Drawing.Color.Navy;
            this.checkBoxOnce.Location = new System.Drawing.Point(80, 186);
            this.checkBoxOnce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxOnce.Name = "checkBoxOnce";
            this.checkBoxOnce.Size = new System.Drawing.Size(144, 24);
            this.checkBoxOnce.TabIndex = 34;
            this.checkBoxOnce.Text = "One time event";
            this.checkBoxOnce.UseVisualStyleBackColor = true;
            this.checkBoxOnce.CheckedChanged += new System.EventHandler(this.checkBoxOnce_CheckedChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(223, 440);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Duration:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxDuration.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDuration.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDuration.FormattingEnabled = true;
            this.comboBoxDuration.Items.AddRange(new object[] {
            "    15 minutes",
            "    30 minutes",
            "    45 minutes",
            "    1 hour",
            "    1 hour 15 minutes",
            "    1 hour 30 minutes",
            "    1 hour 45 minutes",
            "    2 hours",
            "    2 hours 15 minutes",
            "    2 hours 30 minutes",
            "    2 hours 45 minutes",
            "    3 hours",
            "    3 hours 15 minutes",
            "    3 hours 30 minutes",
            "    3 hours 45 minutes",
            "    4 hours",
            "    4 hours 15 minutes",
            "    4 hours 30 minutes",
            "    4 hours 45 minutes",
            "    5 hours",
            "    5 hours 15 minutes",
            "    5 hours 30 minutes",
            "    5 hours 45 minutes",
            "    6 hours",
            "    6 hours 15 minutes",
            "    6 hours 30 minutes",
            "    6 hours 45 minutes",
            "    7 hours",
            "    7 hours 15 minutes",
            "    7 hours 30 minutes",
            "    7 hours 45 minutes",
            "    8 hours",
            "    8 hours 15 minutes",
            "    8 hours 30 minutes",
            "    8 hours 45 minutes",
            "    9 hours",
            "    9 hours 15 minutes",
            "    9 hours 30 minutes",
            "    9 hours 45 minutes",
            "    10 hours",
            "    10 hours 15 minutes",
            "    10 hours 30 minutes",
            "    10 hours 45 minutes",
            "    11 hours",
            "    11 hours 15 minutes",
            "    11 hours 30 minutes",
            "    11 hours 45 minutes",
            "    12 hours"});
            this.comboBoxDuration.Location = new System.Drawing.Point(307, 436);
            this.comboBoxDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(284, 28);
            this.comboBoxDuration.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(209, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Start Time:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNavToEvents
            // 
            this.btnNavToEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavToEvents.BackColor = System.Drawing.Color.Navy;
            this.btnNavToEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavToEvents.ForeColor = System.Drawing.Color.White;
            this.btnNavToEvents.Location = new System.Drawing.Point(962, 664);
            this.btnNavToEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNavToEvents.Name = "btnNavToEvents";
            this.btnNavToEvents.Size = new System.Drawing.Size(300, 39);
            this.btnNavToEvents.TabIndex = 40;
            this.btnNavToEvents.Text = "View events for task";
            this.btnNavToEvents.UseVisualStyleBackColor = false;
            this.btnNavToEvents.Click += new System.EventHandler(this.btnNavToEvents_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.Navy;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.checkedListBox1.Location = new System.Drawing.Point(1272, 368);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(175, 156);
            this.checkedListBox1.TabIndex = 42;
            this.checkedListBox1.Visible = false;
            // 
            // labelCustomWeekly
            // 
            this.labelCustomWeekly.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustomWeekly.AutoSize = true;
            this.labelCustomWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomWeekly.ForeColor = System.Drawing.Color.Navy;
            this.labelCustomWeekly.Location = new System.Drawing.Point(487, 189);
            this.labelCustomWeekly.Name = "labelCustomWeekly";
            this.labelCustomWeekly.Size = new System.Drawing.Size(246, 18);
            this.labelCustomWeekly.TabIndex = 43;
            this.labelCustomWeekly.Text = "Pick days you want to repeat weekly";
            this.labelCustomWeekly.Visible = false;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(946, -16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(333, 80);
            this.label16.TabIndex = 46;
            this.label16.Text = "Tasks Form";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backToMainBtn
            // 
            this.backToMainBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backToMainBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.backToMainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainBtn.ForeColor = System.Drawing.Color.Navy;
            this.backToMainBtn.Location = new System.Drawing.Point(28, 3);
            this.backToMainBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backToMainBtn.Name = "backToMainBtn";
            this.backToMainBtn.Size = new System.Drawing.Size(200, 39);
            this.backToMainBtn.TabIndex = 47;
            this.backToMainBtn.Text = "Main Form";
            this.backToMainBtn.UseVisualStyleBackColor = false;
            this.backToMainBtn.Click += new System.EventHandler(this.backToMainBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.30435F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.69565F));
            this.tableLayoutPanel1.Controls.Add(this.tbTaskID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.tbComments, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxDuration, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxStartTime, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxTimedEvent, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxDailyFreq, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.numOccur, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxWeeklyFreq, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelCustomWeekly, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxOnce, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbTaskType, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelTech, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbTech, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbStudyNumber, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.taskStartDatePicker, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(744, 153);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 511);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(229, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Task ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(206, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Comments:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbComments
            // 
            this.tbComments.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComments.Location = new System.Drawing.Point(307, 476);
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(285, 27);
            this.tbComments.TabIndex = 74;
            // 
            // numOccur
            // 
            this.numOccur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numOccur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOccur.Location = new System.Drawing.Point(307, 256);
            this.numOccur.Name = "numOccur";
            this.numOccur.Size = new System.Drawing.Size(85, 27);
            this.numOccur.TabIndex = 72;
            // 
            // cbTaskType
            // 
            this.cbTaskType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbTaskType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTaskType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTaskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTaskType.FormattingEnabled = true;
            this.cbTaskType.Location = new System.Drawing.Point(307, 148);
            this.cbTaskType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTaskType.Name = "cbTaskType";
            this.cbTaskType.Size = new System.Drawing.Size(276, 28);
            this.cbTaskType.TabIndex = 45;
            // 
            // labelTech
            // 
            this.labelTech.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTech.AutoSize = true;
            this.labelTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTech.ForeColor = System.Drawing.Color.Navy;
            this.labelTech.Location = new System.Drawing.Point(206, 116);
            this.labelTech.Name = "labelTech";
            this.labelTech.Size = new System.Drawing.Size(95, 20);
            this.labelTech.TabIndex = 46;
            this.labelTech.Text = "Technician:";
            this.labelTech.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbTech
            // 
            this.cbTech.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbTech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTech.FormattingEnabled = true;
            this.cbTech.Location = new System.Drawing.Point(307, 112);
            this.cbTech.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTech.Name = "cbTech";
            this.cbTech.Size = new System.Drawing.Size(276, 28);
            this.cbTech.TabIndex = 71;
            // 
            // cbStudyNumber
            // 
            this.cbStudyNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbStudyNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStudyNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStudyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStudyNumber.FormattingEnabled = true;
            this.cbStudyNumber.Location = new System.Drawing.Point(307, 76);
            this.cbStudyNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStudyNumber.Name = "cbStudyNumber";
            this.cbStudyNumber.Size = new System.Drawing.Size(156, 28);
            this.cbStudyNumber.TabIndex = 44;
            this.cbStudyNumber.SelectedIndexChanged += new System.EventHandler(this.cbStudyNumber_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnModify, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUndo, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(838, 57);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(549, 50);
            this.tableLayoutPanel2.TabIndex = 49;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnTasks, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnEvents, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.backToMainBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnStudies, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(856, 704);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(512, 92);
            this.tableLayoutPanel3.TabIndex = 50;
            // 
            // btnTasks
            // 
            this.btnTasks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTasks.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.ForeColor = System.Drawing.Color.Navy;
            this.btnTasks.Location = new System.Drawing.Point(284, 49);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(200, 39);
            this.btnTasks.TabIndex = 36;
            this.btnTasks.Text = "Technicians Form";
            this.btnTasks.UseVisualStyleBackColor = false;
            this.btnTasks.Click += new System.EventHandler(this.btnTechs_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEvents.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.Navy;
            this.btnEvents.Location = new System.Drawing.Point(28, 49);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(200, 39);
            this.btnEvents.TabIndex = 37;
            this.btnEvents.Text = "Events Form";
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnStudies
            // 
            this.btnStudies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStudies.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnStudies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudies.ForeColor = System.Drawing.Color.Navy;
            this.btnStudies.Location = new System.Drawing.Point(284, 3);
            this.btnStudies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudies.Name = "btnStudies";
            this.btnStudies.Size = new System.Drawing.Size(200, 39);
            this.btnStudies.TabIndex = 38;
            this.btnStudies.Text = "Studies Form";
            this.btnStudies.UseVisualStyleBackColor = false;
            this.btnStudies.Click += new System.EventHandler(this.btnStudies_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel4.Controls.Add(this.cbFilterStudyNum, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelFilterTech, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelFilterStudy, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbFilterTech, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelFilterType, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.cbFilterTaskType, 1, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 7);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(724, 140);
            this.tableLayoutPanel4.TabIndex = 52;
            // 
            // cbFilterStudyNum
            // 
            this.cbFilterStudyNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterStudyNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFilterStudyNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFilterStudyNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterStudyNum.FormattingEnabled = true;
            this.cbFilterStudyNum.Location = new System.Drawing.Point(328, 9);
            this.cbFilterStudyNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilterStudyNum.Name = "cbFilterStudyNum";
            this.cbFilterStudyNum.Size = new System.Drawing.Size(393, 28);
            this.cbFilterStudyNum.TabIndex = 53;
            this.cbFilterStudyNum.SelectedIndexChanged += new System.EventHandler(this.cbFilterStudyNum_SelectedIndexChanged);
            // 
            // labelFilterTech
            // 
            this.labelFilterTech.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFilterTech.AutoSize = true;
            this.labelFilterTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterTech.ForeColor = System.Drawing.Color.Navy;
            this.labelFilterTech.Location = new System.Drawing.Point(162, 59);
            this.labelFilterTech.Name = "labelFilterTech";
            this.labelFilterTech.Size = new System.Drawing.Size(160, 20);
            this.labelFilterTech.TabIndex = 38;
            this.labelFilterTech.Text = "Filter by Technician:";
            // 
            // labelFilterStudy
            // 
            this.labelFilterStudy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFilterStudy.AutoSize = true;
            this.labelFilterStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterStudy.ForeColor = System.Drawing.Color.Navy;
            this.labelFilterStudy.Location = new System.Drawing.Point(137, 13);
            this.labelFilterStudy.Name = "labelFilterStudy";
            this.labelFilterStudy.Size = new System.Drawing.Size(185, 20);
            this.labelFilterStudy.TabIndex = 36;
            this.labelFilterStudy.Text = "Filter by Study Number:";
            // 
            // cbFilterTech
            // 
            this.cbFilterTech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterTech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFilterTech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFilterTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterTech.FormattingEnabled = true;
            this.cbFilterTech.Location = new System.Drawing.Point(328, 55);
            this.cbFilterTech.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilterTech.Name = "cbFilterTech";
            this.cbFilterTech.Size = new System.Drawing.Size(393, 28);
            this.cbFilterTech.TabIndex = 4;
            this.cbFilterTech.SelectedIndexChanged += new System.EventHandler(this.cbFilterTech_SelectedIndexChanged);
            // 
            // labelFilterType
            // 
            this.labelFilterType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFilterType.AutoSize = true;
            this.labelFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterType.ForeColor = System.Drawing.Color.Navy;
            this.labelFilterType.Location = new System.Drawing.Point(166, 106);
            this.labelFilterType.Name = "labelFilterType";
            this.labelFilterType.Size = new System.Drawing.Size(156, 20);
            this.labelFilterType.TabIndex = 37;
            this.labelFilterType.Text = "Filter by Task Type:";
            // 
            // cbFilterTaskType
            // 
            this.cbFilterTaskType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterTaskType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFilterTaskType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFilterTaskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterTaskType.FormattingEnabled = true;
            this.cbFilterTaskType.Location = new System.Drawing.Point(328, 102);
            this.cbFilterTaskType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilterTaskType.Name = "cbFilterTaskType";
            this.cbFilterTaskType.Size = new System.Drawing.Size(393, 28);
            this.cbFilterTaskType.TabIndex = 3;
            this.cbFilterTaskType.SelectedIndexChanged += new System.EventHandler(this.cbFilterTaskType_SelectedIndexChanged);
            // 
            // btnDailyFreq
            // 
            this.btnDailyFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDailyFreq.ForeColor = System.Drawing.Color.Navy;
            this.btnDailyFreq.Location = new System.Drawing.Point(1216, 544);
            this.btnDailyFreq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDailyFreq.Name = "btnDailyFreq";
            this.btnDailyFreq.Size = new System.Drawing.Size(136, 34);
            this.btnDailyFreq.TabIndex = 53;
            this.btnDailyFreq.Text = "Add Daily Events";
            this.btnDailyFreq.UseVisualStyleBackColor = true;
            this.btnDailyFreq.Click += new System.EventHandler(this.btnDailyFreq_Click);
            // 
            // checkBoxCF
            // 
            this.checkBoxCF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCF.AutoSize = true;
            this.checkBoxCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCF.ForeColor = System.Drawing.Color.Navy;
            this.checkBoxCF.Location = new System.Drawing.Point(255, 160);
            this.checkBoxCF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxCF.Name = "checkBoxCF";
            this.checkBoxCF.Size = new System.Drawing.Size(230, 22);
            this.checkBoxCF.TabIndex = 70;
            this.checkBoxCF.Text = "Show only current/future tasks";
            this.checkBoxCF.UseVisualStyleBackColor = true;
            this.checkBoxCF.CheckedChanged += new System.EventHandler(this.checkBoxCF_CheckedChanged);
            // 
            // tbTaskID
            // 
            this.tbTaskID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbTaskID.Enabled = false;
            this.tbTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaskID.Location = new System.Drawing.Point(307, 4);
            this.tbTaskID.Name = "tbTaskID";
            this.tbTaskID.Size = new System.Drawing.Size(101, 27);
            this.tbTaskID.TabIndex = 75;
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 803);
            this.Controls.Add(this.checkBoxCF);
            this.Controls.Add(this.btnDailyFreq);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnNavToEvents);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label16);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1497, 850);
            this.Name = "TasksForm";
            this.Text = "Tasks Form";
            this.Load += new System.EventHandler(this.TasksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOccur)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkBoxTimedEvent;
        private System.Windows.Forms.ComboBox comboBoxStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.ComboBox comboBoxWeeklyFreq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxDailyFreq;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker taskStartDatePicker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBoxOnce;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNavToEvents;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label labelCustomWeekly;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button backToMainBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnStudies;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelFilterTech;
        private System.Windows.Forms.Label labelFilterType;
        private System.Windows.Forms.ComboBox cbFilterTaskType;
        private System.Windows.Forms.ComboBox cbFilterTech;
        private System.Windows.Forms.Label labelFilterStudy;
        private System.Windows.Forms.ComboBox cbFilterStudyNum;
        private System.Windows.Forms.ComboBox cbStudyNumber;
        private System.Windows.Forms.Button btnDailyFreq;
        private System.Windows.Forms.ComboBox cbTaskType;
        private System.Windows.Forms.Label labelTech;
        private System.Windows.Forms.CheckBox checkBoxCF;
        private System.Windows.Forms.ComboBox cbTech;
        private System.Windows.Forms.NumericUpDown numOccur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTaskID;
    }
}