using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class RoutingTypeBeanList : BaseApiBean
    {
        [XmlElement("routingType")]
        public List<RoutingTypeBean>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}