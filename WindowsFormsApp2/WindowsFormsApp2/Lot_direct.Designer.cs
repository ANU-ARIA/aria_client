﻿namespace WindowsFormsApp2
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
            this.numbox_humid_margin = new System.Windows.Forms.NumericUpDown();
            this.btn_add_delete = new System.Windows.Forms.Button();
            this.btn_add_insert = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_model_id = new System.Windows.Forms.Label();
            this.numbox_temp_margin = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.numbox_prod_fail = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.combox_model_color = new System.Windows.Forms.ComboBox();
            this.combox_model_name = new System.Windows.Forms.ComboBox();
            this.txtbox_lot_id = new System.Windows.Forms.TextBox();
            this.numbox_prod_count = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_pd_speed = new System.Windows.Forms.Label();
            this.txtbox_model_humid = new System.Windows.Forms.Label();
            this.txtbox_model_temp = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combox_line_id = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.line_temp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.line_humid = new System.Windows.Forms.Label();
            this.lots_list = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_humid_margin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_temp_margin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_prod_fail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_prod_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lots_list)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numbox_humid_margin);
            this.groupBox1.Controls.Add(this.btn_add_delete);
            this.groupBox1.Controls.Add(this.btn_add_insert);
            this.groupBox1.Controls.Add(this.btn_insert);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtbox_model_id);
            this.groupBox1.Controls.Add(this.numbox_temp_margin);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.numbox_prod_fail);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.combox_model_color);
            this.groupBox1.Controls.Add(this.combox_model_name);
            this.groupBox1.Controls.Add(this.txtbox_lot_id);
            this.groupBox1.Controls.Add(this.numbox_prod_count);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtbox_pd_speed);
            this.groupBox1.Controls.Add(this.txtbox_model_humid);
            this.groupBox1.Controls.Add(this.txtbox_model_temp);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combox_line_id);
            this.groupBox1.Location = new System.Drawing.Point(10, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 682);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "작업 지시";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // numbox_humid_margin
            // 
            this.numbox_humid_margin.Location = new System.Drawing.Point(184, 435);
            this.numbox_humid_margin.Name = "numbox_humid_margin";
            this.numbox_humid_margin.Size = new System.Drawing.Size(120, 25);
            this.numbox_humid_margin.TabIndex = 22;
            // 
            // btn_add_delete
            // 
            this.btn_add_delete.Location = new System.Drawing.Point(184, 560);
            this.btn_add_delete.Name = "btn_add_delete";
            this.btn_add_delete.Size = new System.Drawing.Size(150, 46);
            this.btn_add_delete.TabIndex = 0;
            this.btn_add_delete.Text = "예약 삭제";
            this.btn_add_delete.UseVisualStyleBackColor = true;
            this.btn_add_delete.Click += new System.EventHandler(this.insert_Click);
            // 
            // btn_add_insert
            // 
            this.btn_add_insert.Location = new System.Drawing.Point(24, 560);
            this.btn_add_insert.Name = "btn_add_insert";
            this.btn_add_insert.Size = new System.Drawing.Size(150, 46);
            this.btn_add_insert.TabIndex = 0;
            this.btn_add_insert.Text = "예약 지시";
            this.btn_add_insert.UseVisualStyleBackColor = true;
            this.btn_add_insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(24, 499);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(150, 46);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "작업 지시";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.insert_Click);
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
            this.label6.Location = new System.Drawing.Point(397, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "제품 코드 :";
            // 
            // txtbox_model_id
            // 
            this.txtbox_model_id.AutoSize = true;
            this.txtbox_model_id.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_model_id.Location = new System.Drawing.Point(557, 511);
            this.txtbox_model_id.Name = "txtbox_model_id";
            this.txtbox_model_id.Size = new System.Drawing.Size(23, 24);
            this.txtbox_model_id.TabIndex = 4;
            this.txtbox_model_id.Text = "-";
            this.txtbox_model_id.Click += new System.EventHandler(this.Label4_Click);
            // 
            // numbox_temp_margin
            // 
            this.numbox_temp_margin.Location = new System.Drawing.Point(184, 375);
            this.numbox_temp_margin.Name = "numbox_temp_margin";
            this.numbox_temp_margin.Size = new System.Drawing.Size(120, 25);
            this.numbox_temp_margin.TabIndex = 20;
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
            // numbox_prod_fail
            // 
            this.numbox_prod_fail.Location = new System.Drawing.Point(184, 314);
            this.numbox_prod_fail.Name = "numbox_prod_fail";
            this.numbox_prod_fail.Size = new System.Drawing.Size(120, 25);
            this.numbox_prod_fail.TabIndex = 18;
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
            // combox_model_color
            // 
            this.combox_model_color.FormattingEnabled = true;
            this.combox_model_color.Location = new System.Drawing.Point(156, 212);
            this.combox_model_color.Name = "combox_model_color";
            this.combox_model_color.Size = new System.Drawing.Size(121, 23);
            this.combox_model_color.TabIndex = 17;
            // 
            // combox_model_name
            // 
            this.combox_model_name.FormattingEnabled = true;
            this.combox_model_name.Location = new System.Drawing.Point(124, 142);
            this.combox_model_name.Name = "combox_model_name";
            this.combox_model_name.Size = new System.Drawing.Size(121, 23);
            this.combox_model_name.TabIndex = 17;
            // 
            // txtbox_lot_id
            // 
            this.txtbox_lot_id.Location = new System.Drawing.Point(374, 81);
            this.txtbox_lot_id.Name = "txtbox_lot_id";
            this.txtbox_lot_id.Size = new System.Drawing.Size(135, 25);
            this.txtbox_lot_id.TabIndex = 16;
            // 
            // numbox_prod_count
            // 
            this.numbox_prod_count.Location = new System.Drawing.Point(125, 262);
            this.numbox_prod_count.Name = "numbox_prod_count";
            this.numbox_prod_count.Size = new System.Drawing.Size(120, 25);
            this.numbox_prod_count.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(362, 461);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(397, 623);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "적정 습도 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(397, 569);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "적정 온도 :";
            // 
            // txtbox_pd_speed
            // 
            this.txtbox_pd_speed.AutoSize = true;
            this.txtbox_pd_speed.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_pd_speed.Location = new System.Drawing.Point(554, 461);
            this.txtbox_pd_speed.Name = "txtbox_pd_speed";
            this.txtbox_pd_speed.Size = new System.Drawing.Size(23, 24);
            this.txtbox_pd_speed.TabIndex = 4;
            this.txtbox_pd_speed.Text = "-";
            this.txtbox_pd_speed.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtbox_model_humid
            // 
            this.txtbox_model_humid.AutoSize = true;
            this.txtbox_model_humid.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_model_humid.Location = new System.Drawing.Point(557, 623);
            this.txtbox_model_humid.Name = "txtbox_model_humid";
            this.txtbox_model_humid.Size = new System.Drawing.Size(23, 24);
            this.txtbox_model_humid.TabIndex = 4;
            this.txtbox_model_humid.Text = "-";
            this.txtbox_model_humid.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtbox_model_temp
            // 
            this.txtbox_model_temp.AutoSize = true;
            this.txtbox_model_temp.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_model_temp.Location = new System.Drawing.Point(557, 569);
            this.txtbox_model_temp.Name = "txtbox_model_temp";
            this.txtbox_model_temp.Size = new System.Drawing.Size(23, 24);
            this.txtbox_model_temp.TabIndex = 4;
            this.txtbox_model_temp.Text = "-";
            this.txtbox_model_temp.Click += new System.EventHandler(this.Label4_Click);
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
            // combox_line_id
            // 
            this.combox_line_id.FormattingEnabled = true;
            this.combox_line_id.Location = new System.Drawing.Point(100, 81);
            this.combox_line_id.Name = "combox_line_id";
            this.combox_line_id.Size = new System.Drawing.Size(121, 23);
            this.combox_line_id.TabIndex = 2;
            this.combox_line_id.SelectedIndexChanged += new System.EventHandler(this.Line_text_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(1389, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 24);
            this.label14.TabIndex = 14;
            this.label14.Text = "공장 습도 :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(1224, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 24);
            this.label15.TabIndex = 15;
            this.label15.Text = "공장 온도 :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(1019, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 24);
            this.label18.TabIndex = 6;
            this.label18.Text = "관리자 id :";
            // 
            // line_temp
            // 
            this.line_temp.AutoSize = true;
            this.line_temp.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.line_temp.Location = new System.Drawing.Point(1360, 9);
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
            this.label4.Location = new System.Drawing.Point(1148, 9);
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
            this.line_humid.Location = new System.Drawing.Point(1525, 9);
            this.line_humid.Name = "line_humid";
            this.line_humid.Size = new System.Drawing.Size(23, 24);
            this.line_humid.TabIndex = 4;
            this.line_humid.Text = "-";
            this.line_humid.Click += new System.EventHandler(this.Label4_Click);
            // 
            // lots_list
            // 
            this.lots_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lots_list.Location = new System.Drawing.Point(1203, 77);
            this.lots_list.Name = "lots_list";
            this.lots_list.RowHeadersWidth = 51;
            this.lots_list.RowTemplate.Height = 27;
            this.lots_list.Size = new System.Drawing.Size(339, 682);
            this.lots_list.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(616, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(581, 682);
            this.textBox1.TabIndex = 3;
            // 
            // Lot_direct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 771);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lots_list);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.line_humid);
            this.Controls.Add(this.line_temp);
            this.Controls.Add(this.label14);
            this.Name = "Lot_direct";
            this.Text = "Model";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_humid_margin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_temp_margin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_prod_fail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_prod_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lots_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combox_line_id;
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
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.NumericUpDown numbox_prod_count;
        private System.Windows.Forms.Label txtbox_pd_speed;
        private System.Windows.Forms.Label line_temp;
        private System.Windows.Forms.Label line_humid;
        private System.Windows.Forms.Label txtbox_model_humid;
        private System.Windows.Forms.Label txtbox_model_temp;
        private System.Windows.Forms.Label txtbox_model_id;
        private System.Windows.Forms.ComboBox combox_model_name;
        private System.Windows.Forms.TextBox txtbox_lot_id;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numbox_prod_fail;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox combox_model_color;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numbox_humid_margin;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown numbox_temp_margin;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView lots_list;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_add_delete;
        private System.Windows.Forms.Button btn_add_insert;
    }
}