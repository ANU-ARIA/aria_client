using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Set
{
    class Lot
    {
        string responseData, send_message;
        public string req_lot_select(string i)
        {
            if (i == "0")
            {
                send_message = "req_lot_select";
                Server.Server server = new Server.Server();
                responseData = server.Server_Open(send_message);
                
            }
            else
            {
                send_message = "req_lot_select1,"+i+"";
                Server.Server server = new Server.Server();
                responseData = server.Server_Open(send_message);
            }
            return responseData;
        }
        public string req_lot_update(string lot_id, string model_id, string line_id, string product_count, string speed, string fail_rate
            ,string color, string temp, string humidity, string oper_id, string working_state)
        {
            send_message = "req_lot_update," + lot_id + "," + model_id + "," + line_id + "," + product_count + "," + speed + "," + fail_rate + "," + color + "," + temp + "," 
                + humidity + "," + oper_id + "," + working_state;
            Server.Server server = new Server.Server();
            responseData = server.Server_Open(send_message);
            return responseData;
        }
        public string req_lot_delete()
        {
            send_message = "req_lot_delete";
            Server.Server server = new Server.Server();
            responseData = server.Server_Open(send_message);
            return responseData;
        }
    }
}
