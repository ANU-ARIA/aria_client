namespace WindowsFormsApp2
{
    partial class User_set
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
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.TextBox();
            this.pw_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.email_text = new System.Windows.Forms.TextBox();
            this.first_text = new System.Windows.Forms.TextBox();
            this.last_text = new System.Windows.Forms.TextBox();
            this.users_box = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.level_btn1 = new System.Windows.Forms.RadioButton();
            this.level_btn2 = new System.Windows.Forms.RadioButton();
            this.user_view = new System.Windows.Forms.DataGridView();
            this.levet_text = new System.Windows.Forms.TextBox();
            this.id_sc_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.user_view)).BeginInit();
            this.SuspendLayout();
            // 
            // insert
            // 
            this.insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insert.Location = new System.Drawing.Point(287, 524);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 0;
            this.insert.Text = "생성";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete.Location = new System.Drawing.Point(427, 524);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 1;
            this.delete.Text = "삭제";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // update
            // 
            this.update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update.Location = new System.Drawing.Point(580, 524);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 2;
            this.update.Text = "변경";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search.Location = new System.Drawing.Point(1346, 486);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 3;
            this.search.Text = "검색";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "비밀번호";
            // 
            // id_text
            // 
            this.id_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_text.Location = new System.Drawing.Point(362, 109);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(176, 25);
            this.id_text.TabIndex = 6;
            // 
            // pw_text
            // 
            this.pw_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pw_text.Location = new System.Drawing.Point(362, 167);
            this.pw_text.Name = "pw_text";
            this.pw_text.Size = new System.Drawing.Size(176, 25);
            this.pw_text.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "level";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "e_mail";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "first_name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "last_name";
            // 
            // email_text
            // 
            this.email_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email_text.Location = new System.Drawing.Point(362, 295);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(176, 25);
            this.email_text.TabIndex = 13;
            // 
            // first_text
            // 
            this.first_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.first_text.Location = new System.Drawing.Point(362, 356);
            this.first_text.Name = "first_text";
            this.first_text.Size = new System.Drawing.Size(176, 25);
            this.first_text.TabIndex = 14;
            // 
            // last_text
            // 
            this.last_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.last_text.Location = new System.Drawing.Point(362, 416);
            this.last_text.Name = "last_text";
            this.last_text.Size = new System.Drawing.Size(176, 25);
            this.last_text.TabIndex = 15;
            // 
            // users_box
            // 
            this.users_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.users_box.Location = new System.Drawing.Point(596, 109);
            this.users_box.Name = "users_box";
            this.users_box.Size = new System.Drawing.Size(300, 371);
            this.users_box.TabIndex = 17;
            this.users_box.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(679, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "현재 회원목록";
            // 
            // level_btn1
            // 
            this.level_btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.level_btn1.AutoSize = true;
            this.level_btn1.Location = new System.Drawing.Point(369, 237);
            this.level_btn1.Name = "level_btn1";
            this.level_btn1.Size = new System.Drawing.Size(73, 19);
            this.level_btn1.TabIndex = 19;
            this.level_btn1.TabStop = true;
            this.level_btn1.Text = "관리자";
            this.level_btn1.UseVisualStyleBackColor = true;
            // 
            // level_btn2
            // 
            this.level_btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.level_btn2.AutoSize = true;
            this.level_btn2.Location = new System.Drawing.Point(448, 237);
            this.level_btn2.Name = "level_btn2";
            this.level_btn2.Size = new System.Drawing.Size(73, 19);
            this.level_btn2.TabIndex = 19;
            this.level_btn2.TabStop = true;
            this.level_btn2.Text = "사용자";
            this.level_btn2.UseVisualStyleBackColor = true;
            // 
            // user_view
            // 
            this.user_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_view.Location = new System.Drawing.Point(902, 109);
            this.user_view.Name = "user_view";
            this.user_view.RowHeadersWidth = 51;
            this.user_view.RowTemplate.Height = 27;
            this.user_view.Size = new System.Drawing.Size(519, 371);
            this.user_view.TabIndex = 20;
            this.user_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.User_view_CellClick);
            this.user_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.User_view_CellContentClick);
            // 
            // levet_text
            // 
            this.levet_text.Location = new System.Drawing.Point(527, 235);
            this.levet_text.Name = "levet_text";
            this.levet_text.Size = new System.Drawing.Size(52, 25);
            this.levet_text.TabIndex = 21;
            // 
            // id_sc_text
            // 
            this.id_sc_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_sc_text.Location = new System.Drawing.Point(1164, 484);
            this.id_sc_text.Name = "id_sc_text";
            this.id_sc_text.Size = new System.Drawing.Size(176, 25);
            this.id_sc_text.TabIndex = 6;
            // 
            // User_set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 792);
            this.Controls.Add(this.levet_text);
            this.Controls.Add(this.user_view);
            this.Controls.Add(this.level_btn2);
            this.Controls.Add(this.level_btn1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.users_box);
            this.Controls.Add(this.last_text);
            this.Controls.Add(this.first_text);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pw_text);
            this.Controls.Add(this.id_sc_text);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Name = "User_set";
            this.Text = "m1";
            this.Load += new System.EventHandler(this.m1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.TextBox pw_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.TextBox first_text;
        private System.Windows.Forms.TextBox last_text;
        private System.Windows.Forms.RichTextBox users_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton level_btn1;
        private System.Windows.Forms.RadioButton level_btn2;
        private System.Windows.Forms.DataGridView user_view;
        private System.Windows.Forms.TextBox levet_text;
        private System.Windows.Forms.TextBox id_sc_text;
    }
}