using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services;

namespace soap
{
    /// <summary>
    /// Summary description for User
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class User : System.Web.Services.WebService
    {
        [WebMethod]
        public string GetUserBy(string id) => MakeRequest(id);

        private string MakeRequest(string userid)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create($"http://localhost:5050/api/User/{userid}");
            // access req.Headers to get/set header values before calling GetResponse. 
            // req.CookieContainer allows you access cookies.

            var response = req.GetResponse();
            string webcontent;
            using (var strm = new StreamReader(response.GetResponseStream()))
            {
                webcontent = strm.ReadToEnd();
                return webcontent;
            }
        }
    }
}
