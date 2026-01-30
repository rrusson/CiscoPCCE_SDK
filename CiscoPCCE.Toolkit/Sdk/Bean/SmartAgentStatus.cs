using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("smartAgentStatus")]
    public class SmartAgentStatus : BaseApiBean
    {
        [XmlElement("authorizationStatus")]
        public string? AuthorizationStatus { get; set; }

        [XmlElement("complianceStatus")]
        public string? ComplianceStatus { get; set; }

        [XmlElement("daysLeftInEvaluationMode")]
        public string? DaysLeftInEvaluationMode { get; set; }

        [XmlElement("daysLeftInOutOfComplianceMode")]
        public string? DaysLeftInOutOfComplianceMode { get; set; }

        [XmlElement("machineHost")]
        public string? MachineHost { get; set; }

        [XmlElement("machineType")]
        public string? MachineType { get; set; }

        [XmlElement("registrationStatus")]
        public string? RegistrationStatus { get; set; }
    }
}