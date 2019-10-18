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
using WindowsFormsApp2.Class_lot;
using WindowsFormsApp2.Class_Model;

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

        List<Aria_user> _list_user = new List<Aria_user>();

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
            string sMsg  = "";
            int nRet     = Send(sMsg);
            return nRet;
        }

        //Model Insert
        public int req_model_insert(Model _md)
        {
            // MES Server에 전달할 메세지를 만든다.
            string message;
            message = "{{#@@," + _md.model_id + "," + _md.temp_margin + "," + _md.humid_margin + "," + _md.model_name + ",#}}";

            int nErr = Send(message);

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
                responseData = "1,1,1,chokopi,";
            }

            int nAck=0;
            string sReason = "";

            analyze_req_model_insert(responseData, ref nAck, ref sReason);

            return nErr;
        }

        public void analyze_req_model_insert(string responseData, ref int _nAck, ref string _sReason)
        {
            _nAck = 0;
            _sReason = "거절 사유";

        }

    
        // 모델 responseData 리스트
        private int analyze_req_model_list(string _responseData, ref List<Aria_model> _list_model)
        {
            string[] arr = _responseData.Trim().Split(',');


            for (int i = 0; i < arr.Length / 4; i++)
            {
                Aria_model md = new Aria_model();

                md.model_id      = arr[i * 4];
                md.temp_margin   = Int32.Parse(arr[i * 4 + 1]);
                md.humid_margin  = Int32.Parse(arr[i * 4 + 2]);
                md.model_name    = arr[i * 4 + 3];
         
                _list_model.Add(md);
            }

            return 0;
        }

        // 유저 Call By
        public List<Aria_user> req_user_send(Aria_user _us, string _btn_evnt, List<Aria_user> _list_user)
        {
            // MES Server에 전달할 메세지를 만든다.
            string message;

            // insert, delete, update, search, search_all 의 메세지 정의
            // 삽입
            if (_btn_evnt == "!")
            {
                message = "{{#@!," + _us.user_id + "," + _us.pass_word + "," + _us.level + "," + _us.e_mail + "," + _us.first_name + "," + _us.last_name + ",#}}";
            }
            // 삭제
            else if (_btn_evnt == "@")
            {
                message = "{{#@@," + _us.user_id + ",#}}";
            }
            // 수정
            else if (_btn_evnt == "#")
            {
                message = "{{#@#," + _us.user_id + "," + _us.pass_word + "," + _us.level + "," + _us.e_mail + "," + _us.first_name + "," + _us.last_name + ",#}}";
            }
            // 검색
            else if (_btn_evnt == "$")
            {
                message = "{{#@$," + _us.user_id + ",#}}";
            }
            // 총 검색
            else
            {
                message = "{{#@%,,#}}";
            }

            // string 형식의 메세지를 서버 프로토콜에 byte형식으로 보내기 위한 곳
            int nErr = Send(message);

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
                responseData = "OK, ,Sin,1234,1,chokopi@com,Sin,su,";
            }

            string nAck = "";
            string sReason = "";

            // 받은 responseData의 ok, 거절사유, DB값 정제
            _list_user = analyze_req_user_list(responseData, ref nAck, ref sReason, ref _list_user);

            return _list_user;
        }

        // 유저 responseData 리스트
        public List<Aria_user> analyze_req_user_list(string _responseData, ref string _nAck, ref string _sReason, ref List<Aria_user> _list_user)
        {

            string[] arr = _responseData.Trim().Split(',');

            _nAck = arr[0];
            _sReason = arr[1];

            for (int i = 2; i < (arr.Length - 2) / 6; i++)
            {
                Aria_user us = new Aria_user();

                us.user_id = arr[i * 6 - 10];
                us.pass_word = arr[i * 6 - 9];
                us.level = Int32.Parse(arr[i * 6 - 8]);
                us.e_mail = arr[i * 6 - 7];
                us.first_name = arr[i * 6 - 6];
                us.last_name = arr[i * 6 - 5];

                _list_user.Add(us);
            }
            return _list_user;
        }

        // 작업지시 call-by reference
        public int req_lot_list(ref List<Aria_lot_line> _list_lot, string _message)
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
                responseData = "lot01,kim,작업중,초코빵,24,40,";
            }
            analyze_req_lot_list(responseData, ref _list_lot);

            return nRet;
        }


        // 작업지시 responseData 리스트
        private List<Aria_lot_line> analyze_req_lot_list(string _responseData, ref List<Aria_lot_line> _list_lot)
        {
            string[] arr = _responseData.Trim().Split(',');

            for (int i = 0; i < arr.Length / 5; i++)
            {
                Aria_lot_line lot = new Aria_lot_line();

                lot.lot_id = arr[i * 5];
                lot.user_name = arr[i * 5 + 1];
                lot.line_state = arr[i * 5 + 2];
                lot.line_temp = arr[i * 5 + 3];
                lot.line_humidity = arr[i * 5 + 4];

                _list_lot.Add(lot);
            }
            return _list_lot;
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
