using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingtype")
    [XmlRoot("results")]
    public class RoutingTypeBeanList : BaseApiList<RoutingTypeBean>
    {
        [XmlArray("routingTypes")]
        [XmlArrayItem("routingType")]
        public new List<RoutingTypeBean>? Items
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