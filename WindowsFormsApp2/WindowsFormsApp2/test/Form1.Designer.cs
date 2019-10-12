namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage tabPage1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Code1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Op2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.Am1 = new System.Windows.Forms.TextBox();
            this.Am2 = new System.Windows.Forms.TextBox();
            this.Lin1 = new System.Windows.Forms.Label();
            this.Lin2 = new System.Windows.Forms.Label();
            this.Lot1 = new System.Windows.Forms.ComboBox();
            this.Lot2 = new System.Windows.Forms.ComboBox();
            this.Code2 = new System.Windows.Forms.Label();
            this.Op1 = new System.Windows.Forms.ComboBox();
            this.Pro_btn = new System.Windows.Forms.Button();
            this.User_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.time1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.Transparent;
            tabPage1.Controls.Add(this.groupBox1);
            tabPage1.Controls.Add(this.Pro_btn);
            tabPage1.Controls.Add(this.User_id);
            tabPage1.Controls.Add(this.label2);
            tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            tabPage1.Location = new System.Drawing.Point(4, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1167, 645);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Lot 작업지시";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("함초롬돋움 확장", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(18, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 555);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.5F));
            this.tableLayoutPanel1.Controls.Add(this.Code1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Op2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Am2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.Lin1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lin2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Lot1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lot2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Code2, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.Op1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Am1, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.TabStop = true;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint_1);
            // 
            // Code1
            // 
            this.Code1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Code1.AutoSize = true;
            this.Code1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Code1.Location = new System.Drawing.Point(779, 179);
            this.Code1.Name = "Code1";
            this.Code1.Size = new System.Drawing.Size(99, 38);
            this.Code1.TabIndex = 37;
            this.Code1.Text = "label9";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("함초롬돋움 확장", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(760, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 45);
            this.label8.TabIndex = 35;
            this.label8.Text = "제품코드";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("함초롬돋움 확장", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(54, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 45);
            this.label7.TabIndex = 27;
            this.label7.Text = "라인";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Op2
            // 
            this.Op2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Op2.FormattingEnabled = true;
            this.Op2.Location = new System.Drawing.Point(425, 395);
            this.Op2.Name = "Op2";
            this.Op2.Size = new System.Drawing.Size(110, 43);
            this.Op2.TabIndex = 25;
            this.Op2.SelectedIndexChanged += new System.EventHandler(this.Op2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("함초롬돋움 확장", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(412, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 45);
            this.label6.TabIndex = 14;
            this.label6.Text = "옵션";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("함초롬돋움 확장", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(556, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 45);
            this.label5.TabIndex = 13;
            this.label5.Text = "수량";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("함초롬돋움 확장", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(150, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "완제품명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 189);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(16, 398);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Am1
            // 
            this.Am1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Am1.Location = new System.Drawing.Point(558, 176);
            this.Am1.Name = "Am1";
            this.Am1.Size = new System.Drawing.Size(131, 43);
            this.Am1.TabIndex = 15;
            this.Am1.Text = "입력가능";
            this.Am1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Am2
            // 
            this.Am2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Am2.Location = new System.Drawing.Point(558, 385);
            this.Am2.Name = "Am2";
            this.Am2.Size = new System.Drawing.Size(131, 43);
            this.Am2.TabIndex = 16;
            this.Am2.Text = "입력가능";
            this.Am2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lin1
            // 
            this.Lin1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lin1.AutoSize = true;
            this.Lin1.Location = new System.Drawing.Point(61, 180);
            this.Lin1.Name = "Lin1";
            this.Lin1.Size = new System.Drawing.Size(74, 36);
            this.Lin1.TabIndex = 28;
            this.Lin1.Text = "L #1";
            // 
            // Lin2
            // 
            this.Lin2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lin2.AutoSize = true;
            this.Lin2.Location = new System.Drawing.Point(61, 389);
            this.Lin2.Name = "Lin2";
            this.Lin2.Size = new System.Drawing.Size(74, 36);
            this.Lin2.TabIndex = 29;
            this.Lin2.Text = "L #2";
            // 
            // Lot1
            // 
            this.Lot1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lot1.FormattingEnabled = true;
            this.Lot1.Location = new System.Drawing.Point(163, 186);
            this.Lot1.Name = "Lot1";
            this.Lot1.Size = new System.Drawing.Size(228, 43);
            this.Lot1.TabIndex = 30;
            this.Lot1.SelectedIndexChanged += new System.EventHandler(this.Lot1_SelectedIndexChanged);
            // 
            // Lot2
            // 
            this.Lot2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lot2.FormattingEnabled = true;
            this.Lot2.Location = new System.Drawing.Point(163, 395);
            this.Lot2.Name = "Lot2";
            this.Lot2.Size = new System.Drawing.Size(228, 43);
            this.Lot2.TabIndex = 31;
            this.Lot2.SelectedIndexChanged += new System.EventHandler(this.Lot2_SelectedIndexChanged);
            // 
            // Code2
            // 
            this.Code2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Code2.AutoSize = true;
            this.Code2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Code2.Location = new System.Drawing.Point(779, 388);
            this.Code2.Name = "Code2";
            this.Code2.Size = new System.Drawing.Size(99, 38);
            this.Code2.TabIndex = 33;
            this.Code2.Text = "label9";
            this.Code2.Click += new System.EventHandler(this.Code2_Click);
            // 
            // Op1
            // 
            this.Op1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Op1.FormattingEnabled = true;
            this.Op1.Location = new System.Drawing.Point(425, 186);
            this.Op1.Name = "Op1";
            this.Op1.Size = new System.Drawing.Size(110, 43);
            this.Op1.TabIndex = 22;
            this.Op1.SelectedIndexChanged += new System.EventHandler(this.Op1_SelectedIndexChanged);
            // 
            // Pro_btn
            // 
            this.Pro_btn.Location = new System.Drawing.Point(1022, 24);
            this.Pro_btn.Name = "Pro_btn";
            this.Pro_btn.Size = new System.Drawing.Size(145, 625);
            this.Pro_btn.TabIndex = 5;
            this.Pro_btn.Text = "실행";
            this.Pro_btn.UseVisualStyleBackColor = true;
            this.Pro_btn.Click += new System.EventHandler(this.Pro_btn_Click);
            // 
            // User_id
            // 
            this.User_id.Location = new System.Drawing.Point(881, 24);
            this.User_id.Name = "User_id";
            this.User_id.Size = new System.Drawing.Size(116, 38);
            this.User_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(763, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "작업자 ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(79, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1175, 689);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1167, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "실시간모니터링";
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1167, 645);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "생산 재고";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1167, 645);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "불량 검수";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // time1
            // 
            this.time1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time1.AutoEllipsis = true;
            this.time1.AutoSize = true;
            this.time1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.time1.Location = new System.Drawing.Point(958, 58);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(59, 29);
            this.time1.TabIndex = 7;
            this.time1.Text = "time";
            this.time1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.time1.Click += new System.EventHandler(this.Label4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1163, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.baseline_power_settings_new_black_18dp;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1332, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 25);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 840);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ㅣ";
            this.Load += new System.EventHandler(this.Form1_Load);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox User_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Pro_btn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox Op2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Am2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lin2;
        private System.Windows.Forms.ComboBox Lot2;
        private System.Windows.Forms.Label Code2;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox Op1;
        public System.Windows.Forms.TextBox Am1;
        public System.Windows.Forms.Label Lin1;
        public System.Windows.Forms.ComboBox Lot1;
        public System.Windows.Forms.Label Code1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

