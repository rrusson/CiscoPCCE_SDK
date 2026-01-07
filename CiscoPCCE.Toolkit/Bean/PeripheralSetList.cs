using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("results")]
    public class PeripheralSetList : BaseApiBean
    {
        [XmlElement("peripheralSets")]
        [XmlElement("peripheralSet")]
        public List<PeripheralSet>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }
    }
}