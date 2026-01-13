using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("version")]
    public class VersionInfo : BaseApiBean
    {
        [XmlElement("ucceVersion")]
        public required UcceVersion UcceVersion { get; set; }
    }
}