using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using MESComm;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace MESComm
{
    class ServerComm
    {
        private   IPEndPoint    m_clientAddress;
        private   IPEndPoint    m_serverAddress;
        private   TcpClient     m_TcpClient;
        private   NetworkStream m_streamClient;

        string    m_sBindIp = "220.69.249.232";
        string    m_sServerIp = "220.69.249.232";
        const int m_nPort = 4000;
        bool      m_bSimulate = true;

        public IEnumerable<Control> Controls { get; private set; }

        public ServerComm(bool _bSimul)
        {
            m_bSimulate = _bSimul;
        }

        public ServerComm()
        {
        }

        public void InInitializer()
        {

        }

        public void Finalize()
        {

        }


        public int Connect(string sIpAddress, int nPort)
        {
            int nRet = 0;

            if (!m_bSimulate)
            {
                m_clientAddress = new IPEndPoint(IPAddress.Parse(m_sBindIp), m_nPort);
                m_serverAddress = new IPEndPoint(IPAddress.Parse(m_sServerIp), m_nPort);

                m_TcpClient     = new TcpClient(m_clientAddress);
                m_TcpClient.Connect(m_serverAddress);

                m_streamClient  = m_TcpClient.GetStream();
            }
            return nRet;
        }

        public void Close()
        {
            if (!m_bSimulate)
            {
                m_streamClient.Close();
                m_TcpClient.Close();
            }
        }

        public int req_user_log_in(string sId, string sPw)
        {
            string sMsg="";
            int nRet = Send(sMsg);
            return nRet;
        }

        // 모델 call_bye
        public int req_model_list(ref List<Model> _list_model, string _message)
        {
            string message  = _message;
            int nMsgId      = 1;
            int nRet        = Send(message);

            // 메세지 수신
            string responseData = "";
            byte[] data = new byte[1280];
            int bytes;
            if (!m_bSimulate)
            {
                bytes        = m_streamClient.Read(data, 0, data.Length);
                responseData = Encoding.Default.GetString(data, 0, bytes);
            }
            else
            {
                responseData = "1,1,1,chokopi,";
            }
            analyze_req_model_list(responseData, ref _list_model);

            return nRet;
        }
    
        // 모델 responseData 리스트
        private int analyze_req_model_list(string _responseData, ref List<Model> _list_model)
        {
            string[] arr = _responseData.Trim().Split(',');


            for (int i = 0; i < arr.Length / 4; i++)
            {
                Model md = new Model();

                md.model_id      = Int32.Parse(arr[i * 4]);
                md.temp_margin   = Int32.Parse(arr[i * 4 + 1]);
                md.humid_margin  = Int32.Parse(arr[i * 4 + 2]);
                md.model_name    = arr[i * 4 + 3];
         
                _list_model.Add(md);
            }

            return 0;
        }


        // 유저 call-bye
        public int req_user_list(ref List<Aria_user> _list_user, string _message)
        {
            string message = _message;
            int nMsgId = 1;
            int nRet = Send(message);

            // 메세지 수신
            string responseData = "";
            byte[] data = new byte[1280];
            int bytes;
            if (!m_bSimulate)
            {
                bytes = m_streamClient.Read(data, 0, data.Length);
                responseData = Encoding.Default.GetString(data, 0, bytes);
            }
            else
            {
                responseData = "kim,1234,1,chokopi@com,kim,seong,";
            }
            analyze_req_user_list(responseData, ref _list_user);

            return nRet;
        }

        // 유저 responseData 리스트
        private int analyze_req_user_list(string _responseData, ref List<Aria_user> _list_user)
        {
            string[] arr = _responseData.Trim().Split(',');


            for (int i = 0; i < arr.Length / 6; i++)
            {
                Aria_user us = new Aria_user();

                us.user_id     = arr[i * 6];
                us.pass_word   = arr[i * 6 + 1];
                us.level       = Int32.Parse(arr[i * 6 + 2]);
                us.e_mail      = arr[i * 6 + 3];
                us.first_name  = arr[i * 6 + 4];
                us.last_name   = arr[i * 6 + 5];

                _list_user.Add(us);
            }

            return 0;
        }


        private int Send(string _message)
        {
            int nRet = 0;

            byte[] data = System.Text.Encoding.Default.GetBytes(_message);

            if (!m_bSimulate)
            {
                m_streamClient.Write(data, 0, data.Length);
            }
            return nRet;
        }

    }
}
