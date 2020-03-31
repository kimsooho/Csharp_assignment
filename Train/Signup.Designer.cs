namespace Train
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_PW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_CKECK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Signup = new System.Windows.Forms.Button();
            this.btn_IdCheck = new System.Windows.Forms.Button();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataSet11 = new Train.DataSet1();
            this.memberTableAdapter1 = new Train.DataSet1TableAdapters.MEMBERTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(99, 72);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(150, 21);
            this.tb_ID.TabIndex = 0;
            this.tb_ID.TextChanged += new System.EventHandler(this.ID_Check);
            // 
            // tb_PW
            // 
            this.tb_PW.Location = new System.Drawing.Point(99, 99);
            this.tb_PW.Name = "tb_PW";
            this.tb_PW.PasswordChar = '*';
            this.tb_PW.Size = new System.Drawing.Size(150, 21);
            this.tb_PW.TabIndex = 1;
            this.tb_PW.TextChanged += new System.EventHandler(this.PW_Check);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "P/W";
            // 
            // tb_CKECK
            // 
            this.tb_CKECK.Location = new System.Drawing.Point(99, 126);
            this.tb_CKECK.Name = "tb_CKECK";
            this.tb_CKECK.PasswordChar = '*';
            this.tb_CKECK.Size = new System.Drawing.Size(150, 21);
            this.tb_CKECK.TabIndex = 4;
            this.tb_CKECK.TextChanged += new System.EventHandler(this.PW_Check);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "재입력";
            // 
            // btn_Signup
            // 
            this.btn_Signup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Signup.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Signup.Location = new System.Drawing.Point(99, 234);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Size = new System.Drawing.Size(150, 23);
            this.btn_Signup.TabIndex = 6;
            this.btn_Signup.Text = "회   원   가   입";
            this.btn_Signup.UseVisualStyleBackColor = false;
            this.btn_Signup.Click += new System.EventHandler(this.Signup_click);
            // 
            // btn_IdCheck
            // 
            this.btn_IdCheck.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_IdCheck.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_IdCheck.Location = new System.Drawing.Point(256, 72);
            this.btn_IdCheck.Name = "btn_IdCheck";
            this.btn_IdCheck.Size = new System.Drawing.Size(91, 23);
            this.btn_IdCheck.TabIndex = 8;
            this.btn_IdCheck.Text = "중복 확인";
            this.btn_IdCheck.UseVisualStyleBackColor = false;
            this.btn_IdCheck.Click += new System.EventHandler(this.ID_Check_Click);
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(99, 180);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(150, 21);
            this.tb_Phone.TabIndex = 9;
            this.tb_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Phone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "전화번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(255, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "숫자만 입력";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.check.ForeColor = System.Drawing.Color.DarkRed;
            this.check.Location = new System.Drawing.Point(257, 129);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(24, 16);
            this.check.TabIndex = 12;
            this.check.Text = "●";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "이름";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(99, 153);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(150, 21);
            this.tb_Name.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(12, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "이메일";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(99, 207);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(150, 21);
            this.tb_email.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("경기천년제목V Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(255, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "계정찾기에 사용";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("경기천년제목V Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(122, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "회 원 가 입";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 296);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.btn_IdCheck);
            this.Controls.Add(this.btn_Signup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_CKECK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_PW);
            this.Controls.Add(this.tb_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup";
            this.Text = "칙-칙  폭-폭";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_PW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_CKECK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Signup;
        private System.Windows.Forms.Button btn_IdCheck;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label check;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label8;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.MEMBERTableAdapter memberTableAdapter1;
        private System.Windows.Forms.Label label9;
    }
}