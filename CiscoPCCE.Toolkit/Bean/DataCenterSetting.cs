using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class DataCenterSetting : BaseApiBean
    {
        [XmlElement("agent")]
        public required AgentDataCenterSetting Agent { get; set; }

        [XmlElement("baseUrl")]
        public string? BaseUrl { get; set; }

        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("labels")]
        public required NetworkLabelGlobalSetting Labels { get; set; }
    }
}