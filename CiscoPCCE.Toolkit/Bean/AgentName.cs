using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("agentName")]
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