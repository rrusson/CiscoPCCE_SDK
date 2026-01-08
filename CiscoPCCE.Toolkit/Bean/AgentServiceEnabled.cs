using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class AgentServiceEnabled : BaseApiBean
    {
        [XmlElement("mappedServiceType")]
        public string? MappedServiceType { get; set; }
    }
}