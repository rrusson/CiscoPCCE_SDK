using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("PQAgentCount")]
    public class PQCount : BaseApiBean
    {
        public int? AgentCount { get; set; }

        [XmlElement("agentNameList")]
        [XmlElement("agentName")]
        public List<AgentName>? AgentNameList { get; set; }

        public new string? RefURL { get; set; }
    }
}