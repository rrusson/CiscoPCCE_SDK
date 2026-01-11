using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class FileRefWithSize : BaseApiBean
    {
        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("size")]
        public long? Size { get; set; }
    }
}