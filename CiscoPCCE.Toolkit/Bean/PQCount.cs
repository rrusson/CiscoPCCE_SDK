using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("PQAgentCount")]
    public class PQCount : BaseApiBean
    {
        [XmlElement("agentCount")]
        public int? AgentCount { get; set; }

        [XmlArray("agentNameList")]
        [XmlArrayItem("agentName")]
        public List<AgentName>? AgentNameList { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }
    }
}