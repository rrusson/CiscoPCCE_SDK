using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("results")]
    public class PeripheralWithRoutingClientList : BaseApiList<PeripheralWithRoutingClient>
    {
        [XmlArray("peripherals")]
        [XmlArrayItem("peripheral")]
        public new List<PeripheralWithRoutingClient>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}