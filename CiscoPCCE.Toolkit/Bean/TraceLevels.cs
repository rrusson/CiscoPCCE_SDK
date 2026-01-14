using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("traceLevels")]
    public class TraceLevels : BaseApiBean
    {
        [XmlElement("component")]
        public List<Component>? Components { get; set; }
    }
}