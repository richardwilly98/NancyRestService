using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using Nancy.Hosting.Self;

namespace NancyRestService
{
    public partial class MainService : ServiceBase
    {
        private NancyHost host = null;

        public MainService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new NancyHost(new Uri("http://skipperportal.luckyluke.local:9090"));
            host.Start();
        }

        protected override void OnStop()
        {
            if (host != null)
            {
                host.Stop();
            }
        }
    }
}
