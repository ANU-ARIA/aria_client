using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Set
{
    class Line
    {
        string send_message, responseData;
        public string Line_Update(string lot_id, string line_id, string oper_name)
        {
            send_message = "req_line_update," + lot_id + "," + line_id + "," + oper_name;
            Server.Server server = new Server.Server();
            responseData = server.Server_Open(send_message);
            return responseData;
        }
        public string Line_Update2(string line, string line_temp, string line_humid)
        {
            send_message = "req_line_update2," + line + "," + line_temp + "," + line_humid;
            Server.Server server = new Server.Server();
            responseData = server.Server_Open(send_message);
            return responseData;
        }
        public string Line_Update3(string line)
        {
            send_message = "req_line_update3," + line;
            Server.Server server = new Server.Server();
            responseData = server.Server_Open(send_message);
            return responseData;
        }
    }
}
