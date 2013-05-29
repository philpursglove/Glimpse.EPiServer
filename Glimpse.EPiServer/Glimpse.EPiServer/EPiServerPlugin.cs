using Glimpse.AspNet.Extensibility;
using Glimpse.Core.Extensibility;
using Glimpse.AspNet.Extensions;
using EPiServer.Core;

namespace Glimpse.EPiServer
{
    public class EPiServerPlugin : AspNetTab
    {
        public override object GetData(ITabContext context)
        {
            var httpContext = context.GetHttpContext();
            string url = httpContext.Request.RawUrl;


            return new object();
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
