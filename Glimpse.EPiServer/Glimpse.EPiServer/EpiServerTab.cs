using System.Collections.Generic;
using System.Globalization;

using EPiServer.Core;
using EPiServer.DataAbstraction;

using Glimpse.AspNet.Extensibility;
using Glimpse.AspNet.Extensions;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;

namespace Glimpse.EPiServer
{
    public class EpiServerTab : AspNetTab
    {
        public override object GetData(ITabContext context)
        {
            TabSection episerverTab = Plugin.Create("Section", "Content");

            PageData currentPageData = EPiServerDataFactory.GetPageData(context.GetHttpContext().Request.RawUrl);
            TabSection pageData = new TabSection("Property", "Value");
            pageData.AddRow().Column("Page Name").Column(currentPageData.PageName);
            pageData.AddRow().Column("Page Type").Column(currentPageData.PageTypeName);
            pageData.AddRow()
                    .Column("Start Publish")
                    .Column(currentPageData.StartPublish.ToString(CultureInfo.InvariantCulture));
            pageData.AddRow()
                    .Column("Stop Publish")
                    .Column(currentPageData.StopPublish.ToString(CultureInfo.InvariantCulture));

            episerverTab.Section("Page Information", pageData);


            // Possible child page types?
            // version

            PageReference currentPageRef = EPiServerDataFactory.GetPageReference(
                context.GetHttpContext().Request.RawUrl);
            DynamicPropertyCollection dynprops = DynamicProperty.ListForPage(currentPageRef);

            TabSection dynpropData = new TabSection();

            foreach (DynamicProperty dynprop in dynprops)
            {
                PropertyData prop = dynprop.PropertyValue;

                dynpropData.AddRow().Column(prop.Name).Column(prop.IsNull ? "null" : prop.Value.ToString());
            }
            episerverTab.Section("Dynamic Properties", dynpropData);

            return episerverTab;

        }

        public override string Name
        {
            get
            {
                return "EPiServer";
            }
        }

    }
}
