using System.ComponentModel;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace frontend
{
    public partial class MainForm : Form
    {
        #region Variables
        private static readonly string username = "lcabraja";
        private static readonly string password = "1234567890";
        private static readonly string userdata = "<User xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns=\"http://schemas.datacontract.org/2004/07/model\"><ID>lcabraja-id</ID><Username>lcabraja</Username><PasswordHash>1234567890</PasswordHash><Images><Image><ResourceTitle>Fox 1</ResourceTitle><ResourceURL>https://randomfox.ca/images/1.jpg</ResourceURL><IsFavorite>true</IsFavorite></Image><Image><ResourceTitle>Fox 2</ResourceTitle><ResourceURL>https://randomfox.ca/images/2.jpg</ResourceURL><IsFavorite>false</IsFavorite></Image><Image><ResourceTitle>Fox 3</ResourceTitle><ResourceURL>https://randomfox.ca/images/3.jpg</ResourceURL><IsFavorite>false</IsFavorite></Image></Images></User>";

        private XmlSchemaSet schemas = new XmlSchemaSet();
        private ServiceReference2.UserSoapClient _soapClient;
        private api.Client.IRestClient _restClient;
        #endregion Variables

        #region Lifecycle
        public MainForm()
        {
            InitializeComponent();
            schemas.Add("http://schemas.datacontract.org/2004/07/model", XmlReader.Create(new StringReader(model.User.XSD)));
            _soapClient = new ServiceReference2.UserSoapClient(ServiceReference2.UserSoapClient.EndpointConfiguration.UserSoap);
            _restClient = new api.Client.RestClient("http://localhost:5050/", new HttpClient());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopTheParty.Cancel();
        }
        #endregion Lifecycle

        #region Zadatak 01
        private delegate void InvokeTask1Update(string text);
        private void Task1OutputUpdate(string text)
        {
            if (endLabel.InvokeRequired)
            {
                var d = new InvokeTask1Update(Task1OutputUpdate);
                task1Output.Invoke(d, new object[] { text });
            }
            else
            {
                task1Output.Text = text;
            }
        }

        private async void btnTask1_Click(object sender, EventArgs e) =>
            await Task.Run(() =>
            {
                try
                {
                    Task1OutputUpdate("Fetching [/api/user/xsd]");
                    var response = MakeRequest("/user/xsd", verb: "POST", body: task1Input.Text, contentType: "application/xml");
                    if (response is HttpWebResponse httpResponse)
                    {
                        if ((int)httpResponse?.StatusCode / 100 == 2)
                        {
                            Task1OutputUpdate($"OK [{(int)httpResponse.StatusCode} {httpResponse.StatusDescription}]");
                        }
                        else
                        {
                            Task1OutputUpdate($"NOT OK [{(int)httpResponse.StatusCode} {httpResponse.StatusDescription}]\n{response.GetBodyText()}");
                        }
                    }
                }
                catch (WebException ex)
                {
                    Task1OutputUpdate($"ERROR [{ex.Status}] {ex.Message}\n{ex.Response.GetBodyText()}");
                }
            });

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            task1Input.Text = userdata;
            task1Output.Text = "";
        }
        #endregion Zadatak 01

        #region Zadatak 02
        private delegate void InvokeTask2Update(string text);
        private void Task2OutputUpdate(string text)
        {
            if (endLabel.InvokeRequired)
            {
                var d = new InvokeTask2Update(Task2OutputUpdate);
                task2Output.Invoke(d, new object[] { text });
            }
            else
            {
                task2Output.Text = text;
            }
        }
        private async void btnTask2_Click(object sender, EventArgs e) =>
            await Task.Run(() =>
            {
                try
                {
                    Task2OutputUpdate("Fetching [/api/user/rng]");
                    var response = MakeRequest("/user/rng", verb: "POST", body: task2Input.Text, contentType: "application/xml");
                    if (response is HttpWebResponse httpResponse)
                    {
                        if ((int)httpResponse?.StatusCode / 100 == 2)
                        {
                            Task2OutputUpdate($"OK [{(int)httpResponse.StatusCode} {httpResponse.StatusDescription}]");
                        }
                        else
                        {
                            Task2OutputUpdate($"NOT OK [{(int)httpResponse.StatusCode} {httpResponse.StatusDescription}]\n{response.GetBodyText()}");
                        }
                    }
                }
                catch (WebException ex)
                {
                    Task2OutputUpdate($"ERROR [{ex.Status}] {ex.Message}\n{ex.Response.GetBodyText()}");
                }
            });

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            task2Input.Text = userdata;
            task2Output.Text = "";
        }
        #endregion Zadatak 02

        #region Zadatak 03
        private async void btnTask3_Click(object sender, EventArgs e)
        {
            task3Output.Text = "Performing request...";
            try
            {
                var result = await _soapClient.GetUserByAsync(task3Input.Text);
                task3Output.Text = result.Body.GetUserByResult;
                task4Input.Text = result.Body.GetUserByResult;
            }
            catch (Exception ex)
            {
                task3Output.Text = ex.Message;
                task4Input.Text = ex.Message;
            }
        }
        private void tabPage3_Enter(object sender, EventArgs e)
        {
            task3Input.Text = "lcabraja-id";
        }
        #endregion Zadatak 03

        #region Zadatak 04 
        private void btnTask4_Click(object sender, EventArgs e)
        {
            try
            {

                var xmldata = XElement.Parse(task4Input.Text);
                XDocument xmldoc = new XDocument(xmldata);

                bool hasErrors = false;
                string errorMessage = "";
                xmldoc.Validate(schemas, (o, e) =>
                    {
                        errorMessage = e.Message;
                        hasErrors = true;
                    });

                if (hasErrors)
                {
                    task4Output.Text = $"[Error] {errorMessage}";
                }
                else
                {
                    task4Output.Text = "[OK] Document passes XSD validation.";
                }
            }
            catch (XmlException ex)
            {
                task4Output.Text = $"[XML Error] {ex.Message}";
            }
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            task4Output.Text = "";
        }
        #endregion Zadatak 04

        #region Zadatak 05
        private static readonly string task5Action0 = "<?xml version=\"1.0\"?><methodCall><methodName>firstcity</methodName></methodCall>";
        private static readonly string task5Action1 = "<?xml version=\"1.0\"?><methodCall><methodName>listcities</methodName></methodCall>";
        private static readonly string task5Action2 = "<?xml version=\"1.0\"?><methodCall><methodName>cityname</methodName><params><param><value><string>CITYNAME</string></value></param></params></methodCall>";
        private void btnTask5_Click(object sender, EventArgs e)
        {
            try
            {
                int index = task5Actions.SelectedIndex;
                switch (index)
                {
                    case 0:
                        task5Output.Text = $"[{task5Actions.SelectedValue}] Performing request...";
                        var response0 = MakeRequest("/rpc", baseurl: "http://localhost:4040", verb: "POST", contentType: "application/xml", body: task5Input.Text);
                        if (response0 is HttpWebResponse httpResponse0)
                        {
                            if ((int)httpResponse0?.StatusCode / 100 == 2)
                            {
                                task5Output.Text = $"OK [{(int)httpResponse0.StatusCode} {httpResponse0.StatusDescription}]\n{response0.GetBodyText()}";
                            }
                            else
                            {
                                task5Output.Text = $"NOT OK [{(int)httpResponse0.StatusCode} {httpResponse0.StatusDescription}]\n{response0.GetBodyText()}";
                            }
                        }
                        return;
                    case 1:
                        task5Output.Text = $"[{task5Actions.SelectedValue}] Performing request...";
                        var response1 = MakeRequest("/rpc", baseurl: "http://localhost:4040", verb: "POST", contentType: "application/xml", body: task5Input.Text);
                        if (response1 is HttpWebResponse httpResponse1)
                        {
                            if ((int)httpResponse1?.StatusCode / 100 == 2)
                            {
                                task5Output.Text = $"OK [{(int)httpResponse1.StatusCode} {httpResponse1.StatusDescription}]\n{response1.GetBodyText()}";
                            }
                            else
                            {
                                task5Output.Text = $"NOT OK [{(int)httpResponse1.StatusCode} {httpResponse1.StatusDescription}]\n{response1.GetBodyText()}";
                            }
                        }
                        return;
                    case 2:
                        task5Output.Text = $"[{task5Actions.SelectedValue}] Performing request...";
                        var response2 = MakeRequest("/rpc", baseurl: "http://localhost:4040", verb: "POST", contentType: "application/xml", body: task5Input.Text);
                        if (response2 is HttpWebResponse httpResponse2)
                        {
                            if ((int)httpResponse2?.StatusCode / 100 == 2)
                            {
                                task5Output.Text = $"OK [{(int)httpResponse2.StatusCode} {httpResponse2.StatusDescription}]\n{response2.GetBodyText()}";
                            }
                            else
                            {
                                task5Output.Text = $"NOT OK [{(int)httpResponse2.StatusCode} {httpResponse2.StatusDescription}]\n{response2.GetBodyText()}";
                            }
                        }
                        return;
                    default:
                        task5Input.Text = "[Error] Bad action selected";
                        return;
                }
            }
            catch (WebException ex)
            {
                task5Output.Text = $"ERROR [{ex.Status}] {ex.Message}\n{ex.Response}";
            }

        }

        private void task5Actions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = task5Actions.SelectedIndex;
            switch (index)
            {
                case 0: task5Input.Text = task5Action0; return;
                case 1: task5Input.Text = task5Action1; return;
                case 2: task5Input.Text = task5Action2; return;
            }
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {

        }
        #endregion Zadatak 05

        #region Zadatak 06
        private delegate void InvokeTask6Update(string text);
        private void Task6OutputUpdate(string text)
        {
            if (endLabel.InvokeRequired)
            {
                var d = new InvokeTask6Update(Task6OutputUpdate);
                task6Output.Invoke(d, new object[] { text });
            }
            else
            {
                task6Output.Text = text;
            }
        }
        private async void btnTask6Unauthorized_Click(object sender, EventArgs e) =>
            await Task.Run(() =>
            {
                try
                {
                    Task6OutputUpdate("Fetching [/api/user]");
                    var response = MakeRequest("/user", authorize: false);
                    if (response is HttpWebResponse httpResponse)
                    {
                        if ((int)httpResponse?.StatusCode / 100 == 2)
                        {
                            Task6OutputUpdate($"OK [{(int)httpResponse.StatusCode} {httpResponse.StatusDescription}]");
                        }
                        else
                        {
                            Task6OutputUpdate($"NOT OK [{(int)httpResponse.StatusCode} {httpResponse.StatusDescription}]\n{response.GetBodyText()}");
                        }
                    }
                }
                catch (WebException ex)
                {
                    Task6OutputUpdate($"ERROR [{ex.Status}] {ex.Message}\n{ex.Response}");
                }
            });

        private async void btnTask6Authorized_Click(object sender, EventArgs e) =>
            await Task.Run(() =>
            {
                try
                {
                    Task6OutputUpdate("Fetching [/api/user]");
                    var response = MakeRequest("/user", authorize: true);
                    if (response is HttpWebResponse httpResponse)
                    {
                        if ((int)httpResponse?.StatusCode / 100 == 2)
                        {
                            Task6OutputUpdate($"OK [{(int)httpResponse.StatusCode} {httpResponse.StatusDescription}]");
                        }
                        else
                        {
                            Task6OutputUpdate($"NOT OK [{(int)httpResponse.StatusCode} {httpResponse.StatusDescription}]\n{response.GetBodyText()}");
                        }
                    }
                }
                catch (WebException ex)
                {
                    task6Output.Text = $"ERROR [{ex.Status}] {ex.Message}\n{ex.Response}";
                }
            });

        private void tabPage6_Enter(object sender, EventArgs e)
        {

        }
        #endregion Zadatak 06

        #region Zadatak 07
        private bool partyStarted = false;
        private CancellationTokenSource stopTheParty = new CancellationTokenSource();
        private delegate void InvokePartyUpdate(Color color, int x, int y);
        private void SetPartyValues(Color color, int x, int y)
        {
            if (endLabel.InvokeRequired)
            {
                var d = new InvokePartyUpdate(SetPartyValues);
                endLabel.Invoke(d, new object[] { color, x, y });
            }
            else
            {
                endLabel.ForeColor = color;
                endLabel.Location = new() { X = x, Y = y };
            }
        }
        private void tabPage7_Enter(object sender, EventArgs e)
        {
            if (!partyStarted)
            {
                partyStarted = true;
                Task.Run(() =>
                {
                    int i = 0;
                    bool goingUp = true;
                    while (!stopTheParty.Token.IsCancellationRequested)
                    {
                        endLabel.Location = new Point(endLabel.Location.X - 1, endLabel.Location.Y);
                        if (i >= 255) goingUp = false;
                        if (i <= 0) goingUp = true;
                        if (goingUp) i++; else i--;

                        int a, r, g, b;
                        string hex = string.Format("#{0:X2}{1:X2}00", i, 255 - i);
                        a = 255;
                        r = System.Convert.ToInt32(hex.Substring(1, 2), 16);
                        g = System.Convert.ToInt32(hex.Substring(3, 2), 16);
                        b = System.Convert.ToInt32(hex.Substring(5, 2), 16);
                        endLabel.ForeColor = System.Drawing.Color.FromArgb(a, r, g, b);
                        Console.WriteLine($"{r} {g} {b}");
                        Thread.Sleep(50);
                    }
                }, stopTheParty.Token);
            }
        }
        #endregion Zadatak 07

        #region Helper Methods
        private WebResponse? MakeRequest(
            string endpoint,
            string? body = null,
            string? contentType = null,
            string accept = "application/xml",
            string verb = "GET",
            string baseurl = "http://localhost:5050/api",
            bool authorize = true
        )
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create($"{baseurl}{endpoint}");
            req.Accept = accept;
            req.Method = verb;
            req.Headers.Add("Authorization", authorize ? "Bearer " + GetJWT() : "None");
            if (contentType != null)
            {
                req.ContentType = contentType;
            }

            if (body != null)
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] bytes = encoding.GetBytes(body);
                req.ContentLength = bytes.Length;

                Stream newStream = req.GetRequestStream();
                newStream.Write(bytes, 0, bytes.Length);
                newStream.Close();
            }
            return req.GetResponse();
        }
        private string GetJWT()
        {
            HttpWebRequest auth = (HttpWebRequest)WebRequest.Create("http://localhost:5050/api/User/authentication");
            string postData = $"{{\"username\":\"{username}\",\"password\":\"{password}\"}}";
            auth.Method = "POST";
            auth.ContentType = "application/json";

            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytes = encoding.GetBytes(postData);
            auth.ContentLength = bytes.Length;

            Stream newStream = auth.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            return auth.GetResponse().GetBodyText();
        }
        #endregion Helper Methods
    }
}
