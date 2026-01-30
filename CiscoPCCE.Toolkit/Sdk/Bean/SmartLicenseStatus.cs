using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("smartLicenseStatus")]
    public class SmartLicenseStatus : BaseApiBean
    {
        [XmlElement("agentEnabled")]
        public string? AgentEnabled { get; set; }

        [XmlElement("serialNumber")]
        public string? SerialNumber { get; set; }

        [XmlElement("state")]
        public string? State { get; set; }
    }
}