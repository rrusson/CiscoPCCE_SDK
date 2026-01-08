using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class SecondaryNode : BaseApiBean
    {
        [XmlElement("host")]
        public string? Host { get; set; }
    }
}