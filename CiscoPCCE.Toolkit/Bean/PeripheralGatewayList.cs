using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("results")]
    public class PeripheralGatewayList : BaseApiWrappedList<PeripheralGateway>
    {
        [XmlArray("peripheralGateways")]
        [XmlArrayItem("peripheralGateway")]
        public new List<PeripheralGateway>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}