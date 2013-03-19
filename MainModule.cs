using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NancyRestService
{
    public class MainModule : Nancy.NancyModule
    {
        public MainModule()
        {
            Get["/"] = _ => "Hello REST Service";
            Get["/hello/{name}"] = _ => String.Format("Hello REST Service {0}", _.name);
        }
    }
}
