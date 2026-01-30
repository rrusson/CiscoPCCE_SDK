using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class AgentServiceEnabled : BaseApiBean
    {
        [XmlElement("mappedServiceType")]
        public string? MappedServiceType { get; set; }
    }
}