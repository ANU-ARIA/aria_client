using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Set
{
    class Products
    {
        string send_message, responseData;
        public string Products_update(string model_name, string line_id, string lot_id, string lot_amount)
        {
            send_message = "req_products_update," + model_name + "," + line_id + "," + lot_id + ","+lot_amount;
            Server.Server server = new Server.Server();
            responseData = server.Server_Open(send_message);
            return responseData;
        }

        public string Products_update2(string _id, string lot_id, string model_temp, string model_humid, string insp_result, string fail_reason)
        {
            send_message = "req_products_update2," + _id + "," + lot_id + "," + model_temp + "," + model_humid + "," + insp_result + "," + fail_reason;
            Server.Server server = new Server.Server();
            responseData = server.Server_Open(send_message);
            return responseData;
        }

        public string Products_update3(string _id, string lot_id)
        {
            send_message = "req_products_update3," + _id + "," + lot_id ;
            Server.Server server = new Server.Server();
            responseData = server.Server_Open(send_message);
            return responseData;
        }
    }
}
