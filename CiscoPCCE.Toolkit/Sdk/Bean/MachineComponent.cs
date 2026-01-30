using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("component")]
    public class MachineComponent : BaseApiBean
    {
        [XmlElement("name")]
        public string? Name { get; set; }

    }
}