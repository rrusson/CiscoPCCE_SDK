using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("agentSecurity")]
    public class AgentSecurity : BaseApiBean
    {
        [XmlElement("agentsWithoutAdvancedHashing")]
        public int? AgentsWithoutAdvancedHashing { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("enforceAdvancedHashing")]
        public bool? EnforceAdvancedHashing { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("unsupportedPeripheralGateways")]
        public int? UnsupportedPeripheralGateways { get; set; }
    }
}