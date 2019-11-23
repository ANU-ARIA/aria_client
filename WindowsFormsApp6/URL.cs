using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class URL
    {
        public string Facebook(ref string url)
        {
            url = "https://www.facebook.com";
            return url;
        }
        public string Twitter(string url)
        {
            url = "www.Twitter.com";
            return url;
        }
    }
}
