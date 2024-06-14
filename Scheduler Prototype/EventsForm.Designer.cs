namespace Scheduler_Prototype
{
    partial class EventsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEventCountSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEventID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTaskID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStudyID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.cbAddHelp = new System.Windows.Forms.CheckBox();
            this.comboBoxExtraTechs = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStartTime = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEvents = new System.Windows.Forms.DateTimePicker();
            this.cbTaskType = new System.Windows.Forms.ComboBox();
            this.labelPrimaryTech = new System.Windows.Forms.Label();
            this.cbPrimaryTech = new System.Windows.Forms.ComboBox();
            this.cbStudyNum = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.backToMainBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnStudies = new System.Windows.Forms.Button();
            this.btnTechs = new System.Windows.Forms.Button();
            this.btnAddTechs = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cbFilterStudyNum = new System.Windows.Forms.ComboBox();
            this.labelFilterTech = new System.Windows.Forms.Label();
            this.labelFilterStudy = new System.Windows.Forms.Label();
            this.cbFilterTech = new System.Windows.Forms.ComboBox();
            this.labelFilterType = new System.Windows.Forms.Label();
            this.cbFilterTaskType = new System.Windows.Forms.ComboBox();
            this.checkBoxToday = new System.Windows.Forms.CheckBox();
            this.checkBoxCF = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(16, 192);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(824, 608);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
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
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnNew.TabIndex = 23;
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
            this.btnModify.TabIndex = 25;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
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
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnUndo.TabIndex = 27;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(146, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Event Date:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(39, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Task Event Count Search:";
            // 
            // btnEventCountSearch
            // 
            this.btnEventCountSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEventCountSearch.ForeColor = System.Drawing.Color.Navy;
            this.btnEventCountSearch.Location = new System.Drawing.Point(1209, 260);
            this.btnEventCountSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEventCountSearch.Name = "btnEventCountSearch";
            this.btnEventCountSearch.Size = new System.Drawing.Size(75, 34);
            this.btnEventCountSearch.TabIndex = 33;
            this.btnEventCountSearch.Text = "Search";
            this.btnEventCountSearch.UseVisualStyleBackColor = true;
            this.btnEventCountSearch.Click += new System.EventHandler(this.btnEventCountSearch_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(165, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Event ID:";
            // 
            // tbEventID
            // 
            this.tbEventID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventID.Location = new System.Drawing.Point(249, 57);
            this.tbEventID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEventID.Name = "tbEventID";
            this.tbEventID.Size = new System.Drawing.Size(100, 27);
            this.tbEventID.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(171, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Task ID:";
            // 
            // tbTaskID
            // 
            this.tbTaskID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbTaskID.Enabled = false;
            this.tbTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaskID.Location = new System.Drawing.Point(249, 10);
            this.tbTaskID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTaskID.Name = "tbTaskID";
            this.tbTaskID.Size = new System.Drawing.Size(100, 27);
            this.tbTaskID.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(497, 624);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Study ID:";
            this.label6.Visible = false;
            // 
            // tbStudyID
            // 
            this.tbStudyID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStudyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStudyID.Location = new System.Drawing.Point(372, 622);
            this.tbStudyID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStudyID.Name = "tbStudyID";
            this.tbStudyID.Size = new System.Drawing.Size(100, 27);
            this.tbStudyID.TabIndex = 39;
            this.tbStudyID.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(123, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Study Number:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(152, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Task Type:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnModify, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUndo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(870, 96);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 50);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(978, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(333, 80);
            this.label16.TabIndex = 49;
            this.label16.Text = "Events Form";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.48398F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.51602F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbEventID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbComments, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.tbTaskID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbAddHelp, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxExtraTechs, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxDuration, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxStartTime, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerEvents, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.cbTaskType, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelPrimaryTech, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbPrimaryTech, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbStudyNum, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown1, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(848, 160);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(593, 528);
            this.tableLayoutPanel2.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(148, 489);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 71;
            this.label11.Text = "Comments:";
            // 
            // tbComments
            // 
            this.tbComments.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComments.Location = new System.Drawing.Point(249, 485);
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(285, 27);
            this.tbComments.TabIndex = 72;
            // 
            // cbAddHelp
            // 
            this.cbAddHelp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbAddHelp.AutoSize = true;
            this.cbAddHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddHelp.ForeColor = System.Drawing.Color.Navy;
            this.cbAddHelp.Location = new System.Drawing.Point(103, 434);
            this.cbAddHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAddHelp.Name = "cbAddHelp";
            this.cbAddHelp.Size = new System.Drawing.Size(140, 24);
            this.cbAddHelp.TabIndex = 70;
            this.cbAddHelp.Text = "Additional help";
            this.cbAddHelp.UseVisualStyleBackColor = true;
            this.cbAddHelp.CheckedChanged += new System.EventHandler(this.cbAddHelp_CheckedChanged);
            // 
            // comboBoxExtraTechs
            // 
            this.comboBoxExtraTechs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxExtraTechs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxExtraTechs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxExtraTechs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExtraTechs.FormattingEnabled = true;
            this.comboBoxExtraTechs.Location = new System.Drawing.Point(249, 432);
            this.comboBoxExtraTechs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxExtraTechs.Name = "comboBoxExtraTechs";
            this.comboBoxExtraTechs.Size = new System.Drawing.Size(155, 28);
            this.comboBoxExtraTechs.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(165, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Duration:";
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
            this.comboBoxDuration.Location = new System.Drawing.Point(249, 385);
            this.comboBoxDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(327, 28);
            this.comboBoxDuration.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(151, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Start Time:";
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
            this.comboBoxStartTime.Location = new System.Drawing.Point(249, 338);
            this.comboBoxStartTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStartTime.Name = "comboBoxStartTime";
            this.comboBoxStartTime.Size = new System.Drawing.Size(155, 28);
            this.comboBoxStartTime.TabIndex = 53;
            // 
            // dateTimePickerEvents
            // 
            this.dateTimePickerEvents.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEvents.Location = new System.Drawing.Point(249, 292);
            this.dateTimePickerEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEvents.Name = "dateTimePickerEvents";
            this.dateTimePickerEvents.Size = new System.Drawing.Size(331, 27);
            this.dateTimePickerEvents.TabIndex = 52;
            // 
            // cbTaskType
            // 
            this.cbTaskType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbTaskType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTaskType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTaskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTaskType.FormattingEnabled = true;
            this.cbTaskType.Location = new System.Drawing.Point(249, 244);
            this.cbTaskType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTaskType.Name = "cbTaskType";
            this.cbTaskType.Size = new System.Drawing.Size(331, 28);
            this.cbTaskType.TabIndex = 63;
            // 
            // labelPrimaryTech
            // 
            this.labelPrimaryTech.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrimaryTech.AutoSize = true;
            this.labelPrimaryTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrimaryTech.ForeColor = System.Drawing.Color.Navy;
            this.labelPrimaryTech.Location = new System.Drawing.Point(85, 201);
            this.labelPrimaryTech.Name = "labelPrimaryTech";
            this.labelPrimaryTech.Size = new System.Drawing.Size(158, 20);
            this.labelPrimaryTech.TabIndex = 69;
            this.labelPrimaryTech.Text = "Primary Technician:";
            // 
            // cbPrimaryTech
            // 
            this.cbPrimaryTech.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPrimaryTech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPrimaryTech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPrimaryTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrimaryTech.FormattingEnabled = true;
            this.cbPrimaryTech.Location = new System.Drawing.Point(249, 197);
            this.cbPrimaryTech.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPrimaryTech.Name = "cbPrimaryTech";
            this.cbPrimaryTech.Size = new System.Drawing.Size(247, 28);
            this.cbPrimaryTech.TabIndex = 70;
            // 
            // cbStudyNum
            // 
            this.cbStudyNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbStudyNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStudyNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStudyNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStudyNum.FormattingEnabled = true;
            this.cbStudyNum.Location = new System.Drawing.Point(249, 150);
            this.cbStudyNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStudyNum.Name = "cbStudyNum";
            this.cbStudyNum.Size = new System.Drawing.Size(123, 28);
            this.cbStudyNum.TabIndex = 69;
            this.cbStudyNum.SelectedIndexChanged += new System.EventHandler(this.cbStudyNum_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(249, 104);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 60;
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
            this.backToMainBtn.TabIndex = 51;
            this.backToMainBtn.Text = "Main Form";
            this.backToMainBtn.UseVisualStyleBackColor = false;
            this.backToMainBtn.Click += new System.EventHandler(this.backToMainBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnTasks, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnStudies, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnTechs, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.backToMainBtn, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(888, 697);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(512, 92);
            this.tableLayoutPanel3.TabIndex = 57;
            // 
            // btnTasks
            // 
            this.btnTasks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTasks.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.ForeColor = System.Drawing.Color.Navy;
            this.btnTasks.Location = new System.Drawing.Point(28, 49);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(200, 39);
            this.btnTasks.TabIndex = 36;
            this.btnTasks.Text = "Tasks Form";
            this.btnTasks.UseVisualStyleBackColor = false;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
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
            // btnTechs
            // 
            this.btnTechs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTechs.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTechs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechs.ForeColor = System.Drawing.Color.Navy;
            this.btnTechs.Location = new System.Drawing.Point(284, 49);
            this.btnTechs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTechs.Name = "btnTechs";
            this.btnTechs.Size = new System.Drawing.Size(200, 39);
            this.btnTechs.TabIndex = 37;
            this.btnTechs.Text = "Technicians Form";
            this.btnTechs.UseVisualStyleBackColor = false;
            this.btnTechs.Click += new System.EventHandler(this.btnTechs_Click);
            // 
            // btnAddTechs
            // 
            this.btnAddTechs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTechs.ForeColor = System.Drawing.Color.Navy;
            this.btnAddTechs.Location = new System.Drawing.Point(1243, 586);
            this.btnAddTechs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTechs.Name = "btnAddTechs";
            this.btnAddTechs.Size = new System.Drawing.Size(75, 34);
            this.btnAddTechs.TabIndex = 64;
            this.btnAddTechs.Text = "Add";
            this.btnAddTechs.UseVisualStyleBackColor = true;
            this.btnAddTechs.Click += new System.EventHandler(this.btnAddTechs_Click);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(15, 7);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(802, 135);
            this.tableLayoutPanel4.TabIndex = 66;
            // 
            // cbFilterStudyNum
            // 
            this.cbFilterStudyNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterStudyNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFilterStudyNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFilterStudyNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterStudyNum.FormattingEnabled = true;
            this.cbFilterStudyNum.Location = new System.Drawing.Point(363, 8);
            this.cbFilterStudyNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilterStudyNum.Name = "cbFilterStudyNum";
            this.cbFilterStudyNum.Size = new System.Drawing.Size(436, 28);
            this.cbFilterStudyNum.TabIndex = 53;
            this.cbFilterStudyNum.SelectedIndexChanged += new System.EventHandler(this.cbFilterStudyNum_SelectedIndexChanged);
            // 
            // labelFilterTech
            // 
            this.labelFilterTech.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFilterTech.AutoSize = true;
            this.labelFilterTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterTech.ForeColor = System.Drawing.Color.Navy;
            this.labelFilterTech.Location = new System.Drawing.Point(197, 57);
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
            this.labelFilterStudy.Location = new System.Drawing.Point(172, 12);
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
            this.cbFilterTech.Location = new System.Drawing.Point(363, 53);
            this.cbFilterTech.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilterTech.Name = "cbFilterTech";
            this.cbFilterTech.Size = new System.Drawing.Size(436, 28);
            this.cbFilterTech.TabIndex = 4;
            this.cbFilterTech.SelectedIndexChanged += new System.EventHandler(this.cbFilterTech_SelectedIndexChanged);
            // 
            // labelFilterType
            // 
            this.labelFilterType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFilterType.AutoSize = true;
            this.labelFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterType.ForeColor = System.Drawing.Color.Navy;
            this.labelFilterType.Location = new System.Drawing.Point(201, 102);
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
            this.cbFilterTaskType.Location = new System.Drawing.Point(363, 98);
            this.cbFilterTaskType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilterTaskType.Name = "cbFilterTaskType";
            this.cbFilterTaskType.Size = new System.Drawing.Size(436, 28);
            this.cbFilterTaskType.TabIndex = 3;
            this.cbFilterTaskType.SelectedIndexChanged += new System.EventHandler(this.cbFilterTaskType_SelectedIndexChanged);
            // 
            // checkBoxToday
            // 
            this.checkBoxToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxToday.AutoSize = true;
            this.checkBoxToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxToday.ForeColor = System.Drawing.Color.Navy;
            this.checkBoxToday.Location = new System.Drawing.Point(502, 5);
            this.checkBoxToday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxToday.Name = "checkBoxToday";
            this.checkBoxToday.Size = new System.Drawing.Size(197, 22);
            this.checkBoxToday.TabIndex = 67;
            this.checkBoxToday.Text = "Show only today\'s events";
            this.checkBoxToday.UseVisualStyleBackColor = true;
            this.checkBoxToday.CheckedChanged += new System.EventHandler(this.checkBoxToday_CheckedChanged);
            // 
            // checkBoxCF
            // 
            this.checkBoxCF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxCF.AutoSize = true;
            this.checkBoxCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCF.ForeColor = System.Drawing.Color.Navy;
            this.checkBoxCF.Location = new System.Drawing.Point(81, 5);
            this.checkBoxCF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxCF.Name = "checkBoxCF";
            this.checkBoxCF.Size = new System.Drawing.Size(237, 22);
            this.checkBoxCF.TabIndex = 69;
            this.checkBoxCF.Text = "Show only current/future events";
            this.checkBoxCF.UseVisualStyleBackColor = true;
            this.checkBoxCF.CheckedChanged += new System.EventHandler(this.checkBoxCF_CheckedChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.checkBoxCF, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.checkBoxToday, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(16, 153);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(801, 32);
            this.tableLayoutPanel5.TabIndex = 70;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 811);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.btnAddTechs);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbStudyID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.btnEventCountSearch);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1409, 858);
            this.Name = "EventsForm";
            this.Text = "Events Form";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEventCountSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEventID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTaskID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbStudyID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button backToMainBtn;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvents;
        private System.Windows.Forms.ComboBox comboBoxStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnStudies;
        private System.Windows.Forms.Button btnTechs;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.ComboBox comboBoxDuration;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAddTechs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox cbFilterStudyNum;
        private System.Windows.Forms.Label labelFilterTech;
        private System.Windows.Forms.Label labelFilterStudy;
        private System.Windows.Forms.ComboBox cbFilterTech;
        private System.Windows.Forms.Label labelFilterType;
        private System.Windows.Forms.ComboBox cbFilterTaskType;
        private System.Windows.Forms.CheckBox checkBoxToday;
        private System.Windows.Forms.ComboBox cbStudyNum;
        private System.Windows.Forms.ComboBox cbTaskType;
        private System.Windows.Forms.ComboBox cbPrimaryTech;
        private System.Windows.Forms.Label labelPrimaryTech;
        private System.Windows.Forms.CheckBox checkBoxCF;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox comboBoxExtraTechs;
        private System.Windows.Forms.CheckBox cbAddHelp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbComments;
    }
}