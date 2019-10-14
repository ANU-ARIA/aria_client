using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApp2
{
    public partial class Lot_direct : Form
    {

        string bindIp = "220.69.249.232";
        string serverIp = "220.69.249.232";
        const int serverPort = 4000;

        int bb = Convert.ToInt32(700);

        public Lot_direct()
        {
            InitializeComponent();
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {

            // 텍스트 데이터
            string line = combox_line_id.Text;
            string lot = txtbox_lot_id.Text;
            string md_name = combox_model_name.Text;
            string md_color = combox_model_color.Text;
            string lot_id = txtbox_lot_id.Text;
            decimal pd_cnt = numbox_prod_count.Value;
            decimal pd_fail = numbox_prod_fail.Value;
            decimal temp_mag = numbox_temp_margin.Value;
            decimal hum_mag = numbox_humid_margin.Value;

            // 데이터를 하나의 메세지로 묶는다.
            string message;

            message = "{{##!," + line + "," + lot + "," + md_name + "," + md_color + "," + lot_id +
                 "," + pd_cnt + "," + pd_fail + "," + temp_mag + "," + hum_mag + ",#}}";

            IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(bindIp), bb);
            IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

            bb++;

            TcpClient client = new TcpClient(clientAddress);
            client.Connect(serverAddress);
            byte[] data = System.Text.Encoding.Default.GetBytes(message);
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);

            data = new byte[256];
            string responseData = "";

            int bytes = stream.Read(data, 0, data.Length);
            responseData = Encoding.Default.GetString(data, 0, bytes);

            if (responseData == "작업지시 받았습니다~") //result.sResult == "OK"
            {
                textBox1.Text = responseData;
                MessageBox.Show("작업지시 받았습니다~");
            }
            else
            {
                MessageBox.Show("작업지시에 실패했습니다.");
            }

            // 객체 종료
            stream.Close();
            client.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Line_text_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
