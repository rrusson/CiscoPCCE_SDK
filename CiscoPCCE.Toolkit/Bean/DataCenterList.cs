using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("datacenter")
    [XmlRoot("results")]
    public class DataCenterList : BaseApiList<DataCenter>
    {
        [XmlArray("datacenters")]
        [XmlArrayItem("datacenter")]
        public new List<DataCenter>? Items
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