namespace WindowsFormsApp2
{
    partial class Model_set
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.model_temp_text = new System.Windows.Forms.TextBox();
            this.models_box = new System.Windows.Forms.RichTextBox();
            this.search = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.model_name_text = new System.Windows.Forms.TextBox();
            this.model_humidity_text = new System.Windows.Forms.TextBox();
            this.model_id_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.model_view = new System.Windows.Forms.DataGridView();
            this.model_id_sch_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.model_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1023, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "모델목록";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(484, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "수정과 삭제는 모델 id 입력 후 버튼 클릭.";
            // 
            // model_temp_text
            // 
            this.model_temp_text.Location = new System.Drawing.Point(276, 238);
            this.model_temp_text.Name = "model_temp_text";
            this.model_temp_text.Size = new System.Drawing.Size(172, 25);
            this.model_temp_text.TabIndex = 37;
            // 
            // models_box
            // 
            this.models_box.Location = new System.Drawing.Point(899, 50);
            this.models_box.Name = "models_box";
            this.models_box.Size = new System.Drawing.Size(311, 263);
            this.models_box.TabIndex = 36;
            this.models_box.Text = "";
            this.models_box.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(1265, 553);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 35;
            this.search.Text = "검색";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(538, 441);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 34;
            this.update.Text = "변경";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(350, 441);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 33;
            this.delete.Text = "삭제";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(177, 441);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 32;
            this.insert.Text = "생성";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // model_name_text
            // 
            this.model_name_text.Location = new System.Drawing.Point(276, 370);
            this.model_name_text.Name = "model_name_text";
            this.model_name_text.Size = new System.Drawing.Size(172, 25);
            this.model_name_text.TabIndex = 31;
            // 
            // model_humidity_text
            // 
            this.model_humidity_text.Location = new System.Drawing.Point(276, 306);
            this.model_humidity_text.Name = "model_humidity_text";
            this.model_humidity_text.Size = new System.Drawing.Size(172, 25);
            this.model_humidity_text.TabIndex = 30;
            // 
            // model_id_text
            // 
            this.model_id_text.Location = new System.Drawing.Point(276, 170);
            this.model_id_text.Name = "model_id_text";
            this.model_id_text.Size = new System.Drawing.Size(172, 25);
            this.model_id_text.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "제품명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "적정습도";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "적정온도";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "모델 id";
            // 
            // model_view
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.model_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.model_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.model_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.model_view.Location = new System.Drawing.Point(899, 339);
            this.model_view.Name = "model_view";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.model_view.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.model_view.RowHeadersWidth = 51;
            this.model_view.RowTemplate.Height = 27;
            this.model_view.Size = new System.Drawing.Size(441, 208);
            this.model_view.TabIndex = 42;
            this.model_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Model_view_CellClick);
            this.model_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // model_id_sch_text
            // 
            this.model_id_sch_text.Location = new System.Drawing.Point(1087, 551);
            this.model_id_sch_text.Name = "model_id_sch_text";
            this.model_id_sch_text.Size = new System.Drawing.Size(172, 25);
            this.model_id_sch_text.TabIndex = 27;
            // 
            // Model_set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 690);
            this.Controls.Add(this.model_view);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.model_temp_text);
            this.Controls.Add(this.models_box);
            this.Controls.Add(this.search);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.model_name_text);
            this.Controls.Add(this.model_humidity_text);
            this.Controls.Add(this.model_id_sch_text);
            this.Controls.Add(this.model_id_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Model_set";
            this.Text = "m2";
            this.Load += new System.EventHandler(this.Model_set_Load);
            ((System.ComponentModel.ISupportInitialize)(this.model_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox model_temp_text;
        private System.Windows.Forms.RichTextBox models_box;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.TextBox model_name_text;
        private System.Windows.Forms.TextBox model_humidity_text;
        private System.Windows.Forms.TextBox model_id_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView model_view;
        private System.Windows.Forms.TextBox model_id_sch_text;
    }
}