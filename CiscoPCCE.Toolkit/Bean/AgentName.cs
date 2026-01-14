using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("agentName")]
    public class AgentName : BaseApiBean
    {
        [XmlElement("agentId")]
        public int? AgentId { get; set; }

        [XmlElement("agentURL")]
        public string? AgentURL { get; set; }

        [XmlElement("enterpriseName")]
        public string? EnterpriseName { get; set; }
    }
}