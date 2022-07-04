using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void BtnExecuteSoapRequest_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Performing request...";
            ServiceReference2.UserSoapClient client = new ServiceReference2.UserSoapClient(ServiceReference2.UserSoapClient.EndpointConfiguration.UserSoap);
            var result = client.GetUserByAsync("123456789").Result;
            textBox1.Text = result.Body.GetUserByResult;
        }
    }
}
