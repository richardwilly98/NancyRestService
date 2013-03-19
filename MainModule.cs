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
            Get["/"] = _ => { return "Hello REST Service"; };
        }
    }
}
