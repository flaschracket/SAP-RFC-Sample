using System;
using System.Collections.Generic;
using System.Threading;
using SAP.Middleware.Connector;


namespace SAPRFCSample
{
    internal class SessionProvider : ISessionProvider
    {
        int sessionCounter = 0;

        internal string sessionID;
        internal SessionProvider()
        {
            this.sessionID = CreateSession();

        }
        

        internal void SetSession(string sessionID)
        {
            this.sessionID = sessionID;
        }

        #region ISessionProvider Members

        public String GetCurrentSession()
        {
            return sessionID;
        }

        public void ContextStarted()
        {
        }

        public void ContextFinished()
        {
        }

        public String CreateSession()
        {
            return "Session_" + Convert.ToString(Interlocked.Increment(ref sessionCounter));
        }

        public void PassivateSession(String sessionID)
        {
        }

        public void ActivateSession(String sessionID)
        {
        }

        public void DestroySession(String sessionID)
        {
            if (sessionID != null && sessionID.Equals(this.sessionID))
            {
                this.sessionID = null;
            }
        }

        public bool IsAlive(String sessionID)
        {
            return sessionID != null && sessionID.Equals(this.sessionID);
        }

        public bool ChangeEventsSupported()
        {
            return false;
        }

#pragma warning disable 0067
        public event RfcSessionManager.SessionChangeHandler SessionChanged;
#pragma warning restore 0067

        #endregion
    }
}
