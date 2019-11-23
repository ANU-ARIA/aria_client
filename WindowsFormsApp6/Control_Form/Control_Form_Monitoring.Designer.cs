namespace WindowsFormsApp6.Control_Form
{
    partial class Control_Form_Monitoring
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.grid_monitoring = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_monitoring)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox3.Font = new System.Drawing.Font("휴먼엑스포", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(662, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 39);
            this.textBox3.TabIndex = 23;
            this.textBox3.Text = "실시간 모니터링";
            // 
            // grid_monitoring
            // 
            this.grid_monitoring.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_monitoring.Location = new System.Drawing.Point(23, 659);
            this.grid_monitoring.Name = "grid_monitoring";
            this.grid_monitoring.RowHeadersWidth = 51;
            this.grid_monitoring.RowTemplate.Height = 27;
            this.grid_monitoring.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_monitoring.Size = new System.Drawing.Size(1478, 274);
            this.grid_monitoring.TabIndex = 22;
            this.grid_monitoring.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_monitoring_CellMouseDoubleClick);
            // 
            // Control_Form_Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.grid_monitoring);
            this.Name = "Control_Form_Monitoring";
            this.Size = new System.Drawing.Size(1522, 933);
            this.Load += new System.EventHandler(this.Control_Form_Monitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_monitoring)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.DataGridView grid_monitoring;
    }
}
