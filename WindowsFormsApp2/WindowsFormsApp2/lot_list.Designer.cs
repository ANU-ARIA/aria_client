namespace WindowsFormsApp2
{
    partial class Lot_list
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datetime_box = new System.Windows.Forms.CheckBox();
            this.oper_id_box = new System.Windows.Forms.CheckBox();
            this.model_name_box = new System.Windows.Forms.CheckBox();
            this.line_box = new System.Windows.Forms.CheckBox();
            this.search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.model_name_text = new System.Windows.Forms.ComboBox();
            this.line_text = new System.Windows.Forms.ComboBox();
            this.oper_id_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datetime_box);
            this.groupBox1.Controls.Add(this.oper_id_box);
            this.groupBox1.Controls.Add(this.model_name_box);
            this.groupBox1.Controls.Add(this.line_box);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.model_name_text);
            this.groupBox1.Controls.Add(this.line_text);
            this.groupBox1.Controls.Add(this.oper_id_text);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "작업 이력 list";
            // 
            // datetime_box
            // 
            this.datetime_box.AutoSize = true;
            this.datetime_box.Location = new System.Drawing.Point(29, 231);
            this.datetime_box.Name = "datetime_box";
            this.datetime_box.Size = new System.Drawing.Size(18, 17);
            this.datetime_box.TabIndex = 6;
            this.datetime_box.UseVisualStyleBackColor = true;
            this.datetime_box.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // oper_id_box
            // 
            this.oper_id_box.AutoSize = true;
            this.oper_id_box.Location = new System.Drawing.Point(29, 185);
            this.oper_id_box.Name = "oper_id_box";
            this.oper_id_box.Size = new System.Drawing.Size(18, 17);
            this.oper_id_box.TabIndex = 6;
            this.oper_id_box.UseVisualStyleBackColor = true;
            this.oper_id_box.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // model_name_box
            // 
            this.model_name_box.AutoSize = true;
            this.model_name_box.Location = new System.Drawing.Point(29, 134);
            this.model_name_box.Name = "model_name_box";
            this.model_name_box.Size = new System.Drawing.Size(18, 17);
            this.model_name_box.TabIndex = 6;
            this.model_name_box.UseVisualStyleBackColor = true;
            // 
            // line_box
            // 
            this.line_box.AutoSize = true;
            this.line_box.Location = new System.Drawing.Point(29, 85);
            this.line_box.Name = "line_box";
            this.line_box.Size = new System.Drawing.Size(18, 17);
            this.line_box.TabIndex = 6;
            this.line_box.UseVisualStyleBackColor = true;
            this.line_box.CheckedChanged += new System.EventHandler(this.Line_box_CheckedChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(29, 318);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(539, 102);
            this.search.TabIndex = 5;
            this.search.Text = "검색";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(333, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "~";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(368, 224);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // model_name_text
            // 
            this.model_name_text.FormattingEnabled = true;
            this.model_name_text.Location = new System.Drawing.Point(159, 130);
            this.model_name_text.Name = "model_name_text";
            this.model_name_text.Size = new System.Drawing.Size(121, 23);
            this.model_name_text.TabIndex = 2;
            // 
            // line_text
            // 
            this.line_text.FormattingEnabled = true;
            this.line_text.Location = new System.Drawing.Point(121, 79);
            this.line_text.Name = "line_text";
            this.line_text.Size = new System.Drawing.Size(121, 23);
            this.line_text.TabIndex = 2;
            // 
            // oper_id_text
            // 
            this.oper_id_text.Location = new System.Drawing.Point(183, 184);
            this.oper_id_text.Name = "oper_id_text";
            this.oper_id_text.Size = new System.Drawing.Size(121, 25);
            this.oper_id_text.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(63, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "날짜";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(63, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "작업자 명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(63, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "모델 명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(63, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Line";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(637, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(512, 437);
            this.dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Lot_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 470);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lot_list";
            this.Text = "lot_list";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox model_name_text;
        private System.Windows.Forms.ComboBox line_text;
        private System.Windows.Forms.TextBox oper_id_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox oper_id_box;
        private System.Windows.Forms.CheckBox model_name_box;
        private System.Windows.Forms.CheckBox line_box;
        private System.Windows.Forms.CheckBox datetime_box;
    }
}