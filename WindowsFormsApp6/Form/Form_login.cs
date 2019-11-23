using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form_login : Form
    {
        public static string use_level;
        public static string name_level;
        public static string oper_name;
        public Form_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form_main_menu mainmenu = new Form_main_menu(this);
            string respon = "";
            Set.Login lo = new Set.Login();
            respon = lo.Log_In(text_id.Text, text_pass.Text);
            string[] respon_division = respon.Split(new char[] { ',' });
            if (respon_division[0] == "OK")
            {
                this.Visible = false;
                MessageBox.Show(respon_division[1] + "님 환영합니다!");
                use_level = respon_division[3];
                if(use_level == "1")
                {
                    name_level = respon_division[1] + "님 (관리자)";
                    oper_name = respon_division[1];
                    mainmenu.btn_Lot_set.Enabled = false;
                    mainmenu.btn_Monitoring_set.Enabled = false;
                    mainmenu.btn_Fail_set.Enabled = false;
                    mainmenu.btn_Pass_set.Enabled = false;
                }
                else
                {
                    name_level = respon_division[1] + "님 (작업자)";
                    mainmenu.btn_User_set.Enabled = false;
                    mainmenu.btn_Model_set.Enabled = false;
                    mainmenu.btn_Line_set.Enabled = false;
                    oper_name = respon_division[1];

                }
                
                mainmenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 잘못되었습니다.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Aria Mes System을 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }
    }
}
