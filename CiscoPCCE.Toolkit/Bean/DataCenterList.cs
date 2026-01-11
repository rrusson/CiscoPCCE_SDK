using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("results")]
    public class DataCenterList : BaseApiBean
    {
        [XmlArray("datacenters")]
        [XmlArrayItem("datacenter")]
        public List<DataCenter12k>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}