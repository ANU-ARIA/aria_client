using WindowsFormsApp6.Control_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Thread_Class;
using System.Threading;

namespace WindowsFormsApp6
{
    public partial class Form_main_menu : Form
    {
        public static int number_1 = 1;
        public static string number_2 = "0";
        public static string number_3 = "0";
        public static string number_4 = "0";
        public static string number_5 = "0";

        public static string number_all;

        public string url;
        URL Url = new URL();

        Form_login lf;
        public Form_main_menu(Form_login ef)
        {
            InitializeComponent();
            SidePanel.Height = btn_User_set.Height;
            SidePanel.Top = btn_User_set.Top;
            lf = ef;
        }
        public Form_main_menu()
        {
            InitializeComponent();
            SidePanel.Height = btn_User_set.Height;
            SidePanel.Top = btn_User_set.Top;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Aria Mes System을 종료하시겠습니까?\n예 - 종료, 아니오 - 로그아웃", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Form_login login = new Form_login();
                login.Show();
                this.Close();
            }
        }

        private void btn_User_set_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_User_set.Height;
            SidePanel.Top = btn_User_set.Top;
            control_Form_User1.BringToFront();
        }
        private void btn_Model_set_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Model_set.Height;
            SidePanel.Top = btn_Model_set.Top;
            control_Form_Model1.BringToFront();
        }

        private void btn_Line_set_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Line_set.Height;
            SidePanel.Top = btn_Line_set.Top;
        }

        private void btn_Lot_set_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Lot_set.Height;
            SidePanel.Top = btn_Lot_set.Top;
            //Control_Form.Control_Form_LOT con_lot = new Control_Form.Control_Form_LOT();
            //con_lot.Show();
            control_Form_LOT1.BringToFront();

        }

        private void btn_Monitoring_set_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Monitoring_set.Height;
            SidePanel.Top = btn_Monitoring_set.Top;
            control_Form_Monitoring1.BringToFront();
        }

        private void btn_Pass_set_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Pass_set.Height;
            SidePanel.Top = btn_Pass_set.Top;
            control_Form_Finish_Product1.BringToFront();
        }

        private void btn_Fail_set_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_Fail_set.Height;
            SidePanel.Top = btn_Fail_set.Top;
            control_Form_Fail_Product1.BringToFront();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void control_Form_Finish_Product1_Load(object sender, EventArgs e)
        {
            this.control_Form_LOT1 = new WindowsFormsApp6.Control_Form.Control_Form_LOT(this);
            this.control_Form_LOT1.Location = new System.Drawing.Point(244, 140);
            this.control_Form_LOT1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.control_Form_LOT1.Name = "control_Form_LOT1";
            this.control_Form_LOT1.Size = new System.Drawing.Size(1547, 942);
            this.control_Form_LOT1.TabIndex = 19;
            this.Controls.Add(this.control_Form_LOT1);
        }
        Thread en = new Thread(new ThreadStart(envi));
        Thread Ceid1 = new Thread(new ThreadStart(Pi.CEID1.Pi_ceid1));
        
        private void Form_main_menu_Load(object sender, EventArgs e)
        {
            Thread ene = new Thread(new ThreadStart(this.ene));
            ene.IsBackground = true;
            ene.Start();
            Thread li1 = new Thread(new ThreadStart(enupdate1));
            Thread li2 = new Thread(new ThreadStart(enupdate2));
            Thread li3 = new Thread(new ThreadStart(enupdate3));
            Thread eng = new Thread(new ThreadStart(this.ene));
            li1.IsBackground = true;
            li2.IsBackground = true;
            li3.IsBackground = true;
            label4.Text = Form_login.name_level;
            en.IsBackground = true;
            //en.Start();
            //li1.Start();
            //Delay(1000);
            //li2.Start();
            //Delay(1000);
            //li3.Start();
            Delay(1000);
            Ceid1.IsBackground = true;
            Ceid1.Start();
            //Delay(1000);
            //eng.IsBackground = true;
            //eng.Start();

        }
        public void ene()
        {
            while (true)
            {
                textBox1.Text = Pi.CEID1.Product_number + Pi.CEID1.Model_name + Pi.CEID1.Prod_Percent + Pi.CEID1.Result + Pi.CEID1.Fail_reason + Pi.CEID1.CV_move_state + Pi.CEID1.Robot_gripper_state;
                Delay(2000);
            }
        }
        public static void envi() // 온습도 쓰레드 함수
        {
            Random r_temp = new Random();
            Random r_humid = new Random();
            while(true)
            { 
                environment.temp = r_temp.Next(20, 40).ToString();
                environment.humid = r_humid.Next(40, 70).ToString();
                Delay(1000);
            }
        }
        Set.Line line2 = new Set.Line();
        public void enupdate1()
        {
            while(true)
            {
                line2.Line_Update2("L#1", environment.temp, environment.humid);
                Delay(10000);
            }
        }
        public void enupdate2()
        {
            while (true)
            {
                line2.Line_Update2("L#2", environment.temp, environment.humid);
                Delay(10000);
            }
        }
        public void enupdate3()
        {
            while (true)
            {
                line2.Line_Update2("L#3", environment.temp, environment.humid);
                Delay(10000);
            }
        }

        public static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }
        private Point mousePoint;

        private void Form_main_menu_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Form_main_menu_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void Form_main_menu_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
