using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class RoutingTypeBeanList : BaseApiBean
    {
        [XmlElement("routingType")]
        public List<RoutingTypeBean>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }
    }
}