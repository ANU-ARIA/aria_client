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
        string serverIp = "220.69.249.226";
        const int serverPort = 4000;

        int bb = Convert.ToInt32(669);

        int cost = -1;



        public User_set()
        {
            InitializeComponent();

        }

        private void m1_Load(object sender, EventArgs e)
        {

        }

        // 삽입
        private void insert_Click(object sender, EventArgs e)
        {
            if (level_btn1.Checked == true) cost = 0;
            else if (level_btn2.Checked == true) cost = 1;

            if (cost == -1)
            {
                MessageBox.Show("관리자, 사용자를 선택해주세요");
                return;
            }

            // 텍스트 데이터
            string id = id_text.Text;
            string pw = pw_text.Text;
            int level = cost;
            string e_mail = email_text.Text;
            string f_name = first_text.Text;
            string l_name = last_text.Text;


            // 데이터를 하나의 메세지로 묶는다.
            string message;

            message = "{{#!!," + id_text.Text + "," + pw_text.Text + ","+ level +"," + email_text.Text + "," + first_text.Text +
                "," + last_text.Text  + ",#}}";

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
                MessageBox.Show("생성되었습니다.");
            }
            else
            {
                MessageBox.Show("생성에 실패했습니다.");
            }

            // 객체 종료
            stream.Close();
            client.Close();

        }

        // 검색 
        private void search_Click(object sender, EventArgs e)
        {
            if (level_btn1.Checked == true) cost = 0;
            else if (level_btn2.Checked == true) cost = 1;

            if (cost == -1)
            {
                MessageBox.Show("권한을 선택해주세요.");
                return;
            }

            // 텍스트 데이터
            string id = id_text.Text;
            string pw = pw_text.Text;
            int level = cost;
            string e_mail = email_text.Text;
            string f_name = first_text.Text;
            string l_name = last_text.Text;


            // 데이터를 하나의 메세지로 묶는다.
            string message;

            message = "{{#!$," + id_text.Text + "," + pw_text.Text + "," + level + "," + email_text.Text + "," + first_text.Text +
                "," + last_text.Text + ",#}}";

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

            if (responseData == "select 받았습니다~") //result.sResult == "OK"
            {
                users_box.Text = responseData;
                MessageBox.Show("검색되었습니다.");
            }
            else
            {
                MessageBox.Show("검색에 실패했습니다.");
            }


            // 객체 종료
            stream.Close();
            client.Close();
        }

        // 삭제
        private void Delete_Click(object sender, EventArgs e)
        {
            if (level_btn1.Checked == true) cost = 0;
            else if (level_btn2.Checked == true) cost = 1;

            if (cost == -1)
            {
                MessageBox.Show("관리자, 사용자를 선택해주세요");
                return;
            }

            // 텍스트 데이터
            string id = id_text.Text;
            string pw = pw_text.Text;
            int level = cost;
            string e_mail = email_text.Text;
            string f_name = first_text.Text;
            string l_name = last_text.Text;


            // 데이터를 하나의 메세지로 묶는다.
            string message;

            message = "{{#!@," + id_text.Text + "," + pw_text.Text + "," + level + "," + email_text.Text + "," + first_text.Text +
                "," + last_text.Text + ",#}}";

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
                MessageBox.Show("삭제되었습니다.");
            }
            else
            {
                MessageBox.Show("삭제에 실패했습니다.");
            }


            // 객체 종료
            stream.Close();
            client.Close();
        }

        // 수정
        private void Update_Click(object sender, EventArgs e)
        {
            if (level_btn1.Checked == true) cost = 0;
            else if (level_btn2.Checked == true) cost = 1;

            if (cost == -1)
            {
                MessageBox.Show("관리자, 사용자를 선택해주세요");
                return;
            }

            // 텍스트 데이터
            string id = id_text.Text;
            string pw = pw_text.Text;
            int level = cost;
            string e_mail = email_text.Text;
            string f_name = first_text.Text;
            string l_name = last_text.Text;


            // 데이터를 하나의 메세지로 묶는다.
            string message;

            message = "{{#!#," + id_text.Text + "," + pw_text.Text + "," + level + "," + email_text.Text + "," + first_text.Text +
                "," + last_text.Text + ",#}}";

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
                MessageBox.Show("업데이트 되었습니다.");
            }
            else
            {
                MessageBox.Show("업데이트에 실패했습니다.");
            }


            // 객체 종료
            stream.Close();
            client.Close();
        }
    }
}
