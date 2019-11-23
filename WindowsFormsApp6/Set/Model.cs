using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.Server;

namespace WindowsFormsApp6.Set
{
    class Model
    {
        string responseData, send_message;
        public string req_model_select(string model_id_list, string model_info_list)
        {
            send_message = "req_model_select," + model_id_list + "," + model_info_list;
            Server.Server server = new Server.Server();
            responseData = server.Server_Open(send_message);
            return responseData;
        }

        public string req_model_update(List<string> model_info)
        {
            if (model_info[4] == "55")
            {
                send_message = "req_model_create," + model_info[0] + "," + model_info[1] + "," + model_info[2] + "," + model_info[3];
                Server.Server server = new Server.Server();
                responseData = server.Server_Open(send_message);
            }
            else
            {
                send_message = "req_model_update," + model_info[0] + "," + model_info[1] + "," + model_info[2] + "," + model_info[3];
                Server.Server server = new Server.Server();
                responseData = server.Server_Open(send_message);
            }
            return responseData;
        }
        public string req_model_delete(string model_info)
        {
            send_message = "req_model_delete," + model_info + ",,,,,,";
            Server.Server server = new Server.Server();
            responseData = server.Server_Open(send_message);
            return responseData;
        }
    }
}
