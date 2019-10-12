using MySql.Data.MySqlClient;
using System;
using System.Collections;
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

    public partial class User_set : Form
    {
        string bindIp = "220.69.249.232";
        string serverIp = "220.69.249.232";
        const int serverPort = 4000;
        int bb = Convert.ToInt32(1000);

        int cost = -1;

        private List<Aria_user> addr;
        DataTable table = new DataTable();

        Aria_user Us = new Aria_user();



        public User_set()
        {
            InitializeComponent();

            addr = new List<Aria_user>();

            table.Columns.Add("아이디", typeof(string));
            table.Columns.Add("비밀번호", typeof(string));
            table.Columns.Add("권한", typeof(int));
            table.Columns.Add("e-mail", typeof(string));
            table.Columns.Add("성", typeof(string));
            table.Columns.Add("이름", typeof(string));

            user_view.DataSource = table;

        }

        public void re_set()
        {
            table.Clear();
            addr.Clear();
        }

        public void tcp_ip()
        {
        }

        private void m1_Load(object sender, EventArgs e)
        {
            TJcl();
        }

        // 삽입
        private void insert_Click(object sender, EventArgs e)
        {
            re_set();

            try
            {

                if (level_btn1.Checked == true) cost = 0;
                else if (level_btn2.Checked == true) cost = 1;

                if (cost == -1)
                {
                    MessageBox.Show("관리자, 사용자를 선택해주세요");
                    return;
                }


                // 텍스트 데이터
                Us.user_id = id_text.Text;
                Us.pass_word = pw_text.Text;
                Us.level = cost;
                Us.e_mail = email_text.Text;
                Us.first_name = first_text.Text;
                Us.last_name = last_text.Text;


                // 데이터를 하나의 메세지로 묶는다.
                string message;

                message = "{{#!!," + Us.user_id + "," + Us.pass_word + "," + Us.level + "," + Us.e_mail + "," + Us.first_name +
                "," + Us.last_name + ",#}}";


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
                    users_box.Text = responseData;
                    MessageBox.Show("생성 되었습니다.");
                }
                else
                {
                    MessageBox.Show("생성에 실패했습니다.");
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

        
        // 삭제
        private void Delete_Click(object sender, EventArgs e)
        {
            re_set();

            if (level_btn1.Checked == true) cost = 0;
            else if (level_btn2.Checked == true) cost = 1;

            // 텍스트 데이터
            Us.user_id = id_text.Text;
            Us.pass_word = pw_text.Text;
            Us.level = cost;
            Us.e_mail = email_text.Text;
            Us.first_name = first_text.Text;
            Us.last_name = last_text.Text;


            // 데이터를 하나의 메세지로 묶는다.
            string message;

            message = "{{#!@," + Us.user_id + "," + Us.pass_word + "," + Us.level + "," + Us.e_mail + "," + Us.first_name +
                "," + Us.last_name + ",#}}";

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
                users_box.Text = responseData;
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

        // 수정
        private void Update_Click(object sender, EventArgs e)
        {
            re_set();

            if (level_btn1.Checked == true) cost = 0;
            else if (level_btn2.Checked == true) cost = 1;

            if (cost == -1)
            {
                MessageBox.Show("관리자, 사용자를 선택해주세요");
                return;
            }

            // 텍스트 데이터
            Us.user_id = id_text.Text;
            Us.pass_word = pw_text.Text;
            Us.level = cost;
            Us.e_mail = email_text.Text;
            Us.first_name = first_text.Text;
            Us.last_name = last_text.Text;


            // 데이터를 하나의 메세지로 묶는다.
            string message;

            message = "{{#!#," + Us.user_id + "," + Us.pass_word + "," + Us.level + "," + Us.e_mail + "," + Us.first_name +
                "," + Us.last_name + ",#}}";

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
                users_box.Text = responseData;
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

        // 검색 %
        private void search_Click(object sender, EventArgs e)
        {
            re_set();

            // 텍스트 데이터
            try
            {

                Us.user_id = id_sc_text.Text;
                // 데이터를 하나의 메세지로 묶는다.
                string message;

                message = "{{#!%," + Us.user_id + ",#}}";

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

                if (responseData == "없음") //result.sResult == "OK"
                {
                    MessageBox.Show("검색된 값이 없습니다.");
                    TJcl();
                    stream.Close();
                    client.Close();

                }
                else
                {
                    MessageBox.Show("검색 되었습니다.");

                    users_box.Text = responseData;

                    string[] arr = responseData.Trim().Split(',');

                    for (int i = 0; i < arr.Length / 6; i++)
                    {
                        Aria_user md = new Aria_user();

                        md.user_id = arr[i * 6];
                        md.pass_word = arr[i * 6 + 1];
                        md.level = Int32.Parse(arr[i * 6 + 2]);
                        md.e_mail = arr[i * 6 + 3];
                        md.first_name = arr[i * 6 + 4];
                        md.last_name = arr[i * 6 + 5];

                        if (table.Rows.Count < arr.Length / 6)
                        {
                            table.Rows.Add(arr[i * 6], arr[i * 6 + 1], arr[i * 6 + 2], arr[i * 6 + 3], arr[i * 6 + 4], arr[i * 6 + 5]);
                        }

                    }
                    // 객체 종료
                    stream.Close();
                    client.Close();
                }

            }
            catch (Exception h)
            {
                MessageBox.Show("총 검색.");

                TJcl();
            }

        }


        public void TJcl()
        {
            re_set();

            string message;

            message = "{{#!$,,#}}";

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

            users_box.Text = responseData;

            string[] arr = responseData.Trim().Split(',');

            for (int i = 0; i < arr.Length / 6; i++)
            {
                Aria_user md = new Aria_user();

                md.user_id = arr[i * 6];
                md.pass_word = arr[i * 6 + 1];
                md.level = Int32.Parse(arr[i * 6 + 2]);
                md.e_mail = arr[i * 6 + 3];
                md.first_name = arr[i * 6 + 4];
                md.last_name = arr[i * 6 + 5];

                if (table.Rows.Count < arr.Length / 6)
                {
                    table.Rows.Add(arr[i * 6], arr[i * 6 + 1], arr[i * 6 + 2], arr[i *  6+ 3], arr[i * 6 + 4], arr[i * 6 + 5]);
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

        private int currentIndex = -1;

        private void User_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ////currentIndex = e.RowIndex; // 현재 인덱스를 필드에 보관
            //DataGridViewCell dgvc = user_view.Rows[e.RowIndex].Cells[0];
            //currentIndex = Convert.ToInt32(dgvc.Value.ToString()) - 1;
            //if (currentIndex != -1)
            //{
            //    id_text.Text = user_view.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    pw_text.Text = user_view.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    levet_text.Text = user_view.Rows[e.RowIndex].Cells[2].Value.ToString();
            //    email_text.Text = user_view.Rows[e.RowIndex].Cells[3].Value.ToString();
            //    first_text.Text = user_view.Rows[e.RowIndex].Cells[4].Value.ToString();
            //    last_text.Text = user_view.Rows[e.RowIndex].Cells[5].Value.ToString();

            //}
        }

        private void User_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
