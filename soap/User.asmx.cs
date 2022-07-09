using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services;
using System.Xml;

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
        private string soapUserCredentials = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes("soapuser" + ":" + "soappassword"));

        [WebMethod]
        public string GetUserBy(string id) => MakeRequest(id);

        private string MakeRequest(string userid)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create($"http://localhost:5050/api/User/{userid}");
            req.Accept = "application/xml";
            req.Headers.Add("Authorization", "Basic " + soapUserCredentials);
            // access req.Headers to get/set header values before calling GetResponse. 
            // req.CookieContainer allows you access cookies.

            var response = req.GetResponse();
            string webcontent;
            using (var strm = new StreamReader(response.GetResponseStream()))
            {
                webcontent = strm.ReadToEnd();

                var dom = new XmlDocument();
                dom.LoadXml(webcontent);
                var mgr = new XmlNamespaceManager(dom.NameTable);
                mgr.AddNamespace("x", "http://www.w3.org/1999/xhtml");
                var res = dom.SelectNodes($"//User[ID='{userid}']", mgr);
                return webcontent;
            }
        }
    }
}


/*
 
System.Web.Services.Protocols.SoapException: Server was unable to process request. ---> System.Net.WebException: The remote server returned an error: (401) Unauthorized.
   at System.Net.HttpWebRequest.GetResponse()
   at soap.User.MakeRequest(String userid) in C:\Users\lcabraja\source\repos\iis-project-luka-cabraja\soap\User.asmx.cs:line 35
   --- End of inner exception stack trace ---
 */