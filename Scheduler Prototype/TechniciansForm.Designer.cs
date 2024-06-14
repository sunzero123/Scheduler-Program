namespace Scheduler_Prototype
{
    partial class TechniciansForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechniciansForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbTechID = new System.Windows.Forms.Label();
            this.lbFname = new System.Windows.Forms.Label();
            this.lbLname = new System.Windows.Forms.Label();
            this.lbNickname = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbTechID = new System.Windows.Forms.MaskedTextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbInitials = new System.Windows.Forms.TextBox();
            this.lbInitials = new System.Windows.Forms.Label();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.backToMainBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnStudies = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSearchTech = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(16, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(528, 569);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
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
            this.btnNew.TabIndex = 2;
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
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
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
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnUndo.TabIndex = 5;
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
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbTechID
            // 
            this.lbTechID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTechID.AutoSize = true;
            this.lbTechID.ForeColor = System.Drawing.Color.Navy;
            this.lbTechID.Location = new System.Drawing.Point(109, 14);
            this.lbTechID.Name = "lbTechID";
            this.lbTechID.Size = new System.Drawing.Size(117, 20);
            this.lbTechID.TabIndex = 7;
            this.lbTechID.Text = "Technician ID:";
            // 
            // lbFname
            // 
            this.lbFname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbFname.AutoSize = true;
            this.lbFname.ForeColor = System.Drawing.Color.Navy;
            this.lbFname.Location = new System.Drawing.Point(129, 62);
            this.lbFname.Name = "lbFname";
            this.lbFname.Size = new System.Drawing.Size(97, 20);
            this.lbFname.TabIndex = 8;
            this.lbFname.Text = "First Name:";
            // 
            // lbLname
            // 
            this.lbLname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbLname.AutoSize = true;
            this.lbLname.ForeColor = System.Drawing.Color.Navy;
            this.lbLname.Location = new System.Drawing.Point(130, 110);
            this.lbLname.Name = "lbLname";
            this.lbLname.Size = new System.Drawing.Size(96, 20);
            this.lbLname.TabIndex = 9;
            this.lbLname.Text = "Last Name:";
            // 
            // lbNickname
            // 
            this.lbNickname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNickname.AutoSize = true;
            this.lbNickname.ForeColor = System.Drawing.Color.Navy;
            this.lbNickname.Location = new System.Drawing.Point(138, 158);
            this.lbNickname.Name = "lbNickname";
            this.lbNickname.Size = new System.Drawing.Size(88, 20);
            this.lbNickname.TabIndex = 10;
            this.lbNickname.Text = "Nickname:";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbEmail.AutoSize = true;
            this.lbEmail.ForeColor = System.Drawing.Color.Navy;
            this.lbEmail.Location = new System.Drawing.Point(170, 254);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 20);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.09559F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.90441F));
            this.tableLayoutPanel1.Controls.Add(this.tbTechID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbLname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbInitials, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbInitials, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbFname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbFname, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbLname, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbEmail, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbEmail, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbNickname, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbNickname, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbTechID, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(595, 199);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 288);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tbTechID
            // 
            this.tbTechID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbTechID.Enabled = false;
            this.tbTechID.Location = new System.Drawing.Point(232, 10);
            this.tbTechID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTechID.Mask = "00000";
            this.tbTechID.Name = "tbTechID";
            this.tbTechID.Size = new System.Drawing.Size(100, 27);
            this.tbTechID.TabIndex = 13;
            this.tbTechID.ValidatingType = typeof(int);
            // 
            // tbLname
            // 
            this.tbLname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbLname.Location = new System.Drawing.Point(232, 106);
            this.tbLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(279, 27);
            this.tbLname.TabIndex = 15;
            // 
            // tbInitials
            // 
            this.tbInitials.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbInitials.Location = new System.Drawing.Point(232, 202);
            this.tbInitials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInitials.Name = "tbInitials";
            this.tbInitials.Size = new System.Drawing.Size(100, 27);
            this.tbInitials.TabIndex = 17;
            // 
            // lbInitials
            // 
            this.lbInitials.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbInitials.AutoSize = true;
            this.lbInitials.ForeColor = System.Drawing.Color.Navy;
            this.lbInitials.Location = new System.Drawing.Point(164, 206);
            this.lbInitials.Name = "lbInitials";
            this.lbInitials.Size = new System.Drawing.Size(62, 20);
            this.lbInitials.TabIndex = 13;
            this.lbInitials.Text = "Initials:";
            // 
            // tbFname
            // 
            this.tbFname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbFname.Location = new System.Drawing.Point(232, 58);
            this.tbFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(279, 27);
            this.tbFname.TabIndex = 14;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbEmail.Location = new System.Drawing.Point(232, 250);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(279, 27);
            this.tbEmail.TabIndex = 18;
            // 
            // tbNickname
            // 
            this.tbNickname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbNickname.Location = new System.Drawing.Point(232, 154);
            this.tbNickname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(279, 27);
            this.tbNickname.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(651, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(432, 80);
            this.label11.TabIndex = 37;
            this.label11.Text = "Technicians Form";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.Navy;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(457, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 34);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(220, 15);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(223, 27);
            this.tbSearch.TabIndex = 38;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // backToMainBtn
            // 
            this.backToMainBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backToMainBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.backToMainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainBtn.ForeColor = System.Drawing.Color.Navy;
            this.backToMainBtn.Location = new System.Drawing.Point(28, 5);
            this.backToMainBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backToMainBtn.Name = "backToMainBtn";
            this.backToMainBtn.Size = new System.Drawing.Size(200, 39);
            this.backToMainBtn.TabIndex = 40;
            this.backToMainBtn.Text = "Main Form";
            this.backToMainBtn.UseVisualStyleBackColor = false;
            this.backToMainBtn.Click += new System.EventHandler(this.backToMainBtn_Click);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(592, 128);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(549, 50);
            this.tableLayoutPanel2.TabIndex = 41;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnEvents, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.backToMainBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnTasks, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnStudies, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(608, 512);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(512, 100);
            this.tableLayoutPanel3.TabIndex = 42;
            // 
            // btnEvents
            // 
            this.btnEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEvents.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.Navy;
            this.btnEvents.Location = new System.Drawing.Point(284, 55);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(200, 39);
            this.btnEvents.TabIndex = 37;
            this.btnEvents.Text = "Events Form";
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTasks.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.ForeColor = System.Drawing.Color.Navy;
            this.btnTasks.Location = new System.Drawing.Point(28, 55);
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
            this.btnStudies.Location = new System.Drawing.Point(284, 5);
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
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.65471F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.34529F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelSearchTech, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbSearch, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(16, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(528, 57);
            this.tableLayoutPanel4.TabIndex = 43;
            // 
            // labelSearchTech
            // 
            this.labelSearchTech.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSearchTech.AutoSize = true;
            this.labelSearchTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchTech.ForeColor = System.Drawing.Color.Navy;
            this.labelSearchTech.Location = new System.Drawing.Point(39, 18);
            this.labelSearchTech.Name = "labelSearchTech";
            this.labelSearchTech.Size = new System.Drawing.Size(175, 20);
            this.labelSearchTech.TabIndex = 39;
            this.labelSearchTech.Text = "Search by Technician:";
            // 
            // TechniciansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1199, 698);
            this.Name = "TechniciansForm";
            this.Text = "Technicians Form";
            this.Load += new System.EventHandler(this.TechniciansForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbTechID;
        private System.Windows.Forms.Label lbFname;
        private System.Windows.Forms.Label lbLname;
        private System.Windows.Forms.Label lbNickname;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.MaskedTextBox tbTechID;
        private System.Windows.Forms.TextBox tbInitials;
        private System.Windows.Forms.Label lbInitials;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button backToMainBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnStudies;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelSearchTech;
    }
}