using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("smartAgentStatus")]
    public class SmartAgentStatus : BaseApiBean
    {
        public string? AuthorizationStatus { get; set; }

        public string? ComplianceStatus { get; set; }

        public string? DaysLeftInEvaluationMode { get; set; }

        public string? DaysLeftInOutOfComplianceMode { get; set; }

        public string? MachineHost { get; set; }

        public string? MachineType { get; set; }

        public string? RegistrationStatus { get; set; }
    }
}