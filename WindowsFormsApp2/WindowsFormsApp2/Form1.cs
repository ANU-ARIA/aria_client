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
    public partial class Form1 : Form
    {
        Login frm3;
        public Form1()
        {
            InitializeComponent();
            
        }
        public Form1(Login _form3)
        {
            InitializeComponent();
            frm3 = _form3;
            User_id.Text = frm3.textBox1.Text;
            Am1.Text = "";
            Am2.Text = "";
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
            System.DateTime.Now.ToString("yyyy");
            time1.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 tt hh시 mm분");
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lot1.Items.Add("식빵");
            Lot1.Items.Add("카스테라빵");
            Lot1.Items.Add("소보로빵");
            Lot1.Items.Add("크림빵");
            Lot2.Items.Add("식빵");
            Lot2.Items.Add("카스테라빵");
            Lot2.Items.Add("소보로빵");
            Lot2.Items.Add("크림빵");
            Op1.Items.Add("초코");
            Op1.Items.Add("딸기");
            Op1.Items.Add("바나나");
            Op1.Items.Add("메론");
            Op2.Items.Add("초코");
            Op2.Items.Add("딸기");
            Op2.Items.Add("바나나");
            Op2.Items.Add("메론");


        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time1.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 tt hh시 mm분");
        }

        private void Lot1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sel = Lot1.SelectedIndex;
            int sel2 = Op1.SelectedIndex;

            String txt = Lot1.SelectedItem as String;
            String txt2 = Op1.SelectedItem as String;

            if (sel > -1 && sel2 > -1)
            {
                String msg = String.Format(txt);
                String msg2 = String.Format(txt2);

                if (msg == "식빵")
                {
                    if (msg2 == "초코")
                        Code1.Text = "100_1";
                    else if (msg2 == "딸기")
                        Code1.Text = "100_2";
                    else if (msg2 == "바나나")
                        Code1.Text = "100_3";
                    else if (msg2 == "메론")
                        Code1.Text = "100_4";
                }
                else if (msg == "카스테라빵")
                {
                    if (msg2 == "초코")
                        Code1.Text = "101_1";
                    else if (msg2 == "딸기")
                        Code1.Text = "101_2";
                    else if (msg2 == "바나나")
                        Code1.Text = "101_3";
                    else if (msg2 == "메론")
                        Code1.Text = "101_4";
                }
                else if (msg == "소보로빵")
                {
                    if (msg2 == "초코")
                        Code1.Text = "102_1";
                    else if (msg2 == "딸기")
                        Code1.Text = "102_2";
                    else if (msg2 == "바나나")
                        Code1.Text = "102_3";
                    else if (msg2 == "메론")
                        Code1.Text = "102_4";
                }
                else if (msg == "크림빵")
                {
                    if (msg2 == "초코")
                        Code1.Text = "103_1";
                    else if (msg2 == "딸기")
                        Code1.Text = "103_2";
                    else if (msg2 == "바나나")
                        Code1.Text = "103_3";
                    else if (msg2 == "메론")
                        Code1.Text = "103_4";
                }
            }
        }

        private void Lot2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sel = Lot2.SelectedIndex;
            int sel2 = Op2.SelectedIndex;

            String txt = Lot2.SelectedItem as String;
            String txt2 = Op2.SelectedItem as String;

            if (sel > -1 && sel2 > -1)
            {
                String msg = String.Format(txt);
                String msg2 = String.Format(txt2);

                if (msg == "식빵")
                {
                    if (msg2 == "초코")
                        Code2.Text = "100_1";
                    else if (msg2 == "딸기")
                        Code2.Text = "100_2";
                    else if (msg2 == "바나나")
                        Code2.Text = "100_3";
                    else if (msg2 == "메론")
                        Code2.Text = "100_4";
                }
                else if (msg == "카스테라빵")
                {
                    if (msg2 == "초코")
                        Code2.Text = "101_1";
                    else if (msg2 == "딸기")
                        Code2.Text = "101_2";
                    else if (msg2 == "바나나")
                        Code2.Text = "101_3";
                    else if (msg2 == "메론")
                        Code2.Text = "101_4";
                }
                else if (msg == "소보로빵")
                {
                    if (msg2 == "초코")
                        Code2.Text = "102_1";
                    else if (msg2 == "딸기")
                        Code2.Text = "102_2";
                    else if (msg2 == "바나나")
                        Code2.Text = "102_3";
                    else if (msg2 == "메론")
                        Code2.Text = "102_4";
                }
                else if (msg == "크림빵")
                {
                    if (msg2 == "초코")
                        Code2.Text = "103_1";
                    else if (msg2 == "딸기")
                        Code2.Text = "103_2";
                    else if (msg2 == "바나나")
                        Code2.Text = "103_3";
                    else if (msg2 == "메론")
                        Code2.Text = "103_4";
                }
            }
        }

        private void Op1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sel = Lot1.SelectedIndex;
            int sel2 = Op1.SelectedIndex;

            String txt = Lot1.SelectedItem as String;
            String txt2 = Op1.SelectedItem as String;

            if (sel > -1 && sel2 > -1)
            {
                String msg = String.Format(txt);
                String msg2 = String.Format(txt2);

                if (msg == "식빵")
                {
                    if (msg2 == "초코")
                        Code1.Text = "100_1";
                    else if (msg2 == "딸기")
                        Code1.Text = "100_2";
                    else if (msg2 == "바나나")
                        Code1.Text = "100_3";
                    else if (msg2 == "메론")
                        Code1.Text = "100_4";
                }
                else if (msg == "카스테라빵")
                {
                    if (msg2 == "초코")
                        Code1.Text = "101_1";
                    else if (msg2 == "딸기")
                        Code1.Text = "101_2";
                    else if (msg2 == "바나나")
                        Code1.Text = "101_3";
                    else if (msg2 == "메론")
                        Code1.Text = "101_4";
                }
                else if (msg == "소보로빵")
                {
                    if (msg2 == "초코")
                        Code1.Text = "102_1";
                    else if (msg2 == "딸기")
                        Code1.Text = "102_2";
                    else if (msg2 == "바나나")
                        Code1.Text = "102_3";
                    else if (msg2 == "메론")
                        Code1.Text = "102_4";
                }
                else if (msg == "크림빵")
                {
                    if (msg2 == "초코")
                        Code1.Text = "103_1";
                    else if (msg2 == "딸기")
                        Code1.Text = "103_2";
                    else if (msg2 == "바나나")
                        Code1.Text = "103_3";
                    else if (msg2 == "메론")
                        Code1.Text = "103_4";
                }
            }
        }

        private void Op2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sel = Lot2.SelectedIndex;
            int sel2 = Op2.SelectedIndex;

            String txt = Lot2.SelectedItem as String;
            String txt2 = Op2.SelectedItem as String;

            if (sel > -1 && sel2 > -1)
            {
                String msg = String.Format(txt);
                String msg2 = String.Format(txt2);

                if (msg == "식빵")
                {
                    if (msg2 == "초코")
                        Code2.Text = "100_1";
                    else if (msg2 == "딸기")
                        Code2.Text = "100_2";
                    else if (msg2 == "바나나")
                        Code2.Text = "100_3";
                    else if (msg2 == "메론")
                        Code2.Text = "100_4";
                }
                else if (msg == "카스테라빵")
                {
                    if (msg2 == "초코")
                        Code2.Text = "101_1";
                    else if (msg2 == "딸기")
                        Code2.Text = "101_2";
                    else if (msg2 == "바나나")
                        Code2.Text = "101_3";
                    else if (msg2 == "메론")
                        Code2.Text = "101_4";
                }
                else if (msg == "소보로빵")
                {
                    if (msg2 == "초코")
                        Code2.Text = "102_1";
                    else if (msg2 == "딸기")
                        Code2.Text = "102_2";
                    else if (msg2 == "바나나")
                        Code2.Text = "102_3";
                    else if (msg2 == "메론")
                        Code2.Text = "102_4";
                }
                else if (msg == "크림빵")
                {
                    if (msg2 == "초코")
                        Code2.Text = "103_1";
                    else if (msg2 == "딸기")
                        Code2.Text = "103_2";
                    else if (msg2 == "바나나")
                        Code2.Text = "103_3";
                    else if (msg2 == "메론")
                        Code2.Text = "103_4";
                }
            }
        }

        private void Code2_Click(object sender, EventArgs e)
        {

        }

        private void Pro_btn_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this);               //생성자 함수로 frm2만듬
            frm2.ShowDialog();                                        // Show 함수 불러옴
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("종료하시겠습니까?", "종료확인", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login logout = new Login();
            logout.ShowDialog();
        }
    }
}
