using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("capacityRule")]
    public class CapacityCheckResult : BaseApiBean
    {
        [XmlElement("actual")]
        public long? Actual { get; set; }

        [XmlElement("capacityCheckOperation")]
        public required Object CapacityCheckOperation { get; set; }

        [XmlElement("max")]
        public long? Max { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }
    }
}