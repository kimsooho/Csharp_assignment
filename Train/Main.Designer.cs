namespace Train
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Oracle.DataAccess.Client.OracleParameter oracleParameter8 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter9 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter10 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter1 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter2 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter3 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter11 = new Oracle.DataAccess.Client.OracleParameter();
            this.label_ID = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tRAINIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.START_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISPATCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new Train.DataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDispatchCheck = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_bu = new System.Windows.Forms.RadioButton();
            this.rb_seo = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_end = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_hour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_start = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.TicketView = new System.Windows.Forms.DataGridView();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAINIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOOMNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTARTTIMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tICKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.cmdSeatHelper = new Oracle.DataAccess.Client.OracleCommand();
            this.cmdSeatCancel = new Oracle.DataAccess.Client.OracleCommand();
            this.dISPATCHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stationTableAdapter1 = new Train.DataSet1TableAdapters.STATIONTableAdapter();
            this.sectionTableAdapter1 = new Train.DataSet1TableAdapters.SECTIONTableAdapter();
            this.dISPATCHTableAdapter = new Train.DataSet1TableAdapters.DISPATCHTableAdapter();
            this.seaT_STATUSTableAdapter1 = new Train.DataSet1TableAdapters.SEAT_STATUSTableAdapter();
            this.SeatHelper = new Train.DataSet1TableAdapters.DISPATCHTableAdapter();
            this.tICKETTableAdapter2 = new Train.DataSet1TableAdapters.TICKETTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISPATCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISPATCHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("경기천년제목V Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_ID.Location = new System.Drawing.Point(12, 9);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(74, 21);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 463);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(899, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "승차권 예매";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tRAINIDDataGridViewTextBoxColumn,
            this.sTNAMEDataGridViewTextBoxColumn,
            this.ST_NAME,
            this.sTARTTIMEDataGridViewTextBoxColumn,
            this.START_TIME,
            this.DIRECTION});
            this.dataGridView2.DataSource = this.dISPATCHBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.Location = new System.Drawing.Point(8, 137);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(885, 294);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectSeat);
            // 
            // tRAINIDDataGridViewTextBoxColumn
            // 
            this.tRAINIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tRAINIDDataGridViewTextBoxColumn.DataPropertyName = "TRAIN_ID";
            this.tRAINIDDataGridViewTextBoxColumn.HeaderText = "기차 번호";
            this.tRAINIDDataGridViewTextBoxColumn.Name = "tRAINIDDataGridViewTextBoxColumn";
            this.tRAINIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTNAMEDataGridViewTextBoxColumn
            // 
            this.sTNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTNAMEDataGridViewTextBoxColumn.DataPropertyName = "ST_NAME";
            this.sTNAMEDataGridViewTextBoxColumn.HeaderText = "출발 역";
            this.sTNAMEDataGridViewTextBoxColumn.Name = "sTNAMEDataGridViewTextBoxColumn";
            this.sTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ST_NAME
            // 
            this.ST_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ST_NAME.DataPropertyName = "EXPR1";
            this.ST_NAME.HeaderText = "도착 역";
            this.ST_NAME.Name = "ST_NAME";
            this.ST_NAME.ReadOnly = true;
            // 
            // sTARTTIMEDataGridViewTextBoxColumn
            // 
            this.sTARTTIMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "START_TIME";
            this.sTARTTIMEDataGridViewTextBoxColumn.HeaderText = "출발 시간";
            this.sTARTTIMEDataGridViewTextBoxColumn.Name = "sTARTTIMEDataGridViewTextBoxColumn";
            this.sTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // START_TIME
            // 
            this.START_TIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.START_TIME.DataPropertyName = "DISPATCH";
            this.START_TIME.HeaderText = "도착 시간";
            this.START_TIME.Name = "START_TIME";
            this.START_TIME.ReadOnly = true;
            // 
            // DIRECTION
            // 
            this.DIRECTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIRECTION.DataPropertyName = "DIRECTION";
            this.DIRECTION.HeaderText = "방향";
            this.DIRECTION.Name = "DIRECTION";
            this.DIRECTION.ReadOnly = true;
            // 
            // dISPATCHBindingSource
            // 
            this.dISPATCHBindingSource.DataMember = "DISPATCH";
            this.dISPATCHBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnDispatchCheck);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_end);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cb_hour);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_start);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 120);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH";
            // 
            // btnDispatchCheck
            // 
            this.btnDispatchCheck.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDispatchCheck.Font = new System.Drawing.Font("경기천년제목V Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDispatchCheck.Location = new System.Drawing.Point(667, 49);
            this.btnDispatchCheck.Name = "btnDispatchCheck";
            this.btnDispatchCheck.Size = new System.Drawing.Size(212, 59);
            this.btnDispatchCheck.TabIndex = 22;
            this.btnDispatchCheck.Text = "열차 시간표 확인";
            this.btnDispatchCheck.UseVisualStyleBackColor = false;
            this.btnDispatchCheck.Click += new System.EventHandler(this.btnDispatchCheck_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_bu);
            this.groupBox2.Controls.Add(this.rb_seo);
            this.groupBox2.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(6, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 77);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "방향";
            // 
            // rb_bu
            // 
            this.rb_bu.AutoSize = true;
            this.rb_bu.Checked = true;
            this.rb_bu.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_bu.Location = new System.Drawing.Point(6, 20);
            this.rb_bu.Name = "rb_bu";
            this.rb_bu.Size = new System.Drawing.Size(74, 20);
            this.rb_bu.TabIndex = 19;
            this.rb_bu.TabStop = true;
            this.rb_bu.Text = "부산행";
            this.rb_bu.UseVisualStyleBackColor = true;
            this.rb_bu.Click += new System.EventHandler(this.DicrecClick);
            // 
            // rb_seo
            // 
            this.rb_seo.AutoSize = true;
            this.rb_seo.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_seo.Location = new System.Drawing.Point(6, 42);
            this.rb_seo.Name = "rb_seo";
            this.rb_seo.Size = new System.Drawing.Size(74, 20);
            this.rb_seo.TabIndex = 20;
            this.rb_seo.Text = "서울행";
            this.rb_seo.UseVisualStyleBackColor = true;
            this.rb_seo.Click += new System.EventHandler(this.DicrecClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(382, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "시";
            // 
            // cb_end
            // 
            this.cb_end.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_end.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_end.FormattingEnabled = true;
            this.cb_end.Location = new System.Drawing.Point(276, 49);
            this.cb_end.Name = "cb_end";
            this.cb_end.Size = new System.Drawing.Size(124, 27);
            this.cb_end.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("경기천년제목V Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(438, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "열 차 조 회 하 기";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SearchTrainClick);
            // 
            // cb_hour
            // 
            this.cb_hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hour.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_hour.FormattingEnabled = true;
            this.cb_hour.Location = new System.Drawing.Point(292, 81);
            this.cb_hour.Name = "cb_hour";
            this.cb_hour.Size = new System.Drawing.Size(87, 27);
            this.cb_hour.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(111, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "년";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("경기천년제목V Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(141, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "출발";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("경기천년제목V Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(307, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "도착";
            // 
            // cb_start
            // 
            this.cb_start.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_start.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_start.FormattingEnabled = true;
            this.cb_start.Location = new System.Drawing.Point(108, 48);
            this.cb_start.Name = "cb_start";
            this.cb_start.Size = new System.Drawing.Size(130, 27);
            this.cb_start.TabIndex = 7;
            this.cb_start.SelectedIndexChanged += new System.EventHandler(this.cb_start_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(243, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "→";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.TicketView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(899, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "예약 조회";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Font = new System.Drawing.Font("경기천년제목V Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(741, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "새로고침";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TicketView
            // 
            this.TicketView.AllowUserToAddRows = false;
            this.TicketView.AutoGenerateColumns = false;
            this.TicketView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.TicketView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIDDataGridViewTextBoxColumn,
            this.tRAINIDDataGridViewTextBoxColumn1,
            this.rOOMNUMDataGridViewTextBoxColumn,
            this.sNUMDataGridViewTextBoxColumn,
            this.sTSTARTDataGridViewTextBoxColumn,
            this.sTENDDataGridViewTextBoxColumn,
            this.sTARTTIMEDataGridViewTextBoxColumn1,
            this.eNDTIMEDataGridViewTextBoxColumn,
            this.dIRECTIONDataGridViewTextBoxColumn,
            this.cOSTDataGridViewTextBoxColumn});
            this.TicketView.DataSource = this.tICKETBindingSource;
            this.TicketView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.TicketView.Location = new System.Drawing.Point(6, 53);
            this.TicketView.Name = "TicketView";
            this.TicketView.ReadOnly = true;
            this.TicketView.RowTemplate.Height = 23;
            this.TicketView.Size = new System.Drawing.Size(887, 378);
            this.TicketView.TabIndex = 0;
            this.TicketView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketView_CellClick);
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "예약 번호";
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            this.tIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRAINIDDataGridViewTextBoxColumn1
            // 
            this.tRAINIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tRAINIDDataGridViewTextBoxColumn1.DataPropertyName = "TRAIN_ID";
            this.tRAINIDDataGridViewTextBoxColumn1.HeaderText = "열차 번호";
            this.tRAINIDDataGridViewTextBoxColumn1.Name = "tRAINIDDataGridViewTextBoxColumn1";
            this.tRAINIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rOOMNUMDataGridViewTextBoxColumn
            // 
            this.rOOMNUMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rOOMNUMDataGridViewTextBoxColumn.DataPropertyName = "ROOM_NUM";
            this.rOOMNUMDataGridViewTextBoxColumn.HeaderText = "객차";
            this.rOOMNUMDataGridViewTextBoxColumn.Name = "rOOMNUMDataGridViewTextBoxColumn";
            this.rOOMNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sNUMDataGridViewTextBoxColumn
            // 
            this.sNUMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sNUMDataGridViewTextBoxColumn.DataPropertyName = "S_NUM";
            this.sNUMDataGridViewTextBoxColumn.HeaderText = "좌석";
            this.sNUMDataGridViewTextBoxColumn.Name = "sNUMDataGridViewTextBoxColumn";
            this.sNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTSTARTDataGridViewTextBoxColumn
            // 
            this.sTSTARTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTSTARTDataGridViewTextBoxColumn.DataPropertyName = "ST_START";
            this.sTSTARTDataGridViewTextBoxColumn.HeaderText = "출발 역";
            this.sTSTARTDataGridViewTextBoxColumn.Name = "sTSTARTDataGridViewTextBoxColumn";
            this.sTSTARTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTENDDataGridViewTextBoxColumn
            // 
            this.sTENDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTENDDataGridViewTextBoxColumn.DataPropertyName = "ST_END";
            this.sTENDDataGridViewTextBoxColumn.HeaderText = "도착 역";
            this.sTENDDataGridViewTextBoxColumn.Name = "sTENDDataGridViewTextBoxColumn";
            this.sTENDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTARTTIMEDataGridViewTextBoxColumn1
            // 
            this.sTARTTIMEDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTARTTIMEDataGridViewTextBoxColumn1.DataPropertyName = "START_TIME";
            this.sTARTTIMEDataGridViewTextBoxColumn1.HeaderText = "출발 시간";
            this.sTARTTIMEDataGridViewTextBoxColumn1.Name = "sTARTTIMEDataGridViewTextBoxColumn1";
            this.sTARTTIMEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // eNDTIMEDataGridViewTextBoxColumn
            // 
            this.eNDTIMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eNDTIMEDataGridViewTextBoxColumn.DataPropertyName = "END_TIME";
            this.eNDTIMEDataGridViewTextBoxColumn.HeaderText = "도착 시간";
            this.eNDTIMEDataGridViewTextBoxColumn.Name = "eNDTIMEDataGridViewTextBoxColumn";
            this.eNDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIRECTIONDataGridViewTextBoxColumn
            // 
            this.dIRECTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dIRECTIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECTION";
            this.dIRECTIONDataGridViewTextBoxColumn.HeaderText = "방향";
            this.dIRECTIONDataGridViewTextBoxColumn.Name = "dIRECTIONDataGridViewTextBoxColumn";
            this.dIRECTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOSTDataGridViewTextBoxColumn
            // 
            this.cOSTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cOSTDataGridViewTextBoxColumn.DataPropertyName = "COST";
            this.cOSTDataGridViewTextBoxColumn.HeaderText = "요금";
            this.cOSTDataGridViewTextBoxColumn.Name = "cOSTDataGridViewTextBoxColumn";
            this.cOSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tICKETBindingSource
            // 
            this.tICKETBindingSource.DataMember = "TICKET";
            this.tICKETBindingSource.DataSource = this.dataSet11;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=HONG;USER ID=A5293348;PASSWORD=A5293348";
            // 
            // cmdSeatHelper
            // 
            this.cmdSeatHelper.CommandText = resources.GetString("cmdSeatHelper.CommandText");
            this.cmdSeatHelper.Connection = this.oracleConnection1;
            oracleParameter8.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter8.ParameterName = "T_ID";
            oracleParameter9.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter9.ParameterName = "DIREC";
            oracleParameter10.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter10.ParameterName = "ST";
            this.cmdSeatHelper.Parameters.Add(oracleParameter8);
            this.cmdSeatHelper.Parameters.Add(oracleParameter9);
            this.cmdSeatHelper.Parameters.Add(oracleParameter10);
            this.cmdSeatHelper.Transaction = null;
            // 
            // cmdSeatCancel
            // 
            this.cmdSeatCancel.AddRowid = true;
            this.cmdSeatCancel.CommandText = "UPDATE SEAT_STATUS SET STATUS = \'0\' WHERE TRAIN_ID = :T_ID AND ROOM_NUM = :R_NUM " +
    "AND S_NUM = :S_NUM AND ST_NAME = :ST";
            this.cmdSeatCancel.Connection = this.oracleConnection1;
            oracleParameter1.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter1.ParameterName = "T_ID";
            oracleParameter2.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Int32;
            oracleParameter2.ParameterName = "R_NUM";
            oracleParameter3.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Int32;
            oracleParameter3.ParameterName = "S_NUM";
            oracleParameter11.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter11.ParameterName = "ST";
            this.cmdSeatCancel.Parameters.Add(oracleParameter1);
            this.cmdSeatCancel.Parameters.Add(oracleParameter2);
            this.cmdSeatCancel.Parameters.Add(oracleParameter3);
            this.cmdSeatCancel.Parameters.Add(oracleParameter11);
            this.cmdSeatCancel.Transaction = null;
            // 
            // dISPATCHBindingSource1
            // 
            this.dISPATCHBindingSource1.DataMember = "DISPATCH";
            this.dISPATCHBindingSource1.DataSource = this.dataSet11;
            // 
            // stationTableAdapter1
            // 
            this.stationTableAdapter1.ClearBeforeFill = true;
            // 
            // sectionTableAdapter1
            // 
            this.sectionTableAdapter1.ClearBeforeFill = true;
            // 
            // dISPATCHTableAdapter
            // 
            this.dISPATCHTableAdapter.ClearBeforeFill = true;
            // 
            // seaT_STATUSTableAdapter1
            // 
            this.seaT_STATUSTableAdapter1.ClearBeforeFill = true;
            // 
            // SeatHelper
            // 
            this.SeatHelper.ClearBeforeFill = true;
            // 
            // tICKETTableAdapter2
            // 
            this.tICKETTableAdapter2.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(619, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_ID);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "칙-칙  폭-폭";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISPATCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TicketView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISPATCHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_hour;
        private System.Windows.Forms.ComboBox cb_end;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView TicketView;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSet1TableAdapters.STATIONTableAdapter stationTableAdapter1;
        private DataSet1TableAdapters.SECTIONTableAdapter sectionTableAdapter1;
        private System.Windows.Forms.BindingSource dISPATCHBindingSource;
        private DataSet1TableAdapters.DISPATCHTableAdapter dISPATCHTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_bu;
        private System.Windows.Forms.RadioButton rb_seo;
        private DataSet1TableAdapters.SEAT_STATUSTableAdapter seaT_STATUSTableAdapter1;
        private DataSet1TableAdapters.DISPATCHTableAdapter SeatHelper;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand cmdSeatHelper;
        private Oracle.DataAccess.Client.OracleCommand cmdSeatCancel;
        private System.Windows.Forms.BindingSource dISPATCHBindingSource1;
        private System.Windows.Forms.Button btnDispatchCheck;        
        private System.Windows.Forms.BindingSource tICKETBindingSource;
        private DataSet1TableAdapters.TICKETTableAdapter tICKETTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAINIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn START_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAINIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOOMNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTARTTIMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}