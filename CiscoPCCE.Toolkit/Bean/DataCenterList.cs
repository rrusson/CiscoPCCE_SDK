using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("results")]
    public class DataCenterList : BaseApiBean
    {
        [XmlElement("datacenters")]
        [XmlElement("datacenter")]
        public List<DataCenter12k>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }
    }
}