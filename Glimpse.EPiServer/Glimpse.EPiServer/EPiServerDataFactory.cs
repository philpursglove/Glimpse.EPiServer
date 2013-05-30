
using EPiServer.Core;

using Glimpse.AspNet.Extensions;
using Glimpse.Core.Extensibility;

namespace Glimpse.EPiServer
{
    static class EPiServerDataFactory
    {
        static PageData GetPageData(ITabContext context)
        {
            PageReference currentPageRef = PageReference.ParseUrl(context.GetHttpContext().Request.RawUrl);
            return new PageData(currentPageRef);
        }

        static PageReference GetPageReference(ITabContext context)
        {
            return PageReference.ParseUrl(context.GetHttpContext().Request.RawUrl);
        }
    }
}
