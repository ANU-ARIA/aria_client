namespace WindowsFormsApp6
{
    partial class ex
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.text_claerspeed = new System.Windows.Forms.TextBox();
            this.text_speed = new System.Windows.Forms.TextBox();
            this.text_fin = new System.Windows.Forms.TextBox();
            this.text_ing = new System.Windows.Forms.TextBox();
            this.text_amount = new System.Windows.Forms.TextBox();
            this.text_modelname = new System.Windows.Forms.TextBox();
            this.text_lot = new System.Windows.Forms.TextBox();
            this.text_line = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.circularProgressBar1);
            this.panel1.Controls.Add(this.text_claerspeed);
            this.panel1.Controls.Add(this.text_speed);
            this.panel1.Controls.Add(this.text_fin);
            this.panel1.Controls.Add(this.text_ing);
            this.panel1.Controls.Add(this.text_amount);
            this.panel1.Controls.Add(this.text_modelname);
            this.panel1.Controls.Add(this.text_lot);
            this.panel1.Controls.Add(this.text_line);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(129, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 503);
            this.panel1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(459, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(406, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "실시간 생산";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(397, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "현재 생산량";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("굴림체", 30F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.SystemColors.ControlDark;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(377, 229);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Blue;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("굴림", 24F);
            this.circularProgressBar1.Size = new System.Drawing.Size(215, 205);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 11;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // text_claerspeed
            // 
            this.text_claerspeed.Location = new System.Drawing.Point(1018, 279);
            this.text_claerspeed.Multiline = true;
            this.text_claerspeed.Name = "text_claerspeed";
            this.text_claerspeed.Size = new System.Drawing.Size(203, 77);
            this.text_claerspeed.TabIndex = 10;
            // 
            // text_speed
            // 
            this.text_speed.Location = new System.Drawing.Point(809, 270);
            this.text_speed.Multiline = true;
            this.text_speed.Name = "text_speed";
            this.text_speed.Size = new System.Drawing.Size(203, 77);
            this.text_speed.TabIndex = 9;
            // 
            // text_fin
            // 
            this.text_fin.Location = new System.Drawing.Point(625, 270);
            this.text_fin.Multiline = true;
            this.text_fin.Name = "text_fin";
            this.text_fin.Size = new System.Drawing.Size(178, 77);
            this.text_fin.TabIndex = 8;
            // 
            // text_ing
            // 
            this.text_ing.Location = new System.Drawing.Point(72, 397);
            this.text_ing.Multiline = true;
            this.text_ing.Name = "text_ing";
            this.text_ing.Size = new System.Drawing.Size(178, 77);
            this.text_ing.TabIndex = 7;
            // 
            // text_amount
            // 
            this.text_amount.Location = new System.Drawing.Point(72, 299);
            this.text_amount.Multiline = true;
            this.text_amount.Name = "text_amount";
            this.text_amount.Size = new System.Drawing.Size(178, 48);
            this.text_amount.TabIndex = 6;
            this.text_amount.Text = "지시 수량 : 10";
            // 
            // text_modelname
            // 
            this.text_modelname.Location = new System.Drawing.Point(72, 215);
            this.text_modelname.Multiline = true;
            this.text_modelname.Name = "text_modelname";
            this.text_modelname.Size = new System.Drawing.Size(178, 48);
            this.text_modelname.TabIndex = 5;
            // 
            // text_lot
            // 
            this.text_lot.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_lot.Location = new System.Drawing.Point(1007, 202);
            this.text_lot.Multiline = true;
            this.text_lot.Name = "text_lot";
            this.text_lot.Size = new System.Drawing.Size(173, 55);
            this.text_lot.TabIndex = 3;
            // 
            // text_line
            // 
            this.text_line.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_line.Location = new System.Drawing.Point(702, 202);
            this.text_line.Multiline = true;
            this.text_line.Name = "text_line";
            this.text_line.Size = new System.Drawing.Size(173, 55);
            this.text_line.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "라인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(917, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "작업지시";
            // 
            // ex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 763);
            this.Controls.Add(this.panel1);
            this.Name = "ex";
            this.Text = "ex";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        public System.Windows.Forms.TextBox text_claerspeed;
        public System.Windows.Forms.TextBox text_speed;
        public System.Windows.Forms.TextBox text_fin;
        public System.Windows.Forms.TextBox text_ing;
        public System.Windows.Forms.TextBox text_amount;
        public System.Windows.Forms.TextBox text_modelname;
        public System.Windows.Forms.TextBox text_lot;
        public System.Windows.Forms.TextBox text_line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}