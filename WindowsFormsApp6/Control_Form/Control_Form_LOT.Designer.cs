namespace WindowsFormsApp6.Control_Form
{
    partial class Control_Form_LOT
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
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.com_color = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.com_line = new System.Windows.Forms.ComboBox();
            this.txt_humid = new System.Windows.Forms.TextBox();
            this.txt_temp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.text_select_lot = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.combo_model_name = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_model_humid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_model_temp = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_lot_failrate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_lot_speed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_lot_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_lot_lot = new System.Windows.Forms.TextBox();
            this.grid_lot_select = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_lot_select)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(76)))), ((int)(((byte)(111)))));
            this.textBox11.Font = new System.Drawing.Font("휴먼엑스포", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox11.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox11.Location = new System.Drawing.Point(638, 471);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(248, 39);
            this.textBox11.TabIndex = 16;
            this.textBox11.Text = "      Lot List";
            // 
            // com_color
            // 
            this.com_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.com_color.FormattingEnabled = true;
            this.com_color.Location = new System.Drawing.Point(374, 154);
            this.com_color.Name = "com_color";
            this.com_color.Size = new System.Drawing.Size(363, 23);
            this.com_color.TabIndex = 18;
            this.com_color.SelectedIndexChanged += new System.EventHandler(this.com_color_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(179)))), ((int)(((byte)(92)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1116, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(366, 57);
            this.button4.TabIndex = 17;
            this.button4.Text = "PI로 전송";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // com_line
            // 
            this.com_line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.com_line.FormattingEnabled = true;
            this.com_line.Location = new System.Drawing.Point(374, 106);
            this.com_line.Name = "com_line";
            this.com_line.Size = new System.Drawing.Size(363, 23);
            this.com_line.TabIndex = 17;
            this.com_line.SelectedIndexChanged += new System.EventHandler(this.com_line_SelectedIndexChanged);
            // 
            // txt_humid
            // 
            this.txt_humid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_humid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_humid.Location = new System.Drawing.Point(1114, 102);
            this.txt_humid.Name = "txt_humid";
            this.txt_humid.Size = new System.Drawing.Size(364, 25);
            this.txt_humid.TabIndex = 29;
            // 
            // txt_temp
            // 
            this.txt_temp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_temp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_temp.Location = new System.Drawing.Point(1114, 55);
            this.txt_temp.Name = "txt_temp";
            this.txt_temp.Size = new System.Drawing.Size(364, 25);
            this.txt_temp.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(744, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(363, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "적정 습도";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(744, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(363, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "적정 온도";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(363, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "선택된 Lot";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_select_lot
            // 
            this.text_select_lot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_select_lot.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_select_lot.Location = new System.Drawing.Point(374, 10);
            this.text_select_lot.Name = "text_select_lot";
            this.text_select_lot.Size = new System.Drawing.Size(363, 25);
            this.text_select_lot.TabIndex = 24;
            this.text_select_lot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(179)))), ((int)(((byte)(92)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(365, 57);
            this.button3.TabIndex = 23;
            this.button3.Text = "Lot 검색";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // combo_model_name
            // 
            this.combo_model_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_model_name.FormattingEnabled = true;
            this.combo_model_name.Location = new System.Drawing.Point(374, 59);
            this.combo_model_name.Name = "combo_model_name";
            this.combo_model_name.Size = new System.Drawing.Size(363, 23);
            this.combo_model_name.TabIndex = 22;
            this.combo_model_name.SelectedIndexChanged += new System.EventHandler(this.combo_model_name_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(4, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(363, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "모델 습도";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_model_humid
            // 
            this.txt_model_humid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_model_humid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_model_humid.Location = new System.Drawing.Point(374, 102);
            this.txt_model_humid.Name = "txt_model_humid";
            this.txt_model_humid.Size = new System.Drawing.Size(363, 25);
            this.txt_model_humid.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(4, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(363, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "모델 온도";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_model_temp
            // 
            this.txt_model_temp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_model_temp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_model_temp.Location = new System.Drawing.Point(374, 55);
            this.txt_model_temp.Name = "txt_model_temp";
            this.txt_model_temp.Size = new System.Drawing.Size(363, 25);
            this.txt_model_temp.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(179)))), ((int)(((byte)(92)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(374, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(365, 57);
            this.button2.TabIndex = 15;
            this.button2.Text = "작업 시작";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(179)))), ((int)(((byte)(92)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(745, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 57);
            this.button1.TabIndex = 14;
            this.button1.Text = "작업지시 추가";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(4, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(363, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "제품 색상";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(744, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(363, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "불량률";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_lot_failrate
            // 
            this.text_lot_failrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_lot_failrate.Location = new System.Drawing.Point(1114, 58);
            this.text_lot_failrate.Name = "text_lot_failrate";
            this.text_lot_failrate.Size = new System.Drawing.Size(364, 25);
            this.text_lot_failrate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(744, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "생산속도";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_lot_speed
            // 
            this.text_lot_speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_lot_speed.Location = new System.Drawing.Point(1114, 153);
            this.text_lot_speed.Name = "text_lot_speed";
            this.text_lot_speed.Size = new System.Drawing.Size(364, 25);
            this.text_lot_speed.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(744, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "생산량";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_lot_amount
            // 
            this.text_lot_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_lot_amount.Location = new System.Drawing.Point(1114, 105);
            this.text_lot_amount.Name = "text_lot_amount";
            this.text_lot_amount.Size = new System.Drawing.Size(364, 25);
            this.text_lot_amount.TabIndex = 4;
            /*this.text_lot_amount.TextChanged += new System.EventHandler(this.text_lot_amount_TextChanged);*/
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "라인 id";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "모델 id";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "작업지시";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_lot_lot
            // 
            this.text_lot_lot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_lot_lot.Location = new System.Drawing.Point(374, 11);
            this.text_lot_lot.Name = "text_lot_lot";
            this.text_lot_lot.Size = new System.Drawing.Size(363, 25);
            this.text_lot_lot.TabIndex = 0;
            // 
            // grid_lot_select
            // 
            this.grid_lot_select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_lot_select.Location = new System.Drawing.Point(20, 540);
            this.grid_lot_select.Name = "grid_lot_select";
            this.grid_lot_select.RowHeadersWidth = 51;
            this.grid_lot_select.RowTemplate.Height = 27;
            this.grid_lot_select.Size = new System.Drawing.Size(1485, 346);
            this.grid_lot_select.TabIndex = 13;
            this.grid_lot_select.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_lot_select_CellContentClick);
            this.grid_lot_select.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_lot_select_CellContentDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1485, 63);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.com_color, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.com_line, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.text_lot_lot, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.combo_model_name, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.text_lot_amount, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.text_lot_failrate, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.text_lot_speed, 3, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 96);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1482, 191);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.txt_humid, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label14, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.txt_temp, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.text_select_lot, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_model_temp, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_model_humid, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 313);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1482, 139);
            this.tableLayoutPanel3.TabIndex = 18;
            /*this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);*/
            // 
            // Control_Form_LOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.grid_lot_select);
            this.Controls.Add(this.textBox11);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Control_Form_LOT";
            this.Size = new System.Drawing.Size(1525, 897);
            this.Load += new System.EventHandler(this.Control_Form_LOT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_lot_select)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_lot_failrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_lot_speed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_lot_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_lot_lot;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_model_humid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_model_temp;
        private System.Windows.Forms.DataGridView grid_lot_select;
        private System.Windows.Forms.ComboBox combo_model_name;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox text_select_lot;
        private System.Windows.Forms.TextBox txt_humid;
        private System.Windows.Forms.TextBox txt_temp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox com_line;
        private System.Windows.Forms.ComboBox com_color;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
