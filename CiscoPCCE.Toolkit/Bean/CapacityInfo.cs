using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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