using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Set
{
    class Pi
    {
        string responseData, send_message;
        public string Pi_send(string lot_id, string prod_model, string prod_count, string model_temp, string model_humid, string line, string prod_color)
        {
            send_message = "S2F41," + lot_id + "," + prod_model + "," + prod_count + "," + model_temp + "," + model_humid + "," + line + "," + prod_color;
            Server.Server server = new Server.Server();
            responseData = server.Server_Open(send_message);
            return responseData;
        }
    }
}
