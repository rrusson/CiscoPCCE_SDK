using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("PQAgentCount")]
    public class PQCount : BaseApiBean
    {
        [XmlElement("agentCount")]
        public int? AgentCount { get; set; }

        [XmlArray("agentNameList")]
        [XmlArrayItem("agentName")]
        public List<AgentName>? AgentNameList { get; set; }

    }
}