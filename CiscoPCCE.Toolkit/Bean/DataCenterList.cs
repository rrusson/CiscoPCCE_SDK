using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("datacenter")
    [XmlRoot("results")]
    public class DataCenterList : BaseApiList<DataCenter12k>
    {
        [XmlArray("datacenters")]
        [XmlArrayItem("datacenter")]
        public new List<DataCenter12k>? Items
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