using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SAP.Middleware.Connector;

namespace SAPRFCSample
{
    public partial class RFCConnector : Form
    {
        public RFCConnector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectorInterface sapConnect = new ConnectorInterface();
            sapConnect.rfcName = tbRFCName.Text;
            bool result = sapConnect.Connect();
            status.Text = result.ToString();
            sapConnect.ExampleSimpleStatefulCalls(tbFunctionName.Text);
            loginSID.Text =  sapConnect._logonsessionID;
      
        }

    }
}
