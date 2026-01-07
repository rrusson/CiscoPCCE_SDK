using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("capacityInfo")]
    public class CapacityInfo : BaseApiBean
    {
        [XmlElement("capacityRules")]
        [XmlElement("capacityRule")]
        public List<CapacityCheckResult>? CapacityCheckResults { get; set; }
    }
}