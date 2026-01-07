using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("smartAgentStatusList")]
    public class SmartAgentStatusList : BaseApiBean
    {
        [XmlElement("smartAgentStatus")]
        public List<SmartAgentStatus>? SmartAgentStatuses { get; set; }
    }
}