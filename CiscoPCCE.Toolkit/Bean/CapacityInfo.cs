using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("capacityInfo")]
    public class CapacityInfo : BaseApiBean
    {
        [XmlArray("capacityRules")]
        [XmlArrayItem("capacityRule")]
        public List<CapacityCheckResult>? CapacityCheckResults { get; set; }
    }
}