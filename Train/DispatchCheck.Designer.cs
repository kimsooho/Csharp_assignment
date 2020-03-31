namespace Train
{
    partial class DispatchCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispatchCheck));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.rb_Busan = new System.Windows.Forms.RadioButton();
            this.rb_Seoul = new System.Windows.Forms.RadioButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tRAINIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISPATCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISPATCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Train.DataSet1();
            this.dISPATCHTableAdapter = new Train.DataSet1TableAdapters.DISPATCHTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISPATCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_All);
            this.groupBox3.Controls.Add(this.rb_Busan);
            this.groupBox3.Controls.Add(this.rb_Seoul);
            this.groupBox3.Font = new System.Drawing.Font("경기천년제목V Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(12, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 67);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "방향별 조회";
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Checked = true;
            this.rb_All.Font = new System.Drawing.Font("경기천년제목V Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_All.Location = new System.Drawing.Point(6, 32);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(112, 25);
            this.rb_All.TabIndex = 2;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "전체보기";
            this.rb_All.UseVisualStyleBackColor = true;
            this.rb_All.Click += new System.EventHandler(this.DirectionClick);
            // 
            // rb_Busan
            // 
            this.rb_Busan.AutoSize = true;
            this.rb_Busan.Font = new System.Drawing.Font("경기천년제목V Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_Busan.Location = new System.Drawing.Point(212, 32);
            this.rb_Busan.Name = "rb_Busan";
            this.rb_Busan.Size = new System.Drawing.Size(91, 25);
            this.rb_Busan.TabIndex = 1;
            this.rb_Busan.Text = "부산행";
            this.rb_Busan.UseVisualStyleBackColor = true;
            this.rb_Busan.Click += new System.EventHandler(this.DirectionClick);
            // 
            // rb_Seoul
            // 
            this.rb_Seoul.AutoSize = true;
            this.rb_Seoul.Font = new System.Drawing.Font("경기천년제목V Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_Seoul.Location = new System.Drawing.Point(119, 32);
            this.rb_Seoul.Name = "rb_Seoul";
            this.rb_Seoul.Size = new System.Drawing.Size(91, 25);
            this.rb_Seoul.TabIndex = 0;
            this.rb_Seoul.Text = "서울행";
            this.rb_Seoul.UseVisualStyleBackColor = true;
            this.rb_Seoul.Click += new System.EventHandler(this.DirectionClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tRAINIDDataGridViewTextBoxColumn,
            this.sTNAMEDataGridViewTextBoxColumn,
            this.dISPATCHDataGridViewTextBoxColumn,
            this.sTARTTIMEDataGridViewTextBoxColumn,
            this.dIRECTIONDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.dISPATCHBindingSource;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.Location = new System.Drawing.Point(12, 139);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(685, 345);
            this.dataGridView3.TabIndex = 6;
            // 
            // tRAINIDDataGridViewTextBoxColumn
            // 
            this.tRAINIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tRAINIDDataGridViewTextBoxColumn.DataPropertyName = "TRAIN_ID";
            this.tRAINIDDataGridViewTextBoxColumn.HeaderText = "열차 번호";
            this.tRAINIDDataGridViewTextBoxColumn.Name = "tRAINIDDataGridViewTextBoxColumn";
            this.tRAINIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTNAMEDataGridViewTextBoxColumn
            // 
            this.sTNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTNAMEDataGridViewTextBoxColumn.DataPropertyName = "ST_NAME";
            this.sTNAMEDataGridViewTextBoxColumn.HeaderText = "역";
            this.sTNAMEDataGridViewTextBoxColumn.Name = "sTNAMEDataGridViewTextBoxColumn";
            this.sTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dISPATCHDataGridViewTextBoxColumn
            // 
            this.dISPATCHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dISPATCHDataGridViewTextBoxColumn.DataPropertyName = "DISPATCH";
            this.dISPATCHDataGridViewTextBoxColumn.HeaderText = "역 도착 시간";
            this.dISPATCHDataGridViewTextBoxColumn.Name = "dISPATCHDataGridViewTextBoxColumn";
            this.dISPATCHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTARTTIMEDataGridViewTextBoxColumn
            // 
            this.sTARTTIMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "START_TIME";
            this.sTARTTIMEDataGridViewTextBoxColumn.HeaderText = "출발 시간";
            this.sTARTTIMEDataGridViewTextBoxColumn.Name = "sTARTTIMEDataGridViewTextBoxColumn";
            this.sTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIRECTIONDataGridViewTextBoxColumn
            // 
            this.dIRECTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dIRECTIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECTION";
            this.dIRECTIONDataGridViewTextBoxColumn.HeaderText = "방향";
            this.dIRECTIONDataGridViewTextBoxColumn.Name = "dIRECTIONDataGridViewTextBoxColumn";
            this.dIRECTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dISPATCHBindingSource
            // 
            this.dISPATCHBindingSource.DataMember = "DISPATCH";
            this.dISPATCHBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dISPATCHTableAdapter
            // 
            this.dISPATCHTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("경기천년제목V Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "열차 시간표 조회";
            // 
            // DispatchCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(709, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DispatchCheck";
            this.Text = "칙-칙  폭-폭";
            this.Load += new System.EventHandler(this.DispatchCheck_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISPATCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_All;
        private System.Windows.Forms.RadioButton rb_Busan;
        private System.Windows.Forms.RadioButton rb_Seoul;
        private System.Windows.Forms.DataGridView dataGridView3;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dISPATCHBindingSource;
        private DataSet1TableAdapters.DISPATCHTableAdapter dISPATCHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAINIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISPATCHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}