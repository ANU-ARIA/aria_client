using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Set
{
    class Login
    {
        public string Log_In(string id, string pw)
        {
            string responseData, send_message;
            send_message = "req_user_log_in," + id + "," + pw;
            Server.Server server = new Server.Server();
            responseData = server.Server_Open(send_message);
            return responseData;
        }
    }
}
