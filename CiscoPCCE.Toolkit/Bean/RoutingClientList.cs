using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("results")]
    public class RoutingClientList : BaseApiWrappedList<RoutingClient>
    {
        [XmlArray("routingClients")]
        [XmlArrayItem("routingClient")]
        public new List<RoutingClient>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}