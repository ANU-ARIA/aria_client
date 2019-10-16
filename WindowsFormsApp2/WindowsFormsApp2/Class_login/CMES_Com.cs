using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESComm
{
    class CLogInReqResponse
    {
        public CLogInReqResponse(string _data)
        {
            // result, right, nak_reason ex) "OK", "OPER", ""
            sResult = "";
            sRight = "";
            sNakReason = "";
        }
        public string sResult="";
        public string sRight = "";
        public string sNakReason = "";
    }


    class CUser_set
    {
        public CUser_set()
        {

        }
    }

}
