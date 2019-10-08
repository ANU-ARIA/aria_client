namespace WindowsFormsApp2
{
    partial class Line
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prod_all_time = new System.Windows.Forms.TextBox();
            this.prod_time = new System.Windows.Forms.TextBox();
            this.prod_rem_count = new System.Windows.Forms.TextBox();
            this.prod_com_count_text = new System.Windows.Forms.TextBox();
            this.prod_fail = new System.Windows.Forms.TextBox();
            this.prod_count_text = new System.Windows.Forms.TextBox();
            this.prod_pass = new System.Windows.Forms.TextBox();
            this.model_name_text = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.line_humid = new System.Windows.Forms.Label();
            this.line_temp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 12);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 27;
            this.DataGridView.Size = new System.Drawing.Size(1158, 339);
            this.DataGridView.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.prod_all_time);
            this.groupBox3.Controls.Add(this.prod_time);
            this.groupBox3.Controls.Add(this.prod_rem_count);
            this.groupBox3.Controls.Add(this.prod_com_count_text);
            this.groupBox3.Controls.Add(this.prod_fail);
            this.groupBox3.Controls.Add(this.prod_count_text);
            this.groupBox3.Controls.Add(this.prod_pass);
            this.groupBox3.Controls.Add(this.model_name_text);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1448, 548);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "실시간 모니터링";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(60, 424);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 27);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(60, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 27);
            this.panel3.TabIndex = 13;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(804, 42);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(617, 336);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(833, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "불 량 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(833, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "정 상 :";
            // 
            // prod_all_time
            // 
            this.prod_all_time.Location = new System.Drawing.Point(305, 364);
            this.prod_all_time.Name = "prod_all_time";
            this.prod_all_time.Size = new System.Drawing.Size(112, 25);
            this.prod_all_time.TabIndex = 8;
            // 
            // prod_time
            // 
            this.prod_time.Location = new System.Drawing.Point(305, 234);
            this.prod_time.Name = "prod_time";
            this.prod_time.Size = new System.Drawing.Size(112, 25);
            this.prod_time.TabIndex = 8;
            // 
            // prod_rem_count
            // 
            this.prod_rem_count.Location = new System.Drawing.Point(607, 128);
            this.prod_rem_count.Name = "prod_rem_count";
            this.prod_rem_count.Size = new System.Drawing.Size(112, 25);
            this.prod_rem_count.TabIndex = 8;
            // 
            // prod_com_count_text
            // 
            this.prod_com_count_text.Location = new System.Drawing.Point(229, 128);
            this.prod_com_count_text.Name = "prod_com_count_text";
            this.prod_com_count_text.Size = new System.Drawing.Size(112, 25);
            this.prod_com_count_text.TabIndex = 8;
            // 
            // prod_fail
            // 
            this.prod_fail.Location = new System.Drawing.Point(949, 491);
            this.prod_fail.Name = "prod_fail";
            this.prod_fail.Size = new System.Drawing.Size(112, 25);
            this.prod_fail.TabIndex = 8;
            // 
            // prod_count_text
            // 
            this.prod_count_text.Location = new System.Drawing.Point(607, 73);
            this.prod_count_text.Name = "prod_count_text";
            this.prod_count_text.Size = new System.Drawing.Size(112, 25);
            this.prod_count_text.TabIndex = 8;
            // 
            // prod_pass
            // 
            this.prod_pass.Location = new System.Drawing.Point(949, 426);
            this.prod_pass.Name = "prod_pass";
            this.prod_pass.Size = new System.Drawing.Size(112, 25);
            this.prod_pass.TabIndex = 8;
            // 
            // model_name_text
            // 
            this.model_name_text.Location = new System.Drawing.Point(229, 72);
            this.model_name_text.Name = "model_name_text";
            this.model_name_text.Size = new System.Drawing.Size(112, 25);
            this.model_name_text.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(750, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 542);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(750, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 541);
            this.panel1.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(53, 365);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 24);
            this.label15.TabIndex = 4;
            this.label15.Text = "완료 예정 시간 : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(53, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 24);
            this.label13.TabIndex = 4;
            this.label13.Text = "생산되는 시간(1p) : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(431, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "남은 수량 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(53, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "완료 수량 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(431, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "지시 수량 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(53, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "제품 명 :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.line_humid);
            this.groupBox4.Controls.Add(this.line_temp);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(1176, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 339);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "공장 환경";
            this.groupBox4.Enter += new System.EventHandler(this.GroupBox4_Enter);
            // 
            // line_humid
            // 
            this.line_humid.AutoSize = true;
            this.line_humid.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.line_humid.Location = new System.Drawing.Point(152, 110);
            this.line_humid.Name = "line_humid";
            this.line_humid.Size = new System.Drawing.Size(23, 24);
            this.line_humid.TabIndex = 1;
            this.line_humid.Text = "-";
            this.line_humid.Click += new System.EventHandler(this.Label2_Click);
            // 
            // line_temp
            // 
            this.line_temp.AutoSize = true;
            this.line_temp.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.line_temp.Location = new System.Drawing.Point(152, 47);
            this.line_temp.Name = "line_temp";
            this.line_temp.Size = new System.Drawing.Size(23, 24);
            this.line_temp.TabIndex = 1;
            this.line_temp.Text = "-";
            this.line_temp.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(45, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "습도 : ";
            this.label3.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "온도 : ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 917);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.groupBox3);
            this.Name = "Line";
            this.Text = "Line";
            this.Load += new System.EventHandler(this.Line_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label line_temp;
        private System.Windows.Forms.Label line_humid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prod_all_time;
        private System.Windows.Forms.TextBox prod_time;
        private System.Windows.Forms.TextBox prod_rem_count;
        private System.Windows.Forms.TextBox prod_com_count_text;
        private System.Windows.Forms.TextBox prod_fail;
        private System.Windows.Forms.TextBox prod_count_text;
        private System.Windows.Forms.TextBox prod_pass;
        private System.Windows.Forms.TextBox model_name_text;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}