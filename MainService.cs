using System;
using System.Reflection;
using System.ServiceProcess;
using log4net;
using log4net.Config;
using Nancy.Hosting.Self;

[assembly: XmlConfigurator(Watch = true)]
namespace NancyRestService
{
    public partial class MainService : ServiceBase
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private NancyHost _host = null;

        public MainService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Log.Debug("Start host");
            _host = new NancyHost(new Uri("http://skipperportal.luckyluke.local:9090"));
            _host.Start();
        }

        protected override void OnStop()
        {
            Log.Debug("Stop host");
            if (_host != null)
            {
                _host.Stop();
            }
        }
    }
}
