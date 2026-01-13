using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agentdistribution")
    [XmlRoot("agentDistribution")]
    public class AgentDistribution : BaseApiBean
    {
        [XmlElement("agentHistoricalData")]
        public bool? AgentHistoricalData { get; set; }

        [XmlElement("agentRealTimeData")]
        public bool? AgentRealTimeData { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("peripheralId")]
        public int? PeripheralId { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }
    }
}