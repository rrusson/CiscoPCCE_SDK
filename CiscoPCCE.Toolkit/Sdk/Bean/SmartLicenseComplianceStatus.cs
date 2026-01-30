using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("smartLicenseComplianceStatus")]
    public class SmartLicenseComplianceStatus : BaseApiBean
    {
        [XmlElement("complianceStatus")]
        public string? ComplianceStatus { get; set; }

        [XmlElement("smartAgentStatusList")]
        public required SmartAgentStatusList SmartAgentStatusList { get; set; }
    }
}