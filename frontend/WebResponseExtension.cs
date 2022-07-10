using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace frontend
{
    public static class WebResponseExtension
    {
        public static string GetBodyText(this WebResponse response)
        {
            string webcontent = "";
            using (var strm = new StreamReader(response.GetResponseStream()))
            {
                webcontent = strm.ReadToEnd();
            }
            return webcontent;
        }

        public static string GetBodyText(this HttpWebResponse response)
        {
            string webcontent = "";
            using (var strm = new StreamReader(response.GetResponseStream()))
            {
                webcontent = strm.ReadToEnd();
            }
            return webcontent;
        }
    }
}
