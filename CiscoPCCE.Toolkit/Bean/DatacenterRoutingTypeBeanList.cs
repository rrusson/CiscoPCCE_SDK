using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class DatacenterRoutingTypeBeanList : BaseApiBean
    {
        [XmlElement("datacenterRoutingType")]
        public List<DatacenterRoutingTypeBean>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}