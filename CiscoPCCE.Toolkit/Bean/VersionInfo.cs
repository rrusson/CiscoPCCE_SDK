using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("version")]
    public class VersionInfo : BaseApiBean
    {
        [XmlElement("ucceVersion")]
        public required UcceVersion UcceVersion { get; set; }
    }
}