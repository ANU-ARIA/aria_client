using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Server
{
    class Server
    {
        public string Server_Open(string message)
        {
            string bindIp = "220.69.249.226";
            string serverIp = "220.69.249.226";
            const int serverPort = 4000;
            Random r = new Random();

            string responseData = "";
            int Random_Port = r.Next(0, 60000);

            Server_Sysnum();

            IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(bindIp), Random_Port);
            IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);
            TcpClient client    = new TcpClient(clientAddress);

            client.Connect(serverAddress);

            byte[]  data            = System.Text.Encoding.Default.GetBytes("{{$" + Form_main_menu.number_all + "," + message + ",$}}"); // message값 송신
            NetworkStream stream    = client.GetStream();
            stream.Write(data, 0, data.Length);
            data                    = new byte[1024];

            int bytes               = stream.Read(data, 0, data.Length);
            responseData            = Encoding.Default.GetString(data, 0, bytes); // responseData값 수신

            stream.Close();
            client.Close();

            return responseData;
        }
        public static void Server_Sysnum()
        {
            if (Form_main_menu.number_1 == 10)
            {
                Form_main_menu.number_2 = (Convert.ToInt32(Form_main_menu.number_2) + 1).ToString();
                Form_main_menu.number_1 = 0;
            }
            if (Form_main_menu.number_2 == "10")
            {
                Form_main_menu.number_3 = (Convert.ToInt32(Form_main_menu.number_3) + 1).ToString();
                Form_main_menu.number_2 = "0";
            }
            if (Form_main_menu.number_3 == "10")
            {
                Form_main_menu.number_4 = (Convert.ToInt32(Form_main_menu.number_4) + 1).ToString();
                Form_main_menu.number_3 = "0";
            }
            if (Form_main_menu.number_4 == "10")
            {
                Form_main_menu.number_5 = (Convert.ToInt32(Form_main_menu.number_5) + 1).ToString();
                Form_main_menu.number_4 = "0";
            }
            Form_main_menu.number_all = Form_main_menu.number_4 + Form_main_menu.number_3 + Form_main_menu.number_2 + Form_main_menu.number_1.ToString();
            Form_main_menu.number_1++;
        }
    }
}
