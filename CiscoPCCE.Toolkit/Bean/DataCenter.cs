using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("datacenter")]
    public class DataCenter : BaseApiBean
    {
        [XmlElement("agentPG")]
        public required AgentPG AgentPG { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("cMPublisherAssociationRequired")]
        public bool? CMPublisherAssociationRequired { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("eceConfigured")]
        public bool? EceConfigured { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("multiChannelPG")]
        public required MultiChannelPG MultiChannelPG { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("sideAPGAddress")]
        public string? SideAPGAddress { get; set; }

        [XmlElement("sideBPGAddress")]
        public string? SideBPGAddress { get; set; }

        [XmlElement("vruPG")]
        public required VruPG VruPG { get; set; }
    }
}