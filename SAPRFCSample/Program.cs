using System;
using System.Windows.Forms;
using SAP.Middleware.Connector;


namespace SAPRFCSample
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RFCConnector());
        }
    }
}
