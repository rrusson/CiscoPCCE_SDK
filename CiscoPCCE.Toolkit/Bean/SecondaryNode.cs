using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class SecondaryNode : BaseApiBean
    {
        [XmlElement("host")]
        public string? Host { get; set; }
    }
}