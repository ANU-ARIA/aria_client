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
        string               m_sBindIp = "220.69.249.232";
        string               m_sServerIp = "220.69.249.232";
        const int            m_nServerPort = 4000;
        private List<Model>  m_listReceivedModel;
        DataTable            m_dtModel = new DataTable();

        int bb = Convert.ToInt32(700);

        public Model_set()
        {
            InitializeComponent();

            m_listReceivedModel = new List<Model>();

            //DataTable table = new DataTable();

            m_dtModel.Columns.Add("모델 id", typeof(int));
            m_dtModel.Columns.Add("적정 온도", typeof(int));
            m_dtModel.Columns.Add("적정 습도", typeof(int));
            m_dtModel.Columns.Add("모델 명", typeof(string));

            DataGridView_Model.DataSource = m_dtModel;
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
                // 텍스트 데이터 (컨트롤로 부터 데이터를 가져옴.)
                int md_id = Int32.Parse(txtbox_model_id.Text);
                float md_temp = Int32.Parse(txtbox_model_temp.Text);
                float md_hum = Int32.Parse(txtbox_model_humidity.Text);
                string md_name = txtbox_model_name.Text;

                // 데이터를 하나의 메세지로 묶는다.
                // MES Server에 전달할 메세지를 만든다.
                string message;

                message = "{{#@!," + md_id + "," + md_temp + "," + md_hum + "," + md_name + ",#}}";

                // MES Server와 통신을 연결 한다.
                IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(m_sBindIp), bb);
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(m_sServerIp), m_nServerPort);

                bb++;

                TcpClient client = new TcpClient(clientAddress);
                client.Connect(serverAddress);

                // MES Server 메세지를 송신 한다.
                byte[] data = System.Text.Encoding.Default.GetBytes(message);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                // MES Server로 부터 수신된 데이터를 읽는다.
                data = new byte[256];
                string responseData = "";

                int bytes = stream.Read(data, 0, data.Length);
                responseData = Encoding.Default.GetString(data, 0, bytes);

                // MES Server로 부터 수신된 메세지를 해석한다.
                if (responseData == "insert 받았습니다~") //result.sResult == "OK"
                {
                    rtxtbox_models.Text = responseData;
                    MessageBox.Show("생성 되었습니다.");
                }
                else
                {
                    MessageBox.Show("생성에 실패했습니다.");
                }

                ShowModelInfoToGridCtrl();

                stream.Close();
                client.Close();
            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");
                ShowModelInfoToGridCtrl();
            }

            


            // 객체 종료
           
        }

        // 삭제
        private void Delete_Click(object sender, EventArgs e)
        {

            try
            {

                // 텍스트 데이터
                int md_id = Int32.Parse(txtbox_model_id.Text);
                float md_temp = Int32.Parse(txtbox_model_temp.Text);
                float md_hum = Int32.Parse(txtbox_model_humidity.Text);
                string md_name = txtbox_model_name.Text;

                // 데이터를 하나의 메세지로 묶는다.
                string message;

                message = "{{#@@," + md_id + "," + md_temp + "," + md_hum + "," + md_name + ",#}}";

                IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(m_sBindIp), bb);
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(m_sServerIp), m_nServerPort);

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
                    rtxtbox_models.Text = responseData;
                    MessageBox.Show("삭제 되었습니다.");
                }
                else
                {
                    MessageBox.Show("삭제에 실패했습니다.");
                }

                ShowModelInfoToGridCtrl();
                // 객체 종료
                stream.Close();
                client.Close();


            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");
                ShowModelInfoToGridCtrl();
            }
        }

        // 수정
        private void Update_Click(object sender, EventArgs e)
        {

            try
            {

                // 텍스트 데이터
                int md_id = Int32.Parse(txtbox_model_id.Text);
                float md_temp = Int32.Parse(txtbox_model_temp.Text);
                float md_hum = Int32.Parse(txtbox_model_humidity.Text);
                string md_name = txtbox_model_name.Text;


                // 데이터를 하나의 메세지로 묶는다.
                string message;

                message = "{{#@#," + md_id + "," + md_temp + "," + md_hum + "," + md_name + ",#}}";

                IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(m_sBindIp), bb);
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(m_sServerIp), m_nServerPort);

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
                    rtxtbox_models.Text = responseData;
                    MessageBox.Show("수정 되었습니다.");
                }
                else
                {
                    MessageBox.Show("수정에 실패했습니다.");
                }
                ShowModelInfoToGridCtrl();

                // 객체 종료
                stream.Close();
                client.Close();

            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");
                ShowModelInfoToGridCtrl();

            }
        }


        // 검색
        private void Search_Click(object sender, EventArgs e)
        {
            m_dtModel.Clear();
            m_listReceivedModel.Clear();

            // 텍스트 데이터
            try
            {
                int md_id = Int32.Parse(txtbox_model_id_sch.Text);

                string message;

                message = "{{#@%," + md_id + ",#}}";

                IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(m_sBindIp), bb);
                IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(m_sServerIp), m_nServerPort);

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

                    ShowModelInfoToGridCtrl();

                    stream.Close();
                    client.Close();
                }
                else
                {
                    rtxtbox_models.Text = responseData;

                    MessageBox.Show("검색 되었습니다.");


                    string[] arr = responseData.Trim().Split(',');

                    for (int i = 0; i < arr.Length / 4; i++)
                    {
                        Model md = new Model();

                        md.model_id = Int32.Parse(arr[i * 4]);
                        md.temp_margin = Int32.Parse(arr[i * 4 + 1]);
                        md.humid_margin = Int32.Parse(arr[i * 4 + 2]);
                        md.model_name = arr[i * 4 + 3];

                        if (m_dtModel.Rows.Count < arr.Length / 4)
                        {
                            m_dtModel.Rows.Add(arr[i * 4], arr[i * 4 + 1], arr[i * 4 + 2], arr[i * 4 + 3]);
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

                ShowModelInfoToGridCtrl();
            }

        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private int currentIndex = -1;

        private void Model_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //currentIndex = e.RowIndex; // 현재 인덱스를 필드에 보관
            DataGridViewCell dgvc = DataGridView_Model.Rows[e.RowIndex].Cells[0];
            currentIndex = Convert.ToInt32(dgvc.Value.ToString()) - 1;
            if (currentIndex != -1)
            {
                txtbox_model_id.Text = DataGridView_Model.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbox_model_temp.Text = DataGridView_Model.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtbox_model_humidity.Text = DataGridView_Model.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtbox_model_name.Text = DataGridView_Model.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }

        private void Model_set_Load(object sender, EventArgs e)
        {
            ShowModelInfoToGridCtrl();
        }

        // 그리뷰에 띄우는 함수
        public void ShowModelInfoToGridCtrl()
        {
            // clear model_info table ctrl
            m_dtModel.Clear();
            m_listReceivedModel.Clear();

            ServerComm server_comm = new ServerComm(true);

            server_comm.Connect(m_sServerIp, m_nServerPort);

            server_comm.req_model_list(ref m_listReceivedModel);      

            foreach (Control ctl in this.Controls)
            {
                if (typeof(System.Windows.Forms.TextBox) == ctl.GetType())
                {
                    ctl.Text = null;
                }
            }

            server_comm.Close();
        }
    }
}
