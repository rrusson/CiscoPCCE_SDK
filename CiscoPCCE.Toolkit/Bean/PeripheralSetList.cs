using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("results")]
    public class PeripheralSetList : BaseApiBean
    {
        [XmlArray("peripheralSets")]
        [XmlArrayItem("peripheralSet")]
        public List<PeripheralSet>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}