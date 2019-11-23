using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WindowsFormsApp6.Pi;

namespace WindowsFormsApp6.Control_Form
{
    public partial class Control_Form_LOT : UserControl
    {
        public static int monitor_index;
        string txt;
        string model_info_list;
        string model_id;
        string job;
        string model_name;

        public static string Pass;

        public string com_line_txt1;
        public string com_color_txt1;

        public static int mmount1;

        public List<string> TBL_lot_id = new List<string>();
        public List<string> TBL_model_id = new List<string>();
        public List<string> TBL_line_id = new List<string>();
        public List<string> TBL_total_product_count = new List<string>();
        public List<string> TBL_speed = new List<string>();
        public List<string> TBL_product_fail_rate = new List<string>();
        public List<string> TBL_product_color = new List<string>();
        public List<string> TBL_temp = new List<string>();
        public List<string> TBL_humid = new List<string>();
        public List<string> TBL_operid = new List<string>();
        public List<string> TBL_working_state = new List<string>();

        Control_Form_Monitoring monitor;



        public Control_Form_LOT()
        {
            InitializeComponent();
        }

        Form_main_menu fm = null;
        public Control_Form_LOT(Form_main_menu form)
        {
            InitializeComponent();
            fm = form;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Set.Lot lot = new Set.Lot();
            Set.Products products = new Set.Products();
            MessageBox.Show(lot.req_lot_update(text_lot_lot.Text, model_id, com_line_txt1, text_lot_amount.Text,
                text_lot_speed.Text, text_lot_failrate.Text,com_color_txt1, txt_model_temp.Text,txt_model_humid.Text,"ehddn","0"));
            MessageBox.Show(products.Products_update(txt, com_line_txt1, text_lot_lot.Text, text_lot_amount.Text));

            

        }

        private void Control_Form_LOT_Load(object sender, EventArgs e)
        {
            try
            {
                this.Controls.Add(grid_lot_select);

                com_line.Items.Add("L#1");
                com_line.Items.Add("L#2");
                com_line.Items.Add("L#3");

                com_color.Items.Add("Red");
                com_color.Items.Add("Blue");
                com_color.Items.Add("Black");
                com_color.Items.Add("Green");


                Set.Model model = new Set.Model();
                model_info_list = model.req_model_select("0", "0");
                string[] model_info_list_division = model_info_list.Split(new char[] { ',' });

                int index = 3;
                int index2 = 4;
                combo_model_name.Items.Add(model_info_list_division[index]);
                for (int i = 1; i < model_info_list_division.Length / 4; i++) // combobox 추가
                {
                    index = index + index2;
                    combo_model_name.Items.Add(model_info_list_division[index]);
                }


                grid_lot_select.ColumnCount = 12;

                grid_lot_select.Columns[0].Name = "Lot Id";
                grid_lot_select.Columns[1].Name = "Model Id";
                grid_lot_select.Columns[2].Name = "Line Id";
                grid_lot_select.Columns[3].Name = "Total Product Count";
                grid_lot_select.Columns[4].Name = "Product Speed Warn";
                grid_lot_select.Columns[5].Name = "Product Fail Rate";
                grid_lot_select.Columns[6].Name = "Product Color";
                grid_lot_select.Columns[7].Name = "Temp Margin";
                grid_lot_select.Columns[8].Name = "Humid Margin";
                grid_lot_select.Columns[9].Name = "Oper Id";
                grid_lot_select.Columns[10].Name = "Working State";
                grid_lot_select.Columns[11].Name = "Lot Create Time";
            }
            catch(Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }

        private void combo_model_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sel = combo_model_name.SelectedIndex;
            txt = combo_model_name.SelectedItem as string;

            string[] model_info_list_division = model_info_list.Split(new char[] { ',' });
            if (sel > -1)
            {
                for(int i = 0; i < model_info_list_division.Length; i++)
                {
                    if(model_info_list_division[i] == txt)
                    {
                        model_id = model_info_list_division[i - 3];
                        txt_model_temp.Text = model_info_list_division[i - 2];
                        txt_model_humid.Text = model_info_list_division[i - 1];
                        txt_temp.Text = (Convert.ToInt32(txt_model_temp.Text) - 10).ToString() + " ~ " + txt_model_temp.Text;
                        txt_humid.Text = (Convert.ToInt32(txt_model_humid.Text) - 15).ToString() + " ~ " + txt_model_humid.Text;

                    }
                }
                model_name = txt;

            }
            
        }

