using System.Xml;
using System.Xml.Schema;

namespace frontend
{
    public partial class MainForm : Form
    {
        private XmlSchemaSet schemas = new XmlSchemaSet();
        private ServiceReference2.UserSoapClient _soapClient;
        private api.Client.IRestClient _restClient;

        public MainForm()
        {
            InitializeComponent();
            schemas.Add("http://schemas.datacontract.org/2004/07/model", XmlReader.Create(new StringReader(model.User.XSD)));
            _soapClient = new ServiceReference2.UserSoapClient(ServiceReference2.UserSoapClient.EndpointConfiguration.UserSoap);
            _restClient = new api.Client.RestClient("http://localhost:5050/", new HttpClient());
        }

        private async void BtnExecuteSoapRequest_Click(object sender, EventArgs e)
        {
            //soapBox.Text = "Performing request...";
            try
            {
                //var result = await _soapClient.GetUserByAsync(tbSoapParameter.Text);
                var result = await _soapClient.GetUserByAsync("lcabraja-id");
                //soapBox.Text = result.Body.GetUserByResult;
            }
            catch (Exception ex)
            {
                //soapBox.Text = ex.Message;
            }
        }

        private async void BtnExecuteRestRequest_Click(object sender, EventArgs e)
        {
            var users = (await _restClient.UserAllAsync()).Select(u => (model.User)u);
            //restBox.Text = users.Select(u => u.ToString()).Aggregate("", (c, n) => $"{c}\n{n}");
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            
        }

        //XDocument xmldoc = new XDocument(xmldata);

        //bool hasErrors = false;
        //string errorMessage = "";
        //xmldoc.Validate(schemas, (o, e) =>
        //    {
        //        errorMessage = e.Message;
        //        hasErrors = true;
        //    });
    }
}
