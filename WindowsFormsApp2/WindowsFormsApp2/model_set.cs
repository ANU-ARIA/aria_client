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
using Newtonsoft.Json;
using MESComm;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Model_set : Form
    {
        string bindIp = "220.69.249.232";
        string serverIp = "220.69.249.232";
        const int serverPort = 4000;

        int bb = Convert.ToInt32(700);
        private List<Model> addr;
        DataTable table = new DataTable();

        public Model_set()
        {
            InitializeComponent();

            addr = new List<Model>();

            //DataTable table = new DataTable();

            table.Columns.Add("모델 id", typeof(int));
            table.Columns.Add("적정 온도", typeof(int));
            table.Columns.Add("적정 습도", typeof(int));
            table.Columns.Add("모델 명", typeof(string));

            model_view.DataSource = table;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // 생성
        private void Insert_Click(object sender, EventArgs e)
        {
            bb++;

            try
            {
                // 텍스트 데이터
                int md_id = Int32.Parse(model_id_text.Text);
                float md_temp = Int32.Parse(model_temp_text.Text);
                float md_hum = Int32.Parse(model_humidity_text.Text);
                string md_name = model_name_text.Text;

                // 데이터를 하나의 메세지로 묶는다.
                string message;

                message = "{{#@!," + md_id + "," + md_temp + "," + md_hum + "," + md_name + ",#}}";

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

                if (responseData == "insert 받았습니다~") //result.sResult == "OK"
                {
                    models_box.Text = responseData;
                    MessageBox.Show("생성 되었습니다.");
                }
                else
                {
                    MessageBox.Show("생성에 실패했습니다.");
                }

                TJcl();

                stream.Close();
                client.Close();
            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");
                TJcl();
            }

            


            // 객체 종료
           
        }

        // 삭제
        private void Delete_Click(object sender, EventArgs e)
        {

            try
            {

                // 텍스트 데이터
                int md_id = Int32.Parse(model_id_text.Text);
                float md_temp = Int32.Parse(model_temp_text.Text);
                float md_hum = Int32.Parse(model_humidity_text.Text);
                string md_name = model_name_text.Text;

                // 데이터를 하나의 메세지로 묶는다.
                string message;

                message = "{{#@@," + md_id + "," + md_temp + "," + md_hum + "," + md_name + ",#}}";

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

                if (responseData == "delete 받았습니다~") //result.sResult == "OK"
                {
                    models_box.Text = responseData;
                    MessageBox.Show("삭제 되었습니다.");
                }
                else
                {
                    MessageBox.Show("삭제에 실패했습니다.");
                }

                TJcl();
                // 객체 종료
                stream.Close();
                client.Close();


            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");
                TJcl();
            }
        }

        // 수정
        private void Update_Click(object sender, EventArgs e)
        {

            try
            {

                // 텍스트 데이터
                int md_id = Int32.Parse(model_id_text.Text);
                float md_temp = Int32.Parse(model_temp_text.Text);
                float md_hum = Int32.Parse(model_humidity_text.Text);
                string md_name = model_name_text.Text;


                // 데이터를 하나의 메세지로 묶는다.
                string message;

                message = "{{#@#," + md_id + "," + md_temp + "," + md_hum + "," + md_name + ",#}}";

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

                if (responseData == "update 받았습니다~") //result.sResult == "OK"
                {
                    models_box.Text = responseData;
                    MessageBox.Show("수정 되었습니다.");
                }
                else
                {
                    MessageBox.Show("수정에 실패했습니다.");
                }
                TJcl();

                // 객체 종료
                stream.Close();
                client.Close();

            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");
                TJcl();

            }
        }


        // 검색
        private void Search_Click(object sender, EventArgs e)
        {
            table.Clear();
            addr.Clear();

            // 텍스트 데이터
            try
            {
                int md_id = Int32.Parse(model_id_sch_text.Text);

                    string message;

                    message = "{{#@%," + md_id + ",#}}";

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

                if (responseData == "없음")
                {
                    MessageBox.Show("검색된 값이 없습니다.");

                    TJcl();

                    stream.Close();
                    client.Close();
                }
                else
                {
                    models_box.Text = responseData;

                    MessageBox.Show("검색 되었습니다.");


                    string[] arr = responseData.Trim().Split(',');

                    for (int i = 0; i < arr.Length / 4; i++)
                    {
                        Model md = new Model();

                        md.model_id = Int32.Parse(arr[i * 4]);
                        md.temp_margin = Int32.Parse(arr[i * 4 + 1]);
                        md.humid_margin = Int32.Parse(arr[i * 4 + 2]);
                        md.model_name = arr[i * 4 + 3];

                        if (table.Rows.Count < arr.Length / 4)
                        {
                            table.Rows.Add(arr[i * 4], arr[i * 4 + 1], arr[i * 4 + 2], arr[i * 4 + 3]);
                        }

                    }

                    stream.Close();
                    client.Close();
                }


                    // 객체 종료

            }
            catch (Exception h)
            {
                MessageBox.Show("총 검색.");

                TJcl();
            }

        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private int currentIndex = -1;

        private void Model_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //currentIndex = e.RowIndex; // 현재 인덱스를 필드에 보관
            DataGridViewCell dgvc = model_view.Rows[e.RowIndex].Cells[0];
            currentIndex = Convert.ToInt32(dgvc.Value.ToString()) - 1;
            if (currentIndex != -1)
            {
                model_id_text.Text = model_view.Rows[e.RowIndex].Cells[0].Value.ToString();
                model_temp_text.Text = model_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                model_humidity_text.Text = model_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                model_name_text.Text = model_view.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

        private void Model_set_Load(object sender, EventArgs e)
        {
            TJcl();
        }

        // 그리뷰에 띄우는 함수
        public void TJcl()
        {
            table.Clear();
            addr.Clear();

            // 텍스트 데이터
            //int md_id = Int32.Parse(model_id_text.Text);
            //float md_temp = Int32.Parse(model_temp_text.Text);
            //float md_hum = Int32.Parse(model_humidity_text.Text);
            //string md_name = model_name_text.Text;

            // 데이터를 하나의 메세지로 묶는다.

            string message;

            //if ( md_id != null)
            //{
            //    message = "{{#@$,"+ md_id + ",#}}";
            //}
            //else if( md_id == null)
            //{
            //    message = "{{#@$,,#}}";
            //}

            message = "{{#@$,,#}}";

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

            models_box.Text = responseData;

            string[] arr = responseData.Trim().Split(',');

            for (int i = 0; i < arr.Length / 4; i++)
            {
                Model md = new Model();

                md.model_id = Int32.Parse(arr[i * 4]);
                md.temp_margin = Int32.Parse(arr[i * 4 + 1]);
                md.humid_margin = Int32.Parse(arr[i * 4 + 2]);
                md.model_name = arr[i * 4 + 3];

                if (table.Rows.Count < arr.Length / 4)
                {
                    table.Rows.Add(arr[i * 4], arr[i * 4 + 1], arr[i * 4 + 2], arr[i * 4 + 3]);
                }

            }

            foreach (Control ctl in this.Controls)
            {
                if (typeof(System.Windows.Forms.TextBox) == ctl.GetType())
                {
                    ctl.Text = null;
                }
            }


            // 객체 종료
            stream.Close();
            client.Close();
        }
    }
}
