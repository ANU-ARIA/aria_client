namespace WindowsFormsApp2
{
    partial class Lot_direct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.humid_margin_text = new System.Windows.Forms.NumericUpDown();
            this.insert = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.temp_margin_text = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.prod_fail_text = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.model_color_text = new System.Windows.Forms.ComboBox();
            this.model_name_text = new System.Windows.Forms.ComboBox();
            this.lot_id_text = new System.Windows.Forms.TextBox();
            this.prod_count_text = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.line_temp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.line_humid = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.line_text = new System.Windows.Forms.ComboBox();
            this.lots_list = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humid_margin_text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_margin_text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_fail_text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_count_text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lots_list)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.humid_margin_text);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.temp_margin_text);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.prod_fail_text);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.model_color_text);
            this.groupBox1.Controls.Add(this.model_name_text);
            this.groupBox1.Controls.Add(this.lot_id_text);
            this.groupBox1.Controls.Add(this.prod_count_text);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.line_temp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.line_humid);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.line_text);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 577);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "작업 지시";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // humid_margin_text
            // 
            this.humid_margin_text.Location = new System.Drawing.Point(184, 435);
            this.humid_margin_text.Name = "humid_margin_text";
            this.humid_margin_text.Size = new System.Drawing.Size(120, 25);
            this.humid_margin_text.TabIndex = 22;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(24, 499);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(176, 53);
            this.insert.TabIndex = 0;
            this.insert.Text = "작업 지시";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(20, 436);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(147, 24);
            this.label22.TabIndex = 23;
            this.label22.Text = "습도 margin :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(329, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "제품 코드 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(489, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "-";
            this.label5.Click += new System.EventHandler(this.Label4_Click);
            // 
            // temp_margin_text
            // 
            this.temp_margin_text.Location = new System.Drawing.Point(184, 375);
            this.temp_margin_text.Name = "temp_margin_text";
            this.temp_margin_text.Size = new System.Drawing.Size(120, 25);
            this.temp_margin_text.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(20, 376);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(147, 24);
            this.label21.TabIndex = 21;
            this.label21.Text = "온도 margin :";
            // 
            // prod_fail_text
            // 
            this.prod_fail_text.Location = new System.Drawing.Point(184, 314);
            this.prod_fail_text.Name = "prod_fail_text";
            this.prod_fail_text.Size = new System.Drawing.Size(120, 25);
            this.prod_fail_text.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(20, 315);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(154, 24);
            this.label20.TabIndex = 19;
            this.label20.Text = "불량율 제한 :";
            // 
            // model_color_text
            // 
            this.model_color_text.FormattingEnabled = true;
            this.model_color_text.Location = new System.Drawing.Point(156, 212);
            this.model_color_text.Name = "model_color_text";
            this.model_color_text.Size = new System.Drawing.Size(121, 23);
            this.model_color_text.TabIndex = 17;
            // 
            // model_name_text
            // 
            this.model_name_text.FormattingEnabled = true;
            this.model_name_text.Location = new System.Drawing.Point(124, 142);
            this.model_name_text.Name = "model_name_text";
            this.model_name_text.Size = new System.Drawing.Size(121, 23);
            this.model_name_text.TabIndex = 17;
            // 
            // lot_id_text
            // 
            this.lot_id_text.Location = new System.Drawing.Point(374, 81);
            this.lot_id_text.Name = "lot_id_text";
            this.lot_id_text.Size = new System.Drawing.Size(135, 25);
            this.lot_id_text.TabIndex = 16;
            // 
            // prod_count_text
            // 
            this.prod_count_text.Location = new System.Drawing.Point(125, 262);
            this.prod_count_text.Name = "prod_count_text";
            this.prod_count_text.Size = new System.Drawing.Size(120, 25);
            this.prod_count_text.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(350, 528);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 24);
            this.label14.TabIndex = 14;
            this.label14.Text = "공장 습도 :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(350, 474);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 24);
            this.label15.TabIndex = 15;
            this.label15.Text = "공장 온도 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(294, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "예상 소요 시간 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(20, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 24);
            this.label12.TabIndex = 8;
            this.label12.Text = "수 량 :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(20, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 24);
            this.label18.TabIndex = 6;
            this.label18.Text = "관리자 id :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(329, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "적정 습도 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(329, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "적정 온도 :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(486, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 24);
            this.label17.TabIndex = 4;
            this.label17.Text = "-";
            this.label17.Click += new System.EventHandler(this.Label4_Click);
            // 
            // line_temp
            // 
            this.line_temp.AutoSize = true;
            this.line_temp.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.line_temp.Location = new System.Drawing.Point(486, 474);
            this.line_temp.Name = "line_temp";
            this.line_temp.Size = new System.Drawing.Size(23, 24);
            this.line_temp.TabIndex = 4;
            this.line_temp.Text = "-";
            this.line_temp.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(180, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "-";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // line_humid
            // 
            this.line_humid.AutoSize = true;
            this.line_humid.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.line_humid.Location = new System.Drawing.Point(486, 528);
            this.line_humid.Name = "line_humid";
            this.line_humid.Size = new System.Drawing.Size(23, 24);
            this.line_humid.TabIndex = 4;
            this.line_humid.Text = "-";
            this.line_humid.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(489, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "-";
            this.label10.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(489, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "-";
            this.label8.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(20, 212);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 24);
            this.label19.TabIndex = 4;
            this.label19.Text = "제품 색상 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(20, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "제품명 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(246, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "작업지시 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(20, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "라인 :";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // line_text
            // 
            this.line_text.FormattingEnabled = true;
            this.line_text.Location = new System.Drawing.Point(100, 81);
            this.line_text.Name = "line_text";
            this.line_text.Size = new System.Drawing.Size(121, 23);
            this.line_text.TabIndex = 2;
            this.line_text.SelectedIndexChanged += new System.EventHandler(this.Line_text_SelectedIndexChanged);
            // 
            // lots_list
            // 
            this.lots_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lots_list.Location = new System.Drawing.Point(637, 31);
            this.lots_list.Name = "lots_list";
            this.lots_list.RowHeadersWidth = 51;
            this.lots_list.RowTemplate.Height = 27;
            this.lots_list.Size = new System.Drawing.Size(547, 547);
            this.lots_list.TabIndex = 2;
            // 
            // Lot_direct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 606);
            this.Controls.Add(this.lots_list);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lot_direct";
            this.Text = "Model";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humid_margin_text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_margin_text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_fail_text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_count_text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lots_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox line_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.NumericUpDown prod_count_text;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label line_temp;
        private System.Windows.Forms.Label line_humid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox model_name_text;
        private System.Windows.Forms.TextBox lot_id_text;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown prod_fail_text;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox model_color_text;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown humid_margin_text;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown temp_margin_text;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView lots_list;
    }
}