using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("range")]
    public class AgentTargetingRuleRange : BaseApiBean
    {
        [XmlElement("highExtension")]
        public string? HighExtension { get; set; }

        [XmlElement("lowExtension")]
        public string? LowExtension { get; set; }
    }
}