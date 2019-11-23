namespace WindowsFormsApp6.Control_Form
{
    partial class Control_Form_Model
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Form_Model));
            this.grid_model_select = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_move_model_create_update = new System.Windows.Forms.Button();
            this.btn_model_delete = new System.Windows.Forms.Button();
            this.btn_model_select = new System.Windows.Forms.Button();
            this.text_model_select = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_model_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_model_select
            // 
            this.grid_model_select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_model_select.Location = new System.Drawing.Point(23, 247);
            this.grid_model_select.Name = "grid_model_select";
            this.grid_model_select.RowHeadersWidth = 51;
            this.grid_model_select.RowTemplate.Height = 27;
            this.grid_model_select.Size = new System.Drawing.Size(1489, 653);
            this.grid_model_select.TabIndex = 74;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(1656, 570);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 41);
            this.button3.TabIndex = 69;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(184, 191);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(415, 1);
            this.panel7.TabIndex = 73;
            // 
            // btn_move_model_create_update
            // 
            this.btn_move_model_create_update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_move_model_create_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move_model_create_update.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_move_model_create_update.Location = new System.Drawing.Point(1155, 151);
            this.btn_move_model_create_update.Name = "btn_move_model_create_update";
            this.btn_move_model_create_update.Size = new System.Drawing.Size(86, 41);
            this.btn_move_model_create_update.TabIndex = 67;
            this.btn_move_model_create_update.Text = "Create";
            this.btn_move_model_create_update.UseVisualStyleBackColor = false;
            this.btn_move_model_create_update.Click += new System.EventHandler(this.btn_move_model_create_update_Click);
            // 
            // btn_model_delete
            // 
            this.btn_model_delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_model_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_model_delete.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_model_delete.Location = new System.Drawing.Point(1329, 151);
            this.btn_model_delete.Name = "btn_model_delete";
            this.btn_model_delete.Size = new System.Drawing.Size(86, 41);
            this.btn_model_delete.TabIndex = 70;
            this.btn_model_delete.Text = "Delete";
            this.btn_model_delete.UseVisualStyleBackColor = false;
            this.btn_model_delete.Click += new System.EventHandler(this.btn_model_delete_Click);
            // 
            // btn_model_select
            // 
            this.btn_model_select.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_model_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_model_select.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_model_select.Location = new System.Drawing.Point(610, 151);
            this.btn_model_select.Name = "btn_model_select";
            this.btn_model_select.Size = new System.Drawing.Size(86, 41);
            this.btn_model_select.TabIndex = 68;
            this.btn_model_select.Text = "Select";
            this.btn_model_select.UseVisualStyleBackColor = false;
            this.btn_model_select.Click += new System.EventHandler(this.btn_model_select_Click);
            // 
            // text_model_select
            // 
            this.text_model_select.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.text_model_select.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_model_select.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_model_select.Location = new System.Drawing.Point(184, 158);
            this.text_model_select.Name = "text_model_select";
            this.text_model_select.Size = new System.Drawing.Size(349, 27);
            this.text_model_select.TabIndex = 71;
            this.text_model_select.Text = "Model List";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(126, 143);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(40, 39);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 72;
            this.pictureBox8.TabStop = false;
            // 
            // Control_Form_Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.grid_model_select);
            this.Controls.Add(this.text_model_select);
            this.Controls.Add(this.btn_model_select);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_model_delete);
            this.Controls.Add(this.btn_move_model_create_update);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Control_Form_Model";
            this.Size = new System.Drawing.Size(1538, 918);
            this.Load += new System.EventHandler(this.Control_Form_Model_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_model_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grid_model_select;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_move_model_create_update;
        private System.Windows.Forms.Button btn_model_delete;
        private System.Windows.Forms.Button btn_model_select;
        private System.Windows.Forms.TextBox text_model_select;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}
