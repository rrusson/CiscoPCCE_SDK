using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("capacityInfo")]
    public class CapacityInfo : BaseApiBean
    {
        [XmlArray("capacityRules")]
        [XmlArrayItem("capacityRule")]
        public List<CapacityCheckResult>? CapacityCheckResults { get; set; }
    }
}