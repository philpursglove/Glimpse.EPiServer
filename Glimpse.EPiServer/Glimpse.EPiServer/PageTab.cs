using System.Collections.Generic;
using System.Globalization;

using EPiServer.Core;

using Glimpse.AspNet.Extensibility;
using Glimpse.AspNet.Extensions;
using Glimpse.Core.Extensibility;

namespace Glimpse.EPiServer
{
    public class PageTab : AspNetTab
    {
        public override object GetData(ITabContext context)
        {
            Dictionary<string, string> tabData = new Dictionary<string, string>();

            PageData currentPageData = EPiServerDataFactory.GetPageData(context.GetHttpContext().Request.RawUrl);

            tabData.Add("Page Name", currentPageData.PageName);
            tabData.Add("Page Type", currentPageData.PageTypeName);
            tabData.Add("Start Publish", currentPageData.StartPublish.ToString(CultureInfo.InvariantCulture));
            tabData.Add("Stop Publish", currentPageData.StopPublish.ToString(CultureInfo.InvariantCulture));

            // Possible child page types?
            // version

            return tabData;
        }

        public override string Name
        {
            get
            {
                return "Page Details";
            }
        }

    }
}
