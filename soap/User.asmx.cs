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

        private string GetJWT()
        {
            HttpWebRequest auth = (HttpWebRequest)WebRequest.Create("http://localhost:5050/api/User/authentication");
            string postData = "{\"username\":\"lcabraja\",\"password\":\"1234567890\"}";
            auth.Method = "POST";
            auth.ContentType = "application/json";

            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytes = encoding.GetBytes(postData);
            auth.ContentLength = bytes.Length;

            Stream newStream = auth.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = auth.GetResponse();
            string webcontent = null;
            using (var strm = new StreamReader(response.GetResponseStream()))
            {
                webcontent = strm.ReadToEnd();
            }
            return webcontent;
        }

        private string MakeRequest(string userid)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:5050/api/User/");
            req.Accept = "application/xml";
            req.Headers.Add("Authorization", "Bearer " + GetJWT());
            // access req.Headers to get/set header values before calling GetResponse. 
            // req.CookieContainer allows you access cookies.

            var response = req.GetResponse();
            string webcontent;
            using (var strm = new StreamReader(response.GetResponseStream()))
            {
                webcontent = strm.ReadToEnd();

                var doc = new XmlDocument();
                doc.LoadXml(webcontent);
                XmlNode root = doc.DocumentElement;


                XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
                nsmgr.AddNamespace("i", "http://www.w3.org/2001/XMLSchema-instance");
                nsmgr.AddNamespace("us", "http://schemas.datacontract.org/2004/07/model");

                XmlNode node = root.SelectSingleNode("descendant::us:User[us:ID='lcabraja-id']", nsmgr);
                return node?.OuterXml;
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