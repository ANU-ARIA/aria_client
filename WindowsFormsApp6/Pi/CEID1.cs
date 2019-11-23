using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Pi
{
    class CEID1
    {
        public static string Product_number { get; set; }
        public static string Model_name { get; set; }
        public static string Prod_Percent { get; set; }
        public static string Result { get; set; }
        public static string Fail_reason { get; set; }
        public static string CV_move_state { get; set; }
        public static string Robot_gripper_state { get; set; }
        public static string Pi_temp { get; set; }
        public static string Pi_humid { get; set; }
        public static int un_fail = 0;
        public static int fail = 0;


        public static void Pi_ceid1()
        {
            while (true)
            {
                string send_message = "req_pi_ceid1,";
                Server.Server server = new Server.Server();
                string responseData = server.Server_Open(send_message);
                if (responseData == "X")
                {

                }
                else
                {
                    string[] receive_data_division = responseData.Split(new char[] { ',' });
                    Product_number = receive_data_division[0];
                    Model_name = receive_data_division[1];
                    Prod_Percent = receive_data_division[2];
                    Result = receive_data_division[3];
                    Fail_reason = receive_data_division[4];
                    CV_move_state = receive_data_division[5];
                    Robot_gripper_state = receive_data_division[6];
                    if(Result == "Pass")
                    {
                        un_fail++;
                    }
                    else
                    {
                        fail++;
                    }
                }
                Delay(1000);
                string send_message2 = "req_pi_ceid4,";
                string responseData2 = server.Server_Open(send_message2);
                string[] receive_data_division2 = responseData2.Split(new char[] { ',' });

                Delay(1000);
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
    }
}
