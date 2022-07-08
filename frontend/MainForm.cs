namespace frontend
{
    public partial class MainForm : Form
    {
        private ServiceReference2.UserSoapClient _soapClient;
        private api.Client.IRestClient _restClient;

        public MainForm()
        {
            InitializeComponent();
            _soapClient = new ServiceReference2.UserSoapClient(ServiceReference2.UserSoapClient.EndpointConfiguration.UserSoap);
            _restClient = new api.Client.RestClient("http://localhost:5050/", new HttpClient());
        }

        private async void BtnExecuteSoapRequest_Click(object sender, EventArgs e)
        {
            soapBox.Text = "Performing request...";
            try
            {
                //var result = await _soapClient.GetUserByAsync(tbSoapParameter.Text);
                var result = await _soapClient.GetUserByAsync("lcabraja-id");
                soapBox.Text = result.Body.GetUserByResult;
            }
            catch (Exception ex)
            {
                soapBox.Text = ex.Message;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private async void BtnExecuteRestRequest_Click(object sender, EventArgs e)
        {
            var users = (await _restClient.UserAllAsync()).Select(u => (model.User)u);
            restBox.Text = users.Select(u => u.ToString()).Aggregate("", (c, n) => $"{c}\n{n}");
        }
    }
}
