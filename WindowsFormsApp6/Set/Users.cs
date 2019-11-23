using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Set
{
    class Users
    {
        string responseData, send_message;
        public string req_user_select(string user_id_list, string user_info_list)
        {
            send_message = "req_user_select," + user_id_list + "," + user_info_list;
            Server.Server server = new Server.Server();
            responseData = server.Server_Open(send_message);
            return responseData;
        }
        public string req_user_update(List<string> user_info)
        {
            
            if (user_info.Count == 6)
            {
                send_message = "req_user_update," + user_info[0] + "," + user_info[1] + "," + user_info[2] + "," + user_info[3] + "," + user_info[4] +
                    "," + user_info[5];
                Server.Server server = new Server.Server();
                responseData = server.Server_Open(send_message);
            }
            else if (user_info.Count == 7)
            {
                send_message = "req_user_update," + user_info[0] + "," + user_info[1] + "," + user_info[2] + "," + user_info[3] + "," + user_info[4] +
                    "," + user_info[5] + "," + user_info[6];
                Server.Server server = new Server.Server();
                responseData = server.Server_Open(send_message);
            }
            return responseData;
        }
        public string req_user_delete(string user_info)
        {
            send_message = "req_user_delete," + user_info + ",,,,,,";
            Server.Server server = new Server.Server();
            responseData = server.Server_Open(send_message);
            return responseData;
        }
    }
}
