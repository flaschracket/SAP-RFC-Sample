using System;
using System.Collections.Generic;
using SAP.Middleware.Connector;


namespace SAPRFCSample
{
    public class ConnectorInterface
    {
        #region properties
        private RfcDestination _rfcDestination;
        private RfcRepository _rfcRepository;
        public string _logonsessionID = "";

        public string _sesseionProvider_sessionID = "";
        public string _getCurrentSession_sessionID = "";
        //ABAP Application Server
       public string rfcName = "";
        static SessionProvider _exampleSessionProvider = new SessionProvider();
        #endregion
        public bool Connect()
        {
            bool result = false;
            try
            {//rfcdestination manager singlton
                _rfcDestination = RfcDestinationManager.GetDestination(rfcName);
                if (_rfcDestination != null)
                {
                    _rfcDestination.Ping();
                    _rfcRepository = _rfcDestination.Repository;
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
        public bool LogON(string company, string product)
        {
            IRfcFunction queryList = _rfcRepository.CreateFunction("BAPI_XMI_LOGON");
            queryList.SetValue("EXTCOMPANY", company);
            queryList.SetValue("EXTPRODUCT", product);

            queryList.Invoke(_rfcDestination);

            _logonsessionID = queryList.GetString("SESSIONID");

            return true;
        }
        public bool LogOff()
        {
            IRfcFunction queryList = _rfcRepository.CreateFunction("BAPI_XMI_LOGOFF");

            queryList.Invoke(_rfcDestination);


            return true;
        }
        public bool RegisterContext()
        {
            RfcSessionManager.RegisterSessionProvider(_exampleSessionProvider);
            RfcSessionManager.BeginContext(_rfcDestination);

            _sesseionProvider_sessionID = _exampleSessionProvider.sessionID;
            _getCurrentSession_sessionID = _exampleSessionProvider.GetCurrentSession().ToString();
            return true;
        }
        public bool UnregisterContext()
        {
            RfcSessionManager.EndContext(_rfcDestination);
            RfcSessionManager.UnregisterSessionProvider(_exampleSessionProvider);
            return true;
        }

        public void ExampleSimpleStatefulCalls(string functionName)
        {
            RegisterContext();
            //logon user and password is not checked by SAP. any value can use.
            if (LogON("myCompany", "BC-XOM"))
            {
                try
                {
                    IRfcFunction XOMquery;
                    XOMquery = _rfcDestination.Repository.CreateFunction(functionName);
                    XOMquery.Invoke(_rfcDestination);
                }
                catch (RfcBaseException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                finally
                {
                    Console.WriteLine("Finally state");
                }
                LogOff();
            }

        }

    }
}