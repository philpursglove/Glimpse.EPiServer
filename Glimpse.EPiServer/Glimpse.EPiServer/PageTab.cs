using Glimpse.AspNet.Extensibility;
using Glimpse.Core.Extensibility;
using Glimpse.AspNet.Extensions;

namespace Glimpse.EPiServer
{
    public class PageTab : AspNetTab
    {
        public override object GetData(ITabContext context)
        {
            var httpContext = context.GetHttpContext();
            string url = httpContext.Request.RawUrl;

            // Page type
            // Possible child page types?
            // version
            // publish date

            return new object();
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
