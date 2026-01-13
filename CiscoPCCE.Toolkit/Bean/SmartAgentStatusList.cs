using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("smartAgentStatusList")]
    public class SmartAgentStatusList : BaseApiBean
    {
        [XmlElement("smartAgentStatus")]
        public List<SmartAgentStatus>? SmartAgentStatuses { get; set; }
    }
}