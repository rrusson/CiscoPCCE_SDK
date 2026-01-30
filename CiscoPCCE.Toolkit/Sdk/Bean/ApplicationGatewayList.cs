using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationgateway")
    [XmlRoot("results")]
    public class ApplicationGatewayList : BaseApiWrappedList<ApplicationGateway>
    {
        [XmlArray("applicationGateways")]
        [XmlArrayItem("applicationGateway")]
        public new List<ApplicationGateway>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}