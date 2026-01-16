using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("step")]
    public class Step : BaseApiBean
    {
        [XmlElement("agentCount")]
        public int? AgentCount { get; set; }

        [XmlElement("considerIf")]
        public string? ConsiderIf { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlArray("terms")]
        [XmlArrayItem("term")]
        public List<Term>? Terms { get; set; }

        [XmlElement("waitTime")]
        public int? WaitTime { get; set; }
    }
}