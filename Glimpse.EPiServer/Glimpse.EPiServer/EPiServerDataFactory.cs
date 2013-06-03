using EPiServer.Core;

namespace Glimpse.EPiServer
{
    internal static class EPiServerDataFactory
    {
        public static PageData GetPageData(string url)
        {
            PageReference currentPageRef = PageReference.ParseUrl(url);
            return new PageData(currentPageRef);
        }

        public static PageReference GetPageReference(string url)
        {
            return PageReference.ParseUrl(url);
        }
    }
}
