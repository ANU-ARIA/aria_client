using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Pi;

namespace WindowsFormsApp6
{
    public partial class Form_monitoring : Form
    {
        Control_Form.Control_Form_Monitoring Monitor1;
        public int index;

        public Form_monitoring(Control_Form.Control_Form_Monitoring Mo1)
        {
            InitializeComponent();
            Monitor1 = Mo1;
        }
        public Form_monitoring()
        {
            InitializeComponent();
        }

        private void circularProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form_monitoring_Load(object sender, EventArgs e)
        {
            int amount1 = Convert.ToInt32(Thread_Class.Class1.Amount1);
            int amount_progress = 0;
            int amount2 = Convert.ToInt32(Thread_Class.Class2.Amount2);
            int amount3 = Convert.ToInt32(Thread_Class.Class3.Amount3);

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.ForeColor = Color.SkyBlue;

            circularProgressBar3.Value = 0;
            circularProgressBar3.Minimum = 0;

            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series1"].Points.Add();
            chart1.Series["Series1"].Points.Add();
            chart1.Series["Series1"].Color = Color.Red;
            int per = 0;

            Thread dd = new Thread(new ThreadStart(Pi_work));
            dd.IsBackground = true;
            dd.Start();

            try
            {

                if (index == 1)
                {
                    int percent = 0;
                    progressBar1.Maximum = amount1;
                    //while (Convert.ToInt32(Thread_Class.Class1.progress1) != Convert.ToInt32(Thread_Class.Class1.Amount1))
                    //{
                    for (int i = Convert.ToInt32(Thread_Class.Class1.progress1); i < Convert.ToInt32(Thread_Class.Class1.Amount1)+1; i++)
                    {

                        percent = Convert.ToInt32(Thread_Class.Class1.wan1) * 100 / Convert.ToInt32(Thread_Class.Class1.Amount1);
                        progressBar1.Value = Convert.ToInt32(Thread_Class.Class1.wan1);
                        progress_percent.Text = percent.ToString() + "%";
                        label_lot.Text = Thread_Class.Class1.Lot1;
                        label_line.Text = Thread_Class.Class1.Line1;
                        label_modelid.Text = Thread_Class.Class1.Model_Name1;
                        label_amount.Text = Thread_Class.Class1.Amount1;
                        label_ing.Text = Thread_Class.Class1.wan1;
                        label_nam.Text = Thread_Class.Class1.nam1;
                        label_speed.Text = Thread_Class.Class1.speed1;
                        label_time.Text = Thread_Class.Class1.time1;
                        label_temp.Text = Thread_Class.environment.temp;
                        label_humid.Text = Thread_Class.environment.humid;
                        label_modeltemp.Text = Thread_Class.Class1.Temp1;
                        label_modelhumid.Text = Thread_Class.Class1.Humid1;
                        label_operid.Text = Thread_Class.Class1.Oper_id1;
                        chart1.Series["Series1"].Points.Add(Convert.ToInt32(Thread_Class.environment.temp));
                        chart1.Series["Series1"].Points.Add(Convert.ToInt32(Thread_Class.environment.humid));

                        label_fail.Text = Thread_Class.Class1.fail_1;
                        label_unfail.Text = Thread_Class.Class1.unfail_1;
                        circularProgressBar3.Maximum = Convert.ToInt32(Thread_Class.Class1.wan1);
                        circularProgressBar3.Value = Convert.ToInt32(Thread_Class.Class1.fail_1);

                        Delay(Convert.ToInt32(Thread_Class.Class1.speed1) * 1000);
                        amount_progress++;
                        amount1--;
                    }
                    //}
                    }
                else if (index == 2)
                {
                    int percent = 0;
                    progressBar1.Maximum = amount2;
                    while (amount2 != 0)
                    {
                        percent = Convert.ToInt32(Thread_Class.Class2.wan2) * 100 / Convert.ToInt32(Thread_Class.Class2.Amount2);
                        progressBar1.Value = Convert.ToInt32(Thread_Class.Class2.wan2);
                        progress_percent.Text = percent.ToString() + "%";
                        label_lot.Text = Thread_Class.Class2.Lot2;
                        label_line.Text = Thread_Class.Class2.Line2;
                        label_modelid.Text = Thread_Class.Class2.Model_Name2;
                        label_amount.Text = Thread_Class.Class2.Amount2;
                        label_ing.Text = Thread_Class.Class2.wan2;
                        label_nam.Text = Thread_Class.Class2.nam2;
                        label_speed.Text = Thread_Class.Class2.speed2;
                        label_time.Text = Thread_Class.Class2.time2;
                        label_temp.Text = Thread_Class.environment.temp;
                        label_humid.Text = Thread_Class.environment.humid;
                        label_modeltemp.Text = Thread_Class.Class2.temp2;
                        label_modelhumid.Text = Thread_Class.Class2.humid2;
                        label_operid.Text = Thread_Class.Class2.Oper_id2;
                        chart1.Series["Series1"].Points.Add(Convert.ToInt32(Thread_Class.environment.temp));
                        chart1.Series["Series1"].Points.Add(Convert.ToInt32(Thread_Class.environment.humid));

                        label_fail.Text = Thread_Class.Class2.fail_2;
                        label_unfail.Text = Thread_Class.Class2.unfail_2;

                        circularProgressBar3.Maximum = Convert.ToInt32(Thread_Class.Class2.wan2);
                        circularProgressBar3.Value = Convert.ToInt32(Thread_Class.Class2.unfail_2);

                        Delay(Convert.ToInt32(Thread_Class.Class2.speed2) * 1000);
                        amount_progress++;
                        amount2--;
                    }
                }
                else if (index == 3)
                {
                    int percent = 0;
                    progressBar1.Maximum = amount3;
                    while (amount3 != 0)
                    {
                        percent = Convert.ToInt32(Thread_Class.Class3.wan3) * 100 / Convert.ToInt32(Thread_Class.Class3.Amount3);
                        progressBar1.Value = Convert.ToInt32(Thread_Class.Class3.wan3);
                        progress_percent.Text = percent.ToString() + "%";
                        label_lot.Text = Thread_Class.Class3.Lot3;
                        label_line.Text = Thread_Class.Class3.Line3;
                        label_modelid.Text = Thread_Class.Class3.Model_Name3;
                        label_amount.Text = Thread_Class.Class3.Amount3;
                        label_ing.Text = Thread_Class.Class3.wan3;
                        label_nam.Text = Thread_Class.Class3.nam3;
                        label_speed.Text = Thread_Class.Class3.speed3;
                        label_time.Text = Thread_Class.Class3.time3;
                        label_temp.Text = Thread_Class.environment.temp;
                        label_humid.Text = Thread_Class.environment.humid;
                        label_modeltemp.Text = Thread_Class.Class3.Temp3;
                        label_modelhumid.Text = Thread_Class.Class3.Humid3;
                        label_operid.Text = Thread_Class.Class3.Oper_id3;
                        chart1.Series["Series1"].Points.Add(Convert.ToInt32(Thread_Class.environment.temp));
                        chart1.Series["Series1"].Points.Add(Convert.ToInt32(Thread_Class.environment.humid));

                        label_fail.Text = Thread_Class.Class3.fail_3;
                        label_unfail.Text = Thread_Class.Class3.unfail_3;

                        circularProgressBar3.Maximum = Convert.ToInt32(Thread_Class.Class3.wan3);
                        circularProgressBar3.Value = Convert.ToInt32(Thread_Class.Class3.unfail_3);

                        Delay(Convert.ToInt32(Thread_Class.Class3.speed3) * 1000);
                        amount_progress++;
                        amount3--;
                    }
                }
            }
            catch(Exception gg)
            {
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
        public void Pi_work()
        {
            while(true)
            {
                this.label_operid.Text = Form_login.oper_name;
                this.label_line.Text = "L#3";
                this.label_modelid.Text = CEID1.Model_name;
                this.label_modelname.Text = CEID1.Model_name;
                this.label_lot.Text = "크림빵10개";
                this.label_amount.Text = "10개";
                this.progressBar1.Value = (Convert.ToInt32(CEID1.Prod_Percent))*10;
                this.progress_percent.Text = ((Convert.ToInt32(CEID1.Prod_Percent)) * 10).ToString();
                this.label_unfail.Text = CEID1.un_fail.ToString();
                this.label_fail.Text = CEID1.fail.ToString();
                this.label_ing.Text = CEID1.Prod_Percent;
                this.label_nam.Text = (10 - Convert.ToInt32(CEID1.Prod_Percent)).ToString();
                //CEID1.Fail_reason;
                //CEID1.CV_move_state;
                //CEID1.Robot_gripper_state;
                //CEID1.Pi_temp;
                //CEID1.Pi_humid;
                this.label_modeltemp.Text = "25~37";
                this.label_modelhumid.Text = "20~30";
                Delay(2000);
            }
        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
