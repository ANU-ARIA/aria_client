using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 _form)
        {
            InitializeComponent();
            frm1 = _form;
            textBox1.Text = frm1.Lin1.Text;
            textBox2.Text = frm1.Lot1.Text;
            textBox3.Text = frm1.Op1.Text;
            textBox4.Text = frm1.Am1.Text;
            textBox5.Text = frm1.Code1.Text;
            textBox6.Text = "10분39초";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            /* 클래스 나누는거랑 함수 선언 하는방법
            LotStartInfo lot_info;
            MesLotExecResult result = mes_com.req_lot_exec(lot_info);

            if (result.result == "OK")
            {
                // 
            }
            else
            {
                error_msg.text_out("result.ng_reason);
                return;
            }
            */
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
