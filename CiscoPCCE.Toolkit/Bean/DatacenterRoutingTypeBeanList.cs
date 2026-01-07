using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class DatacenterRoutingTypeBeanList : BaseApiBean
    {
        [XmlElement("datacenterRoutingType")]
        public List<DatacenterRoutingTypeBean>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }
    }
}