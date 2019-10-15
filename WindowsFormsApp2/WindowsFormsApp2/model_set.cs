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
        string               m_sMessage = "";
        string               m_sServerIp = "220.69.249.232";
        const int            m_nServerPort = 4000;
        const int            m_nClientPort = 4000;
        private List<Model>  m_listReceivedModel;
        DataTable            m_dtModel = new DataTable();
        ServerComm           server_comm = new ServerComm(true);

        // txtbox clear
        public void Txtboxmodel_clear()
        {
            txtbox_model_id.Clear();
            txtbox_model_temp.Clear();
            txtbox_model_humidity.Clear();
            txtbox_model_name.Clear();
            txtbox_model_id_sch.Clear();
        }

        public Model_set()
        {
            InitializeComponent();

            m_listReceivedModel = new List<Model>();

            //DataTable table = new DataTable();

            m_dtModel.Columns.Add("모델 id",   typeof(int));
            m_dtModel.Columns.Add("적정 온도", typeof(int));
            m_dtModel.Columns.Add("적정 습도", typeof(int));
            m_dtModel.Columns.Add("모델 명",   typeof(string));

            DataGridView_Model.DataSource = m_dtModel;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // 생성
        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                // clear model_info table ctrl
                m_dtModel.Clear();
                m_listReceivedModel.Clear();

                // 텍스트 데이터 (컨트롤로 부터 데이터를 가져옴.)
                int md_id       = Int32.Parse(txtbox_model_id.Text);
                float md_temp   = Int32.Parse(txtbox_model_temp.Text);
                float md_hum    = Int32.Parse(txtbox_model_humidity.Text);
                string md_name  = txtbox_model_name.Text;

                // 데이터를 하나의 메세지로 묶는다.
                // MES Server에 전달할 메세지를 만든다.

                m_sMessage = "{{#@!," + md_id + "," + md_temp + "," + md_hum + "," + md_name + ",#}}";

                server_comm.Connect(m_sServerIp, m_nServerPort);

                server_comm.req_model_list(ref m_listReceivedModel, m_sMessage);

                server_comm.Close();

                Txtboxmodel_clear();

                MessageBox.Show("값이 추가되었습니다.");

            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");
            }

            ShowModelInfoToGridCtrl();
            // 객체 종료

        }

        // 삭제
        private void Delete_Click(object sender, EventArgs e)
        {

            try
            {
                m_dtModel.Clear();
                m_listReceivedModel.Clear();
                // 텍스트 데이터
                int md_id      =  Int32.Parse(txtbox_model_id.Text);
                float md_temp  =  Int32.Parse(txtbox_model_temp.Text);
                float md_hum   =  Int32.Parse(txtbox_model_humidity.Text);
                string md_name =  txtbox_model_name.Text;

                // 데이터를 하나의 메세지로 묶는다.
                m_sMessage = "{{#@@," + md_id + "," + md_temp + "," + md_hum + "," + md_name + ",#}}";

                server_comm.Connect(m_sServerIp, m_nServerPort);

                server_comm.req_model_list(ref m_listReceivedModel, m_sMessage);

                server_comm.Close();

                Txtboxmodel_clear();

                MessageBox.Show("값이 삭제되었습니다.");

            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");
            }

            ShowModelInfoToGridCtrl();

        }

        // 수정
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                m_dtModel.Clear();
                m_listReceivedModel.Clear();

                // 텍스트 데이터
                int md_id      = Int32.Parse(txtbox_model_id.Text);
                float md_temp  = Int32.Parse(txtbox_model_temp.Text);
                float md_hum   = Int32.Parse(txtbox_model_humidity.Text);
                string md_name = txtbox_model_name.Text;

                // 데이터를 하나의 메세지로 묶는다.
                m_sMessage = "{{#@#," + md_id + "," + md_temp + "," + md_hum + "," + md_name + ",#}}";

                server_comm.Connect(m_sServerIp, m_nServerPort);

                server_comm.req_model_list(ref m_listReceivedModel, m_sMessage);

                server_comm.Close();

                Txtboxmodel_clear();

                MessageBox.Show("값이 수정되었습니다.");

            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");
                
            }

            ShowModelInfoToGridCtrl();

        }


        // 부분 검색
        private void Search_Click(object sender, EventArgs e)
        {
            // 텍스트 데이터
            try
            {
                m_dtModel.Clear();
                m_listReceivedModel.Clear();

                int md_id = Int32.Parse(txtbox_model_id_sch.Text);

                m_sMessage = "{{#@%," + md_id + ",#}}";

                server_comm.Connect(m_sServerIp, m_nServerPort);

                server_comm.req_model_list(ref m_listReceivedModel, m_sMessage);

                server_comm.Close();

                Txtboxmodel_clear();

                MessageBox.Show("값이 검색되었습니다.");

                // 객체 종료
            }
            catch
            {
                MessageBox.Show("총 검색.");
            }

            ShowModelInfoToGridCtrl();
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void Model_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtbox_model_id.Text       = this.DataGridView_Model.CurrentRow.Cells[0].Value.ToString();
            txtbox_model_temp.Text     = this.DataGridView_Model.CurrentRow.Cells[1].Value.ToString();
            txtbox_model_humidity.Text = this.DataGridView_Model.CurrentRow.Cells[2].Value.ToString();
            txtbox_model_name.Text     = this.DataGridView_Model.CurrentRow.Cells[3].Value.ToString();

        }

        private void Model_set_Load(object sender, EventArgs e)
        {
            ShowModelInfoToGridCtrl();

        }

        // 그리뷰에 띄우는 함수 (총검색)
        public void ShowModelInfoToGridCtrl()
        {
            // clear model_info table ctrl
            m_dtModel.Clear();
            m_listReceivedModel.Clear();

            m_sMessage = "{{#@%,,#}}";

            server_comm.Connect(m_sServerIp, m_nServerPort);

            server_comm.req_model_list(ref m_listReceivedModel, m_sMessage);

            server_comm.Close();

            Txtboxmodel_clear();
        }

    }
}
