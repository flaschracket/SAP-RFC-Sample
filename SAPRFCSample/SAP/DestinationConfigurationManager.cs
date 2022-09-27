
using System.Collections.Generic;
using System.Configuration;

using SAP.Middleware.Connector;

namespace SAPRFCSample
{/// <summary>
/// now is not used. we use simple config file
/// </summary>
    internal class SAPDestinationConfig : IDestinationConfiguration
    {
        private Dictionary<string, RfcConfigParameters> availableDestinations;
        public SAPDestinationConfig()
        {

        }
        public void InMemoryDestinationConfiguration()
        {
            availableDestinations = new Dictionary<string, RfcConfigParameters>();
        }
       

        public event RfcDestinationManager.ConfigurationChangeHandler ConfigurationChanged;

        public bool ChangeEventsSupported()
        {
            return true;
        }

        public RfcConfigParameters GetParameters(string destinationName)
        {
            RfcConfigParameters parameters = new RfcConfigParameters();
            parameters.Add(RfcConfigParameters.Name, destinationName);//"DEV_RFC"-name to identify SAP system in code
            parameters.Add(RfcConfigParameters.AppServerHost, ConfigurationManager.AppSettings["10.33.46.70"]);//server name or IP or DNSname
            parameters.Add(RfcConfigParameters.SystemNumber, ConfigurationManager.AppSettings["0"]);//instanz nummer
            parameters.Add(RfcConfigParameters.SystemID, ConfigurationManager.AppSettings["NPL"]);//y
            parameters.Add(RfcConfigParameters.User, ConfigurationManager.AppSettings["DEVELOPER"]);
            parameters.Add(RfcConfigParameters.Password, ConfigurationManager.AppSettings["Down1oad"]);
            parameters.Add(RfcConfigParameters.Client, ConfigurationManager.AppSettings["001"]);//3 digit, logon page "mandat"
            parameters.Add(RfcConfigParameters.Language, ConfigurationManager.AppSettings["En"]);
            parameters.Add(RfcConfigParameters.PoolSize, ConfigurationManager.AppSettings["10"]);
           
            return parameters;
        }

       
    }
}
