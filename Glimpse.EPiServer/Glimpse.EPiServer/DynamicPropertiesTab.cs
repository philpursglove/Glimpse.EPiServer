using System.Collections.Generic;

using EPiServer.Core;
using EPiServer.DataAbstraction;

using Glimpse.AspNet.Extensibility;
using Glimpse.AspNet.Extensions;

namespace Glimpse.EPiServer
{
    class DynamicPropertiesTab : AspNetTab
    {
        public override object GetData(Core.Extensibility.ITabContext context)
        {
            SortedDictionary<string, string> tabData = new SortedDictionary<string, string>();

            PageReference currentPageRef = PageReference.ParseUrl(context.GetHttpContext().Request.RawUrl);
            DynamicPropertyCollection dynprops = DynamicProperty.ListForPage(currentPageRef);

            foreach (DynamicProperty dynprop in dynprops)
            {
                PropertyData prop = dynprop.PropertyValue;
                tabData.Add(prop.Name, prop.Value.ToString());
            }

            return tabData;
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
