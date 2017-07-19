using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;

namespace DemoWebApi.Nhibernet
{
    public class NhibernetConfig:IHttpModule
    {
        public String ModuleName
        {
            get { return "NHibernateConfigModule"; }
        }
        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(context_BeginRequest);
            context.EndRequest += new EventHandler(context_EndRequest);
        }
        void context_BeginRequest(object sender, EventArgs e)
        {
            ISession session = CommonClass.FACTORY.OpenSession();

            bool keyExists = false;

            foreach (var key in ((HttpApplication)sender).Context.Items.Keys)
            {
                if (key.ToString() == CommonClass.NHibernateSessionKey)
                    keyExists = true;
            }

            if (!keyExists)
                ((HttpApplication)sender).Context.Items.Add(CommonClass.NHibernateSessionKey, session);
        }

        void context_EndRequest(object sender, EventArgs e)
        {
            ISession session = (ISession)((HttpApplication)sender).Context.Items[CommonClass.NHibernateSessionKey];
            if (session != null && session.IsOpen) session.Close();
        }

        public void Dispose()
        {

        }
    }
}