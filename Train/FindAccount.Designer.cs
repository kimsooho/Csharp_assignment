namespace Train
{
    partial class FindAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindAccount));
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_email = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("경기천년제목V Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(15, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "이름";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(102, 63);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(150, 21);
            this.tb_Name.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("경기천년제목V Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(15, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "전화번호";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(102, 90);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(150, 21);
            this.tb_Phone.TabIndex = 15;
            this.tb_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Phone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("경기천년제목V Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(15, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "이메일";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(102, 117);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(150, 21);
            this.tb_email.TabIndex = 19;
            // 
            // btn_email
            // 
            this.btn_email.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_email.Font = new System.Drawing.Font("경기천년제목V Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_email.Location = new System.Drawing.Point(156, 144);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(96, 23);
            this.btn_email.TabIndex = 21;
            this.btn_email.Text = "이메일로 전송";
            this.btn_email.UseVisualStyleBackColor = false;
            this.btn_email.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("경기천년제목V Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID / PASSWORD 찾기";
            // 
            // FindAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(264, 187);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Phone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindAccount";
            this.Text = "칙-칙  폭-폭";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Label label2;
    }
}