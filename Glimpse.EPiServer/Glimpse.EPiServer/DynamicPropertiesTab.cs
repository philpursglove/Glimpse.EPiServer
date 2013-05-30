using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Glimpse.AspNet.Extensibility;

namespace Glimpse.EPiServer
{
    class DynamicPropertiesTab : AspNetTab
    {
        public override object GetData(Core.Extensibility.ITabContext context)
        {
            return new object();
        }

        public override string Name
        {
            get
            {
                return "Dynamic Properties";
            }
        }
    }
}
