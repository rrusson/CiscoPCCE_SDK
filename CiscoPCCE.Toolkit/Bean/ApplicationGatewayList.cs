using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationgateway")
    [XmlRoot("results")]
    public class ApplicationGatewayList : BaseApiList<ApplicationGateway>
    {
        [XmlArray("applicationGateways")]
        [XmlArrayItem("applicationGateway")]
        public new List<ApplicationGateway>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}