namespace WindowsFormsApp6.Control_Form
{
    partial class Control_Form_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Form_User));
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.grid_user_select = new System.Windows.Forms.DataGridView();
            this.text_user_select = new System.Windows.Forms.TextBox();
            this.btn_user_select = new System.Windows.Forms.Button();
            this.btn_user_delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_move_user_create_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_user_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(146, 201);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(415, 1);
            this.panel7.TabIndex = 52;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(146, 156);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(40, 39);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 49;
            this.pictureBox8.TabStop = false;
            // 
            // grid_user_select
            // 
            this.grid_user_select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_user_select.Location = new System.Drawing.Point(22, 236);
            this.grid_user_select.Name = "grid_user_select";
            this.grid_user_select.RowHeadersWidth = 51;
            this.grid_user_select.RowTemplate.Height = 27;
            this.grid_user_select.Size = new System.Drawing.Size(1488, 653);
            this.grid_user_select.TabIndex = 68;
            this.grid_user_select.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_user_select_CellClick);
            this.grid_user_select.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_user_select_CellContentClick);
            // 
            // text_user_select
            // 
            this.text_user_select.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.text_user_select.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_user_select.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_user_select.Location = new System.Drawing.Point(192, 168);
            this.text_user_select.Name = "text_user_select";
            this.text_user_select.Size = new System.Drawing.Size(349, 27);
            this.text_user_select.TabIndex = 47;
            // 
            // btn_user_select
            // 
            this.btn_user_select.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_user_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_select.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_user_select.Location = new System.Drawing.Point(567, 161);
            this.btn_user_select.Name = "btn_user_select";
            this.btn_user_select.Size = new System.Drawing.Size(86, 41);
            this.btn_user_select.TabIndex = 67;
            this.btn_user_select.Text = "Select";
            this.btn_user_select.UseVisualStyleBackColor = false;
            this.btn_user_select.Click += new System.EventHandler(this.btn_user_select_Click);
            // 
            // btn_user_delete
            // 
            this.btn_user_delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_user_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_delete.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_user_delete.Location = new System.Drawing.Point(1288, 156);
            this.btn_user_delete.Name = "btn_user_delete";
            this.btn_user_delete.Size = new System.Drawing.Size(86, 41);
            this.btn_user_delete.TabIndex = 66;
            this.btn_user_delete.Text = "Delete";
            this.btn_user_delete.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(720, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btn_move_user_create_update
            // 
            this.btn_move_user_create_update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_move_user_create_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move_user_create_update.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_move_user_create_update.Location = new System.Drawing.Point(1107, 156);
            this.btn_move_user_create_update.Name = "btn_move_user_create_update";
            this.btn_move_user_create_update.Size = new System.Drawing.Size(86, 41);
            this.btn_move_user_create_update.TabIndex = 43;
            this.btn_move_user_create_update.Text = "Create";
            this.btn_move_user_create_update.UseVisualStyleBackColor = false;
            this.btn_move_user_create_update.Click += new System.EventHandler(this.btn_move_user_create_update_Click);
            // 
            // Control_Form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.grid_user_select);
            this.Controls.Add(this.text_user_select);
            this.Controls.Add(this.btn_user_select);
            this.Controls.Add(this.btn_user_delete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_move_user_create_update);
            this.Name = "Control_Form_User";
            this.Size = new System.Drawing.Size(1535, 937);
            this.Load += new System.EventHandler(this.Control_Form_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_user_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DataGridView grid_user_select;
        private System.Windows.Forms.TextBox text_user_select;
        private System.Windows.Forms.Button btn_user_select;
        private System.Windows.Forms.Button btn_user_delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_move_user_create_update;
    }
}
