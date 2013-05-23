using Glimpse.AspNet.Extensibility;
using Glimpse.Core.Extensibility;

namespace Glimpse.EPiServer
{
    public class EPiServerPlugin : AspNetTab
    {
        public override object GetData(ITabContext context)
        {
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
