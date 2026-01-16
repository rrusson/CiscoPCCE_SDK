using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Machine : BaseApiBean
    {
        [XmlElement("host")]
        public string? Host { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("type")]
        public MachineType Type { get; set; }
    }
}