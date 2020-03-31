namespace Train
{
    partial class SeatSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatSelect));
            Oracle.DataAccess.Client.OracleParameter oracleParameter1 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter2 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter3 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter4 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter5 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter6 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter7 = new Oracle.DataAccess.Client.OracleParameter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tb_normal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.normal = new System.Windows.Forms.Label();
            this.child = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_child = new System.Windows.Forms.TextBox();
            this.baby = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_baby = new System.Windows.Forms.TextBox();
            this.hero = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_hero = new System.Windows.Forms.TextBox();
            this.disabled = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_disabled = new System.Windows.Forms.TextBox();
            this.old = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_old = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_cost = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.sEATSTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Train.DataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lb_Seat = new System.Windows.Forms.Label();
            this.sEAT_STATUSTableAdapter = new Train.DataSet1TableAdapters.SEAT_STATUSTableAdapter();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.cmdSeatUpdate = new Oracle.DataAccess.Client.OracleCommand();
            this.cmdSeat = new Oracle.DataAccess.Client.OracleCommand();
            this.ticketTableAdapter2 = new Train.DataSet1TableAdapters.TICKETTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sEATSTATUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1 호차";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox4.Image = ((System.Drawing.Image)(resources.GetObject("checkBox4.Image")));
            this.checkBox4.Location = new System.Drawing.Point(135, 89);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(79, 32);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "       4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox3.Image = ((System.Drawing.Image)(resources.GetObject("checkBox3.Image")));
            this.checkBox3.Location = new System.Drawing.Point(47, 89);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 32);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "       3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox2.Image = ((System.Drawing.Image)(resources.GetObject("checkBox2.Image")));
            this.checkBox2.Location = new System.Drawing.Point(136, 31);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 32);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "       2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox1.Image = ((System.Drawing.Image)(resources.GetObject("checkBox1.Image")));
            this.checkBox1.Location = new System.Drawing.Point(47, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 32);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "       1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tb_normal
            // 
            this.tb_normal.Location = new System.Drawing.Point(77, 36);
            this.tb_normal.Name = "tb_normal";
            this.tb_normal.Size = new System.Drawing.Size(27, 23);
            this.tb_normal.TabIndex = 2;
            this.tb_normal.TextChanged += new System.EventHandler(this.tb_normal_TextChanged);
            this.tb_normal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "일반인";
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Location = new System.Drawing.Point(107, 41);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(24, 16);
            this.normal.TabIndex = 11;
            this.normal.Text = "명";
            // 
            // child
            // 
            this.child.AutoSize = true;
            this.child.Location = new System.Drawing.Point(107, 68);
            this.child.Name = "child";
            this.child.Size = new System.Drawing.Size(24, 16);
            this.child.TabIndex = 14;
            this.child.Text = "명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(19, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "어린이";
            // 
            // tb_child
            // 
            this.tb_child.Location = new System.Drawing.Point(77, 63);
            this.tb_child.Name = "tb_child";
            this.tb_child.Size = new System.Drawing.Size(27, 23);
            this.tb_child.TabIndex = 12;
            this.tb_child.TextChanged += new System.EventHandler(this.tb_child_TextChanged);
            this.tb_child.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum);
            // 
            // baby
            // 
            this.baby.AutoSize = true;
            this.baby.Location = new System.Drawing.Point(107, 95);
            this.baby.Name = "baby";
            this.baby.Size = new System.Drawing.Size(24, 16);
            this.baby.TabIndex = 17;
            this.baby.Text = "명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(19, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "유아";
            // 
            // tb_baby
            // 
            this.tb_baby.Location = new System.Drawing.Point(77, 90);
            this.tb_baby.Name = "tb_baby";
            this.tb_baby.Size = new System.Drawing.Size(27, 23);
            this.tb_baby.TabIndex = 15;
            this.tb_baby.TextChanged += new System.EventHandler(this.tb_baby_TextChanged);
            this.tb_baby.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum);
            // 
            // hero
            // 
            this.hero.AutoSize = true;
            this.hero.Location = new System.Drawing.Point(351, 94);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(24, 16);
            this.hero.TabIndex = 35;
            this.hero.Text = "명";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(231, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 34;
            this.label14.Text = "국가유공자";
            // 
            // tb_hero
            // 
            this.tb_hero.Location = new System.Drawing.Point(321, 89);
            this.tb_hero.Name = "tb_hero";
            this.tb_hero.Size = new System.Drawing.Size(27, 23);
            this.tb_hero.TabIndex = 33;
            this.tb_hero.TextChanged += new System.EventHandler(this.tb_hero_TextChanged);
            this.tb_hero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum);
            // 
            // disabled
            // 
            this.disabled.AutoSize = true;
            this.disabled.Location = new System.Drawing.Point(351, 67);
            this.disabled.Name = "disabled";
            this.disabled.Size = new System.Drawing.Size(24, 16);
            this.disabled.TabIndex = 32;
            this.disabled.Text = "명";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(231, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "장애인";
            // 
            // tb_disabled
            // 
            this.tb_disabled.Location = new System.Drawing.Point(321, 62);
            this.tb_disabled.Name = "tb_disabled";
            this.tb_disabled.Size = new System.Drawing.Size(27, 23);
            this.tb_disabled.TabIndex = 30;
            this.tb_disabled.TextChanged += new System.EventHandler(this.tb_disabled_TextChanged);
            this.tb_disabled.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum);
            // 
            // old
            // 
            this.old.AutoSize = true;
            this.old.Location = new System.Drawing.Point(351, 40);
            this.old.Name = "old";
            this.old.Size = new System.Drawing.Size(24, 16);
            this.old.TabIndex = 29;
            this.old.Text = "명";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(231, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 16);
            this.label18.TabIndex = 28;
            this.label18.Text = "경로";
            // 
            // tb_old
            // 
            this.tb_old.Location = new System.Drawing.Point(321, 35);
            this.tb_old.Name = "tb_old";
            this.tb_old.Size = new System.Drawing.Size(27, 23);
            this.tb_old.TabIndex = 27;
            this.tb_old.TextChanged += new System.EventHandler(this.tb_old_TextChanged);
            this.tb_old.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_cost);
            this.groupBox3.Controls.Add(this.tb_normal);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.tb_old);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.old);
            this.groupBox3.Controls.Add(this.baby);
            this.groupBox3.Controls.Add(this.tb_disabled);
            this.groupBox3.Controls.Add(this.normal);
            this.groupBox3.Controls.Add(this.disabled);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.hero);
            this.groupBox3.Controls.Add(this.tb_baby);
            this.groupBox3.Controls.Add(this.tb_hero);
            this.groupBox3.Controls.Add(this.tb_child);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.child);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(12, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 141);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "인원 선택";
            // 
            // lb_cost
            // 
            this.lb_cost.AutoSize = true;
            this.lb_cost.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_cost.Location = new System.Drawing.Point(409, 114);
            this.lb_cost.Name = "lb_cost";
            this.lb_cost.Size = new System.Drawing.Size(62, 16);
            this.lb_cost.TabIndex = 36;
            this.lb_cost.Text = "요금 : 0";
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBooking.Location = new System.Drawing.Point(451, 367);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(103, 23);
            this.btnBooking.TabIndex = 40;
            this.btnBooking.Text = "예약하기";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.BookingClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(288, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 150);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2 호차";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox8.Image = ((System.Drawing.Image)(resources.GetObject("checkBox8.Image")));
            this.checkBox8.Location = new System.Drawing.Point(135, 89);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(79, 32);
            this.checkBox8.TabIndex = 3;
            this.checkBox8.Text = "       4";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox7.Image = ((System.Drawing.Image)(resources.GetObject("checkBox7.Image")));
            this.checkBox7.Location = new System.Drawing.Point(47, 89);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(78, 32);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "       3";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox6.Image = ((System.Drawing.Image)(resources.GetObject("checkBox6.Image")));
            this.checkBox6.Location = new System.Drawing.Point(136, 31);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(78, 32);
            this.checkBox6.TabIndex = 1;
            this.checkBox6.Text = "       2";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox5.Image = ((System.Drawing.Image)(resources.GetObject("checkBox5.Image")));
            this.checkBox5.Location = new System.Drawing.Point(47, 31);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(78, 32);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "       1";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // sEATSTATUSBindingSource
            // 
            this.sEATSTATUSBindingSource.DataMember = "SEAT_STATUS";
            this.sEATSTATUSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(398, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "좌석 선택";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.SelectSeatClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(479, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "다시 선택";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.RetryClick);
            // 
            // lb_Seat
            // 
            this.lb_Seat.AutoSize = true;
            this.lb_Seat.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Seat.Location = new System.Drawing.Point(262, 201);
            this.lb_Seat.Name = "lb_Seat";
            this.lb_Seat.Size = new System.Drawing.Size(134, 16);
            this.lb_Seat.TabIndex = 44;
            this.lb_Seat.Text = "선택된 좌석 수 : 0";
            // 
            // sEAT_STATUSTableAdapter
            // 
            this.sEAT_STATUSTableAdapter.ClearBeforeFill = true;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=HONG;USER ID=A5293348;PASSWORD=A5293348";
            // 
            // cmdSeatUpdate
            // 
            this.cmdSeatUpdate.CommandText = "UPDATE SEAT_STATUS SET STATUS = \'1\' WHERE TRAIN_ID = :T_ID AND ROOM_NUM = :R_NUM " +
    "AND S_NUM = :S_NUM AND ST_NAME = :ST";
            this.cmdSeatUpdate.Connection = this.oracleConnection1;
            oracleParameter1.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter1.ParameterName = "T_ID";
            oracleParameter2.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Int32;
            oracleParameter2.ParameterName = "R_NUM";
            oracleParameter3.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Int32;
            oracleParameter3.ParameterName = "S_NUM";
            oracleParameter4.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter4.ParameterName = "ST";
            this.cmdSeatUpdate.Parameters.Add(oracleParameter1);
            this.cmdSeatUpdate.Parameters.Add(oracleParameter2);
            this.cmdSeatUpdate.Parameters.Add(oracleParameter3);
            this.cmdSeatUpdate.Parameters.Add(oracleParameter4);
            this.cmdSeatUpdate.Transaction = null;
            // 
            // cmdSeat
            // 
            this.cmdSeat.CommandText = resources.GetString("cmdSeat.CommandText");
            this.cmdSeat.Connection = this.oracleConnection1;
            oracleParameter5.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter5.ParameterName = "T_ID";
            oracleParameter6.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter6.ParameterName = "DIREC";
            oracleParameter7.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter7.ParameterName = "ST";
            this.cmdSeat.Parameters.Add(oracleParameter5);
            this.cmdSeat.Parameters.Add(oracleParameter6);
            this.cmdSeat.Parameters.Add(oracleParameter7);
            this.cmdSeat.Transaction = null;
            // 
            // ticketTableAdapter2
            // 
            this.ticketTableAdapter2.ClearBeforeFill = true;
            // 
            // SeatSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(566, 406);
            this.Controls.Add(this.lb_Seat);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeatSelect";
            this.Text = "칙-칙  폭-폭";
            this.Load += new System.EventHandler(this.SeatSelect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sEATSTATUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_normal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label normal;
        private System.Windows.Forms.Label child;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_child;
        private System.Windows.Forms.Label baby;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_baby;
        private System.Windows.Forms.Label hero;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_hero;
        private System.Windows.Forms.Label disabled;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_disabled;
        private System.Windows.Forms.Label old;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_old;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_cost;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lb_Seat;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource sEATSTATUSBindingSource;
        private DataSet1TableAdapters.SEAT_STATUSTableAdapter sEAT_STATUSTableAdapter;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand cmdSeatUpdate;
        private Oracle.DataAccess.Client.OracleCommand cmdSeat;
        private DataSet1TableAdapters.TICKETTableAdapter ticketTableAdapter2;
    }
}