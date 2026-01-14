using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("smartAgentStatusList")]
    public class SmartAgentStatusList : BaseApiBean
    {
        [XmlElement("smartAgentStatus")]
        public List<SmartAgentStatus>? SmartAgentStatuses { get; set; }
    }
}