namespace AnnounceTimer {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.ChartDataGridView = new System.Windows.Forms.DataGridView();
            this.MinutesComboBox = new System.Windows.Forms.ComboBox();
            this.SecondComboBox = new System.Windows.Forms.ComboBox();
            this.AnnounceComboBox = new System.Windows.Forms.ComboBox();
            this.AnnounceTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SettingComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChartDataGridView
            // 
            this.ChartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChartDataGridView.Location = new System.Drawing.Point(14, 60);
            this.ChartDataGridView.Name = "ChartDataGridView";
            this.ChartDataGridView.ReadOnly = true;
            this.ChartDataGridView.RowTemplate.Height = 21;
            this.ChartDataGridView.Size = new System.Drawing.Size(489, 436);
            this.ChartDataGridView.TabIndex = 2;
            this.ChartDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChartDataGridView_CellContentDoubleClick);
            // 
            // MinutesComboBox
            // 
            this.MinutesComboBox.FormattingEnabled = true;
            this.MinutesComboBox.Location = new System.Drawing.Point(73, 502);
            this.MinutesComboBox.Name = "MinutesComboBox";
            this.MinutesComboBox.Size = new System.Drawing.Size(48, 20);
            this.MinutesComboBox.TabIndex = 3;
            // 
            // SecondComboBox
            // 
            this.SecondComboBox.FormattingEnabled = true;
            this.SecondComboBox.Location = new System.Drawing.Point(149, 502);
            this.SecondComboBox.Name = "SecondComboBox";
            this.SecondComboBox.Size = new System.Drawing.Size(48, 20);
            this.SecondComboBox.TabIndex = 4;
            // 
            // AnnounceComboBox
            // 
            this.AnnounceComboBox.FormattingEnabled = true;
            this.AnnounceComboBox.Location = new System.Drawing.Point(297, 502);
            this.AnnounceComboBox.Name = "AnnounceComboBox";
            this.AnnounceComboBox.Size = new System.Drawing.Size(48, 20);
            this.AnnounceComboBox.TabIndex = 5;
            // 
            // AnnounceTextBox
            // 
            this.AnnounceTextBox.Location = new System.Drawing.Point(16, 528);
            this.AnnounceTextBox.Name = "AnnounceTextBox";
            this.AnnounceTextBox.Size = new System.Drawing.Size(489, 19);
            this.AnnounceTextBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "登録";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "0:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SettingComboBox
            // 
            this.SettingComboBox.FormattingEnabled = true;
            this.SettingComboBox.Location = new System.Drawing.Point(194, 34);
            this.SettingComboBox.Name = "SettingComboBox";
            this.SettingComboBox.Size = new System.Drawing.Size(151, 20);
            this.SettingComboBox.TabIndex = 9;
            this.SettingComboBox.SelectedIndexChanged += new System.EventHandler(this.SettingComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 42);
            this.button3.TabIndex = 11;
            this.button3.Text = "停止";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "発生時間";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "分";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "秒";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "秒前にアナウンス";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 585);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SettingComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AnnounceTextBox);
            this.Controls.Add(this.AnnounceComboBox);
            this.Controls.Add(this.SecondComboBox);
            this.Controls.Add(this.MinutesComboBox);
            this.Controls.Add(this.ChartDataGridView);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "防衛軍たいまー";
            ((System.ComponentModel.ISupportInitialize)(this.ChartDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ChartDataGridView;
        private System.Windows.Forms.ComboBox MinutesComboBox;
        private System.Windows.Forms.ComboBox SecondComboBox;
        private System.Windows.Forms.ComboBox AnnounceComboBox;
        private System.Windows.Forms.TextBox AnnounceTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox SettingComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