        private void grid_lot_select_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void grid_lot_select_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            job = this.grid_lot_select.CurrentRow.Cells[0].Value.ToString() + "," + this.grid_lot_select.CurrentRow.Cells[1].Value.ToString() + "," + this.grid_lot_select.CurrentRow.Cells[2].Value.ToString() +
                "," + this.grid_lot_select.CurrentRow.Cells[3].Value.ToString() + "," + this.grid_lot_select.CurrentRow.Cells[4].Value.ToString() + "," + this.grid_lot_select.CurrentRow.Cells[5].Value.ToString() +
                "," + this.grid_lot_select.CurrentRow.Cells[6].Value.ToString() + "," + this.grid_lot_select.CurrentRow.Cells[7].Value.ToString() + "," + this.grid_lot_select.CurrentRow.Cells[8].Value.ToString() +
                "," + this.grid_lot_select.CurrentRow.Cells[9].Value.ToString();
            string[] job_division = job.Split(new char[] { ',' });
            text_select_lot.Text = job_division[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ee = 12;
            grid_lot_select.Rows.Clear();
            Set.Lot lot = new Set.Lot();
            string lot_info_list = lot.req_lot_select("0");

            

        string[] lot_info_list_division = lot_info_list.Split(new char[] { ',' });

                string[] lot_all_info_list_division = lot_info_list.Split(new char[] { '\n' });

            for(int i = 0; i < lot_all_info_list_division.Length; i++)
            {
                if (i == 0)
                {
                    ee = 0;
                }
                else
                {
                    ee = 12 * i;
                }
                TBL_lot_id.Add(lot_info_list_division[ee + 0]);
                TBL_model_id.Add(lot_info_list_division[ee + 1]);
                TBL_line_id.Add(lot_info_list_division[ee + 2]);
                TBL_total_product_count.Add(lot_info_list_division[ee + 3]);
                TBL_speed.Add(lot_info_list_division[ee + 4]);
                TBL_product_fail_rate.Add(lot_info_list_division[ee + 5]);
                TBL_product_color.Add(lot_info_list_division[ee + 6]);
                TBL_temp.Add(lot_info_list_division[ee + 7]);
                TBL_humid.Add(lot_info_list_division[ee + 8]);
                TBL_operid.Add(lot_info_list_division[ee + 9]);
                TBL_working_state.Add(lot_info_list_division[ee + 10]);
            }

            int w = 0; // , 기준 나뉘어진 요소들의 갯수

            for (int j = 1; j < lot_all_info_list_division.Length; j++)
            {
                grid_lot_select.Rows.Add();
            }

            for (int j = 0; j < lot_all_info_list_division.Length; j++)
            {
                for (int h = 0; h < 12; h++)
                {
                    grid_lot_select[h, j].Value = lot_info_list_division[w];
                    w++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < TBL_lot_id.Count; i++)
            {
                if(text_select_lot.Text == TBL_lot_id[i])
                {
                    int all_time = Convert.ToInt32(TBL_total_product_count[i]) * Convert.ToInt32(TBL_speed[i]);
                    int minit = all_time / 60;
                    int second = all_time % 60;

                    if (MessageBox.Show("아래의 작업지시 내용을 추가하시겠습니까?\n작업명 = \t" + TBL_lot_id[i] + "\n모델명 = \t" + TBL_model_id[i] + "\n라인 = \t" + TBL_line_id[i] + "\n생산량 = \t" +
                        TBL_total_product_count[i] + "\n속도 = \t" + TBL_speed[i] + "\n불량률 = \t" + TBL_product_fail_rate[i] + "\n색깔 = \t" + TBL_product_color[i] + "\n온도 = \t" + TBL_temp[i] + "\n습도 = \t" + TBL_humid[i] + "\n작업자 = \t" +
                        "" + TBL_operid[i] + "\n예상소요시간 = \t" + minit + "분 " + second + "초", "작업지시 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("추가되었습니다.");

                        Set.Line line   =   new Set.Line();
                        Set.Lot lot     =   new Set.Lot();
                        MessageBox.Show(lot.req_lot_select(TBL_lot_id[i]));
                        
                        //monitor         =    new Control_Form_Monitoring(this);
                        //monitor.Show();
                        
                        if(TBL_line_id[i] == "L#1")
                        {
                            Thread_Class.Class1.unfail_1 = "0";
                            Thread_Class.Class1.fail_1 = "0";
                            monitor_index = 1;
                            fm.control_Form_Monitoring1.grid_monitoring[2, 0].Value = "작업중";
                            fm.control_Form_Monitoring1.grid_monitoring[1, 0].Value = TBL_model_id[i];
                            fm.control_Form_Monitoring1.grid_monitoring[3, 0].Value = TBL_lot_id[i];
                            fm.control_Form_Monitoring1.line = "L#1";
                            Thread_Class.Class1.Line1 = "L#1";
                            fm.control_Form_Monitoring1.lot_id = TBL_lot_id[i];
                            Thread_Class.Class1.Lot1 = TBL_lot_id[i];
                            fm.control_Form_Monitoring1.model_name = TBL_model_id[i];
                            Thread_Class.Class1.Model_Name1 = TBL_model_id[i];
                            fm.control_Form_Monitoring1.amount = TBL_total_product_count[i];
                            Thread_Class.Class1.Amount1 = TBL_total_product_count[i];
                            fm.control_Form_Monitoring1.ing_speed = TBL_speed[i];
                            Thread_Class.Class1.speed1 = TBL_speed[i];
                            fm.control_Form_Monitoring1.finish_speed = minit + "분 " + second + "초";
                            Thread_Class.Class1.time1 = minit + "분" + second + "초";
                            Thread_Class.Class1.Temp1 = TBL_temp[i];
                            Thread_Class.Class1.Humid1 = TBL_humid[i];
                            Thread_Class.Class1.Oper_id1 = Form_login.oper_name;
                            Thread Index1 = new Thread(new ThreadStart(OUTPUT1));
                            line.Line_Update(TBL_lot_id[i], TBL_line_id[i], TBL_operid[i]);
                            Index1.Start();

                            Delay(1000*(Convert.ToInt32(TBL_speed[i])*Convert.ToInt32(TBL_total_product_count[i])));
                            fm.control_Form_Monitoring1.grid_monitoring[2, 0].Value = "대기중";
                            fm.control_Form_Monitoring1.grid_monitoring[1, 0].Value = "";
                            fm.control_Form_Monitoring1.grid_monitoring[3, 0].Value = "";

                            //fm.control_Form_Monitoring1.textBox1.Text = fm.control_Form_Monitoring1.line + "," + fm.control_Form_Monitoring1.lot_id + "," + fm.control_Form_Monitoring1.model_name +
                            //    "," + fm.control_Form_Monitoring1.amount + "," + fm.control_Form_Monitoring1.ing_speed + "," + fm.control_Form_Monitoring1.finish_speed + ",";

                        }
                        else if (TBL_line_id[i] == "L#2")
                        {
                            Thread_Class.Class2.unfail_2 = "0";
                            Thread_Class.Class2.fail_2 = "0";
                            fm.control_Form_Monitoring1.grid_monitoring[2, 1].Value = "작업중";
                            fm.control_Form_Monitoring1.grid_monitoring[1, 1].Value = TBL_model_id[i];
                            fm.control_Form_Monitoring1.grid_monitoring[3, 1].Value = TBL_lot_id[i];
                            fm.control_Form_Monitoring1.line = "L#2";
                            Thread_Class.Class2.Line2 = "L#2";
                            fm.control_Form_Monitoring1.lot_id = TBL_lot_id[i];
                            Thread_Class.Class2.Lot2 = TBL_lot_id[i];
                            fm.control_Form_Monitoring1.model_name = TBL_model_id[i];
                            Thread_Class.Class2.Model_Name2 = TBL_model_id[i];
                            fm.control_Form_Monitoring1.amount = TBL_total_product_count[i];
                            Thread_Class.Class2.Amount2 = TBL_total_product_count[i];
                            fm.control_Form_Monitoring1.ing_speed = TBL_speed[i];
                            Thread_Class.Class2.speed2 = TBL_speed[i];
                            fm.control_Form_Monitoring1.finish_speed = minit + "분 " + second + "초";
                            Thread_Class.Class2.time2 = minit + "분" + second + "초";
                            Thread_Class.Class2.temp2 = TBL_temp[i];
                            Thread_Class.Class2.humid2 = TBL_humid[i];
                            Thread_Class.Class2.Oper_id2 = Form_login.oper_name;
                            Thread Index1 = new Thread(new ThreadStart(OUTPUT2));
                            Index1.Start();

                            Delay(1000 * (Convert.ToInt32(TBL_speed[i]) * Convert.ToInt32(TBL_total_product_count[i])));
                            fm.control_Form_Monitoring1.grid_monitoring[2, 1].Value = "대기중";
                            fm.control_Form_Monitoring1.grid_monitoring[1, 1].Value = "";
                            fm.control_Form_Monitoring1.grid_monitoring[3, 1].Value = "";

                            //fm.control_Form_Monitoring1.textBox1.Text = fm.control_Form_Monitoring1.line + "," + fm.control_Form_Monitoring1.lot_id + "," + fm.control_Form_Monitoring1.model_name +
                            //    "," + fm.control_Form_Monitoring1.amount + "," + fm.control_Form_Monitoring1.ing_speed + "," + fm.control_Form_Monitoring1.finish_speed + ",";
                        }
                        else if (TBL_line_id[i] == "L#3")
                        {
                            Thread_Class.Class3.unfail_3 = "0";
                            Thread_Class.Class3.fail_3 = "0";
                            fm.control_Form_Monitoring1.grid_monitoring[2, 2].Value = "작업중";
                            fm.control_Form_Monitoring1.grid_monitoring[1, 2].Value = TBL_model_id[i];
                            fm.control_Form_Monitoring1.grid_monitoring[3, 2].Value = TBL_lot_id[i];
                            fm.control_Form_Monitoring1.line = "L#3";
                            Thread_Class.Class3.Line3 = "L#3";
                            fm.control_Form_Monitoring1.lot_id = TBL_lot_id[i];
                            Thread_Class.Class3.Lot3 = TBL_lot_id[i];
                            fm.control_Form_Monitoring1.model_name = TBL_model_id[i];
                            Thread_Class.Class3.Model_Name3 = TBL_model_id[i];
                            fm.control_Form_Monitoring1.amount = TBL_total_product_count[i];
                            Thread_Class.Class3.Amount3 = TBL_total_product_count[i];
                            fm.control_Form_Monitoring1.ing_speed = TBL_speed[i];
                            Thread_Class.Class3.speed3 = TBL_speed[i];
                            fm.control_Form_Monitoring1.finish_speed = minit + "분 " + second + "초";
                            Thread_Class.Class3.time3 = minit + "분" + second + "초";
                            Thread_Class.Class3.Temp3 = TBL_temp[i];
                            Thread_Class.Class3.Humid3 = TBL_humid[i];
                            Thread_Class.Class3.Oper_id3 = Form_login.oper_name;
                            Thread Index1 = new Thread(new ThreadStart(OUTPUT3));
                            Index1.Start();
                            Delay(1000 * (Convert.ToInt32(TBL_speed[i]) * Convert.ToInt32(TBL_total_product_count[i])));
                            fm.control_Form_Monitoring1.grid_monitoring[2, 2].Value = "대기중";
                            fm.control_Form_Monitoring1.grid_monitoring[1, 2].Value = "";
                            fm.control_Form_Monitoring1.grid_monitoring[3, 2].Value = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("취소되었습니다.");
                    }
                }
            }
        }

        public static void OUTPUT1()
        {
            Thread_Class.Class1.progress1 = "0";
            int mount = Convert.ToInt32(Thread_Class.Class1.Amount1);
            mmount1 = Convert.ToInt32(Thread_Class.Class1.Amount1);
            Set.Line line = new Set.Line();
            int index_value = 0;
            Set.Products pro = new Set.Products();
            for (int i = 1; i <= Convert.ToInt32(Thread_Class.Class1.Amount1)+1; i++)
            {
                Delay(Convert.ToInt32(Thread_Class.Class1.speed1) * 1000);
                
                mount--;
                mmount1--;
                Thread_Class.Class1.wan1 = i.ToString();
                Thread_Class.Class1.nam1 = mount.ToString();
                if (Convert.ToInt32(Thread_Class.environment.temp) < Convert.ToInt32(Thread_Class.Class1.Temp1) - 10 || Convert.ToInt32(Thread_Class.environment.humid) < Convert.ToInt32(Thread_Class.Class1.Humid1) - 15)
                {
                    int tem = Convert.ToInt32(Thread_Class.Class1.fail_1);
                    Pass = "1";
                    tem++;
                    Thread_Class.Class1.fail_1 = tem.ToString();
                }
                else
                {
                    int hum = Convert.ToInt32(Thread_Class.Class1.unfail_1);
                    Pass = "0";
                    hum++;
                    Thread_Class.Class1.unfail_1 = hum.ToString();
                }
                int pr = Convert.ToInt32(Thread_Class.Class1.progress1);
                pr++;
                Thread_Class.Class1.progress1 = pr.ToString();

                    if (Pass == "0" && pr != Convert.ToInt32(Thread_Class.Class1.Amount1)+1)
                    {
                        pro.Products_update2(index_value.ToString(), Thread_Class.Class1.Lot1, Thread_Class.environment.temp, Thread_Class.environment.humid,
                            "ok", "null");
                    }
                    else if (Pass == "1" && pr != Convert.ToInt32(Thread_Class.Class1.Amount1)+1)
                    {
                        pro.Products_update2(index_value.ToString(), Thread_Class.Class1.Lot1, Thread_Class.environment.temp, Thread_Class.environment.humid,
                            "no", "temp&humid");
                    }
                    index_value++;
            }
            for (int i = 0; i <= Convert.ToInt32(Thread_Class.Class1.Amount1); i++)
            {
                pro.Products_update3(i.ToString(), Thread_Class.Class1.Lot1);
                Delay(100);
            }
            line.Line_Update3("L#1");
        }
        public static void OUTPUT2()
        {
            int mount = Convert.ToInt32(Thread_Class.Class2.Amount2);
            for (int i = 1; i <= Convert.ToInt32(Thread_Class.Class2.Amount2); i++)
            {
                Delay(Convert.ToInt32(Thread_Class.Class2.speed2)*1000);
                mount--;
                Thread_Class.Class2.wan2 = i.ToString();
                Thread_Class.Class2.nam2 = mount.ToString();

                if (Convert.ToInt32(Thread_Class.environment.temp) < Convert.ToInt32(Thread_Class.Class2.temp2) - 10 || Convert.ToInt32(Thread_Class.environment.humid) < Convert.ToInt32(Thread_Class.Class2.humid2) - 15)
                {
                    int tem = Convert.ToInt32(Thread_Class.Class2.fail_2);
                    tem++;
                    Thread_Class.Class2.fail_2 = tem.ToString();
                }
                else
                {
                    int hum = Convert.ToInt32(Thread_Class.Class2.unfail_2);
                    hum++;
                    Thread_Class.Class2.unfail_2 = hum.ToString();
                }
            }
        }

        public static void OUTPUT3()
        {
            int mount = Convert.ToInt32(Thread_Class.Class3.Amount3);
            for (int i = 1; i <= Convert.ToInt32(Thread_Class.Class3.Amount3); i++)
            {
                Delay(Convert.ToInt32(Thread_Class.Class3.speed3) * 1000);
                mount--;
                Thread_Class.Class3.wan3 = i.ToString();
                Thread_Class.Class3.nam3 = mount.ToString();

                if (Convert.ToInt32(Thread_Class.environment.temp) < Convert.ToInt32(Thread_Class.Class3.Temp3) - 10 || Convert.ToInt32(Thread_Class.environment.humid) < Convert.ToInt32(Thread_Class.Class3.Humid3) - 15)
                {
                    int tem = Convert.ToInt32(Thread_Class.Class3.fail_3);
                    tem++;
                    Thread_Class.Class3.fail_3 = tem.ToString();
                }
                else
                {
                    int hum = Convert.ToInt32(Thread_Class.Class3.unfail_3);
                    hum++;
                    Thread_Class.Class3.unfail_3 = hum.ToString();
                }
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

        private void button4_Click(object sender, EventArgs e)
        {
            Set.Pi p = new Set.Pi();
            MessageBox.Show(p.Pi_send(text_lot_lot.Text, "Aria_CreamBbang", text_lot_amount.Text, txt_model_temp.Text, txt_model_humid.Text, com_line_txt1, com_color_txt1));
            try
            {
                MessageBox.Show(CEID1.Product_number.ToString() + CEID1.Model_name.ToString() + CEID1.Prod_Percent + CEID1.Result + CEID1.Fail_reason +
                    CEID1.CV_move_state + CEID1.Robot_gripper_state);
            }
            catch(Exception ggh)
            {
                MessageBox.Show(ggh.Message);
            }
            Form_monitoring fming = new Form_monitoring();
            Thread piwork = new Thread(new ThreadStart(fming.Pi_work));
            piwork.IsBackground = true;
            piwork.Start();
        }

        private void com_line_SelectedIndexChanged(object sender, EventArgs e)
        {
            string com_line_txt = com_line.SelectedItem as string;
            com_line_txt1 = com_line_txt;
        }

        private void com_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            string com_color_txt = com_color.SelectedItem as string;
            com_color_txt1 = com_color_txt;
        }
    }
}
